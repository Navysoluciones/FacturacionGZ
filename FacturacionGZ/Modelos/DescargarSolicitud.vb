﻿Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml

Friend Class DescargarSolicitud
        Inherits SoapRequestBase

        Public Sub New(ByVal url As String, ByVal action As String)
            MyBase.New(url, action)
        End Sub

        Public Function Generate(ByVal certificate As X509Certificate2, ByVal rfcSolicitante As String, ByVal idPaquete As String) As String
            Dim canonicalTimestamp As String = "<des:PeticionDescargaMasivaTercerosEntrada xmlns:des=""http://DescargaMasivaTerceros.sat.gob.mx"">" & "<des:peticionDescarga IdPaquete=""" & idPaquete & """ RfcSolicitante=""" & rfcSolicitante & ">" & "</des:peticionDescarga>" & "</des:PeticionDescargaMasivaTercerosEntrada>"
            Dim digest As String = CreateDigest(canonicalTimestamp)
            Dim canonicalSignedInfo As String = "<SignedInfo xmlns=""http://www.w3.org/2000/09/xmldsig#"">" & "<CanonicalizationMethod Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""></CanonicalizationMethod>" & "<SignatureMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""></SignatureMethod>" & "<Reference URI=""#_0"">" & "<Transforms>" & "<Transform Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""></Transform>" & "</Transforms>" & "<DigestMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""></DigestMethod>" & "<DigestValue>" & digest & "</DigestValue>" & "</Reference>" & "</SignedInfo>"
            Dim signature As String = Sign(canonicalSignedInfo, certificate)
            Dim soap_request As String = "<s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:u=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"" xmlns:des=""http://DescargaMasivaTerceros.sat.gob.mx"" xmlns:xd=""http://www.w3.org/2000/09/xmldsig#"">" & "<s:Header/>" & "<s:Body>" & "<des:PeticionDescargaMasivaTercerosEntrada>" & "<des:peticionDescarga " & "IdPaquete=""" & idPaquete & """ RfcSolicitante=""" & rfcSolicitante & """>" & "<Signature xmlns=""http://www.w3.org/2000/09/xmldsig#"">" & "<SignedInfo>" & "<CanonicalizationMethod Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>" & "<SignatureMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1""/>" & "<Reference URI=""#_0"">" & "<Transforms>" & "<Transform Algorithm=""http://www.w3.org/2001/10/xml-exc-c14n#""/>" & "</Transforms>" & "<DigestMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1""/>" & "<DigestValue>" & digest & "</DigestValue>" & "</Reference>" & "</SignedInfo>" & "<SignatureValue>" & signature & "</SignatureValue>" & "<KeyInfo>" & "<X509Data>" & "<X509IssuerSerial>" & "<X509IssuerName>" & certificate.Issuer & "</X509IssuerName>" & "<X509SerialNumber>" & certificate.SerialNumber & "</X509SerialNumber>" & "</X509IssuerSerial>" & "<X509Certificate>" & Convert.ToBase64String(certificate.RawData) & "</X509Certificate>" & "</X509Data>" & "</KeyInfo>" & "</Signature>" & "</des:peticionDescarga>" & "</des:PeticionDescargaMasivaTercerosEntrada>" & "</s:Body>" & "</s:Envelope>"
            xml = soap_request
            Return soap_request
        End Function

        Public Overrides Function GetResult(ByVal xmlDoc As XmlDocument) As String
            Dim s As String = xmlDoc.GetElementsByTagName("Paquete")(0).InnerXml
            Return s
        End Function
    End Class
