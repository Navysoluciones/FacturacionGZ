Imports System
Imports System.Security.Cryptography
Imports Org.BouncyCastle.Asn1.X509
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.X509
Imports Org.BouncyCastle.Asn1.Pkcs
Imports System.Text
Imports System.Collections
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml
Imports System.IO
Imports System.Xml.Xsl
Imports System.Linq

    Public Class Sign
    Public Shared Function CrearPFX(ByVal bytesCER As Byte(), ByVal bytesKEY As Byte(), ByVal password As String) As Byte()
        Try
            If bytesCER Is Nothing OrElse bytesKEY Is Nothing Then Throw New Exception("Empty cer and or key")
            Dim certificate = New Mono.Security.X509.X509Certificate(bytesCER)
            Dim arrayOfChars As Char() = password.ToCharArray()
            Dim privateKey As AsymmetricKeyParameter = Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(arrayOfChars, bytesKEY)
            Dim subjectKey As RSA = ToRSA(CType(privateKey, RsaPrivateCrtKeyParameters))
            Dim p12 As Mono.Security.X509.PKCS12 = New Mono.Security.X509.PKCS12()
            p12.Password = password
            Dim list As ArrayList = New ArrayList()
            list.Add(New Byte(3) {1, 0, 0, 0})
            Dim attributes As Hashtable = New Hashtable(1)
            attributes.Add(Mono.Security.X509.PKCS9.localKeyId, list)
            p12.AddCertificate(certificate, attributes)
            p12.AddPkcs8ShroudedKeyBag(subjectKey, attributes)
            Return p12.GetBytes()
        Catch ex As Exception
            Throw New Exception("Los datos del Certificado CER KEY o Password son incorrectos. No es posible leer la llave privada.", ex)
        End Try
    End Function

    Friend Shared Function ToRSA(ByVal rsaKey As RsaKeyParameters) As RSA
            Return CreateRSAProvider(ToRSAParameters(rsaKey))
        End Function

        Friend Shared Function ToRSA(ByVal privKey As RsaPrivateCrtKeyParameters) As RSA
            Return CreateRSAProvider(ToRSAParameters(privKey))
        End Function

        Friend Shared Function ToRSA(ByVal privKey As RsaPrivateKeyStructure) As RSA
            Return CreateRSAProvider(ToRSAParameters(privKey))
        End Function

    Private Shared Function CreateRSAProvider(ByVal rp As RSAParameters) As RSA
        Dim csp As CspParameters = New CspParameters()
        csp.KeyContainerName = String.Format("BouncyCastle-{0}", Guid.NewGuid())
        csp.Flags = CspProviderFlags.UseMachineKeyStore
        Dim rsaCsp As RSACryptoServiceProvider = New RSACryptoServiceProvider(csp)
        rsaCsp.ImportParameters(rp)
        Return rsaCsp
    End Function

    Friend Shared Function ToRSAParameters(ByVal rsaKey As RsaKeyParameters) As RSAParameters
        Dim rp As RSAParameters = New RSAParameters()
        rp.Modulus = rsaKey.Modulus.ToByteArrayUnsigned()

        If rsaKey.IsPrivate Then
            rp.D = ConvertRSAParametersField(rsaKey.Exponent, rp.Modulus.Length)
        Else
            rp.Exponent = rsaKey.Exponent.ToByteArrayUnsigned()
        End If

        Return rp
    End Function

    Friend Shared Function ToRSAParameters(ByVal privKey As RsaPrivateCrtKeyParameters) As RSAParameters
        Dim rp As RSAParameters = New RSAParameters()
        rp.Modulus = privKey.Modulus.ToByteArrayUnsigned()
        rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned()
        rp.P = privKey.P.ToByteArrayUnsigned()
        rp.Q = privKey.Q.ToByteArrayUnsigned()
        rp.D = ConvertRSAParametersField(privKey.Exponent, rp.Modulus.Length)
        rp.DP = ConvertRSAParametersField(privKey.DP, rp.P.Length)
        rp.DQ = ConvertRSAParametersField(privKey.DQ, rp.Q.Length)
        rp.InverseQ = ConvertRSAParametersField(privKey.QInv, rp.Q.Length)
        Return rp
    End Function

    Friend Shared Function ToRSAParameters(ByVal privKey As RsaPrivateKeyStructure) As RSAParameters
        Dim rp As RSAParameters = New RSAParameters()
        rp.Modulus = privKey.Modulus.ToByteArrayUnsigned()
        rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned()
        rp.P = privKey.Prime1.ToByteArrayUnsigned()
        rp.Q = privKey.Prime2.ToByteArrayUnsigned()
        rp.D = ConvertRSAParametersField(privKey.PrivateExponent, rp.Modulus.Length)
        rp.DP = ConvertRSAParametersField(privKey.Exponent1, rp.P.Length)
        rp.DQ = ConvertRSAParametersField(privKey.Exponent2, rp.Q.Length)
        rp.InverseQ = ConvertRSAParametersField(privKey.Coefficient, rp.Q.Length)
        Return rp
    End Function
    Private Shared Function ConvertRSAParametersField(ByVal n As BigInteger, ByVal size As Integer) As Byte()
        Dim bs As Byte() = n.ToByteArrayUnsigned()
        If bs.Length = size Then Return bs
        If bs.Length > size Then Throw New ArgumentException("Specified size too small", "size")
        Dim padded As Byte() = New Byte(size - 1) {}
        Array.Copy(bs, 0, padded, size - bs.Length, bs.Length)
        Return padded
    End Function

End Class
