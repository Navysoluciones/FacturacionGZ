Imports System
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Xml



Friend MustInherit Class SoapRequestBase
        Protected xml As String
        Protected webRequest As HttpWebRequest
        Protected Sub New(ByVal url As String, ByVal SOAPAction As String)
            Me.xml = Nothing
            webRequest = FWebRequest(url, SOAPAction)
        End Sub

        Protected Sub New(ByVal URL As Uri, ByVal SOAPAction As String)
            Me.xml = Nothing
            webRequest = FWebRequest(URL.ToString(), SOAPAction)
        End Sub
        Public Function Send(ByVal Optional autorization As String = Nothing) As String
            Try
                If xml Is Nothing Then Throw New Exception("No se ha proporcionado ningún valor a la propiedad ""xml""")
                Dim request As HttpWebRequest = webRequest

                If Not String.IsNullOrEmpty(autorization) Then
                    request.Headers.Add(HttpRequestHeader.Authorization, autorization)
                End If

                Using stream As Stream = request.GetRequestStream()

                    Using stmw As StreamWriter = New StreamWriter(stream)
                        stmw.Write(xml)
                    End Using
                End Using

                Dim response As WebResponse = CType(request.GetResponse(), WebResponse)
                Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
                Dim result As String = sr.ReadToEnd()
                sr.Close()
                Dim xmlDoc As XmlDocument = New XmlDocument()
                xmlDoc.LoadXml(result)
                Return GetResult(xmlDoc)
            Catch e As WebException
                Throw e
            Catch e As Exception
                Throw New Exception(e.Message)
            End Try
        End Function

        Public MustOverride Function GetResult(ByVal xmlDoc As XmlDocument) As String

        Private Shared Function FWebRequest(ByVal URL As String, ByVal SOAPAction As String, ByVal Optional maxTimeMilliseconds As Integer = 120000) As HttpWebRequest
            Dim webRequest As HttpWebRequest = CType(HttpWebRequest.Create(URL), HttpWebRequest)
            webRequest.Timeout = maxTimeMilliseconds
            webRequest.Method = "POST"
            webRequest.ContentType = "text/xml; charset=utf-8"
            webRequest.Headers.Add("SOAPAction: " & SOAPAction)
            Return webRequest
        End Function

        Public Function CreateDigest(ByVal sourceData As String) As String
            Dim data As Byte() = GetBytes(sourceData)
            Return System.Convert.ToBase64String(HashAlgorithm.Create("SHA1").ComputeHash(data))
        End Function

        Public Function Sign(ByVal sourceData As String, ByVal certificate As X509Certificate2) As String
            Dim data As Byte() = GetBytes(sourceData)
            Dim signature As Byte() = Nothing

            Using rsaCryptoServiceProvider As RSA = certificate.GetRSAPrivateKey()
                signature = rsaCryptoServiceProvider.SignData(data, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1)
            End Using

            Return System.Convert.ToBase64String(signature)
        End Function

        Private Function GetBytes(ByVal sourceData As String) As Byte()
            Return Encoding.[Default].GetBytes(sourceData)
        End Function
    End Class

