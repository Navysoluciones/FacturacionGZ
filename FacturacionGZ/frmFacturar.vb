Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net.Sockets

Public Class frmFacturar
    Dim LSERIE As New List(Of String)
    Dim LNEG As New List(Of String)
    Dim LREG As New List(Of String)
    Dim LDOM As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LMP As New List(Of String)
    Dim LFP As New List(Of String)
    Dim LTIPO As New List(Of String)
    Dim LCP As New List(Of String)
    Dim CONZ As New SqlClient.SqlConnection
    Dim CADENA As String
    Dim LTC As New List(Of String)
    Dim LSNC As New List(Of String)

    Dim LENTO As New List(Of String)
    Dim LENTC As New List(Of String)

    Dim LIDO As New List(Of String)
    Dim LEDO As New List(Of String)
    Dim LIDC As New List(Of String)
    Dim LEDC As New List(Of String)
    Dim LADC As New List(Of String)
    Dim LMON As New List(Of String)

    Dim LINCO As New List(Of String)
    Dim LPAIS As New List(Of String)
    Dim LESTADO As New List(Of String)

    Dim LUSAT As New List(Of String)
    Dim LPYSSAT As New List(Of String)
    Dim LFIVA As New List(Of String)
    Dim LFIEPS As New List(Of String)
    Dim LUSO As New List(Of String)

    Dim LFIVAR As New List(Of String)
    Dim LFISRR As New List(Of String)

    Dim LFPCRP As New List(Of String)
    Dim LMONCRP As New List(Of String)
    Dim LCPCRP As New List(Of String)

    Dim LREL As New List(Of String)

    Dim LTF As New List(Of String)
    Dim LPER As New List(Of String)
    Dim LCON As New List(Of String)
    Dim LEDOO As New List(Of String)
    Dim LEDOD As New List(Of String)

    Dim LRF As New List(Of String)
    Dim LCODPOS As New List(Of String)
    Dim LIAPER As New List(Of String)
    Dim LIAMES As New List(Of String)
    Dim LIAAÑO As New List(Of String)
    Private Sub frmFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        Me.Text = "Facturación " + frmPrincipal.VCFD
        CADENA = frmPrincipal.CadenaConexion
        CONZ.ConnectionString = CADENA
        CHECACONZ()
        S = 0
        I = 0
        T = 0
        VIEPS = 0
        ACTIVAR(True)

        LLENACOMBOBOX3LISTAS(CBEMISOR, LDE, LTIPO, LSNC, "SELECT NOMBRE,TIPO,SERIENC,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
        LLENACOMBOBOX2(CBMON, LMON, "SELECT CLAVE,NOMBRE FROM CSATMONEDA ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBFP, LFP, "SELECT CLAVE,NOMBRE FROM CSATFORMAPAGO WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX(CBCP, LCP, "SELECT CLAVE,NOMBRE FROM CONDICIONESDEPAGO WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
        LLENACOMBOBOX2(CBMP, LMP, "SELECT CLAVE,NOMBRE FROM CSATMETODOPAGO WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        If Not LLENACOMBOBOX(CBTC, LTC, "SELECT CLAVE,NOMBRE FROM CSATTIPOCOMPROBANTE WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion) Then
            MessageBox.Show("Favor de establecer los tipos de Comprobantes, informar a Sistemas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        LIMPIAR()

        LLENACOMBOBOX2(CBEO, LENTO, "SELECT CLAVE,NOMBRE FROM ENTIDADES WHERE ACTIVO=1 ORDER BY NOMBRE", CADENA, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBEC, LENTC, "SELECT CLAVE,NOMBRE FROM ENTIDADES WHERE ACTIVO=1 ORDER BY NOMBRE", CADENA, "Favor de Seleccionar", "")

        LLENACOMBOBOX2(CBCEINCO, LINCO, "SELECT CLAVE,CLAVE+'-'+NOMBRE FROM INCOTERM WHERE ACTIVO=1 ORDER BY NOMBRE", CADENA, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBCEPAIS, LPAIS, "SELECT CLAVE,NOMBRE FROM PAISES WHERE ACTIVO=1 ORDER BY NOMBRE", CADENA, "Favor de Seleccionar", "")


        LLENACOMBOBOX2(CBPYS, LPYSSAT, "SELECT CLAVE,CLAVE+'-'+NOMBRE FROM CSATPYS ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBUNI, LUSAT, "SELECT CLAVE,NOMBRE FROM CSATUNIDADES ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBUSO, LUSO, "SELECT CLAVE,NOMBRE FROM CSATUSOCOMPROBANTE ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")

        LLENACOMBOBOX2(CBFIVA, LFIVA, "SELECT CLAVE,NOMBRE FROM CSATTIPOFACTOR WHERE CLAVE<>2 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        LLENACOMBOBOX2(CBFIEPS, LFIEPS, "SELECT CLAVE,NOMBRE FROM CSATTIPOFACTOR ORDER BY NOMBRE ", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")

        LLENACOMBOBOX2(CBFIVAR, LFIVAR, "SELECT CLAVE,NOMBRE FROM CSATTIPOFACTOR WHERE CLAVE<>2 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        LLENACOMBOBOX2(CBFISRR, LFISRR, "SELECT CLAVE,NOMBRE FROM CSATTIPOFACTOR WHERE CLAVE<>2 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")

        LLENACOMBOBOX2(CBCRPFP, LFPCRP, "SELECT CLAVE,NOMBRE FROM CSATFORMAPAGO WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBCRPMON, LMONCRP, "SELECT CLAVE,NOMBRE FROM CSATMONEDA ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBCRPTCP, LCPCRP, "SELECT CLAVE,NOMBRE FROM CSATTIPOCADENAPAGO ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX(CBREL, LREL, "select CLAVE,CLAVE+' - '+NOMBRE	from CSATRELACIONCFDI order by CLAVE", frmPrincipal.CadenaConexion)
        'cartaporte
        LLENACOMBOBOX2(CBTF, LTF, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATTIPOSFIGURA WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        LLENACOMBOBOX2(CBPER, LPER, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATPERMISOSSCT ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        LLENACOMBOBOX2(CBCON, LCON, "SELECT CLAVE,CLAVE +' - '+DESCRIPCION FROM CSATAUTOTRANSPORTES ORDER BY DESCRIPCION", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        LLENACOMBOBOX2(CBEDOORI, LEDOO, "SELECT CLAVE,CLAVE+ ' - '+ NOMBRE  FROM ESTADOS where PAIS='mex'", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        LLENACOMBOBOX2(CBEDODES, LEDOD, "SELECT CLAVE,CLAVE+ ' - '+ NOMBRE  FROM ESTADOS where PAIS='mex'", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        'INFORMACION ADICIONAL
        OPLlenaComboBox(CBIAPER, LIAPER, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATPERIODICIDAD WHERE ACTIVO=1 ORDER BY CLAVE", CADENA)
        '4.0     
        OPLlenaComboBox(CBRF, LRF, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATREGIMENFISCAL WHERE ACTIVO=1 ORDER BY CLAVE", CADENA)
        CARGAX(LPER, CBPER, "TPXX00")

        CBIAAÑO.Items.Clear()
        Dim añoactual As Integer
        añoactual = DatePart(DateInterval.Year, Now)
        CBIAAÑO.Items.Add((añoactual - 1).ToString)
        CBIAAÑO.Items.Add((añoactual).ToString)
        CBIAAÑO.Items.Add((añoactual + 1).ToString)
        CBIAAÑO.SelectedIndex = 1
        OPCargaX(LPER, CBPER, "TPXX00")

        CBCETO.SelectedIndex = 0
        CBCESUB.SelectedIndex = 0
        CARGAX(LMON, CBMON, "MXN")
        CARGAX(LMONCRP, CBCRPMON, "MXN")
        CARGAX(LINCO, CBCEINCO, "DAP")
        RB1.Checked = True
        RB3.Checked = True
        RB5.Checked = True
        ''default impuestos

        OPCargaX(LFIVA, CBFIVA, "3")
        OPCargaX(LFIEPS, CBFIEPS, "3")



        'CHKCRP.Checked = False
        INICIALIZARTTT()
        BGW.RunWorkerAsync()
        CHECATABLA()
        CHKIR.Checked = True
        CHKINE.Checked = False
        CHKCE.Checked = False
        CHKIT.Checked = True
        CHKIR.Checked = False
        CHKCP.Checked = False
        CBFIVA.SelectedIndex = 0
        CBFIEPS.SelectedIndex = 0
        CBFIVAR.SelectedIndex = 0
        CBFISRR.SelectedIndex = 0
        INICIALIZARNUD()
        ComplementosActivos()
    End Sub
    Private Sub INICIALIZARTTT()
        TTT.SetToolTip(BTNGUARDAR, "Guardar")
        TTT.SetToolTip(BTNCANCELAR, "Cancelar")       
        TTT.SetToolTip(BTNBUSCAR, "Buscar")


        TTT.SetToolTip(TXTCRPNOPE, "Se puede registrar el número de cheque, número de autorización, número de referencia, clave de rastreo en caso de ser SPEI, línea de captura o algún número de referencia o identificación análogo que permita identificar la operación correspondiente al pago efectuado")
        TTT.SetToolTip(TXTCRPRFCCO, "Se puede registrar la clave del RFC de la entidad emisora de la cuenta origen, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc., en caso de ser residente en el extranjero se debe registrar la clave en el RFC genérica XEXX010101000, en caso de que éste no se utilice, la clave en el RFC que se registre debe estar en la lista de claves en el RFC inscritas en el SAT.")
        TTT.SetToolTip(TXTCRPNBCO, "Se puede registrar el nombre del banco ordenante, es requerido en caso de ser extranjero, considerar las reglas de obligatoriedad de acuerdo con la columna Nombre del Banco emisor de la cuenta ordenante en caso de extranjero del catálogo c_FormaPago publicado en el Portal del SAT. ")
        TTT.SetToolTip(TXTCRPCO, "Se puede registrar el número de la cuenta con la que se realizó el pago, considerar las reglas de obligatoriedad de acuerdo con la columna Cuenta Ordenante del catálogo c_FormaPago publicado en el Portal del SAT. ")
        TTT.SetToolTip(TXTCRPRFCCB, "Se puede registrar la clave en el RFC de la entidad operadora de la cuenta destino, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc. ")
        TTT.SetToolTip(TXTCRPCB, "Se puede registrar el número de cuenta en donde se recibió el pago.")
        'TTT.SetToolTip(TXTCRPNUMP, "Es el número de parcialidad que corresponde al pago.")
        'TTT.SetToolTip(TXTCRPISA, "Es el monto del saldo insoluto de la parcialidad anterior. Es requerido cuando MetodoDePagoDR contiene PPD Pago en parcialidades o diferido). En el caso de que sea la primer parcialidad este campo debe contener el importe total del documento relacionado.")
        'TTT.SetToolTip(TXTCRPIPAG, "Es el importe pagado que corresponde al documento relacionado. Este dato es obligatorio cuando exista más de un documento relacionado o cuando existe un documento relacionado y el campo TipoCambioDR tiene un valor.")
        'TTT.SetToolTip(TXTCRPISI, "Es la diferencia entre el importe del saldo anterior y el monto del pago. Es requerido cuando MetodoDePagoDR contiene PPD (Pago en parcialidades o diferido).")        

    End Sub
    Private Function CHECACONZ() As Boolean
        If Me.CONZ.State = ConnectionState.Closed Or Me.CONZ.State = ConnectionState.Broken Then
            Try
                Me.CONZ.Open()
            Catch ex As Exception
                MessageBox.Show("La Conexión NO esta realizada, La Informacion No se ha Procesado, Intente en un momento por Favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End Try
        End If
        Return True
    End Function
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT NOMBRE,NOMBRECOMERCIAL,REGIMENFISCAL,USO FROM CLIENTES WHERE RFC='" + TXTRFC.Text + "'", CONZ)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            TXTNOM.Text = LEC(0)
            TXTNCOM.Text = LEC(1)
            OPCargaX(LRF, CBRF, LEC(2))
            OPCargaX(LUSO, CBUSO, LEC(3))
        End If
        LEC.Close()
        SQL.Dispose()
        OPLlenaComboBox(CBCALLE, LREG, LDOM, LCODPOS, "SELECT REGISTRO,dbo.DIRCLIENTE(RFC,REGISTRO),CP,CALLE FROM DOMICILIOSCLIENTES WHERE RFC='" + TXTRFC.Text + "' AND ACTIVO=1", CADENA)

        If CBCALLE.Items.Count <= 0 Then
            MessageBox.Show("Este cliente no cuenta con direcciones para la Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        Else
            CBCALLE.SelectedIndex = 0
            ACTIVAR(False)
            CHECATABLA()
        End If
        If Trim(TXTRFC.Text) = "XAXX010101000" Or Trim(TXTRFC.Text) = "XEXX010101000" Then
            GBIAPG.Enabled = True
        Else
            GBIAPG.Enabled = False
        End If
    End Sub
    Dim S, I, T, VIEPS, IMP, RIVA, RISR, TADV As Double
    Dim CLETRAS As New num2text
    Private Sub CHECATABLA()
        'Dim VIVA, VRETIVA, VISR As Double
        S = 0
        I = 0
        T = 0
        TADV = 0
        VIEPS = 0
        RIVA = 0
        RISR = 0
        TADV = 0
        If DGV.Rows.Count <= 0 Then
            BTNGUARDAR.Enabled = False
        Else
            BTNGUARDAR.Enabled = True
            Dim X As Integer
            For X = 0 To DGV.Rows.Count - 1
                S += DGV.Item(5, X).Value
                I += DGV.Item(6, X).Value
                VIEPS += DGV.Item(7, X).Value

                RIVA += DGV.Item(8, X).Value
                RISR += DGV.Item(9, X).Value


            Next
        End If
        'I = (S * VIVA) / 100
        'I = Math.Round(I, 2)
        T += (S + I + VIEPS - RIVA - RISR)
        'TADV = S + I + VIEPS + IMP + RIVA + RISR
        'T = S + I + VIEPS - RISR - RIVA
        T = Math.Round(T, 2)
        TXTTOT.Text = FormatNumber(T, 2).ToString
        TXTIMP.Text = FormatNumber(S + I, 2).ToString
        TXTSUB.Text = FormatNumber(S, 2).ToString
        TXTIVA.Text = FormatNumber(I, 2).ToString
        TXTRIVA.Text = FormatNumber(RIVA, 2).ToString
        TXTISR.Text = FormatNumber(RISR, 2).ToString
        TXTIEPS.Text = FormatNumber(VIEPS, 2).ToString
        LBLCCL.Text = CLETRAS.Letras(T.ToString, LMON(CBMON.SelectedIndex), CBMON.Text)

        Try
            DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells            
        Catch ex As Exception

        End Try
        If LTC(CBTC.SelectedIndex) = "P" Then
            BTNGUARDAR.Enabled = True
        End If
    End Sub


    Private Sub CBCALLE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCALLE.SelectedIndexChanged
        LBLDD.Text = LDOM(CBCALLE.SelectedIndex)
        TXTCP.Text = LCODPOS(CBCALLE.SelectedIndex)
    End Sub
    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTRFC.Enabled = V
        CBCALLE.Enabled = Not V
        TXTCANT.Enabled = Not V
        TXTDES.Enabled = Not V
        TXTUNI.Enabled = Not V
        TXTVU.Enabled = Not V
        TXTCOM.Enabled = Not V
        'TXTTCIEPS.Enabled = Not V
        CBUNI.Enabled = Not V
        CBPYS.Enabled = Not V
        Button2.Enabled = Not V
        Button3.Enabled = Not V
        CBFIEPS.Enabled = Not V
        CBFIVA.Enabled = Not V
        CHKIT.Checked = Not V
        If V Then
            CHKIR.Checked = Not V
            CHKIT.Checked = Not V
        End If

        'TXTTIVA.Enabled = Not V
        'TXTTCIEPS.Enabled = Not V
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        frmClsBusqueda.BUSCAR("SELECT RFC,NOMBRE,NOMBRECOMERCIAL [NOMBRE COMERCIAL] FROM VCLIENTES ", " WHERE COMPUESTO", " ORDER BY NOMBRE", "Búsqueda de Clientes", "Nombre Comercial del Cliente", "Cliente(s)", 1, CADENA, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTRFC.Text = frmClsBusqueda.TREG.Rows(0).Item(0)
            CARGADATOS()
        End If
    End Sub
    Private Sub CARGARNOTA(ByVal RES As String, ByVal NOTA As String)
        If Not CHECACONZ() Then
            Exit Sub
        End If
        DGV.DataSource = LLENATABLA("SELECT D.PLATILLO,D.CANTIDAD,P.NOMBRE DESCRIPCION,PRECIO=(CONVERT(NUMERIC(15,2),(D.TOTAL/D.CANTIDAD)/1.16,2)),TOTAL=CONVERT(NUMERIC(15,2),(D.TOTAL/1.16),2) FROM DETALLENOTASDEVENTA D INNER JOIN PLATILLOS P ON D.PLATILLO=P.CLAVE WHERE D.RESTAURANTE='" + RES + "' AND NOTA=" + NOTA.ToString, CADENA)
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CHECATABLA()
    End Sub
    Private Sub TXTNOTA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = Chr(13) Then
        '    If String.IsNullOrEmpty(TXTRFC.Text) Then
        '    Else
        '        CARGARNOTA(LNEG(CBNEG.SelectedIndex), TXTNOTA.Text)
        '    End If
        'End If
    End Sub
    Private Sub ComplementosActivos()
        If CHKINE.Checked Then
            TabPage2.Parent = TABC
        Else
            TabPage2.Parent = Nothing
        End If
        If Me.CHKCE.Checked Then
            TabPage4.Parent = Me.TABC


        Else
            TabPage4.Parent = Nothing
            CHKCEDD.Checked = False
        End If

        LBLCA.Visible = CHKCE.Checked
        LBLFA.Visible = CHKCE.Checked
        TXTCA.Visible = CHKCE.Checked
        TXTFA.Visible = CHKCE.Checked

        If CHKCP.Checked Then
            If LTC(CBTC.SelectedIndex) = "T" Or LTC(CBTC.SelectedIndex) = "I" Then
                TabPage7.Parent = TABC
            Else
                MessageBox.Show("Carta porte solo aplica para Traslado e Ingreso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CHKCP.Checked = False
            End If
        Else
            TabPage7.Parent = Nothing
        End If
    End Sub
    Private Function FOLIO(ByVal SERIE As String) As Integer
        If Not frmPrincipal.CHECACONX Then
            Exit Function
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT DBO.SIGFOLIO('" + CBEMISOR.Text + "','" + SERIE + "')", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        Dim REG As Integer
        REG = 1
        If LEC.Read Then
            If LEC(0) Is DBNull.Value Then
                REG = 1
            Else
                REG = LEC(0)
            End If
        End If
        LEC.Close()
        Return REG
    End Function

    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        If LSERIE.Count <= 0 Then
            MessageBox.Show("Favor de dar de alta Negocios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        CHECATABLA()

        Dim LASERIE As String
        If LTC(CBTC.SelectedIndex) = "2" Then
            LASERIE = LSNC(CBEMISOR.SelectedIndex)
        Else
            LASERIE = LSERIE(CBNEG.SelectedIndex)
        End If
        If LASERIE = "N/A" Then
            MessageBox.Show("Serie de Nota de Crédito No Válida N/A", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim ELFOLIO As Integer
        ELFOLIO = FOLIO(LASERIE)
        'If LTC(CBTC.SelectedIndex) = "P" Then
        '    If CHKCRP.Checked = False Then
        '        MessageBox.Show("Debe estar marcado el complemento de recepción de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'End If

        'If CHKCRP.Checked Then
        '    If LTC(CBTC.SelectedIndex) <> "P" Then
        '        MessageBox.Show("El tipo de comprobante debe ser P-Pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'End If


        If LTC(CBTC.SelectedIndex) = "E" Then
            Dim VSF As New frmSeleccionaFactura
            VSF.MOSTRAR(CBEMISOR.Text, TXTRFC.Text, TXTNOM.Text)
            If VSF.DialogResult = Windows.Forms.DialogResult.Yes Then
                If VSF.CTOT < T Then
                    MessageBox.Show("El total de la factura referenciada es menor que la nota de crédito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Dim SQLRNCF As New SqlClient.SqlCommand("INSERT INTO FEBAJAMAR.dbo.REFERENCIANCFAC (RFCEMISOR,SERIENC,FOLIONC,SERIEFAC,FOLIOFAC,TIENDA,CLIENTEVENTA,RFCRECEPTOR,TOTAL) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "','" + ELFOLIO.ToString + "','" + VSF.CSERIE + "','" + VSF.CFOLIO + "','N/A',0,'" + TXTRFC.Text + "'," + T.ToString + ")", frmPrincipal.CONX)                
                Dim SQLRNCF As New SqlClient.SqlCommand("INSERT INTO REFERENCIANCFAC (RFCEMISOR,SERIENC,FOLIONC,SERIEFAC,FOLIOFAC,TIENDA,CLIENTEVENTA,RFCRECEPTOR,TOTAL) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "','" + ELFOLIO.ToString + "',@SER,@FOL,'N/A',0,'" + TXTRFC.Text + "'," + T.ToString + ")", frmPrincipal.CONX)
                SQLRNCF.Parameters.Add("@SER", SqlDbType.VarChar)
                SQLRNCF.Parameters.Add("@FOL", SqlDbType.VarChar)
                Dim I As Integer
                For I = 0 To VSF.DTRESULTADO.Rows.Count - 1
                    SQLRNCF.Parameters("@SER").Value = VSF.DTRESULTADO.Rows(I).Item(0)
                    SQLRNCF.Parameters("@FOL").Value = VSF.DTRESULTADO.Rows(I).Item(1)
                    SQLRNCF.ExecuteNonQuery()
                Next
                Dim SQLCNC As New SqlClient.SqlCommand("SPCORREONOTACREDITO", frmPrincipal.CONX)
                SQLCNC.CommandType = CommandType.StoredProcedure
                SQLCNC.Parameters.Add("@RFCEMISOR", SqlDbType.VarChar).Value = CBEMISOR.Text
                SQLCNC.Parameters.Add("@RFCRECEPTOR", SqlDbType.VarChar).Value = TXTRFC.Text
                SQLCNC.Parameters.Add("@FOLIO", SqlDbType.VarChar).Value = ELFOLIO.ToString
                SQLCNC.Parameters.Add("@NOTACREDITO", SqlDbType.VarChar).Value = TXTNOM.Text
                SQLCNC.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = T.ToString
                SQLCNC.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = VSF.CSERIE + "-" + VSF.CFOLIO
                SQLCNC.Parameters.Add("@FECHAFAC", SqlDbType.VarChar).Value = VSF.CFECHA
                SQLCNC.ExecuteNonQuery()
            Else
                Exit Sub
            End If

        End If

        If CHKINE.Checked Then
            GUARDAINE(LASERIE, ELFOLIO)
        End If

        If CHKCE.Checked Then
            GUARDACOMERCIOEXTERIOR(LASERIE, ELFOLIO)
        End If
        If CHKCP.Checked Then
            GUARDACARTAPORTE(LASERIE, ELFOLIO)
        End If
        'If CHKCRP.Checked Then
        '    GUARDACOMERCIOEXTERIOR(LASERIE, ELFOLIO)
        'End If

        If LTC(CBTC.SelectedIndex) = "P" Then
            'Dim SQLF As New SqlClient.SqlCommand("INSERT INTO FACTURAS (RFCEMISOR,SERIE,FOLIO,NEGOCIO,RFCCLIENTE,DOMICILIOCLIENTE,SUBTOTAL,TOTAL,IVA,TIPOCAMBIO,NTIPOCOMPROBANTE,NMONEDA,NFORMAPAGO,NMETODOPAGO,RELACIONCFDI,UUIDRELACION,NUSOCFDI,CCLETRA,TIPOCOMPROBANTE,METODOPAGO,FORMAPAGO,NOMBRE,FECHA,RELACIONCFDI,UUIDRELACION,VCFD) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "'," + ELFOLIO.ToString + ",'" + LNEG(CBNEG.SelectedIndex) + "','" + TXTRFC.Text + "','" + LREG(CBCALLE.SelectedIndex).ToString + "',0,0,0,1,'P','XXX','00','00','04','','P01','Cero pesos 00/100 M.N.',1,1,1,'" + TXTNOM.Text + "',@FEC,'" + LREL(CBREL.SelectedIndex) + "','" + TXTFREL.Text + "','3.3')", frmPrincipal.CONX)
            Dim SQLF As New SqlClient.SqlCommand("INSERT INTO FACTURAS (RFCEMISOR,SERIE,FOLIO,NEGOCIO,RFCCLIENTE,DOMICILIOCLIENTE,SUBTOTAL,TOTAL,IVA,TIPOCAMBIO,NTIPOCOMPROBANTE,NMONEDA,NFORMAPAGO,NMETODOPAGO,NUSOCFDI,   CCLETRA,   TIPOCOMPROBANTE,   METODOPAGO,   FORMAPAGO,   NOMBRE,   FECHA,   RELACIONCFDI,   UUIDRELACION,   VCFD)    VALUES ('" + CBEMISOR.Text + "',   '" + LASERIE + "',   " + ELFOLIO.ToString + ",   '" + LNEG(CBNEG.SelectedIndex) + "',   '" + TXTRFC.Text + "',   '" + LREG(CBCALLE.SelectedIndex).ToString + "',   0,   0,   0,   1,   'P',   'XXX',   '00',   '00',   'CP01',   'Cero pesos 00/100 M.N.',   1,   1,   1,   '" + TXTNOM.Text + "',   @FEC,   '" + LREL(CBREL.SelectedIndex) + "',   '" + TXTFREL.Text + "',   '" + frmPrincipal.VCFD + "')", frmPrincipal.CONX)
            SQLF.Parameters.Add("@FEC", SqlDbType.DateTime).Value = DTDE.Value
            SQLF.ExecuteNonQuery()
            Dim SQLD As New SqlClient.SqlCommand("INSERT INTO DETALLEFACTURAS (RFCEMISOR,SERIE,FOLIO,REFNOTA,CANTIDAD,UNISAT,DESCRIPCION,VALORUNITARIO,IMPORTE,PYSSAT,REGISTRO,TIPOFACTORIVA ,TIPOFACTORIEPS,UNIDAD  ) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "'," + ELFOLIO.ToString + ",'0',1,'ACT','Pago',0,0,'84111506',0,3,3,'PAGO')", frmPrincipal.CONX)
            SQLD.ExecuteNonQuery()
            Dim SQLRP As New SqlClient.SqlCommand("INSERT INTO COMPLEMENTORECEPCIONPAGO (RFCEMISOR,SERIE,FOLIO,FECHAPAGO,FORMAPAGO,MONEDAP,TIPOCAMBIOP,MONTO,NUMOPERACION,IDPAGO,UUIDRELACION,SERIER,FOLIOR,METODOPAGODR,IMPSALDOANT,IMPPAGADO,IMPSALDOINSOLUTO,NUMPARCIALIDAD,RFCEMISORCTAORD,NOMBANCOORDEXT,CTAORDENANTE,RFCEMISORCTABEN,CTABENEFICIARIO,TIPOCADPAGO,CERTPAGO,CADPAGO,SELLOPAGO,MONEDADR,TIPOCAMBIODR) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "'," + ELFOLIO.ToString + ",@FEC,'" + LFPCRP(CBCRPFP.SelectedIndex) + "','" + LMONCRP(CBCRPMON.SelectedIndex) + "',@TC,@AB,@NOTAVENTA,@REG,@UUID,@SERIER,@FOLIOR,'PPD',@SA,@AB,@SALDO,@NUMP,'" + TXTCRPRFCCO.Text + "','" + TXTCRPNBCO.Text + "','" + TXTCRPCO.Text + "','" + TXTCRPRFCCB.Text + "','" + TXTCRPCB.Text + "','" + LCPCRP(CBCRPTCP.SelectedIndex) + "','','','','" + LMONCRP(CBCRPMON.SelectedIndex) + "',@TC)", frmPrincipal.CONX)

            '@TC,@AB,@NOTAVENTA,@REG,@UUID,@SERIER,@FOLIOR,PPD,@SA,@AB,@SALDO,@NUMP)


            SQLRP.Parameters.Add("@FEC", SqlDbType.DateTime).Value = SUMARTIEMPOAFECHA(DTPCRPFP.Value, DTHORA.Value)
            SQLRP.Parameters.Add("@TC", SqlDbType.Float).Value = TXTCRPTC.Text
            SQLRP.Parameters.Add("@NOTAVENTA", SqlDbType.VarChar).Value = TXTCRPNOPE.Text

            SQLRP.Parameters.Add("@AB", SqlDbType.Float)
            SQLRP.Parameters.Add("@REG", SqlDbType.Int)
            SQLRP.Parameters.Add("@UUID", SqlDbType.VarChar)
            SQLRP.Parameters.Add("@SERIER", SqlDbType.VarChar)
            SQLRP.Parameters.Add("@FOLIOR", SqlDbType.VarChar)
            SQLRP.Parameters.Add("@SA", SqlDbType.Float)
            SQLRP.Parameters.Add("@SALDO", SqlDbType.Float)
            SQLRP.Parameters.Add("@NUMP", SqlDbType.Int)

            Dim X As Integer
            For X = 0 To DGVCRP.Rows.Count - 1
                SQLRP.Parameters("@SERIER").Value = DGVCRP.Item(0, X).Value
                SQLRP.Parameters("@FOLIOR").Value = DGVCRP.Item(1, X).Value
                SQLRP.Parameters("@UUID").Value = DGVCRP.Item(2, X).Value
                SQLRP.Parameters("@SA").Value = DGVCRP.Item(4, X).Value
                SQLRP.Parameters("@NUMP").Value = DGVCRP.Item(5, X).Value
                SQLRP.Parameters("@AB").Value = DGVCRP.Item(6, X).Value
                SQLRP.Parameters("@SALDO").Value = DGVCRP.Item(7, X).Value
                SQLRP.Parameters("@REG").Value = X

                SQLRP.ExecuteNonQuery()
            Next
            SQLF.Dispose()
            SQLD.Dispose()
            SQLRP.Dispose()
            BDEjecutarSql("EXEC SPGENERAIMPUESTOSPAGOS '" + CBEMISOR.Text + "',   '" + LASERIE + "',   " + ELFOLIO.ToString, CADENA)


        Else
            Dim SQL As New SqlClient.SqlCommand("INSERT INTO FACTURAS (RFCEMISOR,SERIE,FOLIO,NEGOCIO,RFCCLIENTE,DOMICILIOCLIENTE,TIPOCOMPROBANTE,METODOPAGO,FORMAPAGO,REFNOTA,SUBTOTAL,IVA,TOTAL,CCLETRA,RETISR,RETIVA,FECHA,TIPOFACTURA,NOMBRE,DIGITOSTC,COMENTARIO,CONDICIONESDEPAGO,MONEDA,TIPOCAMBIO,NMONEDA,NFORMAPAGO,NMETODOPAGO,NTIPOCOMPROBANTE,NUSOCFDI,VCFD,RELACIONCFDI,UUIDRELACION) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "'," + ELFOLIO.ToString + ",'" + LNEG(CBNEG.SelectedIndex) + "','" + TXTRFC.Text + "','" + LREG(CBCALLE.SelectedIndex).ToString + "','0','0','0','0'," + S.ToString + "," + I.ToString + "," + T.ToString + ",'" + LBLCCL.Text + "','" + RISR.ToString + "','" + RIVA.ToString + "',@FEC,'1','" + TXTNOM.Text + "','" + DIGITOSTC + "','" + TXTCOM.Text + "','" + LCP(CBCP.SelectedIndex) + "','1','" + TIPOCAMBIO.ToString + "','" + LMON(CBMON.SelectedIndex) + "','" + LFP(CBFP.SelectedIndex) + "','" + LMP(CBMP.SelectedIndex) + "','" + LTC(CBTC.SelectedIndex) + "','" + LUSO(CBUSO.SelectedIndex) + "','" + frmPrincipal.VCFD + "','" + LREL(CBREL.SelectedIndex) + "','" + TXTFREL.Text + "')", frmPrincipal.CONX)
            SQL.Parameters.Add("@FEC", SqlDbType.DateTime).Value = DTDE.Value
            SQL.ExecuteNonQuery()
            Dim SQLD As New SqlClient.SqlCommand("INSERT INTO DETALLEFACTURAS (RFCEMISOR,SERIE,FOLIO,REFNOTA,CODIGO,CANTIDAD,DESCRIPCION,VALORUNITARIO,IMPORTE,REGISTRO,UNIDAD,IEPS,TASAIEPS,IVA,TASAIVA,TIPOFACTORIVA,TIPOFACTORIEPS,ISR,TASAISR,TIPOFACTORISR,PYSSAT,UNISAT,TASAIVAR,TIPOFACTORIVAR,TASAIEPSR,TIPOFACTORIEPSR,ISRR,TASAISRR,TIPOFACTORISRR,IVAR,IEPSR,PESO,FRACCIONARANCELARIA) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "','" + ELFOLIO.ToString + "','0',@COD,@CANT,@DES,@PRE,@IMP,@REG,@UNI,@IEPS,@TIEPS,@IVA,@TIVA,@FIVA,@FIEPS,@ISR,@TISR,@FISR,@PYSSAT,@UNISAT,@TIVAR,@FIVAR,@TIEPSR,@FIEPSR,@ISRR,@TISRR,@FISRR,@IVAR,@IEPSR,@PESO,@FARANCEL)", frmPrincipal.CONX)
            SQLD.Parameters.Add("@COD", SqlDbType.VarChar)
            SQLD.Parameters.Add("@CANT", SqlDbType.Float)
            SQLD.Parameters.Add("@DES", SqlDbType.VarChar)
            SQLD.Parameters.Add("@UNI", SqlDbType.VarChar)
            SQLD.Parameters.Add("@PRE", SqlDbType.Float)
            SQLD.Parameters.Add("@IMP", SqlDbType.Float)
            SQLD.Parameters.Add("@REG", SqlDbType.Int)
            SQLD.Parameters.Add("@IEPS", SqlDbType.Float)
            SQLD.Parameters.Add("@IVA", SqlDbType.Float)

            SQLD.Parameters.Add("@TIVA", SqlDbType.Float)
            SQLD.Parameters.Add("@FIVA", SqlDbType.VarChar)
            SQLD.Parameters.Add("@FIEPS", SqlDbType.VarChar)
            SQLD.Parameters.Add("@TIEPS", SqlDbType.Float)
            SQLD.Parameters.Add("@ISR", SqlDbType.Float)
            SQLD.Parameters.Add("@TISR", SqlDbType.Float)
            SQLD.Parameters.Add("@FISR", SqlDbType.VarChar)


            '@PYSSAT,@UNISAT,@TIVAR,@FIVAR,@TIEPSR,@FIEPSR,@ISRR,@TISRR,@FISRR,@IVAR,@IEPSR

            SQLD.Parameters.Add("@PYSSAT", SqlDbType.VarChar)
            SQLD.Parameters.Add("@UNISAT", SqlDbType.VarChar)
            SQLD.Parameters.Add("@TIVAR", SqlDbType.Float)
            SQLD.Parameters.Add("@FIVAR", SqlDbType.VarChar)
            SQLD.Parameters.Add("@TIEPSR", SqlDbType.Float)
            SQLD.Parameters.Add("@FIEPSR", SqlDbType.VarChar)
            SQLD.Parameters.Add("@ISRR", SqlDbType.Float)
            SQLD.Parameters.Add("@TISRR", SqlDbType.Float)
            SQLD.Parameters.Add("@FISRR", SqlDbType.VarChar)
            SQLD.Parameters.Add("@IVAR", SqlDbType.Float)
            SQLD.Parameters.Add("@IEPSR", SqlDbType.Float)
            SQLD.Parameters.Add("@PESO", SqlDbType.Float)
            SQLD.Parameters.Add("@FARANCEL", SqlDbType.VarChar)



            Dim X As Integer
            For X = 0 To DGV.Rows.Count - 1
                SQLD.Parameters("@COD").Value = DGV.Item(0, X).Value.ToString
                SQLD.Parameters("@CANT").Value = DGV.Item(1, X).Value
                SQLD.Parameters("@DES").Value = DGV.Item(2, X).Value.ToString
                SQLD.Parameters("@UNI").Value = DGV.Item(3, X).Value.ToString
                SQLD.Parameters("@PRE").Value = DGV.Item(4, X).Value
                SQLD.Parameters("@IMP").Value = DGV.Item(5, X).Value
                SQLD.Parameters("@IVA").Value = DGV.Item(6, X).Value
                SQLD.Parameters("@IEPS").Value = DGV.Item(7, X).Value
                SQLD.Parameters("@IVAR").Value = DGV.Item(8, X).Value
                SQLD.Parameters("@ISRR").Value = DGV.Item(9, X).Value


                SQLD.Parameters("@REG").Value = X.ToString

                Dim A, B, C As String
                A = DGV.Item(11, X).Value.ToString
                B = DGV.Item(13, X).Value.ToString

                SQLD.Parameters("@FIVA").Value = DGV.Item(11, X).Value
                SQLD.Parameters("@TIVA").Value = DGV.Item(12, X).Value
                SQLD.Parameters("@FIEPS").Value = DGV.Item(13, X).Value
                SQLD.Parameters("@TIEPS").Value = DGV.Item(14, X).Value
                If CHKCE.Checked Then
                    SQLD.Parameters("@UNISAT").Value = "KGM"
                Else
                    SQLD.Parameters("@UNISAT").Value = DGV.Item(15, X).Value.ToString
                End If

                SQLD.Parameters("@PYSSAT").Value = DGV.Item(16, X).Value.ToString

                SQLD.Parameters("@TIVAR").Value = DGV.Item(17, X).Value
                SQLD.Parameters("@FIVAR").Value = DGV.Item(18, X).Value

                SQLD.Parameters("@TISRR").Value = DGV.Item(22, X).Value
                SQLD.Parameters("@FISRR").Value = DGV.Item(23, X).Value
                SQLD.Parameters("@PESO").Value = DGV.Item(24, X).Value


                SQLD.Parameters("@ISR").Value = DGV.Item(19, X).Value
                SQLD.Parameters("@TISR").Value = DGV.Item(20, X).Value
                SQLD.Parameters("@FISR").Value = DGV.Item(21, X).Value
                SQLD.Parameters("@FARANCEL").Value = DGV.Item(26, X).Value

                SQLD.Parameters("@IEPSR").Value = "0"
                SQLD.Parameters("@TIEPSR").Value = "0"
                SQLD.Parameters("@FIEPSR").Value = "3"

                SQLD.ExecuteNonQuery()
            Next
            SQL.Dispose()
            SQLD.Dispose()

        End If
        BDEjecutarSql("UPDATE CLIENTES SET NOMBRE='" + TXTNOM.Text + "',NOMBRECOMERCIAL='" + TXTNCOM.Text + "', USO='" + LUSO(CBUSO.SelectedIndex) + "',REGIMENFISCAL='" + LRF(CBRF.SelectedIndex) + "' WHERE RFC='" + TXTRFC.Text + "'", CADENA)
        BDEjecutarSql("UPDATE DOMICILIOSCLIENTES SET CP='" + Trim(TXTCP.Text) + "' WHERE RFC='" + TXTRFC.Text + "' AND REGISTRO=" + LREG(CBCALLE.SelectedIndex).ToString, CADENA)

        MessageBox.Show("La informacion ha sido Guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'If RISR > 0 Then
        '    frmEsperaRespuesta.MOSTRAR(CBEMISOR.Text, LSERIE(CBNEG.SelectedIndex), ELFOLIO, 2, LTIPO(CBEMISOR.SelectedIndex))
        'Else
        '    frmEsperaRespuesta.MOSTRAR(CBEMISOR.Text, LSERIE(CBNEG.SelectedIndex), ELFOLIO, 1, LTIPO(CBEMISOR.SelectedIndex))
        'End If
        If Trim(TXTRFC.Text) = "XAXX010101000" Or Trim(TXTRFC.Text) = "XEXX010101000" Then
            If CHKCE.Checked Then
            Else
                If BDEjecutarSql("EXEC SPINFORMACIONADICIONALPG '" + CBEMISOR.Text + "','" + LASERIE + "','" + ELFOLIO.ToString + "','" + LIAPER(CBIAPER.SelectedIndex) + "','" + LIAMES(CBIAMES.SelectedIndex) + "','" + CBIAAÑO.Text + "'", CADENA) = "OK" Then
                Else
                    OPMsgError("Error al guardar la informacion adicional")
                End If
            End If
        End If

            ACTIVAR(True)
        LIMPIAR()
    End Sub
    Dim DIGITOSTC As String
    Dim MON As String
    Dim TIPOCAMBIO As Double
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        'If CBNEG.SelectedIndex = 0 Then
        '    MessageBox.Show("Debe seleccionar un negocio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If LTC(CBTC.SelectedIndex) = "P" Then
            If Not VALIDACOMPLEMENTOPAGO() Then
                Exit Sub
            End If
            MON = LMONCRP(CBCRPMON.SelectedIndex)
            TIPOCAMBIO = 1
            If MON <> "MXN" Then
                Try
                    TIPOCAMBIO = CType(TXTCRPTC.Text, Double)
                Catch ex As Exception
                    MessageBox.Show("Tipo de cambio no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
            If CBCRPFP.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar una forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CBCRPMON.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar una Moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CBCRPTCP.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar un tipo Cadena Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TIPOCAMBIO <= 0 Then
                MessageBox.Show("Tipo de cambio no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DGVCRP.Rows.Count <= 0 Then
                MessageBox.Show("Debe agregar al menos un pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show("Recuerde selecionar la serie de Pagos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If LTC(CBTC.SelectedIndex) <> "T" And CHKCP.Checked Then
                If Not ValidarConceptoCartaporte() Then
                    OPMsgError("No se encontró un concepto con clave PYSSAT correspondiente para carta porte")
                    Exit Sub
                End If
            End If
            If CBUSO.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar el uso del CFDI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CHKINE.Checked Then
                If Not VALIDAINFOINE() Then
                    Exit Sub
                End If
            End If
            If CHKCE.Checked Then
                If Not VALIDAINFOCOMERCIOEXTERIOR() Then
                    Exit Sub
                End If
            End If

            MON = LMON(CBMON.SelectedIndex)
            TIPOCAMBIO = 1
            If MON <> "MXN" Then
                Try
                    TIPOCAMBIO = CType(TXTTC.Text, Double)
                Catch ex As Exception
                    MessageBox.Show("Tipo de cambio no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
            If TIPOCAMBIO <= 0 Then
                MessageBox.Show("Tipo de cambio no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DGV.Rows.Count <= 0 Then
                MessageBox.Show("Debe agregar al menos un artículo/producto/servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DIGITOSTC = "No Identificado"
            If LMP(CBMP.SelectedIndex) <> "1" Then
                If TXTTAR.TextLength <> 4 Then
                    MessageBox.Show("Debe escribir los últimos 4 dígitos de Tarjeta / Cheque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DIGITOSTC = TXTTAR.Text
                End If
            End If
        End If

        ''validar carta porte
        If CHKCP.Checked Then
            If Not VALIDAINFOCARTAPORTE() Then
                Exit Sub
            End If
        End If
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea Guardar la Información?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        GUARDAR()

        Try
            Dim clientSocket As New System.Net.Sockets.TcpClient()
            clientSocket.Connect("bahamut.grupobajamar.com", 8888)
            'clientSocket.Connect("192.168.2.84", 8888)
            Dim serverStream As NetworkStream
            'Label1.Text = "Client Socket Program - Server Connected ..."
            serverStream = clientSocket.GetStream()

            Dim outStream As Byte() = Encoding.ASCII.GetBytes("Timbralaaaaa  ")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            clientSocket.Close()
        Catch ex As Exception
            MessageBox.Show("Avisar del Robot Timbrador a Sistemas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub
    Private Function VALIDAINFOCARTAPORTE() As Boolean
        If DGVMCP.RowCount <= 0 Then
            OPMsgError("Debe registrar mercancías")
            Return False
        End If
        If CadenaVacia(TXTNUMPER.Text) Then
            OPMsgError("Número de permiso SCT requerido")
            TXTNUMPER.Focus()
            Return False
        End If
        If CadenaVacia(TXTPLACAS.Text) Then
            OPMsgError("Número de placas requerido")
            TXTPLACAS.Focus()
            Return False
        End If
        If CadenaVacia(TXTASE.Text) Then
            OPMsgError("Aseguradora requerida")
            TXTASE.Focus()
            Return False
        End If
        If CadenaVacia(TXTPOL.Text) Then
            OPMsgError("Número de póliza requerido")
            TXTPOL.Focus()
            Return False
        End If
        If CadenaVacia(TXTRFCCHO.Text) Then
            OPMsgError("RFC del chofer requerido")
            TXTRFCCHO.Focus()
            Return False
        End If
        If CadenaVacia(TXTLIC.Text) Then
            OPMsgError("Número de licencia requerido")
            TXTLIC.Focus()
            Return False
        End If
        If CadenaVacia(TXTCPORI.Text) Then
            OPMsgError("Código postal origen requerido")
            TXTCPORI.Focus()
            Return False
        End If
        If CadenaVacia(TXTCPDES.Text) Then
            OPMsgError("Código postal destino requerido")
            TXTCPDES.Focus()
            Return False
        End If
        If CBTF.SelectedIndex = 0 Or CBPER.SelectedIndex = 0 Or CBCON.SelectedIndex = 0 Or CBEDOORI.SelectedIndex = 0 Or CBEDODES.SelectedIndex = 0 Then
            OPMsgError("Favor de seleccionar las opciones en carta porte")
            Return False
        End If
        Return True
    End Function
    Private Function ValidarConceptoCartaporte() As Boolean
        Dim x As Integer
        For x = 0 To DGV.RowCount - 1
            If BDExtraeUnDato("select CLAVE FROM CSATPYS WHERE CLAVE='" + DGV.Item(16, x).Value.ToString + "' AND CARTAPORTE=1", CADENA) = DGV.Item(16, x).Value.ToString Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub LIMPIAR()
        TXTTAR.Text = ""
        TXTCANT.Text = "1"
        TXTDES.Text = ""
        TXTUNI.Text = ""
        TXTVU.Text = "0.00"
        DGV.DataSource = Nothing
        DGV.Rows.Clear()
        CHECATABLA()

        LIDO.Clear()
        LIDC.Clear()
        LEDO.Clear()
        LEDC.Clear()
        LADC.Clear()
        RB1.Checked = True
        RB3.Checked = True
        RB5.Checked = True
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        ACTIVAR(True)
        LIMPIAR()
    End Sub
    Dim VIVA, VRETIVA, VISR As Double
    Private Sub CONFIGEMI()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT IVA,RETIVA,RETISR FROM EMISORES WHERE RFC='" + CBEMISOR.Text + "'", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            VIVA = LEC(0)
            VRETIVA = LEC(1)
            VISR = LEC(2)
        End If
        LEC.Close()
        SQL.Dispose()
    End Sub
    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        LBLDE.Text = LDE(CBEMISOR.SelectedIndex)
        LLENACOMBOBOX2LISTAS(CBNEG, LNEG, LSERIE, "SELECT CLAVE,SERIE,NOMBRE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "'", frmPrincipal.CadenaConexion)
        If CBEMISOR.Text.Length = 13 Then
            LLENACOMBOBOX2(CBUSO, LUSO, "SELECT CLAVE,NOMBRE FROM CSATUSOCOMPROBANTE WHERE ACTIVO=1 AND FISICA=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        Else
            LLENACOMBOBOX2(CBUSO, LUSO, "SELECT CLAVE,NOMBRE FROM CSATUSOCOMPROBANTE WHERE ACTIVO=1 AND MORAL=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        End If
        CONFIGEMI()
        CHECATABLA()
    End Sub



    Private Sub CBNEG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNEG.SelectedIndexChanged
        Dim LASERIE As String
        If LTC(CBTC.SelectedIndex) = "2" Then
            LASERIE = LSNC(CBEMISOR.SelectedIndex)
        Else
            LASERIE = LSERIE(CBNEG.SelectedIndex)
        End If
        If LASERIE = "N/A" Then
            MessageBox.Show("Serie de Nota de Crédito No Válida N/A", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        LBLDN.Text = LASERIE
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim VNCLIENTES As New frmClientes
        VNCLIENTES.ShowDialog()
    End Sub
    Private Sub AGREGAR(ByVal CANT As Double, ByVal DES As String, ByVal UNI As String, ByVal VU As Double, ByVal FIVA As String, ByVal TIVA As Double, ByVal FIEPS As String, ByVal TIEPS As Double, ByVal UNISAT As String, ByVal PYSSAT As String, ByVal TIVAR As Double, ByVal FIVAR As String, ByVal TISRR As Double, ByVal FISRR As String, ByVal CODINT As String, ByVal PESO As Double)
        DGV.Rows.Add(1)


        Dim TOTIEPS, TOTIVA, TOTIVAR, TOTISRR As Double
        TOTIEPS = 0
        TOTIVA = 0
        TOTIVAR = 0
        TOTISRR = 0
        Dim ITEMS As Integer
        ITEMS = DGV.Rows.Count - 1
        DGV.Item(0, ITEMS).Value = CODINT
        DGV.Item(1, ITEMS).Value = CANT
        DGV.Item(2, ITEMS).Value = DES
        DGV.Item(3, ITEMS).Value = UNI
        DGV.Item(4, ITEMS).Value = VU
        DGV.Item(5, ITEMS).Value = CANT * VU


        If FIEPS = "3" Then
            TOTIEPS = 0
        End If
        If FIEPS = "2" Then
            TOTIEPS = CANT * VU * TIEPS
        End If
        If FIEPS = "1" Then
            TOTIEPS = CANT * VU * TIEPS
        End If
        If FIVA = "3" Then
            TOTIVA = 0
        End If
        If FIVA = "1" Then
            TOTIVA = ((CANT * VU) + TOTIEPS) * TIVA
        End If

        If FISRR = "3" Then
            TOTISRR = 0
        End If
        If FISRR = "1" Then
            TOTISRR = CANT * VU * TISRR
        End If


        If FIVAR = "3" Then
            TOTIVAR = 0
        End If
        If FIVAR = "1" Then
            TOTIVAR = CANT * VU * TIVAR
        End If

        DGV.Item(6, ITEMS).Value = TOTIVA
        DGV.Item(7, ITEMS).Value = TOTIEPS

        DGV.Item(8, ITEMS).Value = TOTIVAR
        Dim TN As Double

        TOTIEPS = Math.Round(TOTIEPS, 2)
        TOTIVA = Math.Round(TOTIVA, 2)
        TOTISRR = Math.Round(TOTISRR, 2)
        TOTIVAR = Math.Round(TOTIVAR, 2)

        TN = (CANT * VU) + TOTIEPS + TOTIVA - TOTISRR - TOTIVAR
        DGV.Item(9, ITEMS).Value = TOTISRR
        DGV.Item(10, ITEMS).Value = (CANT * VU) + TOTIEPS + TOTIVA - TOTISRR - TOTIVAR
        DGV.Item(11, ITEMS).Value = FIVA
        DGV.Item(12, ITEMS).Value = TIVA
        DGV.Item(13, ITEMS).Value = FIEPS
        DGV.Item(14, ITEMS).Value = TIEPS

        DGV.Item(15, ITEMS).Value = UNISAT
        DGV.Item(16, ITEMS).Value = PYSSAT
        DGV.Item(17, ITEMS).Value = TIVAR
        DGV.Item(18, ITEMS).Value = FIVAR
        DGV.Item(19, ITEMS).Value = 0
        DGV.Item(20, ITEMS).Value = 0
        DGV.Item(21, ITEMS).Value = "3"
        DGV.Item(22, ITEMS).Value = TISRR
        DGV.Item(23, ITEMS).Value = FISRR
        DGV.Item(24, ITEMS).Value = PESO
        DGV.Item(25, ITEMS).Value = TXTCA.Text
        DGV.Item(26, ITEMS).Value = TXTFA.Text

        DGV.Refresh()
        'DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CHECATABLA()
    End Sub
    Dim C, V, TIEPS, TIVA, TIVAR, TISRR As Double
    Dim FIVA, FIEPS, FIVAR, FISRR As String
    Private Function VALIDAR() As Boolean
        If CHKIT.Checked Then
            If CBFIEPS.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar Factor Ieps Traslado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBFIEPS.Focus()
                Return False
            End If
            If CBFIVA.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar Factor Iva Traslado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBFIVA.Focus()
                Return False
            End If

            FIVA = LFIVA(CBFIVA.SelectedIndex)
            FIEPS = LFIEPS(CBFIEPS.SelectedIndex)

            Try
                TIVA = CType(TXTTIVA.Text, Double)
            Catch ex As Exception
                MessageBox.Show("Valor Tasa Iva No Válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTTCIEPS.Focus()
                TXTTCIEPS.SelectAll()
                Return False
            End Try
            Try
                TIEPS = CType(TXTTCIEPS.Text, Double)
            Catch ex As Exception
                MessageBox.Show("Valor Tasa Ieps No Válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTTCIEPS.Focus()
                TXTTCIEPS.SelectAll()
                Return False
            End Try

            If LFIEPS(CBFIEPS.SelectedIndex) = "1" Then
                If TIEPS < 0 Then
                    MessageBox.Show("Los valores Tasa Ieps deben ser mayores o igual a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If TIEPS > 0.16 Then
                    MessageBox.Show("El rango máximo de tasa Ieps es de 0.16", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
            If LFIEPS(CBFIEPS.SelectedIndex) = "2" Then
                If TIEPS < 0 Then
                    MessageBox.Show("Los valores Tasa Ieps deben ser mayores o igual a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If TIEPS > 43.77 Then
                    MessageBox.Show("La cuota máxima de Ieps es de 43.77", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
            If LFIVA(CBFIVA.SelectedIndex) = "1" Then
                If TIEPS < 0 Or TIVA < 0 Then
                    MessageBox.Show("Los valores Tasa Iva deben ser mayor o igual a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If TIVA > 0.16 Then
                    MessageBox.Show("El rango máximo de tasa Iva es de 0.16", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        Else
            TIEPS = 0
            TIVA = 0
            FIVA = "3"
            FIEPS = "3"

        End If
        If String.IsNullOrEmpty(TXTCODINT.Text) Then
            MessageBox.Show("Debe especificar un código interno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If CHKIR.Checked Then
            If CBFISRR.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar Factor Isr Retención", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBFIEPS.Focus()
                Return False
            End If
            If CBFIVAR.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar Factor Iva Retención", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBFIVA.Focus()
                Return False
            End If
            FIVAR = LFIVAR(CBFIVAR.SelectedIndex)
            FISRR = LFISRR(CBFISRR.SelectedIndex)

            Try
                TIVAR = CType(TXTIVAR.Text, Double)
            Catch ex As Exception
                MessageBox.Show("Valor Tasa Iva Retención No Válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTIVAR.Focus()
                TXTIVAR.SelectAll()
                Return False
            End Try
            Try
                TISRR = CType(TXTISRR.Text, Double)
            Catch ex As Exception
                MessageBox.Show("Valor Tasa Isr Retención No Válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTISRR.Focus()
                TXTISRR.SelectAll()
                Return False
            End Try

            If LFIVAR(CBFIVAR.SelectedIndex) = "1" Then
                If TIVAR < 0 Then
                    MessageBox.Show("Los valores Tasa Iva Retención deben ser mayores o igual a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If TIVAR > 0.16 Then
                    MessageBox.Show("El rango máximo de Tasa Iva Retención  es de 0.16", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If

            If LFISRR(CBFISRR.SelectedIndex) = "1" Then
                If TISRR < 0 Then
                    MessageBox.Show("Los valores Tasa Isr Retención deben ser mayores o igual a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If TISRR > 0.35 Then
                    MessageBox.Show("El rango máximo de Tasa Isr Retención  es de 0.16", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If


        Else
            TISRR = 0
            TIVAR = 0
            FIVAR = "3"
            FISRR = "3"
        End If
       
        If CBPYS.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar Clave de Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CBPYS.Focus()
            Return False
        End If
        If CBUNI.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar Unidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CBUNI.Focus()
            Return False
        End If
        Try
            C = CType(TXTCANT.Text, Double)
        Catch ex As Exception
            MessageBox.Show("Cantidad No Válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTCANT.Focus()
            TXTCANT.SelectAll()
            Return False
        End Try
        Try
            V = CType(TXTVU.Text, Double)
        Catch ex As Exception
            MessageBox.Show("Valor Unitario No Válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTVU.Focus()
            TXTVU.SelectAll()
            Return False
        End Try

        If C <= 0 Or V <= 0 Then
            MessageBox.Show("Los valores deben ser mayores a Cero (0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(TXTDES.Text) Or String.IsNullOrEmpty(TXTUNI.Text) Then
            MessageBox.Show("Se debe especificar la Descripción y la Unidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

       
        Return True
    End Function

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Not VALIDAR() Then
            Exit Sub
        End If
        Dim VPESO As Double
        Try
            VPESO = CType(TXTPESO.Text, Double)
        Catch ex As Exception
            TXTPESO.Text = "0.01"
            VPESO = 0.01
        End Try
        AGREGAR(C, TXTDES.Text, TXTUNI.Text, V, LFIVA(CBFIVA.SelectedIndex), TIVA, LFIEPS(CBFIEPS.SelectedIndex), TIEPS, LUSAT(CBUNI.SelectedIndex), LPYSSAT(CBPYS.SelectedIndex), TIVAR, FIVAR, TISRR, FISRR, TXTCODINT.Text, VPESO)
        TXTCANT.Text = "1"
        TXTDES.Text = ""
        TXTUNI.Text = ""
        TXTVU.Text = "0.00"
    End Sub

    Private Sub TXTCANT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TXTCANT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BTNQUITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQUITAR.Click
        DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
        CHECATABLA()
    End Sub

    Private Sub CBCR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CHECATABLA()
    End Sub

    Private Sub CBMP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LMP(CBMP.SelectedIndex) <> "1" Then
            TXTTAR.Enabled = True
        Else
            TXTTAR.Text = ""
            TXTTAR.Enabled = False
        End If
    End Sub

    Private Sub TXTRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRFC.KeyPress
        If e.KeyChar = Chr(13) Then
            If String.IsNullOrEmpty(TXTRFC.Text) Then
            Else
                If TXTRFC.Text.Length = 13 Then
                    If RegularExpressions.Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z,&,ñ,Ñ\s]{4})\d{6}([A-Z\w]{3})$") Then
                        CARGADATOS()
                    Else
                        MessageBox.Show("Teclee un RFC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If TXTRFC.Text.Length = 12 Then
                    If RegularExpressions.Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z,&,ñ,Ñ\s]{3})\d{6}([A-Z\w]{3})$") Then
                        CARGADATOS()
                    Else
                        MessageBox.Show("Teclee un RFC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CBTC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTC.SelectedIndexChanged
        Dim LASERIE As String
        LASERIE = "N/A"
        Try
            If LTC(CBTC.SelectedIndex) = "2" Then
                LASERIE = LSNC(CBEMISOR.SelectedIndex)
            Else
                LASERIE = LSERIE(CBNEG.SelectedIndex)
            End If
            If LASERIE = "N/A" Then
                MessageBox.Show("Serie de Nota de Crédito No Válida N/A", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        Try
            If LTC(CBTC.SelectedIndex) = "P" Then
                TabPage6.Parent = TABC
            Else
                TabPage6.Parent = Nothing
            End If

        Catch ex As Exception

        End Try
        LBLDN.Text = LASERIE
        CHECATABLA()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(sender.text)
    End Sub

    Private Sub CHKINE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKINE.CheckedChanged
        If CHKINE.Checked Then
            TabPage2.Parent = TABC
        Else
            TabPage2.Parent = Nothing
        End If
    End Sub

    Private Sub RB7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB7.CheckedChanged, RB2.CheckedChanged, RB1.CheckedChanged
        GB2.Enabled = False
        GB1.Enabled = RB1.Checked
        If RB2.Checked Or RB7.Checked Then
            GB2.Enabled = True
        End If
    End Sub

    Private Sub RB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB3.CheckedChanged, RB4.CheckedChanged
        BTNAO.Enabled = RB3.Checked
        BTNQO.Enabled = RB3.Checked
        CBEO.Enabled = RB3.Checked
        LBO.Enabled = RB3.Checked
    End Sub
    Private Sub BTNAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAO.Click
        If String.IsNullOrEmpty(TXTCO.Text) Then
            MessageBox.Show("Se debe especificar el Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim TXT As String
        TXT = TXTCO.Text
        TXT = Trim(TXT)
        If TXT.Length <= 0 Then
            MessageBox.Show("Se debe especificar el Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CBEO.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar una entidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        AgregarOrdinario(TXTCO.Text, LENTO(CBEO.SelectedIndex))
        TXTCO.Text = ""
        CBEO.SelectedIndex = 0
    End Sub
    Private Sub AgregarOrdinario(ByVal IdContabilidad As String, ByVal Entidad As String)
        LIDO.Add(IdContabilidad)
        LEDO.Add(Entidad)
        LBO.Items.Add(Entidad + " - " + IdContabilidad)
    End Sub

    Private Sub BTNQO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQO.Click
        If LBO.Items.Count <= 0 Then
            Exit Sub
        End If
        LIDO.RemoveAt(LBO.SelectedIndex)
        LEDO.RemoveAt(LBO.SelectedIndex)
        LBO.Items.RemoveAt(LBO.SelectedIndex)
    End Sub

    Private Sub BTNAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAC.Click
        If String.IsNullOrEmpty(TXTCC.Text) Then
            MessageBox.Show("Se debe especificar el Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim TXT As String
        TXT = TXTCC.Text
        TXT = Trim(TXT)
        If TXT.Length <= 0 Then
            MessageBox.Show("Se debe especificar el Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CBEC.SelectedIndex = 0 Then
            MessageBox.Show("Debe seleccionar una entidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim AMB, CON As String
        If RB5.Checked Then
            AMB = "Local"
            CON = "Federal"
        Else
            AMB = "Federal"
            CON = "Local"
        End If
        Dim X As Integer
        For X = 0 To LBC.Items.Count - 1
            If LEDC(X) = LENTC(CBEC.SelectedIndex) And LADC(X) = AMB Then
                MessageBox.Show("No se puede agregar esta entidad con el mismo ámbito (" + AMB + "), deben ser diferente ámbito en la entidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        AgregarCampañaPre(TXTCC.Text, LENTC(CBEC.SelectedIndex), AMB)
        TXTCC.Text = ""
        CBEC.SelectedIndex = 0
    End Sub

    Private Sub AgregarCampañaPre(ByVal IdContabilidad As String, ByVal Entidad As String, ByVal Ambito As String)
        LIDC.Add(IdContabilidad)
        LEDC.Add(Entidad)
        LADC.Add(Ambito)
        LBC.Items.Add(Entidad + " - " + Ambito + " - " + IdContabilidad)
    End Sub
    Private Sub BTNQC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQC.Click
        If LBC.Items.Count <= 0 Then
            Exit Sub
        End If
        LIDC.RemoveAt(LBC.SelectedIndex)
        LEDC.RemoveAt(LBC.SelectedIndex)
        LADC.RemoveAt(LBC.SelectedIndex)
        LBC.Items.RemoveAt(LBC.SelectedIndex)
    End Sub
    Private Function VALIDAINFOCOMERCIOEXTERIOR() As Boolean
        Dim num As Integer
        If (Strings.Trim(Me.TXTCECPED.Text).Length <= 0) Then
            MessageBox.Show("Se debe especificar el la clave de pedimento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        If (Me.CBNEG.SelectedIndex = 0) Then
            MessageBox.Show("Debe seleccionar un incoterm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        Try
            num = CType(Me.TXTCECO.Text, Integer)
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            MessageBox.Show("Certificado origen no válido (0,1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End Try
        If ((num <> 0) And (num <> 1)) Then
            MessageBox.Show("Certificado origen no válido (0,1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        If (Me.CBCESUB.SelectedIndex <= -1) Then
            MessageBox.Show("Se debe especificar la subdivisión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        If (Strings.Trim(Me.TXTCERFP.Text).Length <= 0) Then
            MessageBox.Show("Se debe especificar el registro fiscal del país.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        If Me.CHKCEDD.Checked Then
            If (Strings.Trim(Me.TXTCECP.Text).Length <= 0) Then
                MessageBox.Show("Se debe especificar el código postal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            End If
            If (Strings.Trim(Me.TXTCECALLE.Text).Length <= 0) Then
                MessageBox.Show("Se debe especificar la calle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            End If
        End If
        Dim num4 As Integer = (Me.DGV.Rows.Count - 2)
        Dim i As Integer = 0
        Do While (i <= num4)
            Dim num5 As Integer = (Me.DGV.Rows.Count - 1)
            Dim j As Integer = (i + 1)
            Do While (j <= num5)
                If (Me.DGV.Item(0, i).Value.ToString = Me.DGV.Item(0, j).Value.ToString) Then
                    MessageBox.Show("Se debe especificar No de Identificación/Código diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return False
                End If
                j += 1
            Loop
            i += 1
        Loop
        Return True
    End Function
    Private Function VALIDAINFOINE() As Boolean
        If RB1.Checked Then
            If RB4.Checked Then
                Dim TXT As String
                TXT = TXTCO.Text
                TXT = Trim(TXT)
                If TXT.Length <= 0 Then
                    MessageBox.Show("Se debe especificar el Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                If LBO.Items.Count <= 0 Then
                    MessageBox.Show("Se debe agregar entidades con su Id Contabilidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        If RB2.Checked Or RB7.Checked Then
            If LBC.Items.Count <= 0 Then
                MessageBox.Show("Se debe agregar entidades con su Id Contabilidad y su ámbito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return True
    End Function
    Private Function VALIDACOMPLEMENTOPAGO() As Boolean
        If DGVCRP.Rows.Count <= 0 Then
            MessageBox.Show("Se debe agregar los documentos relacionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim X As Integer
        Dim A, B As Double
        For X = 0 To DGVCRP.Rows.Count - 1
            A = DGVCRP.Item(4, X).Value
            B = DGVCRP.Item(3, X).Value
            If A > B Then

                MessageBox.Show("Saldo Anterior no debe ser mayor al Total del Comprobante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            A = DGVCRP.Item(6, X).Value
            B = DGVCRP.Item(4, X).Value
            If A > B Then
                MessageBox.Show("Abono/pago no debe ser mayor al Saldo anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            A = DGVCRP.Item(5, X).Value
            If A <= 0 Then
                MessageBox.Show("Numero de parcialidad incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            A = DGVCRP.Item(5, X).Value
            If A Mod 1 > 0 Then
                MessageBox.Show("Numero de parcialidad incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            A = DGVCRP.Item(6, X).Value
            If A <= 0 Then
                MessageBox.Show("Importe incorrecto, debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub GUARDACOMERCIOEXTERIOR(ByVal VSERIE As String, ByVal ELFOLIO As Integer)
        Dim SQL As New SqlClient.SqlCommand("SPCOMPLEMENTOCOMERCIOEXTERIOR", CONZ)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@SERIE", SqlDbType.VarChar).Value = VSERIE
        SQL.Parameters.Add("@FOLIO", SqlDbType.Int).Value = ELFOLIO
        SQL.Parameters.Add("@P1", SqlDbType.VarChar).Value = "1.0"

        If (Me.CBCETO.SelectedIndex = 0) Then
            SQL.Parameters.Add("@P2", SqlDbType.VarChar).Value = "2"
        Else
            SQL.Parameters.Add("@P2", SqlDbType.VarChar).Value = "A"
        End If
        SQL.Parameters.Add("@P3", SqlDbType.VarChar).Value = Me.TXTCECPED.Text
        SQL.Parameters.Add("@P4", SqlDbType.VarChar).Value = Me.TXTCECO.Text
        SQL.Parameters.Add("@P5", SqlDbType.VarChar).Value = Me.TXTCENCO.Text
        SQL.Parameters.Add("@P6", SqlDbType.VarChar).Value = Me.LINCO.Item(Me.CBCEINCO.SelectedIndex)
        SQL.Parameters.Add("@P7", SqlDbType.VarChar).Value = Me.CBCESUB.SelectedIndex
        SQL.Parameters.Add("@P8", SqlDbType.VarChar).Value = Me.TXTCEOBS.Text
        SQL.Parameters.Add("@P9", SqlDbType.VarChar).Value = Me.TXTCETC.Text
        SQL.Parameters.Add("@P10", SqlDbType.VarChar).Value = Me.T.ToString
        SQL.Parameters.Add("@P11", SqlDbType.VarChar).Value = ""
        SQL.Parameters.Add("@P12", SqlDbType.VarChar).Value = Me.TXTCECURP.Text
        SQL.Parameters.Add("@P13", SqlDbType.VarChar).Value = Me.TXTCERFP.Text
        If Me.CHKCEDD.Checked Then
            SQL.Parameters.Add("@P14", SqlDbType.VarChar).Value = Me.TXTCERFP.Text
            SQL.Parameters.Add("@P15", SqlDbType.VarChar).Value = Me.TXTCERFC.Text
            SQL.Parameters.Add("@P16", SqlDbType.VarChar).Value = Me.TXTCEDDCURP.Text
            SQL.Parameters.Add("@P17", SqlDbType.VarChar).Value = Me.TXTCEDDNOM
            SQL.Parameters.Add("@P18", SqlDbType.VarChar).Value = Me.TXTCECALLE.Text
            SQL.Parameters.Add("@P19", SqlDbType.VarChar).Value = Me.TXTCENOEXT.Text
            SQL.Parameters.Add("@P20", SqlDbType.VarChar).Value = Me.TXTCENOINT.Text
            SQL.Parameters.Add("@P21", SqlDbType.VarChar).Value = Me.TXTCELOC.Text
            SQL.Parameters.Add("@P22", SqlDbType.VarChar).Value = Me.TXTCEREF.Text
            SQL.Parameters.Add("@P23", SqlDbType.VarChar).Value = Me.TXTCELOC.Text
            SQL.Parameters.Add("@P24", SqlDbType.VarChar).Value = Me.TXTCEMUN.Text
            SQL.Parameters.Add("@P25", SqlDbType.VarChar).Value = Me.LEDO.Item(Me.CBCEEDO.SelectedIndex)
            SQL.Parameters.Add("@P26", SqlDbType.VarChar).Value = Me.LPAIS.Item(Me.CBCEPAIS.SelectedIndex)
            SQL.Parameters.Add("@P27", SqlDbType.VarChar).Value = Me.TXTCECP.Text
        End If
        SQL.ExecuteNonQuery()
    End Sub
    Private Sub GUARDACARTAPORTE(ByVal VSERIE As String, ByVal ELFOLIO As Integer)
        'If LTC(CBTC.SelectedIndex) = "T" Or LTC(CBTC.SelectedIndex) = "I" Then
        ''TRASLADO
        '@RFC,@SER,@FOLIO,@RFCR,@SERR,@FOLIOR,@DIS,@ORIFECHA,@DESFECHA,@ORICP,@ORIEDO,@DESCP,@DESEDO,@PERMSCT,@NUMPERMISOSCT,@CONFIGVEHICULAR,@PLACAVM,@ANIOMODELOVM,@ASEGURARESPCIVIL,@POLIZARESPCIVIL,@ASEGURAMEDAMBIENTE,@POLIZAMEDAMBIENTE,@ASEGURACARGA,@POLIZACARGA,@PRIMASEGURO,@FIGTIPOFIGURA,@FIGRFC,@FIGNUMLICENCIA,@FIGNOMBRE,@FIGREGIDTRIB,@FIGRESF,
        Dim SQL As New SqlClient.SqlCommand("SPCOMPLEMENTOCARTAPORTE", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@SER", SqlDbType.VarChar).Value = VSERIE
        SQL.Parameters.Add("@FOLIO", SqlDbType.VarChar).Value = ELFOLIO.ToString

        SQL.Parameters.Add("@RFCR", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@SERR", SqlDbType.VarChar).Value = LBLSERIER.Text
        SQL.Parameters.Add("@FOLIOR", SqlDbType.VarChar).Value = LBLFOLIOR.Text

        SQL.Parameters.Add("@DIS", SqlDbType.Float).Value = CType(TXTDIS.Text, Double) 'VALIDAR 
        SQL.Parameters.Add("@ORIFECHA", SqlDbType.DateTime).Value = SUMARTIEMPOAFECHA(DTFSAL.Value, DTHORASAL.Value)
        SQL.Parameters.Add("@DESFECHA", SqlDbType.DateTime).Value = SUMARTIEMPOAFECHA(DTFLLEG.Value, DTHORALLEG.Value)
        SQL.Parameters.Add("@ORICP", SqlDbType.VarChar).Value = TXTCPORI.Text
        SQL.Parameters.Add("@ORIEDO", SqlDbType.VarChar).Value = LEDOO(CBEDOORI.SelectedIndex)
        SQL.Parameters.Add("@DESCP", SqlDbType.VarChar).Value = TXTCPDES.Text
        SQL.Parameters.Add("@DESEDO", SqlDbType.VarChar).Value = LEDOD(CBEDODES.SelectedIndex)
        SQL.Parameters.Add("@PERMSCT", SqlDbType.VarChar).Value = LPER(CBPER.SelectedIndex)
        SQL.Parameters.Add("@NUMPERMISOSCT", SqlDbType.VarChar).Value = TXTNUMPER.Text
        SQL.Parameters.Add("@CONFIGVEHICULAR", SqlDbType.VarChar).Value = LCON(CBCON.SelectedIndex)
        SQL.Parameters.Add("@PLACAVM", SqlDbType.VarChar).Value = TXTPLACAS.Text
        SQL.Parameters.Add("@ANIOMODELOVM", SqlDbType.VarChar).Value = NUDMOD.Value.ToString
        SQL.Parameters.Add("@ASEGURARESPCIVIL", SqlDbType.VarChar).Value = TXTASE.Text
        SQL.Parameters.Add("@POLIZARESPCIVIL", SqlDbType.VarChar).Value = TXTPOL.Text
        SQL.Parameters.Add("@ASEGURAMEDAMBIENTE", SqlDbType.VarChar).Value = TXTASEMA.Text
        SQL.Parameters.Add("@POLIZAMEDAMBIENTE", SqlDbType.VarChar).Value = TXTPOLMA.Text
        SQL.Parameters.Add("@ASEGURACARGA", SqlDbType.VarChar).Value = TXTASECAR.Text
        SQL.Parameters.Add("@POLIZACARGA", SqlDbType.VarChar).Value = TXTPOLCAR.Text
        SQL.Parameters.Add("@PRIMASEGURO", SqlDbType.VarChar).Value = TXTMONTO.Text
        SQL.Parameters.Add("@FIGTIPOFIGURA", SqlDbType.VarChar).Value = LTF(CBTF.SelectedIndex)
        SQL.Parameters.Add("@FIGRFC", SqlDbType.VarChar).Value = TXTRFCCHO.Text
        SQL.Parameters.Add("@FIGNUMLICENCIA", SqlDbType.VarChar).Value = TXTLIC.Text
        SQL.Parameters.Add("@FIGNOMBRE", SqlDbType.VarChar).Value = TXTNOMCHO.Text
        SQL.Parameters.Add("@FIGREGIDTRIB", SqlDbType.VarChar).Value = TXTNRI.Text
        SQL.Parameters.Add("@FIGRESF", SqlDbType.VarChar).Value = "MEX"
        SQL.ExecuteNonQuery()

        Dim SQLMCP As New SqlClient.SqlCommand("SPCOMPLEMENTOCARTAPORTEMERCANCIAS", CONZ)
        SQLMCP.CommandType = CommandType.StoredProcedure
        SQLMCP.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQLMCP.Parameters.Add("@SERIE", SqlDbType.VarChar).Value = VSERIE
        SQLMCP.Parameters.Add("@FOLIO", SqlDbType.Int).Value = ELFOLIO
        SQLMCP.Parameters.Add("@PYSSAT", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@COD", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@CANT", SqlDbType.Float)
        SQLMCP.Parameters.Add("@DES", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@UNI", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@IMP", SqlDbType.Float)
        SQLMCP.Parameters.Add("@PESO", SqlDbType.Float)
        SQLMCP.Parameters.Add("@UNISAT", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@FA", SqlDbType.VarChar)
        SQLMCP.Parameters.Add("@REG", SqlDbType.Int)
        Dim X As Integer
        For X = 0 To DGV.RowCount - 1
            SQLMCP.Parameters("@PYSSAT").Value = DGVMCP.Item(0, X).Value
            SQLMCP.Parameters("@COD").Value = DGVMCP.Item(1, X).Value
            SQLMCP.Parameters("@CANT").Value = DGVMCP.Item(2, X).Value
            SQLMCP.Parameters("@DES").Value = DGVMCP.Item(3, X).Value
            SQLMCP.Parameters("@UNI").Value = DGVMCP.Item(4, X).Value
            SQLMCP.Parameters("@IMP").Value = DGVMCP.Item(5, X).Value
            SQLMCP.Parameters("@PESO").Value = DGVMCP.Item(6, X).Value
            SQLMCP.Parameters("@UNISAT").Value = DGVMCP.Item(7, X).Value
            SQLMCP.Parameters("@FA").Value = DGVMCP.Item(8, X).Value
            SQLMCP.Parameters("@REG").Value = X

            SQLMCP.ExecuteNonQuery()
        Next
    End Sub
    Private Sub GUARDAINE(ByVal VSERIE As String, ByVal ELFOLIO As Integer)
        Dim SQL As New SqlClient.SqlCommand("SPCOMPLEMENTOINE", CONZ)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@SERIE", SqlDbType.VarChar).Value = VSERIE
        SQL.Parameters.Add("@FOLIO", SqlDbType.Int).Value = ELFOLIO
        SQL.Parameters.Add("@TP", SqlDbType.VarChar)

        Dim X As Integer

        If RB1.Checked Then
            SQL.Parameters("@TP").Value = "Ordinario"
            If RB4.Checked Then
                SQL.Parameters.Add("@TC", SqlDbType.VarChar).Value = "Ejecutivo Nacional"
                SQL.Parameters.Add("@IDC", SqlDbType.VarChar).Value = TXTCO.Text
                SQL.Parameters.Add("@REG", SqlDbType.Int).Value = 0
                SQL.ExecuteNonQuery()
            Else
                SQL.Parameters.Add("@TC", SqlDbType.VarChar).Value = "Ejecutivo Estatal"
                SQL.Parameters.Add("@ENT", SqlDbType.VarChar)
                SQL.Parameters.Add("@IDC", SqlDbType.VarChar)
                SQL.Parameters.Add("@REG", SqlDbType.Int)
                For X = 0 To LBO.Items.Count - 1
                    SQL.Parameters("@ENT").Value = LEDO(X)
                    SQL.Parameters("@IDC").Value = LIDO(X)
                    SQL.Parameters("@REG").Value = X
                    SQL.ExecuteNonQuery()
                Next

            End If
        End If

        If RB2.Checked Or RB7.Checked Then
            If RB2.Checked Then
                SQL.Parameters("@TP").Value = "Campaña"
            Else
                SQL.Parameters("@TP").Value = "Precampaña"
            End If
            SQL.Parameters.Add("@ENT", SqlDbType.VarChar)
            SQL.Parameters.Add("@IDC", SqlDbType.VarChar)
            SQL.Parameters.Add("@AMB", SqlDbType.VarChar)
            SQL.Parameters.Add("@REG", SqlDbType.Int)
            For X = 0 To LBC.Items.Count - 1
                SQL.Parameters("@ENT").Value = LEDC(X)
                SQL.Parameters("@IDC").Value = LIDC(X)
                SQL.Parameters("@AMB").Value = LADC(X)
                SQL.Parameters("@REG").Value = X
                SQL.ExecuteNonQuery()
            Next
        End If
    End Sub
    Dim FIX, DOF, PAGOS As Double
    Private Sub BGW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork
        CARGARTASACAMBIO()
    End Sub
    Private Sub CARGARTASACAMBIO()
        Dim TC As Double
        Dim FTC As DateTime
        FTC = My.Settings.FechaTC
        'If FTC.Date < Now.Date Then
        TC = TasaCambio()
        TC = TipoCambioV2(2)
        If TC <= 0 Then
            ' MessageBox.Show("Tasa de cambio del dólar no se ha actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.TasaCambio = TC
            My.Settings.FechaTC = Now.Date
            My.Settings.Save()
            My.Settings.Reload()
        End If
        FIX = TipoCambioV2(1)
        DOF = TipoCambioV2(2)
        PAGOS = TipoCambioV2(3)
        'End If
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW.RunWorkerCompleted
        'TXTTC.Text = My.Settings.TasaCambio.ToString
        LBLTC.Text = "Dólar Hoy: " + My.Settings.TasaCambio.ToString
        LLBLF.Text = "FIX: " + FIX.ToString
        LLBLD.Text = "DOF: " + DOF.ToString
        LLBLP.Text = "PAGOS: " + PAGOS.ToString
    End Sub

    Private Sub CBMON_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LMON(CBMON.SelectedIndex) = "1" Then
            TXTTC.Enabled = False
        Else
            TXTTC.Enabled = True
        End If
    End Sub

    Private Sub LBLTC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.banxico.org.mx/portal-mercado-cambiario/index.html")
    End Sub

    Private Sub CHKCEDD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCEDD.CheckedChanged
        GBCEDES.Enabled = CHKCEDD.Checked
    End Sub

    Private Sub CHKCE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCE.CheckedChanged
        If Me.CHKCE.Checked Then
            TabPage4.Parent = Me.TABC


        Else
            TabPage4.Parent = Nothing
            CHKCEDD.Checked = False
        End If

        LBLCA.Visible = CHKCE.Checked
        LBLFA.Visible = CHKCE.Checked
        TXTCA.Visible = CHKCE.Checked
        TXTFA.Visible = CHKCE.Checked
    End Sub

    Private Sub CBCEPAIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCEPAIS.SelectedIndexChanged
        Try
            MODULOGENERAL.LLENACOMBOBOX2(CBCEEDO, LESTADO, ("SELECT CLAVE,NOMBRE FROM ESTADOS WHERE PAIS='" & LPAIS(CBCEPAIS.SelectedIndex) & "'"), frmPrincipal.CadenaConexion, "No Aplica", "")
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmClsBusqueda.BUSCAR("SELECT CLAVE,CLAVE+'-'+NOMBRE PRODUCTO FROM CSATPYS ", " WHERE CLAVE+'-'+NOMBRE", " ORDER BY NOMBRE", "Búsqueda de Productos Sat", "Nombre del Producto", "Producto(s)", 1, frmPrincipal.CadenaConexion, False)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CARGAX(LPYSSAT, CBPYS, frmClsBusqueda.TREG.Rows(0).Item(0).ToString)
            'CARGADATOS()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmClsBusqueda.BUSCAR("SELECT CLAVE,NOMBRE FROM CSATUNIDADES ", " WHERE CLAVE+'-'+NOMBRE", " ORDER BY NOMBRE", "Búsqueda de Unidades Sat", "Nombre de la unidad", "Unidad(es)", 1, frmPrincipal.CadenaConexion, False)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CARGAX(LUSAT, CBUNI, frmClsBusqueda.TREG.Rows(0).Item(0).ToString)
            'CARGADATOS()
        End If
    End Sub

    Private Sub CBPYS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPYS.SelectedIndexChanged
        Label31.Text = CBPYS.Text
    End Sub

    Private Sub CBUNI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUNI.SelectedIndexChanged
        Label32.Text = CBUNI.Text
    End Sub

    Private Sub CHKCP_CheckedChanged(sender As Object, e As EventArgs) Handles CHKCP.CheckedChanged
        If CHKCP.Checked Then
            If LTC(CBTC.SelectedIndex) = "T" Or LTC(CBTC.SelectedIndex) = "I" Then
                TabPage7.Parent = TABC
            Else
                MessageBox.Show("Carta porte solo aplica para Traslado e Ingreso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CHKCP.Checked = False
            End If
        Else
            TabPage7.Parent = Nothing
        End If

    End Sub

    Private Sub BTNBUSPER_Click(sender As Object, e As EventArgs) Handles BTNBUSPER.Click
        frmClsBusqueda.BUSCAR("SELECT * FROM CSATPERMISOSSCT ", " WHERE NOMBRE", " ORDER BY NOMBRE", "Búsqueda de Permisos SCT", "Nombre del Permiso", "Registro(s)", 1, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CARGAX(LPER, CBPER, frmClsBusqueda.TREG.Rows(0).Item(0).ToString)
        End If
    End Sub

    Private Sub BTNBUSCON_Click(sender As Object, e As EventArgs) Handles BTNBUSCON.Click
        frmClsBusqueda.BUSCAR("SELECT * FROM CSATAUTOTRANSPORTES ", " WHERE DESCRIPCION", " ORDER BY DESCRIPCION", "Búsqueda de AutoTransportes", "Nombre del AutoTransporte", "Registro(s)", 1, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CARGAX(LCON, CBCON, frmClsBusqueda.TREG.Rows(0).Item(0).ToString)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmClsBusqueda.BUSCAR("SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,F.FECHA,F.TOTAL,F.UUID,F.Nombre FROM FACTURAS F WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=DATEADD(YY,-10,GETDATE()) AND UUID<>'' ", " and nombre", " ORDER BY F.FECHA", "Búsqueda de facturas a relacionar", "Nombre del Cliente", "Registro(s)", 1, frmPrincipal.CadenaConexion, False)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTFREL.Text = frmClsBusqueda.TREG.Rows(0).Item(5).ToString

        End If
    End Sub
    Dim DTMCP As New DataTable
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmClsBusqueda.BUSCAR("SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,F.FECHA,F.TOTAL,F.UUID,F.Nombre FROM FACTURAS F WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=DATEADD(YY,-10,GETDATE()) AND UUID<>'' ", " and nombre", " ORDER BY F.FECHA", "Búsqueda de facturas a relacionar", "Nombre del Cliente", "Registro(s)", 1, frmPrincipal.CadenaConexion, False)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            LBLSERIER.Text = frmClsBusqueda.TREG.Rows(0).Item(1).ToString
            LBLFOLIOR.Text = frmClsBusqueda.TREG.Rows(0).Item(2).ToString
            LBLUUIDR.Text = frmClsBusqueda.TREG.Rows(0).Item(5).ToString
            DTMCP = BDLlenatabla("SELECT PYSSAT,CODIGO,CANTIDAD,DESCRIPCION,UNIDAD,IMPORTE,PESO,UNISAT,FRACCIONARANCELARIA FROM DETALLEFACTURAS WHERE RFCEMISOR='" + CBEMISOR.Text + "' AND SERIE='" + LBLSERIER.Text + "' AND FOLIO='" + LBLFOLIOR.Text + "'", frmPrincipal.CadenaConexion)
            LlenarMercanciasCartaPorte(DTMCP)
        End If
    End Sub
    Private Sub INICIALIZARNUD()
        Dim ANIO As Integer
        ANIO = Now.Year
        NUDMOD.Minimum = ANIO - 100
        NUDMOD.Maximum = ANIO + 1
        NUDMOD.Value = ANIO
    End Sub

    Private Sub CBPER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPER.SelectedIndexChanged
        TXTNUMPER.Enabled = True
        If LPER(CBPER.SelectedIndex) = "TPXX00" Then
            TXTNUMPER.Text = "Permiso no contemplado en el catálogo”
            TXTNUMPER.Enabled = False
        End If
    End Sub

    Private Sub CBRF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRF.SelectedIndexChanged
        CARGAUSOCOMPROBANTE(LRF(CBRF.SelectedIndex))
    End Sub
    Private Sub CARGAUSOCOMPROBANTE(ByVal REGIMEN As String)
        Try
            OPLlenaComboBox(CBUSO, LUSO, "SELECT D.CLAVE,D.NOMBRE FROM CSATREGIMENUSO N INNER JOIN CSATUSOCOMPROBANTE D ON N.USO=D.CLAVE WHERE D.ACTIVO=1 AND N.REGIMEN='" + REGIMEN + "' ORDER BY NOMBRE", CADENA, "Favor de Seleccionar", "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CBIAPER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBIAPER.SelectedIndexChanged
        Try
            If LIAPER(CBIAPER.SelectedIndex) = "05" Then
                OPLlenaComboBox(CBIAMES, LIAMES, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATMESES WHERE ACTIVO=1 AND CLAVE IN ('13','14','15','16','17','18')", CADENA)
            Else
                OPLlenaComboBox(CBIAMES, LIAMES, "SELECT CLAVE,CLAVE +' - '+NOMBRE FROM CSATMESES WHERE ACTIVO=1 AND CLAVE IN ('01','02','03','04','05','06','07','08','09','10','11','12')", CADENA)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LlenarMercanciasCartaPorte(ByVal DT As DataTable)
        Dim ITEMS As Integer
        Dim X As Integer
        DGVMCP.Rows.Clear()
        For X = 0 To DT.Rows.Count - 1
            DGVMCP.Rows.Add(1)
            ITEMS = DGVMCP.Rows.Count - 1
            DGVMCP.Item(0, ITEMS).Value = DT.Rows(X).Item(0)
            DGVMCP.Item(1, ITEMS).Value = DT.Rows(X).Item(1)
            DGVMCP.Item(2, ITEMS).Value = DT.Rows(X).Item(2)
            DGVMCP.Item(3, ITEMS).Value = DT.Rows(X).Item(3)
            DGVMCP.Item(4, ITEMS).Value = DT.Rows(X).Item(4)
            DGVMCP.Item(5, ITEMS).Value = DT.Rows(X).Item(5)
            DGVMCP.Item(6, ITEMS).Value = DT.Rows(X).Item(6)
            DGVMCP.Item(7, ITEMS).Value = DT.Rows(X).Item(7)
            DGVMCP.Item(8, ITEMS).Value = DT.Rows(X).Item(8)
        Next
        DgvAjusteEncabezado(DGVMCP, "")
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ITEMS As Integer
        Dim X As Integer
        DGVMCP.Rows.Clear()
        For X = 0 To DGV.Rows.Count - 1
            DGVMCP.Rows.Add(1)
            ITEMS = DGVMCP.Rows.Count - 1
            DGVMCP.Item(0, ITEMS).Value = DGV.Item(16, X).Value
            DGVMCP.Item(1, ITEMS).Value = DGV.Item(0, X).Value
            DGVMCP.Item(2, ITEMS).Value = DGV.Item(1, X).Value
            DGVMCP.Item(3, ITEMS).Value = DGV.Item(2, X).Value
            DGVMCP.Item(4, ITEMS).Value = DGV.Item(3, X).Value
            DGVMCP.Item(5, ITEMS).Value = DGV.Item(5, X).Value
            DGVMCP.Item(6, ITEMS).Value = DGV.Item(24, X).Value
            DGVMCP.Item(7, ITEMS).Value = DGV.Item(15, X).Value
            DGVMCP.Item(8, ITEMS).Value = DGV.Item(26, X).Value
        Next
        DgvAjusteEncabezado(DGVMCP, "")
    End Sub

    Private Sub CBMON_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TXTTC.Enabled = False
        TXTTC.Text = "1.00"
        If LMON(CBMON.SelectedIndex) <> "MXN" Then
            TXTTC.Enabled = True
        End If

        LBLCCL.Text = CLETRAS.Letras(T.ToString, LMON(CBMON.SelectedIndex), CBMON.Text)
    End Sub

    Private Sub CBFIVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFIVA.SelectedIndexChanged
        TXTTIVA.Enabled = False
        If LFIVA(CBFIVA.SelectedIndex) = "1" Then
            TXTTIVA.Enabled = True
        End If
    End Sub

    Private Sub CBFIEPS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFIEPS.SelectedIndexChanged
        TXTTCIEPS.Enabled = False
        If LFIEPS(CBFIEPS.SelectedIndex) = "1" Or LFIEPS(CBFIEPS.SelectedIndex) = "2" Then
            TXTTCIEPS.Enabled = True
        End If
    End Sub

    Private Sub CHKIT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKIT.CheckedChanged
        GBTRAS.Enabled = CHKIT.Checked
    End Sub

    Private Sub CHKIR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKIR.CheckedChanged
        GBRET.Enabled = CHKIR.Checked
    End Sub

    Private Sub CBEO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEO.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmClsBusqueda.BUSCAR("Select ClaveSat,Descripcion,CostoPromedio,Codigo,UnidadSat,Unidad from VPRODUCTOSFACTURADOS where RFCEMISOR='" + CBEMISOR.Text + "'", " and Descripcion", " ORDER BY Descripcion", "Búsqueda de Productos facturados", "Nombre del producto", "Producto(s)", 1, frmPrincipal.CadenaConexion, False)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CARGAX(LPYSSAT, CBPYS, frmClsBusqueda.TREG.Rows(0).Item(0).ToString)
            TXTCODINT.Text = frmClsBusqueda.TREG.Rows(0).Item(3).ToString
            TXTDES.Text = frmClsBusqueda.TREG.Rows(0).Item(1).ToString
            TXTUNI.Text = frmClsBusqueda.TREG.Rows(0).Item(5).ToString
            OPCargaX(LUSAT, CBUNI, frmClsBusqueda.TREG.Rows(0).Item(4).ToString)
            TXTVU.Text = frmClsBusqueda.TREG.Rows(0).Item(2).ToString

            TXTVU.SelectAll()
            TXTVU.Focus()
            'CARGADATOS()
        End If
    End Sub

    Private Sub CHKCRP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTNBCER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBCER.Click
        MessageBox.Show("No implementado actualmente, cuando se tenga un certificado de pago se procederá a su desarrollo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Dim DTCRP As New DataTable

    Private Sub BTNCRPAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCRPAGREGAR.Click
        Dim VSFP As New frmSeleccionaFacturaPago
        VSFP.MOSTRAR(CBEMISOR.Text, TXTRFC.Text, TXTNOM.Text)
        If VSFP.DialogResult = Windows.Forms.DialogResult.Yes Then
            DGVCRP.Columns.Clear()
            DTCRP.Rows.Clear()
            DTCRP.Columns.Clear()
            DTCRP.Columns.Add("Serie")
            DTCRP.Columns.Add("CFolio")
            DTCRP.Columns.Add("UUID")
            DTCRP.Columns.Add("Total Comprobante")
            DTCRP.Columns.Add("Saldo Anterior")
            DTCRP.Columns.Add("Num Parcialidad")
            DTCRP.Columns.Add("Importe")
            DTCRP.Columns.Add("Nuevo Saldo")


            Dim I As Integer
            For I = 0 To VSFP.DTRESULTADO.Rows.Count - 1
                Dim DOW As DataRow = DTCRP.NewRow()
                DOW(0) = VSFP.DTRESULTADO.Rows(I).Item(0)
                DOW(1) = VSFP.DTRESULTADO.Rows(I).Item(1)
                DOW(2) = VSFP.DTRESULTADO.Rows(I).Item(4)
                DOW(3) = VSFP.DTRESULTADO.Rows(I).Item(3)
                DOW(4) = 0.0
                DOW(5) = 0.0
                DOW(6) = 0.0
                DOW(7) = 0.0
                DTCRP.Rows.Add(DOW)
            Next
        End If
        DGVCRP.DataSource = DTCRP
        DGVCRP.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCRP.Columns(3).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(4).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(5).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(6).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(7).DefaultCellStyle = FORMATONUMERICO()

        DGVCRP.ReadOnly = False
        DGVCRP.Columns(0).ReadOnly = True
        DGVCRP.Columns(1).ReadOnly = True
        DGVCRP.Columns(2).ReadOnly = True
        DGVCRP.Columns(3).ReadOnly = True
        DGVCRP.Columns(7).ReadOnly = True
        
    End Sub

    Private Sub DGVCRP_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCRP.CellEndEdit
        Try
            Dim X As Integer
            For X = 0 To DGVCRP.Rows.Count - 1
                DGVCRP.Item(7, X).Value = DGVCRP.Item(4, X).Value - DGVCRP.Item(6, X).Value
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DGVCRP.Rows.Count <= 0 Then
            Exit Sub
        End If
        DTCRP.Rows.RemoveAt(DGVCRP.CurrentRow.Index)
        DGVCRP.DataSource = DTCRP
        DGVCRP.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCRP.Columns(3).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(4).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(5).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(6).DefaultCellStyle = FORMATONUMERICO()
        DGVCRP.Columns(7).DefaultCellStyle = FORMATONUMERICO()

        DGVCRP.ReadOnly = False
        DGVCRP.Columns(0).ReadOnly = True
        DGVCRP.Columns(1).ReadOnly = True
        DGVCRP.Columns(2).ReadOnly = True
        DGVCRP.Columns(3).ReadOnly = True
        DGVCRP.Columns(7).ReadOnly = True
    End Sub

    Private Sub CBMON_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMON.SelectedIndexChanged

    End Sub

    Private Sub TXTTC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTC.TextChanged
        TXTCETC.Text = TXTTC.Text
    End Sub

    Private Sub TXTTOT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTOT.TextChanged
        TXTCETUSD.Text = TXTTOT.Text
    End Sub

    Private Sub CBFIVAR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFIVAR.SelectedIndexChanged
        TXTIVAR.Enabled = False
        If LFIVAR(CBFIVAR.SelectedIndex) = "1" Then
            TXTIVAR.Enabled = True
        End If
    End Sub

    Private Sub CBFISRR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFISRR.SelectedIndexChanged
        TXTISRR.Enabled = False
        If LFISRR(CBFISRR.SelectedIndex) = "1" Then
            TXTISRR.Enabled = True
        End If
    End Sub

    Private Sub TABC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TABC.SelectedIndexChanged

    End Sub
End Class