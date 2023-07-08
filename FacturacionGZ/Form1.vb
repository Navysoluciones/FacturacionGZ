Public Class frmPrincipal
    Public LIGA As String
    Public VERSION As String
    Public CadenaOriginal As String
    Public CA As New clsActualizacion
    'Dim LCOM As New List(Of String)
    Public CONX As New SqlClient.SqlConnection
    Public IP As String
    Public CadenaConexion As String
    'Public RFCBASE As String
    Public CIUDAD, NombreCorporativo As String
    Public Usuario As String
    Public CORPORATIVO, NivelBase As Integer
    Public VCFD As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CORPORATIVO = 2
        VERSION = "BETA1.0"
        'RFCBASE = "FRG101213EQ6"
        VCFD = "4.0"

        IP = "soluserver.ddns.net"
        'IPFE = "187.141.151.178"
        'If PRUEBAPING("BAHAMUT", "Ip Local", False) Then
        '    IP = "192.168.2.75"
        'End If
        'CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=FEMAGOS;User ID=dbaadmin;Password=masterkey"

        CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=FEMITAS;User ID=dbaadmin;Password=Xoporte1234."
        'CadenaConexion = "Data Source=LOCALHOST;Initial Catalog=FENAVYSOLUCIONES;User ID=DBAADMIN;Password=masterkey"
        'CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=FACTURACIONELECTRONICA;User ID=DBAADMIN;Password=masterkey"
        CONX.ConnectionString = CadenaConexion
        'CHECACONX()
        PBFONDO.Controls.Add(PBCNC)
        PBFONDO.Controls.Add(Label1)
        SB.Items(0).Text = "Los Mochis, Sin. Hoy es " + FormatDateTime(Now, DateFormat.LongDate) + " "
        If Not CONECTAR("WWW.BAJASUN.COM.MX") Then
            frmAyuda.Show()
            frmCambioIP.ShowDialog()
            If frmCambioIP.DialogResult = Windows.Forms.DialogResult.Yes Then
                If Not CHECACONX() Then
                    Dim VAYU As New frmAyuda
                    VAYU.Show()
                    MessageBox.Show("No se puede Conectar con el Servidor, Intente en un Momento Por Favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                Else
                    INICIAR()
                End If
            Else
                Me.Close()
            End If
        Else
            INICIAR()
        End If
        'SELLO()
        'GENERARDESDEVB()
        'CREARCFD()
        'TIMBRARVB()
        'TIMBRA()
        'TIMBRAR()
        'CALCULACADENAORIGINAL()
        'TIMBRAREJEMPLO()
        'TIMBRACSHARP()
        'Dim VEMI As New frmFacturar
        'VEMI.ShowDialog()
    End Sub
    Public Function CONECTAR(ByVal PAGINA As String)
        Try
            If CHECACONXX() Then
                Return True
            Else
                MessageBox.Show("Intento de Conexión 1 Fallido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("Intento de Conexión 1 Fallido (Principal)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
        CadenaConexion = "Data Source=201.120.24.207,1433;Network Library=DBMSSOCN;Initial Catalog=FEPM;User ID=Kenbunym*14;Password=aGi1sgXN*14"
        CONX.ConnectionString = CadenaConexion
        Try
            CONX.Open()
            IP = "201.120.24.207"
            MessageBox.Show("Conectado desde 207", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return True
        Catch ex As Exception
            MessageBox.Show("Intento de Conexión 2 Fallido (Alterno A)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
        CadenaConexion = "Data Source=201.120.180.232,1433;Network Library=DBMSSOCN;Initial Catalog=FEPM;User ID=Kenbunym*14;Password=aGi1sgXN*14"
        CONX.ConnectionString = CadenaConexion
        Try
            CONX.Open()
            IP = "201.120.180.232"
            MessageBox.Show("Conectado desde 232", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return True
        Catch ex As Exception
            MessageBox.Show("Intento de Conexión 3 Fallido (Alterno B)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
        IP = CA.DNSLookup(PAGINA)
        If IP = "" Then
            Return False
        Else
            CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=FACTURACIONELECTRONICA;User ID=Kenbunym*14;Password=aGi1sgXN*14"
            CONX.ConnectionString = CadenaConexion
            Try
                CONX.Open()
                MessageBox.Show("Conectado desde " + IP + "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return True
            Catch ex As Exception
                MessageBox.Show("Intento de Conexión 4 Fallido (Alterno No-IP)" + IP, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        End If
        Return False
    End Function
    Private Sub INICIAR()
        If VERIFICAVERSION() Then
            If Not VERIFICAUBICACION() Then
                Me.Close()
                Exit Sub
            End If
            Dim VSES As New frmLogin
            VSES.ShowDialog()
            If VSES.DialogResult = Windows.Forms.DialogResult.Yes Then

                MessageBox.Show("Bienvenido al Sistema Facturación Electrónica " + NombreCorporativo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                If NivelBase >= 10 Then
                    ADMINISTRADOR(True)
                Else
                    ADMINISTRADOR(False)
                End If
            Else
                Me.Close()
            End If
        Else
            frmLigaVersion.MOSTRAR(LIGA, "C:\NUEVAVERSION\FacturacionElectronicaNS.RAR", "Actualización de Facturacion ElectrÓnica")
            Me.Close()
        End If
    End Sub
    Private Sub ADMINISTRADOR(ByVal V As Boolean)
        Me.Text = "Sistema Facturación Electrónica " + NombreCorporativo
        SB.Items(0).Text = Me.CIUDAD + " Hoy es " + FormatDateTime(Now, DateFormat.LongDate) + " "
    End Sub
    Private Function VERIFICAUBICACION() As Boolean
        Return True
        Dim FL As New System.IO.FileInfo(Application.ExecutablePath)
        Dim ORIGEN As String
        ORIGEN = FL.DirectoryName + "\FacturacionElectronica.exe"
        If FL.DirectoryName <> "C:\" Then
            MessageBox.Show("El Archivo NO se encuentra en la Unidad Disco Local C: Se creará Una Copia, Favor de Cerrar Todas las Aplicaciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Try
                System.IO.File.Delete("C:\FacturacionElectronica.exe")
            Catch ex As Exception

            End Try
            System.IO.File.Copy(ORIGEN, "C:\FacturacionElectronica.exe")
            Try
                System.IO.File.Delete(ORIGEN)
            Catch ex As Exception

            End Try
            CreateShortCut("Acceso Directo a Facturacion Electronica", "C:\FacturacionElectronica.exe", True)
            Return False
        End If
        Return True
    End Function
    Private Sub CreateShortCut(ByVal strLinkName_ As String, ByVal strTargetPath_ As String _
             , ByVal blnDesktop_ As Boolean, Optional ByVal strPath_ As String = "" _
             , Optional ByVal strArguments_ As String = "" _
             , Optional ByVal strDescription_ As String = "" _
             , Optional ByVal strHotKey_ As String = "" _
             , Optional ByVal strIconLocation_ As String = "" _
             , Optional ByVal strWorkingDirectory_ As String = "")

        Dim shell As Object = CreateObject("WScript.shell")
        Dim link As Object

        If blnDesktop_ Then
            Dim DesktopPath As Object = shell.SpecialFolders("Desktop")
            link = shell.CreateShortcut _
                   (DesktopPath & "\" & strLinkName_ & ".lnk")
        Else
            link = shell.CreateShortcut _
                   (strPath_ & "\" & strLinkName_ & ".lnk")
        End If
        Try
            With link
                ' Argumentos
                .Description = strLinkName_              ' Nombre del Acceso directo
                .TargetPath = strTargetPath_             ' Destino
                .WindowStyle = 1                         ' Ejecutar
                .Save()
            End With
        Catch ex As Exception

        End Try

    End Sub
    Private Function VERIFICAVERSION() As Boolean
        Return True
        Try
            CHECACONX()
            'MessageBox.Show("desconecta", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim VER As String
            Dim SQL As New SqlClient.SqlCommand("SELECT VERSION,LIGA FROM VERSIONES WHERE SISTEMA='NSFAC'", Me.CONX)
            Dim LEC As SqlClient.SqlDataReader
            LEC = SQL.ExecuteReader
            If LEC.Read Then
                VER = LEC(0)
                LIGA = LEC(1)
                LEC.Close()
                If VER = VERSION Then
                    Return True
                Else
                    Return False
                End If
            Else
                LEC.Close()
                Return False
            End If
        Catch ex As Exception
            'CE.Escribir(Sistema, Now, "Verificar Version", ex.ToString)
            Return True
        End Try
    End Function
    Private Function CHECACONXX()
        If Me.CONX.State = ConnectionState.Closed Or Me.CONX.State = ConnectionState.Broken Then
            Try
                Me.CONX.Open()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function
    ''Private Sub GENERARDESDEVB()
    ''    Dim filename As [String] = "C:\archivossat\FRG101213EQ6_FAC__20110310.xml"
    ''    Dim filenameSalida As [String] = "C:\CFDCO.DATA"
    ''    Dim stylesheet As [String] = "C:\cadenaoriginal_3_0.xslt"

    ''    Dim xslt As New Xsl.XslTransform()
    ''    'Dim salida As System.IO.Stream
    ''    xslt.Load(stylesheet)
    ''    Dim xpathdocument As New Xml.XPath.XPathDocument(filename)
    ''    Dim writer As New Xml.XmlTextWriter(filenameSalida, System.Text.Encoding.UTF8)
    ''    writer.Formatting = Xml.Formatting.Indented

    ''    xslt.Transform(xpathdocument, Nothing, writer, Nothing)
    ''    Dim cadena As String = xslt.ToString()
    ''    MessageBox.Show(cadena)
    ''End Sub
    ''Private Sub LACADENAORIGINAL()
    ''    ''GENERAR CADENA ORIGINAL
    ''    'Dim transformador As New XslCompiledTransform ' variable que transforma el xml mediante el xstl
    ''    ''Para la versión 3 utilizar:
    ''    'transformador.Load(App_Path_Sistema_SAT() & "cadenaoriginal_3_0.xslt") ' carga el xslt desde la ruta en donde se encuentre
    ''    ''transformador.Load(App_Path_Sistema_SAT() & "cadenaoriginal_2_0.xslt") ' carga el xslt desde la ruta en donde se encuentre
    ''    'Dim CadenaOriginal = New StringWriter()
    ''    ''transformador.Transform(Config.Facturas.RutaXML & sNombreFactura, Nothing, CadenaOriginal)
    ''    'transformador.Transform(xmlDoc.CreateNavigator, Nothing, CadenaOriginal)
    ''    ''transformador.Transform(xmlDoc.CreateNavigator,Nothing,
    ''    'Factura.sello = GenerarSello(CadenaOriginal.ToString)
    ''    Shell("C:\XSLT\BIN\XSLTPROC CADENAORIGINAL_3_0.XSLT C:\ejemplocn.XML | C:\XSLT\BIN\OPENSSL DGST -SHA1 -SIGN C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.KEY | C:\XSLT\BIN\OPENSSL ENC -BASE64 -A -OUT C:\SALIDASELLO.TXT")
    ''End Sub
    ''Private Sub SELLO()
    ''    'Dim IO As STR
    ''    ''CADENA ORIGINAL
    ''    ''Shell("C:\XSLT\BIN\XSLTPROC CADENAORIGINAL.XSLT C:\CFD.XML")
    ''    '' '' COMANDO K PROCESA UN XML CON SU CADENA ORIGINAL, ME REGRESA LA CADNA ORIGINAL, LA FIRMA CON LA KEY Y ME DA EL SELLO
    ''    ''LCOM.Add("CD\.")
    ''    ''LCOM.Add("CD XSLT")
    ''    ''LCOM.Add("CD BIN")
    ''    ''LCOM.Add("XSLTPROC CADENAORIGINAL.XSLT C:\CFD.XML | OPENSSL DGST -MD5 -SIGN C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.KEY.PEM | OPENSSL ENC -BASE64 -A -OUT C:\SALIDASELLO.TXT")
    ''    ''CA.EjecutarConBat(LCOM)

    ''    Shell("C:\xslt\bin\openssl dgst -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key -out C:\sellado.txt C:\FileOriginal.txt")
    ''    System.Threading.Thread.Sleep(500)
    ''    Shell("C:\xslt\bin\openssl enc -base64 -in C:\sellado.txt -out C:\sellado64.txt") 'System.IO.File.WriteAllText("CadenaOriginal.txt", CadenaOriginal, System.Text.Encoding.UTF8)
    ''    ''System.Threading.Thread.Sleep(500)
    ''    ''Shell("C:\Archivos de programa\GnuWin32\bin\openssl dgst -md5 -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key -out C:\sellado.txt C:\FileOriginal.txt")
    ''    ''System.Threading.Thread.Sleep(500)
    ''    ''Shell("C:\Archivos de programa\GnuWin32\bin\openssl enc -base64 -in C:\sellado.txt -out C:\sellado64.txt")
    ''    Dim ALGO As String
    ''    Using SRS As New StreamReader("c:\SALIDASELLO.txt")
    ''        ALGO = SRS.ReadToEnd()
    ''        MessageBox.Show(ALGO)
    ''    End Using
    ''    Me.Close()
    ''End Sub
    ''    'Dim IO As STR
    ''    ''CADENA ORIGINAL
    ''    Shell("C:\XSLT\BIN\XSLTPROC CADENAORIGINAL.XSLT C:\CFD.XML")
    ''    '' COMANDO K PROCESA UN XML CON SU CADENA ORIGINAL, ME REGRESA LA CADNA ORIGINAL, LA FIRMA CON LA KEY Y ME DA EL SELLO
    ''    LCOM.Add("CD\.")
    ''    LCOM.Add("CD XSLT")
    ''    LCOM.Add("CD BIN")
    ''    LCOM.Add("XSLTPROC CADENAORIGINAL.XSLT C:\CFD.XML | OPENSSL DGST -MD5 -SIGN C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.KEY.PEM | OPENSSL ENC -BASE64 -A -OUT C:\SALIDASELLO.TXT")
    ''    CA.EjecutarConBat(LCOM)
    ''    'Shell("C:\XSLT\BIN\XSLTPROC CADENAORIGINAL.XSLT C:\CFD.XML | C:\XSLT\BIN\OPENSSL DGST -MD5 -SIGN C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.KEY.PEM | C:\XSLT\BIN\OPENSSL ENC -BASE64 -A -OUT C:\SALIDASELLO.TXT")
    ''    'Shell("C:\xslt\bin\openssl dgst -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key -out C:\sellado.txt C:\FileOriginal.txt")
    ''    System.Threading.Thread.Sleep(500)
    ''    'Shell("C:\xslt\bin\openssl enc -base64 -in C:\sellado.txt -out C:\sellado64.txt") 'System.IO.File.WriteAllText("CadenaOriginal.txt", CadenaOriginal, System.Text.Encoding.UTF8)
    ''    'System.Threading.Thread.Sleep(500)
    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl dgst -md5 -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key -out C:\sellado.txt C:\FileOriginal.txt")
    ''    'System.Threading.Thread.Sleep(500)
    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl enc -base64 -in C:\sellado.txt -out C:\sellado64.txt")
    ''    Dim ALGO As String
    ''    Using SRS As New StreamReader("c:\SALIDASELLO.txt")
    ''        ALGO = SRS.ReadToEnd()
    ''        MessageBox.Show(ALGO)
    ''    End Using
    ''    Me.Close()
    ''    '' '' '' ESTO HACIA ANTES
    ''    ' '' ''CadenaOriginal = "||3.0|2011-01-08T12:16:40|ingreso|UNA SOLA EXHIBICIÓN|2000.00|2320.00|FRG101213EQ6|FRANQUICIAS Y RESTAURANTES GRUPO CHINALOA S DE RL DE CV|AVENIDA IGNACIO ZARAGOZA SUR|690|CENTRO|AHOME|SINALOA|MÉXICO|81280|BUGF810603SI8|FRANCISCO JAVIER BUSTAMANTE GARCIA|MIGUEL HIDALGO|1364|AHOME|SINALOA|MÉXICO|81229|1.00|CONSUMO|2000.00|2000.00|IVA|16.00|320.00||"
    ''    '' ''CadenaOriginal = "||3.0|2011-01-08T12:16:40|ingreso|UNA SOLA EXHIBICIÓN|2000.00|2320.00|FRG101213EQ6|FRANQUICIA Y RESTAURANTES GRUPO CHINALOA S DE RL DE CV|AVENIDA IGNACIO ZARAGOZA SUR|690|CENTRO|AHOME|SINALOA|MÉXICO|81280|BUGF810603SI8|FRANCISCO JAVIER BUSTAMANTE GARCIA|MIGUEL HIDALGO|1364|AHOME|SINALOA|MÉXICO|81229|1||CONSUMO|2000.00|2000.00|IVA|16.00|320|320||"
    ''    ' '' ''CadenaOriginal = "||A|1|2005-09-02T16:30:00|1|ISP900909Q88|Industrias del Sur Poniente, S.A. de C.V.|Alvaro Obregón|37|3|Col. Roma Norte|México|Cuauhtémoc|Distrito Federal|México|06700|Pino Suarez|23|Centro|Monterrey|Monterrey|Nuevo Léon|México|95460|CAUR390312S87|Rosa María Calderón Uriegas|Topochico|52|Jardines del Valle|Monterrey|Monterrey|Nuevo León|México|95465|10|Caja|Vasos decorados|20|200|1|pieza|Charola metálica|150|150|IVA|52.5||"
    ''    ' '' ''CadenaOriginal = "||2.0|ABCD|2|03-05-2010T14:11:36|49|2008|INGRESO|UNA SOLA EXHIBICIÓN|2000.00|00.00|2320.00|PAMC660606ER9|CONTRIBUYENTE PRUEBASEIS PATERNOSEIS MATERNOSEIS|PRUEBA SEIS|6|6|PUEBLA CENTRO|PUEBLA|PUEBLA|PUEBLA||MÉXICO|72000|CAUR390312S87|ROSA MARÍA CÁLDERON URIEGAS|TOPOCHICO|52|JARDINES DEL VALLE|NUEVO LEÓN|MEXICO|95465|1.00|SERVICIO|01|ASESORIA FISCAL Y ADMINISTRATIVA|2000.00|IVA|16.00|320.00|| "
    ''    ' '' '' alt + 179  │
    ''    ' '' '' alt + 186 ║
    ''    ' '' '' alt + 213 ı
    ''    ' '' '' alt + 124 | la buenas 
    ''    '' ''Dim STR As String
    ''    '' ''STR = "DOBLEPIPE,VERSION XML,FECHA,TIPOCOMPROBANTE,FORMAPAGO,SUBTOTAL,TOTAL,RFC,NOMBRE,CALLE,NUMERO,COLONIA,MUNICIPIO,ESTADO,PAIS,CP,RFCCLIENTE,NOMBRECLIENTE,CALLECLIENTE,NUMEROCLIENTE,MUNICIPIOCLIENTE,ESTADOCLIENTE,PAISCLIENTE,CPCLIENTE,CANTIDAD,DESCRIPCION,VALORUNITARIO,IMPORTE,CONCEPTOIVA,TASA,IMPORTE,TOTALIMPORTE,CALLEFISCAL,NUMEROFISCAL,COLONIAFISCAL,LOCALIDADFISCAL,MUNICIPIOFISCAL,ESTADOFISCAL,PAISFISCAL,CPFISCAL"
    ''    ' '' '' Metemos la cadena a un archivo de texto
    ''    '' ''System.IO.File.WriteAllText("c:\FileOriginal.txt", CadenaOriginal)
    ''    ' '' '' Transformamos la cadena a UTF8
    ''    '' ''Dim contenido As String
    ''    '' ''Using sr As New StreamReader("c:\FileOriginal.txt", System.Text.Encoding.GetEncoding(1252))
    ''    '' ''    contenido = sr.ReadToEnd()
    ''    '' ''End Using
    ''    '' ''Using sw As New StreamWriter("c:\UTF8.txt", False, System.Text.Encoding.UTF8)
    ''    '' ''    sw.Write(contenido)
    ''    '' ''End Using

    ''    'Aquí lo que hacemos es escribir un txt (MD5.txt) con la digestión MD5 para usarlo en el sellado
    ''    'Strcadena = ObtenerMd5("D:\SAT\Files\Out\UTF8.txt")

    ''    ''D:\OpenSSL\bin\openssl.exe dgst -MD5 D:\SAT\Files\Out\UTF8.txt > D:\SAT\Files\Out\MD5.txt

    ''    'Dim CadenaUTF8 As Byte()
    ''    'Dim tmpHash() As Byte
    ''    'Dim Digestion As String

    ''    ''convierte en UTF8 
    ''    'CadenaUTF8 = System.Text.Encoding.UTF8.GetBytes(CadenaOriginal)

    ''    ''crea el hash 
    ''    'tmpHash = New Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(CadenaUTF8)

    ''    '' lo pasa a una variable string mediante la funcion ByteArrayToString 
    ''    'Digestion = ByteArrayToString(tmpHash)


    ''    'System.IO.File.WriteAllText("c:\MD5.txt", Digestion, System.Text.Encoding.UTF8)

    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl enc -base64 -in c:\MD5.txt -out C:\sellado64.txt")
    ''    'System.Threading.Thread.Sleep(500)
    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl -inform DER -in C:\ArchivosSAT\FRG101213EQ6_1102281708S.key  -passinn pass:Koshito150781 -out c:\archivokey.key.pem")

    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key  enc -base64 -in C:\sellado.txt -out C:\sellado64.txt")

    ''    'Dim CadenaUTF8 As Byte()
    ''    'Dim tmpHash() As Byte
    ''    'Dim Digestion As String
    ''    'OpenSSL.Crypto.

    ''    ''convierte en UTF8 
    ''    'CadenaUTF8 = System.Text.Encoding.UTF8.GetBytes(CadenaOriginal)

    ''    ''crea el hash 
    ''    'tmpHash = New Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(CadenaUTF8)

    ''    '' lo pasa a una variable string mediante la funcion ByteArrayToString 
    ''    'Digestion = ByteArrayToString(tmpHash)


    ''    'System.IO.File.WriteAllText("MD5.txt", Digestion, System.Text.Encoding.UTF8)
    ''    ''System.IO.File.WriteAllText("CadenaOriginal.txt", CadenaOriginal, System.Text.Encoding.UTF8)

    ''    'System.IO.File.WriteAllText("CadenaOriginal.txt", CadenaOriginal, System.Text.Encoding.UTF8)
    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl dgst -md5 -sign C:\ArchivosSAT\FRG101213EQ6_1102281708S.key -out C:\sellado.txt C:\FileOriginal.txt")
    ''    'System.Threading.Thread.Sleep(500)
    ''    'Shell("C:\Archivos de programa\GnuWin32\bin\openssl enc -base64 -in C:\sellado.txt -out C:\sellado64.txt")
    ''End Sub
    ''Public Function ValorMD5(ByVal textoACodificar As String) As String

    ''    Dim codificador As New System.Security.Cryptography.MD5CryptoServiceProvider
    ''    Dim valorEnBytes() As Byte
    ''    Dim cadenaMD5 As New System.Text.StringBuilder

    ''    valorEnBytes = codificador.ComputeHash(System.Text.Encoding.Default.GetBytes(textoACodificar))

    ''    For contador = 0 To valorEnBytes.Length - 1
    ''        cadenaMD5.Append(valorEnBytes(contador).ToString("x2")) 'Añade a la cadena el valor del byte en formato hexadecimal 
    ''    Next contador

    ''    Return cadenaMD5.ToString()

    ''End Function
    ''Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
    ''    Dim i As Integer
    ''    Dim sOutput As New System.Text.StringBuilder(arrInput.Length)
    ''    For i = 0 To arrInput.Length - 1
    ''        sOutput.Append(arrInput(i).ToString("x2"))
    ''    Next
    ''    Return sOutput.ToString()
    ''End Function
    ''Conversion del archivo generado a la cadena original!
    ''Private Sub GENERARDESDEVB()
    ''    Dim filename As [String] = "C:\archivossat\FRG101213EQ6_FAC_ab1_20110308.xml"
    ''    Dim filenameSalida As [String] = "C:\CFDCO.DATA"
    ''    Dim stylesheet As [String] = "C:\cadenaoriginal_3_0.xslt"

    ''    Dim xslt As New Xsl.XslTransform()
    ''    'Dim salida As System.IO.Stream
    ''    xslt.Load(stylesheet)
    ''    Dim xpathdocument As New Xml.XPath.XPathDocument(filename)
    ''    Dim writer As New Xml.XmlTextWriter(filenameSalida, System.Text.Encoding.UTF8)
    ''    writer.Formatting = Xml.Formatting.Indented

    ''    xslt.Transform(xpathdocument, Nothing, writer, Nothing)
    ''    Dim cadena As String = xslt.ToString()
    ''    MessageBox.Show(cadena)
    ''End Sub
    ''Public Sub AddCertificado(ByVal sCert As String, ByVal sPwd As String)
    ''    Dim certX509 As X509Certificate

    ''    Try
    ''        certX509 = New X509Certificate2(sCert, sPwd)

    ''        proxy.ClientCertificates.Add(certX509)
    ''    Catch ex As Exception
    ''        Throw New Exception("Error al cargar Certificado de Timbrado: " + ex.Message)
    ''    End Try

    ''    'proxy.Url = "https://demotf.buzonfiscal.com:433/timbrado?wsdl"
    ''    proxy.Url = "https://demotf.buzonfiscal.com:433/timbrado?wsdl"
    ''    'proxy.Url = "timbrefiscal.mx/descargas/TimbradoCFDI.wsdl"
    ''    '0proxy.Url = "d:\pac_kit\wsdl\requesttimbracfdi.xml"

    ''End Sub
    ''Public Sub CargarConfiguracion(ByVal DIRARCHIVO As String)
    ''    'Try
    ''    If System.IO.File.Exists(DIRARCHIVO) Then
    ''        'Deserialize text file to a new object.
    ''        Dim objStreamReader As New StreamReader(DIRARCHIVO)
    ''        Dim Xml As New Serialization.XmlSerializer(Config.GetType)
    ''        Config = Xml.Deserialize(objStreamReader)
    ''        objStreamReader.Close()
    ''    Else
    ''        Debug.Print("El archivo de configuració no existe")
    ''        Console.WriteLine("El archivo de configuració no existe")
    ''    End If
    ''    MessageBox.Show(Config.Comprobante.sello)
    ''    'Catch ex As Exception
    ''    '    MessageBox.Show(ex.Message)
    ''    '    'Debug.Print("El archivo de configuració no existe: " & ex.Message)
    ''    '    'Console.WriteLine("El archivo de configuració no existe: " & ex.Message)
    ''    'End Try
    ''End Sub
    ''Private Sub TIMBRAR()
    ''    'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

    ''    ''TimbreFiscal.TimbreFiscalDigital() es una referecia web, un web services a:"http://www.timbrefiscal.mx/descargas/TimbradoCFDI.wsdl"
    ''    Dim timbrefiscaldigital As New TimbreFiscal1.TimbreFiscalDigital()
    ''    Dim req = New TimbreFiscal1.RequestTimbradoCFDType()


    ''    Dim tip = New TimbreFiscal.ComprobanteTipoDeComprobante
    ''    tip = TimbreFiscal.ComprobanteTipoDeComprobante.ingreso
    ''    Dim proxy As New TimbreFiscal1.TimbradoCFDI()
    ''    req = New TimbreFiscal1.RequestTimbradoCFDType()

    ''    Dim COMPROBANTE As New TimbreFiscal1.Comprobante
    ''    COMPROBANTE.condicionesDePago = "PAGO EN UNA SOLA EXHIBICION"
    ''    COMPROBANTE.tipoDeComprobante = TimbreFiscal1.ComprobanteTipoDeComprobante.ingreso
    ''    COMPROBANTE.formaDePago = "EFECTIVO"
    ''    COMPROBANTE.version = "3.0"
    ''    COMPROBANTE.Emisor = New TimbreFiscal1.ComprobanteEmisor
    ''    COMPROBANTE.Emisor.rfc = "FRG101213EQ6"
    ''    COMPROBANTE.Emisor.nombre = "FRANQUICIAS Y RESTAURANTES GRUPO CHINALOA S DE RL DE CV"

    ''    COMPROBANTE.certificado = "MIIEsDCCA5igAwIBAgIUMDAwMDEwMDAwMDAxMDI5MzA4NDkwDQYJKoZIhvcNAQEFBQAwggE2MTgwNgYDVQQDDC9BLkMuIGRlbCBTZXJ2aWNpbyBkZSBBZG1pbmlzdHJhY2nDs24gVHJpYnV0YXJpYTEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExHzAdBgkqhkiG9w0BCQEWEGFjb2RzQHNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxEzARBgNVBAcMCkN1YXVodGVtb2MxMzAxBgkqhkiG9w0BCQIMJFJlc3BvbnNhYmxlOiBGZXJuYW5kbyBNYXJ0w61uZXogQ29zczAeFw0xMTAzMDEw"
    ''    COMPROBANTE.noCertificado = "00001000000102930849"
    ''    COMPROBANTE.sello = "E8MC72K6IEjHz/6U5BiP10LBjkNu8nC+EnVpT6dJ6hGJUK57Wg0lvjBLCpQ8mSpemjfFZJfy3+2cw6TvmScMuFDkzSkVvwaW6PAbOS+Mdyd1oAp/GljfyJzZcVnKGAdqR7A3C5g243+eS0RddP1CM8ATXUAVrtA6wC4yID93i0M="

    ''    COMPROBANTE.fecha = Now.Date
    ''    COMPROBANTE.subTotal = 2000
    ''    COMPROBANTE.total = 2320
    ''    COMPROBANTE.Impuestos = New TimbreFiscal1.ComprobanteImpuestos


    ''    Dim LIT As New List(Of TimbreFiscal1.ComprobanteImpuestos)
    ''    Dim LITT As New List(Of TimbreFiscal1.ComprobanteImpuestosTraslado)
    ''    Dim IT As TimbreFiscal1.ComprobanteImpuestos
    ''    IT = New TimbreFiscal1.ComprobanteImpuestos


    ''    Dim ITT As TimbreFiscal1.ComprobanteImpuestosTraslado
    ''    ITT = New TimbreFiscal1.ComprobanteImpuestosTraslado

    ''    ITT.importe = 320.0
    ''    ITT.impuesto = TimbreFiscal1.ComprobanteImpuestosTrasladoImpuesto.IVA
    ''    ITT.tasa = 16.0
    ''    LITT.Add(ITT)
    ''    IT.totalImpuestosTrasladados = 320
    ''    IT.Traslados = LITT.ToArray
    ''    'LIT.Add(IT)
    ''    COMPROBANTE.Impuestos = IT





    ''    COMPROBANTE.Emisor.DomicilioFiscal = New TimbreFiscal1.t_UbicacionFiscal
    ''    COMPROBANTE.Emisor.DomicilioFiscal.calle = "AVENIDA IGNACIO ZARAGOZA SUR"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.codigoPostal = "81280"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.colonia = "CENTRO"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.estado = "SINALOA"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.localidad = "LOS MOCHIS"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.municipio = "AHOME"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.noInterior = "690"
    ''    COMPROBANTE.Emisor.DomicilioFiscal.pais = "MEXICO"



    ''    COMPROBANTE.Receptor = New TimbreFiscal1.ComprobanteReceptor
    ''    COMPROBANTE.Receptor.nombre = "FRANCISCO JAVIER BUSTAMANTE GARCIA"
    ''    COMPROBANTE.Receptor.rfc = "BUGF810603SI8"
    ''    COMPROBANTE.Receptor.Domicilio = New TimbreFiscal1.t_Ubicacion
    ''    COMPROBANTE.Receptor.Domicilio.calle = "MIGUEL HIDALGO OTE"
    ''    COMPROBANTE.Receptor.Domicilio.codigoPostal = "81229"
    ''    COMPROBANTE.Receptor.Domicilio.colonia = "JIQUILPAN II"
    ''    COMPROBANTE.Receptor.Domicilio.estado = "SINALOA"
    ''    COMPROBANTE.Receptor.Domicilio.localidad = "LOS MOCHIS"
    ''    COMPROBANTE.Receptor.Domicilio.municipio = "AHOME"
    ''    COMPROBANTE.Receptor.Domicilio.noExterior = "1364"
    ''    COMPROBANTE.Receptor.Domicilio.pais = "MEXICO"


    ''    Dim CONCEPTO As TimbreFiscal1.ComprobanteConcepto
    ''    CONCEPTO = New TimbreFiscal1.ComprobanteConcepto
    ''    CONCEPTO.cantidad = 1
    ''    CONCEPTO.descripcion = "CONSUMO"
    ''    CONCEPTO.importe = 2000
    ''    CONCEPTO.noIdentificacion = "001"
    ''    CONCEPTO.unidad = "1"
    ''    CONCEPTO.valorUnitario = 2000
    ''    Dim LCON As New List(Of TimbreFiscal1.ComprobanteConcepto)
    ''    'COMPROBANTE.Conceptos(0) = New TimbreFiscal1.ComprobanteConcepto
    ''    LCON.Add(CONCEPTO)
    ''    COMPROBANTE.Conceptos = LCON.ToArray



    ''    'req.Comprobante = COMPROBANTE

    ''    'req.Comprobante = CType(Factura, TimbreFiscal1.Comprobante)
    ''    'req.Comprobante.Emisor.DomicilioFiscal = New TimbreFiscal1.t_UbicacionFiscal

    ''    'req.Documento.Tipo = TimbreFiscal1.DocumentoTypeTipo.XML
    ''    req.InfoBasica = New TimbreFiscal1.InfoBasicaType()
    ''    req.InfoBasica.RfcEmisor = "FRG101213EQ6" ' PONGAN EL RFC DEL EMISOR DE SU CFDI
    ''    req.InfoBasica.RfcReceptor = "BUGF810603SI8" ' PONGAN EL RRF DEL RECEPTOR DE SU CFDI
    ''    'req.InfoBasica.Serie = "" ' pongan la serie del cfdi si tiene
    ''    'req.RefID = "" 'opcional pongan una cadena grande de preferencia

    ''    ''METODO DE METER EL XML

    ''    req.Documento = New TimbreFiscal1.DocumentoType()
    ''    'Dim MemStream As System.IO.MemoryStream = FileToMemory("c:\ARCHIVOSSAT\FRG101213EQ6_FAC__20110312.xml")
    ''    'Dim MemStream As System.IO.MemoryStream = FileToMemory("c:\ARCHIVOSSAT\FRG101213EQ6_FAC__20110312env.xml")
    ''    Dim MemStream As System.IO.MemoryStream = FileToMemory("c:\ejemplocn.xml")
    ''    'Dim MemStream As System.IO.MemoryStream = FileToMemory("c:\facturasinsello.xml")
    ''    req.Documento.Archivo = MemStream.ToArray()

    ''    'Dim s As New Xml.Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3")
    ''    'Dim s As New Xml.Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3/cfdv3.xsd")
    ''    'req.Comprobante = s.Deserialize(New IO.StringReader("||3.0|2011-03-12T01:22:42|ingreso|PAGO EN UNA SOLA EXHIBICION|2000|2320|FRG101213EQ6|FRANQUICIAS Y RESTAURANTES GRUPO CHINALOA S DE RL DE CV|AVENIDA IGNACIO ZARAGOZA SUR|690|CENTRO|LOS MOCHIS|NINGUNA|AHOME|SINALOA|MEXICO|81280|BUGF810603SI8|FRANCISCO JAVIER BUSTAMANTE GARCIA|MIGUEL HIDALGO OTE|1364|JIQUILPAN II|LOS MOCHIS|AHOME|SINALOA|MEXICO|81229|1.00|1|001|CONSUMO|2000.00|2000.00|IVA|16.00|320|320||"))

    ''    ''METODO ASIGNACION DIRECTA COMPROBANTE
    ''    'Dim msXML As New MemoryStream()
    ''    'Dim ss As New Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3")
    ''    ''Dim ss As New Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3/cfdv3.xsd")
    ''    'Dim UTF8withoutBOM2 As Encoding = New UTF8Encoding(False)
    ''    'Dim writer2 As New XmlTextWriter(msXML, UTF8withoutBOM2)
    ''    'ss.Serialize(writer2, COMPROBANTE)
    ''    'msXML.Position = 0
    ''    'req.Documento = New TimbreFiscal1.DocumentoType
    ''    'req.Documento.Archivo = msXML.ToArray()
    ''    'req.Documento.Tipo = TimbreFiscal1.DocumentoTypeTipo.XML
    ''    'req.Documento.Version = "3.0"


    ''    ''METODO DESERIALIZACION DIRECTA COMPROBANTE
    ''    'Dim msXML As New MemoryStream()
    ''    ''Dim ss As New Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3")
    ''    'Dim ss As New Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3/cfdv3.xsd")
    ''    'req.Comprobante = ss.Deserialize(New IO.StringReader("c:\ARCHIVOSSAT\FRG101213EQ6_FAC__20110312ENV.xml"))



    ''    'MessageBox.Show(req.Documento.ToString)
    ''    '' esta URL es del PAC que estoy realizando pruebas, se puede cambiar
    ''    'proxy.Url = "https://demotf.buzonfiscal.com/timbrado?wsdl"
    ''    ''ellos entregan un demo y una contraseña
    ''    proxy.ClientCertificates.Add(New System.Security.Cryptography.X509Certificates.X509Certificate2("C:\demo\demofrg.pfx", "demofrg"))
    ''    'AddCertificado("C:\demo\demofrg.pfx", "demofrg")

    ''    'Try
    ''    timbrefiscaldigital = proxy.timbradoCFD(req)
    ''    MessageBox.Show(proxy.RequestEncoding.ToString)
    ''    MsgBox(timbrefiscaldigital.selloSAT)
    ''    'Catch ex As Exception
    ''    'MsgBox(ex.ToString)
    ''    'End Try
    ''End Sub
    ''Private Sub CALCULACADENAORIGINAL()
    ''    'Conversion del archivo generado a la cadena original!
    ''    Dim filename As [String] = "c:\EJEMPLOCN.XML"
    ''    Dim filenameSalida As [String] = "C:\CADENAO.TXT"
    ''    Dim stylesheet As [String] = "C:\cadenaoriginal_3_0.xslt"

    ''    Dim xslt As New System.Xml.Xsl.XslCompiledTransform()
    ''    Dim salida As System.IO.Stream
    ''    xslt.Load(stylesheet)
    ''    Dim xpathdocument As New XPath.XPathDocument(filename)
    ''    Dim writer As New XmlTextWriter(filenameSalida, System.Text.Encoding.UTF8)
    ''    'Dim writer As New XmlTextWriter(salida, System.Text.Encoding.UTF8)
    ''    writer.Formatting = Formatting.Indented

    ''    'xslt.Transform(xpathdocument, Nothing, writer, Nothing)
    ''    xslt.Transform(xpathdocument.CreateNavigator, Nothing, writer)

    ''    'Dim cadena As String = xslt.ToString()
    ''    'MessageBox.Show(cadena.ToString)
    ''    System.Threading.Thread.Sleep(500)
    ''    'filenameSalida = ""
    ''    Dim ALGO As String
    ''    Using abc As New StreamReader("C:\CADENAO.TXT")
    ''        ALGO = abc.ReadToEnd()
    ''        MessageBox.Show(ALGO)
    ''    End Using
    ''End Sub
    ''Private Sub TIMBRA()
    ''    Dim timbrefiscaldigital As New TimbreFiscal.TimbreFiscalDigital()
    ''    Dim req = New TimbreFiscal.RequestTimbradoCFDType()
    ''    Dim proxy As New TimbreFiscal.TimbradoCFDI()
    ''    req = New TimbreFiscal.RequestTimbradoCFDType()
    ''    req.InfoBasica = New TimbreFiscal.InfoBasicaType()
    ''    req.InfoBasica.RfcEmisor = "FRG101213EQ6" ' PONGAN EL RFC DEL EMISOR DE SU CFDI
    ''    req.InfoBasica.RfcReceptor = "BUGF810603SI8" ' PONGAN EL RRF DEL RECEPTOR DE SU CFDI
    ''    req.InfoBasica.Serie = ""  ' pongan la serie del cfdi si tiene
    ''    req.RefID = "" 'opcional pongan una cadena grande de preferencia

    ''    req.Documento = New TimbreFiscal.DocumentoType()
    ''    Dim MemStream As System.IO.MemoryStream = FileToMemory("c:\ARCHIVOSSAT\FRG101213EQ6_FAC__20110310.XML")
    ''    req.Documento.Archivo = MemStream.ToArray()

    ''    proxy.Url = "https://demotf.buzonfiscal.com/timbrado?wsdl"
    ''    proxy.ClientCertificates.Add(New System.Security.Cryptography.X509Certificates.X509Certificate("c:\demo\demofrg.pfx", "demofrg"))
    ''    Try
    ''        timbrefiscaldigital = proxy.timbradoCFD(req)
    ''        MsgBox(timbrefiscaldigital.selloSAT)
    ''    Catch ex As Exception
    ''        MsgBox(ex.ToString)
    ''    End Try
    ''End Sub
    ''Private Sub TIMBRAREJEMPLO()
    ''    'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

    ''    ''TimbreFiscal.TimbreFiscalDigital() es una referecia web, un web services a:"http://www.timbrefiscal.mx/descargas/TimbradoCFDI.wsdl"
    ''    Dim timbrefiscaldigital As New TimbreFiscal1.TimbreFiscalDigital()
    ''    Dim req = New TimbreFiscal1.RequestTimbradoCFDType()
    ''    Dim proxy As New TimbreFiscal1.TimbradoCFDI()
    ''    req = New TimbreFiscal1.RequestTimbradoCFDType()
    ''    req.InfoBasica = New TimbreFiscal1.InfoBasicaType()
    ''    req.InfoBasica.RfcEmisor = "AAA010101AAA" ' PONGAN EL RFC DEL EMISOR DE SU CFDI
    ''    req.InfoBasica.RfcReceptor = "CLI010101DEM" ' PONGAN EL RRF DEL RECEPTOR DE SU CFDI
    ''    'req.InfoBasica.Serie = "" ' pongan la serie del cfdi si tiene
    ''    'req.RefID = "" 'opcional pongan una cadena grande de preferencia

    ''    req.Documento = New TimbreFiscal1.DocumentoType()
    ''    Dim MemStream As System.IO.MemoryStream = FileToMemory("D:\PAC_KIT\CFD.xml")
    ''    req.Documento.Archivo = MemStream.ToArray()

    ''    Dim s As New Xml.Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3")

    ''    'Dim msXML As System.IO.MemoryStream = FileToMemory("D:\PAC_KIT\CFDI_SINTIMBRAR.xml")
    ''    ''Dim ss As New Serialization.XmlSerializer(GetType(TimbreFiscal1.Comprobante), "http://www.sat.gob.mx/cfd/3")
    ''    ''Dim UTF8withoutBOM2 As Encoding = New UTF8Encoding(False)
    ''    ''Dim writer2 As New XmlTextWriter(msXML, UTF8withoutBOM2)
    ''    ''ss.Serialize(writer2, cfdi)
    ''    'msXML.Position = 0
    ''    ''req.Documento = New DocumentoType()
    ''    'req.Documento.Archivo = msXML.ToArray()
    ''    ''req.Documento.Tipo = DocumentoTypeTipo.XML
    ''    'req.Documento.Version = "3.0"

    ''    'req.Documento.Archivo = msXML.ToArray()


    ''    'MessageBox.Show(req.Documento.ToString)
    ''    '' esta URL es del PAC que estoy realizando pruebas, se puede cambiar
    ''    proxy.Url = "https://demotf.buzonfiscal.com/timbrado?wsdl"
    ''    ''ellos entregan un demo y una contraseña
    ''    proxy.ClientCertificates.Add(New System.Security.Cryptography.X509Certificates.X509Certificate2("C:\demo\demofrg.pfx", "demofrg"))
    ''    'AddCertificado("C:\demo\demofrg.pfx", "demofrg")

    ''    Try
    ''        timbrefiscaldigital = proxy.timbradoCFD(req)
    ''        MsgBox(timbrefiscaldigital.selloSAT)
    ''    Catch ex As Exception
    ''        MsgBox(ex.ToString)
    ''    End Try
    ''End Sub
    ''Private Sub TIMBRACSHARP()
    ''    Dim TCS As New LibreriaTimbrado.clsTimbrado
    ''    MessageBox.Show(TCS.Timbar("C:\DEMO\DEMOFRG.PFX", "demofrg", "FRG101213EQ6", "BUGF810603SI8", "c:\ejemplocn.xml"))
    ''End Sub
    ' ''Funcion para convertir a MemoryStream el Archivo XML a timbrar
    'Dim generationDirectory, applicationDirectory As String
    'Dim SourceDirectory As String
    'Dim CERTIFICADO As ElectronicCertificate
    'Dim DataDirectory As String = "c:\Listados"
    'Public ED As ElectronicDocumentLibrary.Document.ElectronicDocument
    'Dim MANAGE As ElectronicManage
    'Private Sub INICIAMANAGE()
    '    'Instanciamos la clase TManageElectronicDocument
    '    SourceDirectory = "\\..\\.."
    '    MANAGE = ElectronicManage.NewEntity()


    '    ' Por motivos de la demos, se elimina la validación de que el RFC del
    '    ' emisor sea igual a los datos del certificado, ya que si agrego esta validación
    '    ' me da error con el folio, ya que para el certificados de pruebas no existen
    '    ' folios autorizados. PARA UN AMBIENTE DE PRODUCCION ESTA OPCION DEBE ESTA ACTIVADA
    '    MANAGE.Save.Options = (MANAGE.Save.Options Or SaveOptions.ValidateCertificateSubject) Xor SaveOptions.ValidateCertificateSubject
    '    'manage.Save.Options - [SaveOptions.ValidateCertificateSubject]

    '    ' Se cargan a memoria el archivo de autoridades certificadoras y el archivo de certificados de emisores de CFD
    '    MANAGE.CertificateAuthorityList.Load("c:\Listados\Listado de autoridades certificadoras\CAL Test.xml")
    '    MANAGE.ElectronicCertificateList.Load("C:\Listados\Listado de certificados\CEL.xml")

    '    ' Se define el archivo de las CERTIFICADOS REVOCADOS que es emitido por el SAT; el cual es cargado a memoria
    '    ' hasta el momento de ser usado, esto con la finalidad de que no se tenga objetos cargados hasta que
    '    ' realmente no se vayan a usar.
    '    MANAGE.CertificateRevocationList.FileName = DataDirectory & "\Listado de certificados revocados\CSD.txt"

    '    ' En este caso se indica que se cargue el contenido del archivo a memoria, ya que quiero mostrar lo rápido
    '    ' que es el proceso de generación, y la carga de este archivo la primera vez toma varios segundos.
    '    MANAGE.CertificateRevocationList.Prepare()

    '    ' Se define el archivo de las FOLIOS AUTORIZADOS por el SAT; el cual es cargado a memoria hasta el momento
    '    ' de ser usado, esto con la finalidad de que no se tenga objetos cargados hasta que realmente no se vayan a usar.
    '    MANAGE.FolioAutorizadoList.FileName = DataDirectory & "\Listado de folios autorizados\FoliosCFD.txt"

    '    ' En este caso se indica que se cargue el contenido del archivo a memoria, ya que quiero mostrar lo rápido
    '    ' que es el proceso de generación, y la carga de este archivo la primera vez toma varios segundos.
    '    MANAGE.FolioAutorizadoList.Prepare()

    '    ' Se definen los diferentes esquemas del CFD y de los complementos, estos son usados al momento generar
    '    ' un CFD y que se haya especificado la validación contra el esquema, mas adelante muestro un ejemplo.
    '    MANAGE.Schema.Version10.Value = DataDirectory & "\schema\comprobante.xsd"
    '    MANAGE.Schema.Version20.Value = DataDirectory & "\schema\cfdv2.xsd"
    '    MANAGE.Schema.Version30.Value = DataDirectory & "\schema\cfdv3.xsd"

    '    MANAGE.Schema.Divisas10.Value = DataDirectory & "\schema\divisas.xsd"
    '    MANAGE.Schema.Donatarias10.Value = DataDirectory & "\schema\donat.xsd"
    '    MANAGE.Schema.EstadoDeCuentaBancario10.Value = DataDirectory & "\schema\ecb.xsd"
    '    MANAGE.Schema.EstadoDeCuentaCombustible10.Value = DataDirectory & "\schema\ecc.xsd"
    '    MANAGE.Schema.ImpuestosLocales10.Value = DataDirectory & "\schema\implocal.xsd"
    '    MANAGE.Schema.PrestadoresDeServiciosDeCFD10.Value = DataDirectory & "\schema\psgecfd.xsd"
    '    MANAGE.Schema.Detallista131.Value = DataDirectory & "\schema\detallista.xsd"
    '    MANAGE.Schema.Timbre10.Value = DataDirectory & "\schema\timbre.xsd"

    '    ' Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
    '    ' la llave privada y el password de la misma.
    '    CERTIFICADO = ElectronicCertificate.NewEntity("C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.cer", "C:\ARCHIVOSSAT\FRG101213EQ6_1102281708S.key", "koshito150781")

    '    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    '    ' y administrar TODOS los recursos que serán usados en el proceso
    '    MANAGE.Save.AssignCertificate(CERTIFICADO)

    '    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación y se le pasa
    '    ' el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    '    ED = ElectronicDocument.NewEntity()
    '    ED.AssignManage(MANAGE)

    '    ' Se crea el directorio donde van a ser almacenado los CFD generados, esto no tiene que ver con la librería,
    '    ' solo es para mantener ordenados los archivos generados.  generationDirectory = applicationDirectory + "\\Generados\\";
    '    generationDirectory = applicationDirectory & "\Generados\"
    '    If Not Directory.Exists(generationDirectory) Then
    '        Try
    '            Directory.CreateDirectory(generationDirectory)
    '        Catch
    '            MessageBox.Show(Me, "No se pudo crear el directorio donde se van a almacenar los CFD's." & vbLf & generationDirectory, "Crear Directorio", MessageBoxButtons.OK, MessageBoxIcon.[Error], MessageBoxDefaultButton.Button1)
    '            Application.[Exit]()
    '        End Try
    '    End If

    'End Sub
    'Private Sub GeneraCadena()
    '    'Dim xmlDoc As XmlDocument

    '    Dim transformador As New XslCompiledTransform ' variable que transforma el xml mediante el xstl

    '    transformador.Load(App_Path_Sistema_SAT() & "cadenaoriginal_3_0.xslt") ' carga el xslt desde la ruta en donde se encuentre
    '    Dim CadenaOriginal = New StringWriter()
    '    transformador.Transform("C:\EJEMPLOCN.XML", Nothing, CadenaOriginal)
    '    'transformador.Transform(xmlDoc.CreateNavigator, Nothing, CadenaOriginal)
    '    'MessageBox.Show(CadenaOriginal.ToString)
    '    Dim sello As String
    '    sello = GenerarSello(CadenaOriginal.ToString)
    '    ' MessageBox.Show(sello)
    'End Sub
    'Public Function GenerarSello(ByVal CadenaOriginal As String) As String
    '    Try
    '        Dim pass As String = "koshito150781"
    '        Dim dataKey As Byte() = File.ReadAllBytes("c:\archivossat\FRG101213EQ6_1102281708S.key")
    '        Dim asp As Org.BouncyCastle.Crypto.AsymmetricKeyParameter = Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(pass.ToCharArray(), dataKey)
    '        Dim ms As New MemoryStream()
    '        Dim writer As TextWriter = New StreamWriter(ms)
    '        Dim stWrite As New System.IO.StringWriter()
    '        Dim pmw As Org.BouncyCastle.OpenSsl.PemWriter = New PemWriter(stWrite)
    '        pmw.WriteObject(asp)
    '        stWrite.Close()

    '        Dim sig As Org.BouncyCastle.Crypto.ISigner
    '        'Dim sig As ISigner = SignerUtilities.GetSigner("SHA1WithRSA")
    '        'sig = SignerUtilities.GetSigner("MD5WithRSAEncryption")
    '        sig = Org.BouncyCastle.Security.SignerUtilities.GetSigner("SHA1WithRSA")

    '        'Versión 2.0 antes del 31 de diciembre de 2010
    '        '            Dim sig As ISigner = SignerUtilities.GetSigner("MD5WithRSAEncryption")
    '        'Versión 2.0 y 3.0 a partir del 01 de enero de 2011
    '        'Dim sig As ISigner = SignerUtilities.GetSigner("SHA1WithRSA")

    '        '' Convertir a UTF8
    '        Dim plaintext As Byte() = Encoding.UTF8.GetBytes(CadenaOriginal)

    '        '' SELLAR
    '        sig.Init(True, asp)
    '        sig.BlockUpdate(plaintext, 0, plaintext.Length)
    '        Dim signature As Byte() = sig.GenerateSignature()

    '        Dim signatureHeader = Convert.ToBase64String(signature)
    '        Return signatureHeader
    '    Catch ex As Exception
    '        Debug.Print("Error: " & ex.Message)
    '        Console.WriteLine("Error: " & ex.Message)
    '        MessageBox.Show(ex.Message)
    '        Return String.Empty
    '    End Try
    'End Function
    'Private Sub CREARCFD()
    '    INICIAMANAGE()
    '    Dim x As Integer
    '    'For x = 1 To 200
    '    LLENARDATOS(5000)
    '    If Not ED.SavetoFile("C:\EJEMPLOCN.XML") Then
    '        Throw New Exception(ED.ErrorText)
    '    End If
    '    GeneraCadena()
    '    'Exit Sub
    '    Dim TVB As New clsTimbradoVB
    '    'TVB.Timbar("C:\DEMO\DEMOFRG.PFX", "FRG101213EQ6", "BUGF810603SI8", "C:\EJEMPLOCN.XML", "demofrg")
    '    TVB.Timbar("C:\DEMO\DEMOFRG.PFX", "FRG101213EQ6", "BUGF810603SI8", "C:\ArchivosSAT\CFD\FRG101213EQ6CHIGUA1cfd.xml", "demofrg")
    '    Dim TF As New TimbreFiscal1.TimbreFiscalDigital
    '    TF = TVB.timbrefiscal

    '    MessageBox.Show(TF.selloSAT)
    '    MessageBox.Show(TF.selloCFD)
    '    MessageBox.Show(TF.noCertificadoSAT)
    '    MessageBox.Show(TF.FechaTimbrado)
    '    MessageBox.Show(TF.UUID)
    '    Dim VALIDADO As Boolean

    '    VALIDADO = False
    '    While Not VALIDADO
    '        Try
    '            'TXTTF1.Text = TF.selloSAT
    '            'TXTTF2.Text = TF.selloCFD
    '            'TXTTF3.Text = TF.noCertificadoSAT
    '            'TXTTF4.Text = TF.FechaTimbrado
    '            'TXTTF5.Text = TF.UUID
    '            TVB.Timbar("C:\DEMO\DEMOFRG.PFX", "FRG101213EQ6", "BUGF810603SI8", "C:\EJEMPLOCN.XML", "demofrg")
    '            TF = TVB.timbrefiscal
    '            VALIDADO = False
    '            TIMBREDATA = ElectronicDocumentLibrary.Complementos.TimbreFiscalDigital.TimbreData.NewEntity()
    '            TIMBREDATA.FechaTimbrado = TF.FechaTimbrado
    '            TIMBREDATA.SelloSAT = TF.selloSAT
    '            TIMBREDATA.NumeroCertificadoSAT = TF.noCertificadoSAT
    '            TIMBREDATA.UUID = TF.UUID
    '            TIMBREDATA.Version = TF.version
    '            ED.CreateCFDI("C:\EJEMPLOCN.XML", "C:\EJEMPLOCNCFDI.XML", TIMBREDATA)
    '            If String.IsNullOrEmpty(TIMBREDATA.UUID) Then
    '                VALIDADO = False
    '            Else
    '                VALIDADO = True
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End While
    '    'Next


    '    'Process.Start("C:\EJEMPLOCN.XML")

    'End Sub
    'Dim TIMBREDATA As ElectronicDocumentLibrary.Complementos.TimbreFiscalDigital.TimbreData
    'Private Sub LLENARDATOS(ByVal IMPORTE As Double)
    '    'Dim partida As Partida
    '    'Dim importacion As Importacion
    '    Dim concepto As Concepto
    '    Dim traslado As Traslado
    '    ED.Data.Clear()
    '    Dim TOTAL As Double
    '    TOTAL = (2000 + IMPORTE) * 1.16
    '    '' Datos del comprobante ****************************************************************
    '    ED.Data.Version.Value = "3.0"
    '    ED.Data.Serie.Value = "PRUEBADEMOFRG"
    '    ED.Data.Folio.Value = IMPORTE
    '    ED.Data.Fecha.Value = DateTime.Now
    '    ''electronicDocument.Data.AnioAprobacion.Value    = 2010
    '    ''electronicDocument.Data.NumeroAprobacion.Value  = 55898
    '    ED.Data.FormaPago.Value = "Pago en una sola exhibicion"
    '    'ED.Data.CondicionesPago.Value = "Parcialidades"
    '    ED.Data.SubTotal.Value = 2000 + IMPORTE
    '    'ED.Data.Descuento.Value = 360
    '    'ED.Data.MotivoDescuento.Value = "5% de descuento por pago en efectivo"
    '    ED.Data.Total.Value = TOTAL
    '    ED.Data.MetodoPago.Value = "Efectivo"
    '    ED.Data.TipoComprobante.Value = "ingreso"
    '    '' ***************************************************************************************

    '    '' Datos del emisor ********************************************************************
    '    ED.Data.Emisor.RFC.Value = "FRG101213EQ6"
    '    ED.Data.Emisor.Nombre.Value = "FRANQUICIAS Y RESTAURANTES GRUPO CHINALOA S DE RL DE CV"

    '    '' Domicilio fiscal del emisor
    '    ED.Data.Emisor.Domicilio.Calle.Value = "ALVARO OBREGON SUR"
    '    ED.Data.Emisor.Domicilio.NumeroExterior.Value = "690"
    '    'ED.Data.Emisor.Domicilio.NumeroInterior.Value = ""
    '    ED.Data.Emisor.Domicilio.Colonia.Value = "CENTRO"
    '    ED.Data.Emisor.Domicilio.Localidad.Value = "LOS MOCHIS"
    '    ED.Data.Emisor.Domicilio.Referencia.Value = "ALTOS"

    '    ED.Data.Emisor.Domicilio.Municipio.Value = "AHOME"
    '    ED.Data.Emisor.Domicilio.Estado.Value = "SINALOA"
    '    ED.Data.Emisor.Domicilio.Pais.Value = "MEXICO"
    '    ED.Data.Emisor.Domicilio.CodigoPostal.Value = "81280"

    '    '' Lugar donde se expidio el documento
    '    ED.Data.Emisor.ExpedidoEn.Calle.Value = "ALVARO OBREGON SUR"
    '    ED.Data.Emisor.ExpedidoEn.NumeroExterior.Value = "690"
    '    'ED.Data.Emisor.ExpedidoEn.NumeroInterior.Value = "1"
    '    ED.Data.Emisor.ExpedidoEn.Colonia.Value = "CENTRO"
    '    ED.Data.Emisor.ExpedidoEn.Localidad.Value = "LOS MOCHIS"
    '    ED.Data.Emisor.ExpedidoEn.Municipio.Value = "AHOME"
    '    ED.Data.Emisor.ExpedidoEn.Estado.Value = "SINALOA"
    '    ED.Data.Emisor.ExpedidoEn.Pais.Value = "MEXICO"
    '    ED.Data.Emisor.ExpedidoEn.CodigoPostal.Value = "81280"
    '    '' ***************************************************************************************

    '    '' Datos del Receptor ********************************************************************
    '    ED.Data.Receptor.RFC.Value = "BUGF810603SI8"
    '    ED.Data.Receptor.Nombre.Value = "FRANCISCO JAVIER BUSTAMANTE GARCIA"

    '    '' Domicilio fiscal del emisor
    '    ED.Data.Receptor.Domicilio.Calle.Value = "MIGUEL HIDALGO OTE"
    '    ED.Data.Receptor.Domicilio.NumeroExterior.Value = "1364"
    '    ED.Data.Receptor.Domicilio.Colonia.Value = "JIQUILPAN 2"
    '    ED.Data.Receptor.Domicilio.Localidad.Value = "LOS MOCHIS"
    '    'ED.Data.Receptor.Domicilio.Referencia.Value = "Entre Morena y Esperanza"
    '    ED.Data.Receptor.Domicilio.Municipio.Value = "AHOME"
    '    ED.Data.Receptor.Domicilio.Estado.Value = "SINALOA"
    '    ED.Data.Receptor.Domicilio.Pais.Value = "MEXICO"
    '    ED.Data.Receptor.Domicilio.CodigoPostal.Value = "81229"
    '    ''***************************************************************************************

    '    '' Concepto  No 1 ************************************************************************
    '    concepto = ED.Data.Conceptos.Add()
    '    concepto.Cantidad.Value = 1
    '    concepto.Unidad.Value = "001"
    '    concepto.Descripcion.Value = "CONSUMO"
    '    concepto.ValorUnitario.Value = 2000 + IMPORTE
    '    concepto.Importe.Value = 2000 + IMPORTE
    '    '' Concepto  No 1 ************************************************************************
    '    concepto = ED.Data.Conceptos.Add()
    '    concepto.Cantidad.Value = 1
    '    concepto.Unidad.Value = "002"
    '    concepto.Descripcion.Value = "CONSUMO2"
    '    concepto.ValorUnitario.Value = 2000 + IMPORTE
    '    concepto.Importe.Value = 2000 + IMPORTE


    '    '' Impuestos trasladados ************************************************************************
    '    traslado = ED.Data.Impuestos.Traslados.Add()
    '    traslado.Tasa.Value = 16
    '    traslado.Tipo.Value = "IVA"
    '    traslado.Importe.Value = (TOTAL / 1.16) * 0.16
    '    ED.Data.Impuestos.TotalTraslados.Value = (TOTAL / 1.16) * 0.16
    'End Sub



    'Private Sub TIMBRARVB()
    '    Dim TVB As New clsTimbradoVB
    '    TVB.Timbar("C:\DEMO\DEMOFRG.PFX", "FRG101213EQ6", "BUGF810603SI8", "c:\ejemplocn.xml", "demofrg")
    '    Dim TF As New TimbreFiscal1.TimbreFiscalDigital
    '    TF = TVB.timbrefiscal
    '    Try

    '        TIMBREDATA = ElectronicDocumentLibrary.Complementos.TimbreFiscalDigital.TimbreData.NewEntity()
    '        TIMBREDATA.FechaTimbrado = TF.FechaTimbrado
    '        TIMBREDATA.SelloSAT = TF.selloSAT
    '        TIMBREDATA.NumeroCertificadoSAT = TF.noCertificadoSAT
    '        TIMBREDATA.UUID = TF.UUID
    '        TIMBREDATA.Version = TF.version
    '        ED.CreateCFDI("C:\EJEMPLOCN.XML", "C:\EJEMPLOCNCFDI.XML", TIMBREDATA)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub

    'Private Function FileToMemory(ByVal Filename As String) As System.IO.MemoryStream
    '    Dim FS As New System.IO.FileStream(Filename, IO.FileMode.Open)
    '    Dim MS As New System.IO.MemoryStream
    '    Dim BA(FS.Length - 1) As Byte
    '    FS.Read(BA, 0, BA.Length)
    '    FS.Close()
    '    MS.Write(BA, 0, BA.Length)
    '    Return MS
    'End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SB.Items(1).Text = "Facturación Electrónica   " + Format(Now, "hh:mm:ss tt")
    End Sub
    Public Function CHECACONX() As Boolean
        If Me.CONX.State = ConnectionState.Closed Or Me.CONX.State = ConnectionState.Broken Then
            Try
                Me.CONX.Open()
            Catch ex As Exception
                MessageBox.Show("La Conexión NO esta realizada, La Informacion No se ha Procesado, Intente en un momento por Favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End Try
        End If
        Return True
    End Function
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Dim VEMISOR As New frmEmisor
        VEMISOR.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim VCLI As New frmClientes
        VCLI.ShowDialog()
    End Sub

    Private Sub NegociosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NegociosToolStripMenuItem.Click
        Dim VNEG As New frmNegocios
        VNEG.ShowDialog()
    End Sub


    Private Sub FacturasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasRealizadasToolStripMenuItem.Click
        Dim VRFR As New frmReporteFacturas
        VRFR.ShowDialog()
    End Sub

    Private Sub CancelarFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarFacturaToolStripMenuItem.Click
        Dim VCF As New frmCancelarFactura
        VCF.ShowDialog()
    End Sub

    Private Sub ReImprimirMultiplesFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReImprimirMultiplesFacturaToolStripMenuItem.Click
        Dim VRFM As New frmReimprimirFacturas
        VRFM.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AyudaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem1.Click
        Dim VAYU As New frmAyuda
        VAYU.ShowDialog()
    End Sub

    Private Sub TimbresGastadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimbresGastadosToolStripMenuItem.Click
        Dim VTG As New frmTimbresGastados
        VTG.ShowDialog()
    End Sub

    Private Sub ModificarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClientesToolStripMenuItem.Click
    End Sub

    Private Sub FoliosUtilizadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoliosUtilizadosToolStripMenuItem.Click
        Dim VFU As New frmFoliosUsados
        VFU.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click

    End Sub

    Private Sub FacturaciónDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónDeClientesToolStripMenuItem.Click
        Dim VFC As New frmReporteFacturaCliente
        VFC.ShowDialog()
    End Sub

    Private Sub FacturasRealizadasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasRealizadasToolStripMenuItem1.Click
        Dim VRFTN As New frmTimbresNegocios
        VRFTN.ShowDialog()
    End Sub

    Private Sub ConsultarVigenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarVigenciaToolStripMenuItem.Click
        Dim VCV As New frmConsultarVigencia
        VCV.ShowDialog()
    End Sub

    Private Sub Facturar33ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Facturar33ToolStripMenuItem.Click
        Dim VFAC As New frmFacturar
        VFAC.ShowDialog()
    End Sub

    Private Sub AjusteFacturasSinTimbrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjusteFacturasSinTimbrarToolStripMenuItem.Click
        Dim VAFST As New frmAjustadorFacturasSinTimbrar
        VAFST.ShowDialog()
    End Sub

    Private Sub PBFONDO_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFONDO.Resize
        'Dim TAMA As System.Drawing.Size
        'TAMA = Me.Size
        'TAMA.Height = TAMA.Height - 100
        'TAMA.Width = TAMA.Width - 10
        'PBCNC.Size = TAMA
        'PBCNC.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PBFONDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFONDO.Click

    End Sub
End Class
