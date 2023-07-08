
Imports System.IO
Imports System.Xml.Serialization
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Xml
Imports System.Xml.Xsl
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Utilities.Encoders
Imports Org.BouncyCastle.Crypto.Engines
Imports Org.BouncyCastle.Crypto.Generators
Imports Org.BouncyCastle.Security
Imports Org.BouncyCastle.OpenSsl
Imports Org.BouncyCastle.Utilities.Collections
Imports Org.BouncyCastle.Crypto.Parameters
Imports System.Net.Mail
Public Class frmEmisor

    Dim LEMI As New List(Of String)
    Dim LRF As New List(Of String)
    Private Sub frmEmisor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        INICIALIZAR()
    End Sub
    Private Sub INICIALIZAR()
        LLENACOMBOBOX(CBRFC, LEMI, "SELECT RFC,RFC EMISOR FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + " ORDER BY RFC", frmPrincipal.CadenaConexion)

        CBRFC.SelectedIndex = 0
    End Sub
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Private Sub LIMPIAR()
        txtCalle.Text = ""
        txtCertificado.Text = ""
        txtCertificados_Serie.Text = ""
        txtCertificados_ValidoDesde.Text = ""
        txtCertificados_ValidoHasta.Text = ""
        txtColonia.Text = ""
        txtCP.Text = ""
        TXTCPFX.Text = ""
        txtEmail.Text = ""
        txtEstado.Text = ""
        txtFax.Text = ""
        TXTISR.Text = ""
        TXTIVA.Text = ""
        txtLocalidad.Text = ""
        txtMunicipio.Text = ""
        txtNoExterior.Text = ""
        txtNoInterior.Text = ""
        txtNombreRazon.Text = ""
        txtPais.Text = ""
        txtPassword.Text = ""
        TXTPWDPFX.Text = ""
        txtReferencia.Text = ""
        TXTRIVA.Text = ""
        txtRutaCER.Text = ""
        txtRutaKey.Text = ""
        txtRutaPDF.Text = ""
        txtRutaXML.Text = ""
        txtTelefono.Text = ""
        txtWeb.Text = ""
        txtXMLT.Text = ""
        TXTRF.SelectedIndex = 0
        TXTSNC.Text = ""
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        'If txtRFC.Text <> frmPrincipal.RFCBASE Then
        '    MessageBox.Show("Este Sistema solo esta Validado para 1 solo RFC, el RFC capturado NO coincide para el cual fue Diseñado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If
        Dim SQL As New SqlClient.SqlCommand("AMEMISORES", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.CommandTimeout = 300
        Dim IVA, RIVA, ISR As Decimal
        IVA = 0
        RIVA = 0
        ISR = 0
        Try
            IVA = CType(TXTIVA.Text, Double)
            RIVA = CType(TXTRIVA.Text, Double)
            ISR = CType(TXTISR.Text, Decimal)
        Catch ex As Exception

        End Try
        SQL.Parameters.Add("@NOM", SqlDbType.VarChar).Value = txtNombreRazon.Text
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBRFC.Text
        SQL.Parameters.Add("@CALLE", SqlDbType.VarChar).Value = txtCalle.Text
        SQL.Parameters.Add("@COL", SqlDbType.VarChar).Value = txtColonia.Text
        SQL.Parameters.Add("@LOC", SqlDbType.VarChar).Value = txtLocalidad.Text
        SQL.Parameters.Add("@CP", SqlDbType.VarChar).Value = txtCP.Text
        SQL.Parameters.Add("@NE", SqlDbType.VarChar).Value = txtNoExterior.Text
        SQL.Parameters.Add("@MUN", SqlDbType.VarChar).Value = txtMunicipio.Text
        SQL.Parameters.Add("@EDO", SqlDbType.VarChar).Value = txtEstado.Text
        SQL.Parameters.Add("@NI", SqlDbType.VarChar).Value = txtNoInterior.Text
        SQL.Parameters.Add("@TEL", SqlDbType.VarChar).Value = txtTelefono.Text
        SQL.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = txtPais.Text
        SQL.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txtEmail.Text
        SQL.Parameters.Add("@FAX", SqlDbType.VarChar).Value = txtFax.Text
        SQL.Parameters.Add("@WEB", SqlDbType.VarChar).Value = txtWeb.Text
        SQL.Parameters.Add("@REF", SqlDbType.VarChar).Value = txtReferencia.Text
        SQL.Parameters.Add("@IVA", SqlDbType.Float).Value = IVA
        SQL.Parameters.Add("@RIVA", SqlDbType.Money).Value = TXTRIVA.Text
        SQL.Parameters.Add("@ISR", SqlDbType.Money).Value = TXTISR.Text

        SQL.Parameters.Add("@REG", SqlDbType.VarChar).Value = TXTRF.Text
        SQL.Parameters.Add("@CREG", SqlDbType.VarChar).Value = LRF(TXTRF.SelectedIndex)

        SQL.Parameters.Add("@NC", SqlDbType.VarChar).Value = TXTNC.Text
        SQL.Parameters.Add("@CURP", SqlDbType.VarChar).Value = TXTCURP.Text
        SQL.Parameters.Add("@SNC", SqlDbType.VarChar).Value = TXTSNC.Text

        Dim IMGTEM As Image
        Dim myCallback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
        IMGTEM = picLogo.Image.GetThumbnailImage(115, 92, myCallback, IntPtr.Zero)
        'If (picLogo.Image Is Nothing) Then
        '    MessageBox.Show("Vacio")
        'Else
        '    MessageBox.Show("Imagen")
        'End If
        Try
            SQL.Parameters.Add("@LOG", SqlDbType.Image).Value = Image2Bytes(IMGTEM)
        Catch ex As Exception
            SQL.Parameters.Add("@LOG", SqlDbType.Image).Value = ""
        End Try

        IMGTEM = PBBB.Image.GetThumbnailImage(100, 100, myCallback, IntPtr.Zero)
        Try
            SQL.Parameters.Add("@LOGBB", SqlDbType.Image).Value = Image2Bytes(IMGTEM)
        Catch ex As Exception
            SQL.Parameters.Add("@LOGBB", SqlDbType.Image).Value = DBNull.Value
        End Try

        IMGTEM = PBRFC.Image.GetThumbnailImage(176, 92, myCallback, IntPtr.Zero)
        Try
            SQL.Parameters.Add("@LOGORFC", SqlDbType.Image).Value = Image2Bytes(IMGTEM)
        Catch ex As Exception
            SQL.Parameters.Add("@LOGORFC", SqlDbType.Image).Value = DBNull.Value
        End Try

        SQL.ExecuteNonQuery()
        Dim SQLCER As New SqlClient.SqlCommand("AMCONFIGURACION", frmPrincipal.CONX)
        SQLCER.CommandType = CommandType.StoredProcedure
        SQLCER.CommandTimeout = 300
        SQLCER.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBRFC.Text
        SQLCER.Parameters.Add("@XML", SqlDbType.VarChar).Value = txtRutaXML.Text
        SQLCER.Parameters.Add("@XMLT", SqlDbType.VarChar).Value = txtXMLT.Text
        SQLCER.Parameters.Add("@PDF", SqlDbType.VarChar).Value = txtRutaPDF.Text
        SQLCER.Parameters.Add("@CER", SqlDbType.VarChar).Value = txtRutaCER.Text
        SQLCER.Parameters.Add("@NC", SqlDbType.VarChar).Value = txtCertificados_Serie.Text
        SQLCER.Parameters.Add("@CERTI", SqlDbType.VarChar).Value = txtCertificado.Text
        SQLCER.Parameters.Add("@VD", SqlDbType.VarChar).Value = txtCertificados_ValidoDesde.Text
        SQLCER.Parameters.Add("@VH", SqlDbType.VarChar).Value = txtCertificados_ValidoHasta.Text
        SQLCER.Parameters.Add("@KEY", SqlDbType.VarChar).Value = txtRutaKey.Text
        SQLCER.Parameters.Add("@CKEY", SqlDbType.VarChar).Value = Encrypt(Me.txtPassword.Text)
        SQLCER.Parameters.Add("@TE", SqlDbType.Int).Value = 2
        SQLCER.Parameters.Add("@RPFX", SqlDbType.VarChar).Value = txtRutaPfx.Text
        SQLCER.Parameters.Add("@PWDPFX", SqlDbType.VarChar).Value = Encrypt(Me.TXTPWDPFX.Text)
        SQLCER.Parameters.Add("@RCERPEM", SqlDbType.VarChar).Value = txtRutaCerPem.Text
        SQLCER.Parameters.Add("@RKEYPEM", SqlDbType.VarChar).Value = txtRutaKeyPem.Text
        SQLCER.Parameters.Add("@XMLC", SqlDbType.VarChar).Value = txtXMLC.Text

        SQLCER.ExecuteNonQuery()

        Dim SQLCOR As New SqlClient.SqlCommand("SPCONFIGURACIONCORREO", frmPrincipal.CONX)
        SQLCOR.CommandType = CommandType.StoredProcedure
        SQLCOR.CommandTimeout = 300
        SQLCOR.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBRFC.Text
        SQLCOR.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = TXTCMAIL.Text
        SQLCOR.Parameters.Add("@PWD", SqlDbType.VarChar).Value = TXTCPWD.Text
        SQLCOR.Parameters.Add("@SMTP", SqlDbType.VarChar).Value = TXTCSMTP.Text
        SQLCOR.Parameters.Add("@DISPLAY", SqlDbType.VarChar).Value = TXTCDR.Text
        SQLCOR.Parameters.Add("@PUE", SqlDbType.Int).Value = TXTCPUER.Text
        SQLCOR.Parameters.Add("@RSSL", SqlDbType.Bit).Value = CHKCRSSL.Checked
        SQLCOR.Parameters.Add("@AE", SqlDbType.Bit).Value = CHKAE.Checked
        SQLCOR.Parameters.Add("@ASU", SqlDbType.VarChar).Value = TXTASU.Text
        SQLCOR.Parameters.Add("@BODY", SqlDbType.VarChar).Value = TXTMSG.Text
        SQLCOR.ExecuteNonQuery()
        MessageBox.Show("Información Guardada Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        LIMPIAR()
        Dim SQL As New SqlClient.SqlCommand("SELECT N.NOMBRE,N.RFC,N.CALLE,N.COLONIA,N.LOCALIDAD,N.CP,N.NOEXT,N.NOINT,N.MUNICIPIO,N.ESTADO,N.TELEFONO,N.PAIS,N.EMAIL,N.FAX,N.WEB,N.REFERENCIA,N.LOGOTIPO,N.LOGOBIDIMENSIONAL,D.RUTAXML,D.RUTAPDF,D.RUTACER,D.CERTIFICADO,D.VALIDODESDE,D.VALIDOHASTA,D.NOCERTIFICADO,D.RUTAKEY,D.PWDKEY,N.LOGORFC,D.RUTAPFX,D.PWDPFX,D.RUTAXMLT,N.IVA,N.RETIVA,N.RETISR,N.REGIMEN,N.NOMBRECOMERCIAL,N.CURP,D.RUTACERPEM,D.RUTAKEYPEM,C.EMAIL,C.CONTRASEÑA,C.SMTP,C.DISPLAY,C.PUERTO,C.RSSL,C.ENVIO,C.ASUNTO,C.BODY,N.SERIENC,N.CREGIMEN,D.RUTAXMLC FROM EMISORES N INNER JOIN CONFIGURACION D ON N.RFC=D.RFC INNER JOIN CONFIGURACIONCORREO C ON N.RFC=C.RFC WHERE N.RFC='" + CBRFC.Text + "'", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            txtNombreRazon.Text = LEC(0)
            txtCalle.Text = LEC(2)
            txtColonia.Text = LEC(3)
            txtLocalidad.Text = LEC(4)
            txtCP.Text = LEC(5)
            txtNoExterior.Text = LEC(6)
            txtNoInterior.Text = LEC(7)
            txtMunicipio.Text = LEC(8)
            txtEstado.Text = LEC(9)
            txtTelefono.Text = LEC(10)
            txtPais.Text = LEC(11)
            txtEmail.Text = LEC(12)
            txtFax.Text = LEC(13)
            txtWeb.Text = LEC(14)
            txtReferencia.Text = LEC(15)
            Try
                picLogo.Image = Bytes2Image(LEC(16))
            Catch ex As Exception

            End Try
            Try
                PBBB.Image = Bytes2Image(LEC(17))
            Catch ex As Exception
                PBBB.Image = Nothing
            End Try
            Try
                PBRFC.Image = Bytes2Image(LEC(27))
            Catch ex As Exception

            End Try
            'LOGOTIPO = LEC(15)
            txtRutaXML.Text = LEC(18)
            txtRutaPDF.Text = LEC(19)
            txtRutaCER.Text = LEC(20)
            txtCertificado.Text = LEC(21)
            txtCertificados_ValidoDesde.Text = LEC(22)
            txtCertificados_ValidoHasta.Text = LEC(23)
            txtCertificados_Serie.Text = LEC(24)
            txtRutaKey.Text = LEC(25)
            txtPassword.Text = Decrypt(LEC(26))
            TXTCPFX.Text = LEC(28)
            TXTPWDPFX.Text = Decrypt(LEC(29))
            txtXMLT.Text = LEC(30)
            TXTIVA.Text = LEC(31)
            TXTRIVA.Text = LEC(32)
            TXTISR.Text = LEC(33)
            TXTRF.Text = LEC(34)
            TXTNC.Text = LEC(35)
            TXTCURP.Text = LEC(36)
            txtRutaCerPem.Text = LEC(37)
            txtRutaKeyPem.Text = LEC(38)

            TXTCMAIL.Text = LEC(39)
            TXTCPWD.Text = LEC(40)
            TXTCSMTP.Text = LEC(41)
            TXTCDR.Text = LEC(42)
            TXTCPUER.Text = LEC(43)
            CHKCRSSL.Checked = LEC(44)
            CHKAE.Checked = LEC(45)
            TXTASU.Text = LEC(46)
            TXTMSG.Text = LEC(47)
            TXTSNC.Text = LEC(48)
            Try
                CARGAX(LRF, TXTRF, LEC(49))
            Catch ex As Exception

            End Try
            txtXMLC.Text = LEC(50)
        End If
        LEC.Close()
    End Sub

    Private Sub cmbLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLogo.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Archivos de imagen JPG"
        ofd.DefaultExt = ".jpg"
        ofd.Filter = "Archivos de imagen (*.jpg)|*.jpg"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.picLogo.Image = Bitmap.FromFile(ofd.FileName)
            'Config.Empresa.RutaLogotipo = ofd.FileName
        End If
    End Sub

    Private Sub cmbExa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExa1.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtRutaXML.Text = Folder.SelectedPath & "\"
        End If
    End Sub

    Private Sub cmbExa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExa2.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtRutaPDF.Text = Folder.SelectedPath & "\"
        End If
    End Sub

    Private Sub cmbExa3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExa3.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Buscar Llave Publica, Certificado *.cer"
        ofd.DefaultExt = ".cer"
        ofd.Filter = "Archivo CER (*.cer)|*.cer"
        ofd.FilterIndex = 1
        ofd.FileName = ""
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtRutaCER.Text = ofd.FileName
            Try
                Dim cCert As New X509Certificate
                Dim strSerial As String = String.Empty

                cCert = X509Certificate.CreateFromCertFile(Me.txtRutaCER.Text)

                txtCertificados_ValidoDesde.Text = DateTime.Parse(cCert.GetEffectiveDateString).ToString("yyyy/MM/dd HH:mm ss")
                txtCertificados_ValidoHasta.Text = DateTime.Parse(cCert.GetExpirationDateString).ToString("yyyy/MM/dd HH:mm ss")

                For i = 1 To Len(cCert.GetSerialNumberString)
                    If ((i / 2) = CLng(i / 2)) Then
                        strSerial = strSerial & Mid(cCert.GetSerialNumberString, i, 1)
                    End If
                Next i

                txtCertificados_Serie.Text = strSerial

                Me.txtCertificado.Text = Convert.ToBase64String(cCert.GetRawCertData)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al leer el certificado." _
                    & Microsoft.VisualBasic.ControlChars.CrLf & "Certificado no válido.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub cmbExa4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExa4.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Buscar Llave Privada, archivo *.key"
        ofd.DefaultExt = ".key"
        ofd.Filter = "Archivo Key (*.key)|*.key"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtRutaKey.Text = ofd.FileName
        End If
    End Sub
    Private Function ValidarLLave(ByVal Ruta_Archivo_Key As String, ByVal Password_Archivo_Key As String) As Boolean
        Dim pass As String = Password_Archivo_Key
        Dim dataKey As Byte() = File.ReadAllBytes(Ruta_Archivo_Key)
        Try
            Dim asp As Org.BouncyCastle.Crypto.AsymmetricKeyParameter = Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(pass.ToCharArray(), dataKey)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub cmbValidaLlave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbValidaLlave.Click
        If Me.txtRutaKey.Text.Trim.Length = 0 Or Me.txtPassword.Text.Trim.Length = 0 Then
            MessageBox.Show("- Debe especificar la ubcación del archivo llave *.key" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "- Debe especificar el password del archivo llave" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "- Debe confirmar el password del archivo llave", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If ValidarLLave(Me.txtRutaKey.Text, Me.txtPassword.Text) Then
            MessageBox.Show("Llave válida!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Archivo llave no válido ó password incorrecto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub GUARDARCONFIGURACION()
        'Try
        '    ''Domicilio fiscal
        '    'Empresa
        '    Config.Empresa.Nombre = Me.txtNombreRazon.Text
        '    Config.Empresa.RFC = Me.txtRFC.Text
        '    Config.Empresa.calle = Me.txtCalle.Text
        '    Config.Empresa.colonia = Me.txtColonia.Text
        '    Config.Empresa.codigoPostal = Me.txtCP.Text
        '    Config.Empresa.estado = Me.txtEstado.Text
        '    Config.Empresa.pais = Me.txtPais.Text
        '    Config.Empresa.Telefono = Me.txtTelefono.Text
        '    Config.Empresa.Fax = Me.txtFax.Text
        '    Config.Empresa.Correo = Me.txtEmail.Text
        '    Config.Empresa.PaginaWeb = Me.txtWeb.Text
        '    Config.Empresa.localidad = Me.txtLocalidad.Text
        '    Config.Empresa.municipio = Me.txtMunicipio.Text
        '    Config.Empresa.noExterior = Me.txtNoExterior.Text
        '    Config.Empresa.noInterior = Me.txtNoInterior.Text
        '    Config.Empresa.referencia = Me.txtReferencia.Text

        '    'Facturacion
        '    Config.Facturas.RutaXML = Me.txtRutaXML.Text
        '    Config.Facturas.RutaPDF = Me.txtRutaPDF.Text

        '    Config.Facturas.RutaCer = Me.txtRutaCER.Text
        '    Config.Facturas.ValidoDesde = Me.txtCertificados_ValidoDesde.Text
        '    Config.Facturas.ValidoHasta = Me.txtCertificados_ValidoHasta.Text
        '    Config.Facturas.noCertificado = Me.txtCertificados_Serie.Text
        '    Config.Facturas.Certificado = Me.txtCertificado.Text

        '    Config.Facturas.RutaKey = Me.txtRutaKey.Text
        '    Config.Facturas.ClaveKey = Encrypt(Me.txtPassword.Text)
        '    Config.Facturas.Serie = ""
        '    Config.Facturas.noAprobacion = ""
        '    Config.Facturas.anoAprobacion = ""
        '    Config.Facturas.FolioInicial = ""
        '    Config.Facturas.FolioFinal = ""

        '    'If sender IsNot Nothing AndAlso e IsNot Nothing Then
        '    '    Config.Facturas.FolioActual = Me.txtFolioActual.Text
        '    'End If

        '    'Base de datos

        '    Config.BaseDatos.TipoBaseDatos = 2
        '    Config.BaseDatos.Servidor = ""
        '    Config.BaseDatos.NombreBD = ""


        '    Config.BaseDatos.UsuarioBD = ""
        '    Config.BaseDatos.PasswordBD = Encrypt("")

        '    Config.BaseDatos.SQLEncabezado = ""
        '    Config.BaseDatos.SQLDetalle = ""

        '    'Serialize object to a text file.
        '    Dim objStreamWriter As New StreamWriter(sPathConfiguracion)
        '    Dim x As New XmlSerializer(Config.GetType)
        '    x.Serialize(objStreamWriter, Config)
        '    objStreamWriter.Close()

        '    'If sender IsNot Nothing AndAlso e IsNot Nothing Then
        '    '    MessageBox.Show("La configuración se guardó correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Ocurrió un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Try
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
        GUARDARCONFIGURACION()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim OBJCFD As New CFD("", "", "holamundo")
        'OBJCFD.GenerarFactura()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Archivos de imagen JPG"
        ofd.DefaultExt = ".jpg"
        ofd.Filter = "Archivos de imagen (*.jpg)|*.jpg"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.PBBB.Image = Bitmap.FromFile(ofd.FileName)
            'Config.Empresa.RutaLogotipo = ofd.FileName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Archivos de imagen JPG"
        ofd.DefaultExt = ".jpg"
        ofd.Filter = "Archivos de imagen (*.jpg)|*.jpg"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.PBRFC.Image = Bitmap.FromFile(ofd.FileName)
            'Config.Empresa.RutaLogotipo = ofd.FileName
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtRutaKey.Text.Trim.Length = 0 Or Me.txtPassword.Text.Trim.Length = 0 Then
            MessageBox.Show("- Debe especificar la ubcación del archivo llave *.key" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "- Debe especificar el password del archivo llave" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "- Debe confirmar el password del archivo llave", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If ValidarLLave(Me.TXTCPFX.Text, Me.TXTPWDPFX.Text) Then
            MessageBox.Show("Llave válida!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Archivo llave no válido ó password incorrecto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Buscar Llave Privada, archivo *.pfx"
        ofd.DefaultExt = ".pfx"
        ofd.Filter = "Archivo Key (*.pfx)|*.pfx"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TXTCPFX.Text = ofd.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtXMLT.Text = Folder.SelectedPath & "\"
        End If
    End Sub

    Private Sub CBRFC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRFC.SelectedIndexChanged
        If CBRFC.Text.Length = 13 Then
            LLENACOMBOBOX(TXTRF, LRF, "SELECT CLAVE,NOMBRE FROM CSATREGIMENFISCAL WHERE ACTIVO=1 AND FISICA=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
        Else
            LLENACOMBOBOX(TXTRF, LRF, "SELECT CLAVE,NOMBRE FROM CSATREGIMENFISCAL WHERE ACTIVO=1 AND MORAL=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
        End If

        CARGADATOS()
    End Sub
    Private Sub CertPEM(ByVal sFileFrom As String, ByVal sFileTo As String)
        If File.Exists(sFileTo) Then
            File.Delete(sFileTo)
        End If
        Dim sr As System.IO.Stream = System.IO.File.OpenRead(sFileFrom)
        Dim cp As New Org.BouncyCastle.X509.X509CertificateParser
        Dim cert As Object = cp.ReadCertificate(sr)
        Dim pkey As Object = cert.GetPublicKey()
        Dim tw As System.IO.TextWriter = New System.IO.StreamWriter(sFileTo)
        Dim pw As Org.BouncyCastle.OpenSsl.PemWriter = New Org.BouncyCastle.OpenSsl.PemWriter(tw)
        'pw.WriteObject(pkey)
        pw.WriteObject(cert)
        tw.Close()
    End Sub
    Private Sub KeyPEM(ByVal sFileFrom As String, ByVal sFileTo As String, ByVal passCSDoFiel As String, ByVal pass As String)
        If File.Exists(sFileTo) Then
            File.Delete(sFileTo)
        End If
        Dim DIR As String = sFileFrom
        Dim dataKey As Byte() = File.ReadAllBytes(DIR)
        Dim asp As Org.BouncyCastle.Crypto.AsymmetricKeyParameter = Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(passCSDoFiel.ToCharArray(), dataKey)
        Dim ms As New MemoryStream()
        Dim writer As TextWriter = New StreamWriter(ms)
        Dim stWrite As System.IO.TextWriter = New System.IO.StreamWriter(sFileTo)
        Dim pmw As Org.BouncyCastle.OpenSsl.PemWriter = New Org.BouncyCastle.OpenSsl.PemWriter(stWrite)
        pmw.WriteObject(asp, "DESEDE", pass, New Org.BouncyCastle.Security.SecureRandom)
        stWrite.Close()


    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
 
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'KeyPEM(txtRutaKey.Text, txtRutaKey.Text & "key.pem", txtPassword.Text, My.Settings.PWDNS)
        KeyPEM(txtRutaKey.Text, txtRutaKey.Text & "key.pem", txtPassword.Text, My.Settings.PWDNS)
        txtRutaKeyPem.Text = txtRutaKey.Text & "key.pem"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim SMTP As New SmtpClient(TXTCSMTP.Text, TXTCPUER.Text)
            SMTP.Credentials = New System.Net.NetworkCredential(TXTCMAIL.Text, TXTCPWD.Text)
            SMTP.Host = TXTCSMTP.Text
            SMTP.EnableSsl = CHKCRSSL.Checked
            SMTP.Timeout = 100000

            Dim MSG As New MailMessage
            MSG.From = New MailAddress(TXTCMAIL.Text, TXTCDR.Text, System.Text.Encoding.UTF8)
            MSG.To.Add(TXTMP.Text)
            MSG.Subject = TXTASU.Text
            MSG.SubjectEncoding = System.Text.Encoding.UTF8
            MSG.Body = TXTMSG.Text
            Try
                SMTP.Send(MSG)
                MessageBox.Show("Mail Enviado Con Éxito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As SmtpException
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Public Function ActivaClienteNS(ByVal rfc As String, ByVal user As String, ByVal pass As String, ByVal status As String)
    '    Try
    '        Dim WSModifica As New WSCLIENTE.edit
    '        WSModifica.reseller_username = user
    '        WSModifica.reseller_password = pass
    '        WSModifica.taxpayer_id = rfc
    '        WSModifica.status = status
    '        Dim response As New WSCLIENTE.editResponse
    '        Dim agrega As New WSCLIENTE.RegistrationSOAP
    '        If WSModifica.status = "s" Or WSModifica.status = "S" Then
    '            response = agrega.edit(WSModifica)
    '            MsgBox("Cliente suspendido Exitosamente")
    '        ElseIf WSModifica.status = "a" Or WSModifica.status = "A" Then
    '            response = agrega.edit(WSModifica)
    '            MsgBox("Cliente Activado Exitosamente")
    '        Else
    '            MsgBox("Este metodo solo acepta estatus A o S ")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("No se modificó el status del cliente " & ex.Message)
    '        Return 0
    '    End Try
    '    Return 0
    'End Function
    'Public Function AgregaClienteNS(ByVal rfc As String, ByVal user As String, ByVal pass As String)
    '    Cursor = Cursors.WaitCursor


    '    Try
    '        Dim WSAgrega As New WSCLIENTE.add 'Hacemos el llamado al metodo
    '        WSAgrega.reseller_username = user
    '        WSAgrega.reseller_password = pass
    '        WSAgrega.taxpayer_id = rfc 'RFC emisor que agregaremos

    '        Dim response As New WSCLIENTE.addResponse
    '        Dim agrega As New WSCLIENTE.RegistrationSOAP

    '        response = agrega.add(WSAgrega)
    '        MsgBox("Cliente Agregado Exitósamente")

    '    Catch ex As Exception
    '        MsgBox("No se Agregó el cliente por: " & ex.Message)
    '        Cursor = Cursors.Default
    '        Return 0
    '    End Try
    '    Cursor = Cursors.Default
    '    Return 0
    'End Function


    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CertPEM(txtRutaCER.Text, txtRutaCER.Text & ".pem")
        txtRutaCerPem.Text = txtRutaCER.Text & ".pem"
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'KeyPEM(txtRutaKey.Text, txtRutaKey.Text & "key.pem", txtPassword.Text, My.Settings.PWDNS)
        KeyPEM(txtRutaKey.Text, txtRutaKey.Text & "key.pem", txtPassword.Text, My.Settings.PWDNS)
        txtRutaKeyPem.Text = txtRutaKey.Text & "key.pem"
    End Sub

    'Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    '    AgregaClienteNS(CBRFC.Text, My.Settings.USUNS, My.Settings.PWDNS)
    'End Sub

    'Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    '    ActivaClienteNS(CBRFC.Text, My.Settings.USUNS, My.Settings.PWDNS, "A")
    'End Sub

    'Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
    '    ActivaClienteNS(CBRFC.Text, My.Settings.USUNS, My.Settings.PWDNS, "S")
    'End Sub

    Private Sub txtNombreRazon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreRazon.TextChanged
        LBLNC1.Text = txtNombreRazon.Text
        LBLNC2.Text = txtNombreRazon.Text
        LBLNC3.Text = txtNombreRazon.Text
        LBLNC4.Text = txtNombreRazon.Text
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtXMLC.Text = Folder.SelectedPath & "\"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Dim bytesCer As Byte() = File.ReadAllBytes(txtRutaCER.Text)
        Dim bytesKey As Byte() = File.ReadAllBytes(txtRutaKey.Text)
        System.IO.File.WriteAllBytes(txtRutaCER.Text & "PFX.pfx", Sign.CrearPFX(bytesCer, bytesKey, txtPassword.Text))
        txtRutaPfx.Text = txtRutaCER.Text & "PFX.pfx"
    End Sub
End Class