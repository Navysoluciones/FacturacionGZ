Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class PFX
        Private cer As String = ""
        Private key As String = ""
        Private clavePrivada As String = ""
        Private ArchivoPFX As String = ""
        Private ArchivoKPEM As String = ""
        Private ArchivoCPEM As String = ""
        Public [error] As String = ""
        Public mensajeExito As String = ""

        Public Sub New(ByVal cer_ As String, ByVal key_ As String, ByVal clavePrivada_ As String, ByVal archivoPfx_ As String, ByVal pathTemp As String)
            cer = cer_
            key = key_
            clavePrivada = clavePrivada_
            ArchivoKPEM = pathTemp & "k.pem"
            ArchivoCPEM = pathTemp & "c.pem"
            ArchivoPFX = archivoPfx_
        End Sub

        Public Function creaPFX() As Boolean
            Dim exito As Boolean = False

            If Not File.Exists(cer) Then
                [error] = "No existe el archivo cer en el sistema"
                Return False
            End If

            If Not File.Exists(key) Then
                [error] = "No existe el archivo key en el sistema"
                Return False
            End If

            If clavePrivada.Trim().Equals("") Then
                [error] = "No existe una clave privada aun en el sistema"
                Return False
            End If

            Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
            Dim proc2 As System.Diagnostics.Process = New System.Diagnostics.Process()
            Dim proc3 As System.Diagnostics.Process = New System.Diagnostics.Process()
            proc.EnableRaisingEvents = False
            proc2.EnableRaisingEvents = False
            proc3.EnableRaisingEvents = False
            proc.StartInfo.FileName = "openssl"
            proc.StartInfo.Arguments = "x509 -inform DER -in """ & cer & """ -out """ & ArchivoCPEM & """"
            proc.StartInfo.WorkingDirectory = "C:\openssl-win32\bin\"
            proc.Start()
            proc.WaitForExit()
            proc2.StartInfo.FileName = "openssl"
            proc2.StartInfo.Arguments = "pkcs8 -inform DER -in """ & key & """ -passin pass:" & clavePrivada & " -out """ & ArchivoKPEM & """"
            proc2.StartInfo.WorkingDirectory = "C:\openssl-win32\bin\"
            proc2.Start()
            proc2.WaitForExit()
            proc3.StartInfo.FileName = "openssl"
            proc3.StartInfo.Arguments = "pkcs12 -export -out """ & ArchivoPFX & """ -inkey """ & ArchivoKPEM & """ -in """ & ArchivoCPEM & """ -passout pass:" & clavePrivada
            proc3.StartInfo.WorkingDirectory = "C:\openssl-win32\bin\"
            proc3.Start()
            proc3.WaitForExit()
            proc.Dispose()
            proc2.Dispose()
            proc3.Dispose()

            If System.IO.File.Exists(ArchivoPFX) Then
                mensajeExito = "Se ha creado el archivo PFX "
            Else
                [error] = "Error al crear el archivo PFX, puede ser que el cer o el key no sean archivos con formato correcto"
                Return False
            End If

            If System.IO.File.Exists(ArchivoCPEM) Then System.IO.File.Delete(ArchivoCPEM)
            If System.IO.File.Exists(ArchivoKPEM) Then System.IO.File.Delete(ArchivoKPEM)
            exito = True
            Return exito
        End Function
    End Class


