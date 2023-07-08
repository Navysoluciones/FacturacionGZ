Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml

Friend Class Autenticacion
    Inherits SoapRequestBase
    Public Sub New(ByVal url As String, ByVal action As String)
        MyBase.New(url, action)
    End Sub

    Public Function Generate(ByVal certificate As X509Certificate2) As String
        Dim format As String = "yyyy-MM-ddTHH:mm:ss.fffZ"
        Dim dateT As DateTime = DateTime.UtcNow
        Dim created As String = dateT.ToString(format)
        Dim expires As String = dateT.AddSeconds(300).ToString(format)
        Dim uuid As String = "uuid-" & Guid.NewGuid().ToString() & "-1"
        Dim canonicalTimestamp As String = "<u:Timestamp xmlns:u=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"" u:Id=""_0"">" & "<u:Created>" & created & "</u:Created>" & "<u:Expires>" & expires & "</u:Expires>" & "</u:Timestamp>"
        Dim digest As String = CreateDigest(canonicalTimestamp)
        Dim canonicalSignedInfo As String = "<SignedInfo xmlns=""http://www.w3.org/2000/09/xmldsig#"">" & "<CanonicalizationMethod Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""></CanonicalizationMethod>" & "<SignatureMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""></SignatureMethod>" & "<Reference URI=""#_0"">" & "<Transforms>" & "<Transform Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""></Transform>" & "</Transforms>" & "<DigestMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""></DigestMethod>" & "<DigestValue>" & digest & "</DigestValue>" & "</Reference>" & "</SignedInfo>"
        Dim signature As String = Sign(canonicalSignedInfo, certificate)
        Dim soap_request As String = "<s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:u=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">" & "<s:Header>" & "<o:Security s:mustUnderstand=""1"" xmlns:o=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"">" & "<u:Timestamp u:Id=""_0"">" & "<u:Created>" & created & "</u:Created>" & "<u:Expires>" & expires & "</u:Expires>" & "</u:Timestamp>" & "<o:BinarySecurityToken u:Id=""" & uuid & """ ValueType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3"" EncodingType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary"">" & Convert.ToBase64String(certificate.RawData) & "</o:BinarySecurityToken>" & "<Signature xmlns=""http://www.w3.org/2000/09/xmldsig#"">" & "<SignedInfo>" & "<CanonicalizationMethod Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>" & "<SignatureMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""/>" & "<Reference URI=""#_0"">" & "<Transforms>" & "<Transform Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>" & "</Transforms>" & "<DigestMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""/>" & "<DigestValue>" & digest & "</DigestValue>" & "</Reference>" & "</SignedInfo>" & "<SignatureValue>" & signature & "</SignatureValue>" & "<KeyInfo>" & "<o:SecurityTokenReference>" & "<o:Reference ValueType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3"" URI=""#" & uuid & """/>" & "</o:SecurityTokenReference>" & "</KeyInfo>" & "</Signature>" & "</o:Security>" & "</s:Header>" & "<s:Body>" & "<Autentica xmlns=""http://DescargaMasivaTerceros.gob.mx""/>" & "</s:Body>" & "</s:Envelope>"
        Xml = soap_request
        Return soap_request
    End Function

    Public Overrides Function GetResult(ByVal xmlDoc As XmlDocument) As String
        Dim s As String = xmlDoc.GetElementsByTagName("AutenticaResult")(0).InnerXml
        Return s
    End Function
End Class
