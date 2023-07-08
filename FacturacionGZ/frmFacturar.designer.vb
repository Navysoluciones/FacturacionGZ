<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBRF = New System.Windows.Forms.ComboBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.TXTNCOM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTNOM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBCALLE = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBLDD = New System.Windows.Forms.Label()
        Me.CBEMISOR = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLDE = New System.Windows.Forms.Label()
        Me.LBLDN = New System.Windows.Forms.Label()
        Me.CBNEG = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTDE = New System.Windows.Forms.DateTimePicker()
        Me.TXTRFC = New System.Windows.Forms.TextBox()
        Me.CBTC = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TABC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TXTCP = New System.Windows.Forms.TextBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHKCP = New System.Windows.Forms.CheckBox()
        Me.CHKINE = New System.Windows.Forms.CheckBox()
        Me.CHKCE = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TXTPESO = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.TXTFA = New System.Windows.Forms.TextBox()
        Me.LBLFA = New System.Windows.Forms.Label()
        Me.TXTCA = New System.Windows.Forms.TextBox()
        Me.LBLCA = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CODINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetIsr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorIeps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaIeps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PYSSAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASAIVAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOFACTORIVAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASAIEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOFACTORIEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASAISRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOFACTORISRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadAduana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FraccionArancelaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.TXTIEPS = New System.Windows.Forms.TextBox()
        Me.CHKIR = New System.Windows.Forms.CheckBox()
        Me.CHKIT = New System.Windows.Forms.CheckBox()
        Me.GBRET = New System.Windows.Forms.GroupBox()
        Me.TXTIVAR = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.TXTISRR = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.CBFIVAR = New System.Windows.Forms.ComboBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.CBFISRR = New System.Windows.Forms.ComboBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.GBTRAS = New System.Windows.Forms.GroupBox()
        Me.TXTTIVA = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXTTCIEPS = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.CBFIVA = New System.Windows.Forms.ComboBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.CBFIEPS = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.TXTCODINT = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CBUNI = New System.Windows.Forms.ComboBox()
        Me.CBPYS = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LBLTOT = New System.Windows.Forms.Label()
        Me.LBLSUB = New System.Windows.Forms.Label()
        Me.LBLIVA = New System.Windows.Forms.Label()
        Me.TXTTOT = New System.Windows.Forms.TextBox()
        Me.LBLCCL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTRIVA = New System.Windows.Forms.TextBox()
        Me.TXTISR = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTSUB = New System.Windows.Forms.TextBox()
        Me.TXTIVA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTIMP = New System.Windows.Forms.TextBox()
        Me.TXTCANT = New System.Windows.Forms.TextBox()
        Me.TXTVU = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTDES = New System.Windows.Forms.TextBox()
        Me.TXTUNI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTNQUITAR = New System.Windows.Forms.Button()
        Me.BTNAGREGAR = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.GBIAPG = New System.Windows.Forms.GroupBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.CBIAAÑO = New System.Windows.Forms.ComboBox()
        Me.CBIAPER = New System.Windows.Forms.ComboBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.CBIAMES = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TXTFREL = New System.Windows.Forms.TextBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.CBREL = New System.Windows.Forms.ComboBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTCOM = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CBUSO = New System.Windows.Forms.ComboBox()
        Me.LLBLP = New System.Windows.Forms.LinkLabel()
        Me.LLBLD = New System.Windows.Forms.LinkLabel()
        Me.LLBLF = New System.Windows.Forms.LinkLabel()
        Me.LBLTC = New System.Windows.Forms.LinkLabel()
        Me.TXTTC = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.CBMON = New System.Windows.Forms.ComboBox()
        Me.CBCP = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTAR = New System.Windows.Forms.TextBox()
        Me.CBFP = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBMP = New System.Windows.Forms.ComboBox()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.RB7 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.BTNQC = New System.Windows.Forms.Button()
        Me.BTNAC = New System.Windows.Forms.Button()
        Me.LBC = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXTCC = New System.Windows.Forms.TextBox()
        Me.CBEC = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.RB6 = New System.Windows.Forms.RadioButton()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.BTNQO = New System.Windows.Forms.Button()
        Me.BTNAO = New System.Windows.Forms.Button()
        Me.LBO = New System.Windows.Forms.ListBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXTCO = New System.Windows.Forms.TextBox()
        Me.CBEO = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TXTCEOBS = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.GBCEDES = New System.Windows.Forms.GroupBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.CBCEPAIS = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.CBCEEDO = New System.Windows.Forms.ComboBox()
        Me.TXTCEREF = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TXTCENOINT = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TXTCENOEXT = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TXTCEMUN = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TXTCELOC = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TXTCECP = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TXTCECALLE = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TXTCEDDNOM = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TXTCEDDCURP = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TXTCERFC = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.CBCEINCO = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TXTCETUSD = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TXTCETC = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.CBCESUB = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TXTCECURP = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TXTCERFP = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TXTCENCO = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TXTCECO = New System.Windows.Forms.TextBox()
        Me.CHKCEDD = New System.Windows.Forms.CheckBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TXTCECPED = New System.Windows.Forms.TextBox()
        Me.CBCETO = New System.Windows.Forms.ComboBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DTHORA = New System.Windows.Forms.DateTimePicker()
        Me.BTNBCER = New System.Windows.Forms.Button()
        Me.CBCRPTCP = New System.Windows.Forms.ComboBox()
        Me.DGVCRP = New System.Windows.Forms.DataGridView()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumParcialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuevoSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.TXTCRPSELLO = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.TXTCRPCAD = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.TXTCRPCER = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.TXTCRPCB = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.TXTCRPRFCCB = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TXTCRPCO = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.TXTCRPNBCO = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.TXTCRPRFCCO = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TXTCRPNOPE = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TXTCRPTC = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.CBCRPMON = New System.Windows.Forms.ComboBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.CBCRPFP = New System.Windows.Forms.ComboBox()
        Me.DTPCRPFP = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTNCRPAGREGAR = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TABCP = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TXTPOLMA = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.TXTASEMA = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.TXTPOL = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.TXTASE = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.BTNBUSCON = New System.Windows.Forms.Button()
        Me.BTNBUSPER = New System.Windows.Forms.Button()
        Me.NUDMOD = New System.Windows.Forms.NumericUpDown()
        Me.CBCON = New System.Windows.Forms.ComboBox()
        Me.CBPER = New System.Windows.Forms.ComboBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.TXTPLACAS = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.TXTNUMPER = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.CBTF = New System.Windows.Forms.ComboBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.TXTPAIS = New System.Windows.Forms.TextBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.TXTNRI = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.TXTLIC = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.TXTRFCCHO = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.TXTNOMCHO = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.TXTCPORI = New System.Windows.Forms.TextBox()
        Me.CBEDOORI = New System.Windows.Forms.ComboBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.TXTDIS = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.DTHORALLEG = New System.Windows.Forms.DateTimePicker()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.DTFLLEG = New System.Windows.Forms.DateTimePicker()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.TXTPOLCAR = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.TXTASECAR = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.DTHORASAL = New System.Windows.Forms.DateTimePicker()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.DTFSAL = New System.Windows.Forms.DateTimePicker()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.TXTCPDES = New System.Windows.Forms.TextBox()
        Me.CBEDODES = New System.Windows.Forms.ComboBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.LBLUUIDR = New System.Windows.Forms.Label()
        Me.LBLFOLIOR = New System.Windows.Forms.Label()
        Me.LBLSERIER = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.DGVMCP = New System.Windows.Forms.DataGridView()
        Me.MCPPySSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPCodInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPUniSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCPFa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.TTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TABC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRET.SuspendLayout()
        Me.GBTRAS.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GBIAPG.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GBCEDES.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DGVCRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.TABCP.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.NUDMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        CType(Me.DGVMCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBRF)
        Me.GroupBox1.Controls.Add(Me.Label126)
        Me.GroupBox1.Controls.Add(Me.TXTNCOM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXTNOM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 283)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(919, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'CBRF
        '
        Me.CBRF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRF.FormattingEnabled = True
        Me.CBRF.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBRF.Location = New System.Drawing.Point(208, 87)
        Me.CBRF.Margin = New System.Windows.Forms.Padding(4)
        Me.CBRF.Name = "CBRF"
        Me.CBRF.Size = New System.Drawing.Size(681, 28)
        Me.CBRF.TabIndex = 2
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(73, 91)
        Me.Label126.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(110, 20)
        Me.Label126.TabIndex = 1221
        Me.Label126.Text = "Reg. Fiscal:"
        '
        'TXTNCOM
        '
        Me.TXTNCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNCOM.Location = New System.Drawing.Point(208, 52)
        Me.TXTNCOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTNCOM.MaxLength = 100
        Me.TXTNCOM.Name = "TXTNCOM"
        Me.TXTNCOM.Size = New System.Drawing.Size(681, 26)
        Me.TXTNCOM.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 55)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 20)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nombre Comercial:"
        '
        'TXTNOM
        '
        Me.TXTNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOM.Location = New System.Drawing.Point(208, 15)
        Me.TXTNOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTNOM.MaxLength = 100
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(681, 26)
        Me.TXTNOM.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre Fiscal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 239)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "RFC Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 427)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Calle:"
        '
        'CBCALLE
        '
        Me.CBCALLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCALLE.FormattingEnabled = True
        Me.CBCALLE.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCALLE.Location = New System.Drawing.Point(103, 423)
        Me.CBCALLE.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCALLE.Name = "CBCALLE"
        Me.CBCALLE.Size = New System.Drawing.Size(752, 28)
        Me.CBCALLE.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBLDD)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 462)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(977, 86)
        Me.GroupBox2.TabIndex = 104
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Domicilio"
        '
        'LBLDD
        '
        Me.LBLDD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDD.Location = New System.Drawing.Point(12, 21)
        Me.LBLDD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLDD.Name = "LBLDD"
        Me.LBLDD.Size = New System.Drawing.Size(957, 60)
        Me.LBLDD.TabIndex = 95
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(164, 31)
        Me.CBEMISOR.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(293, 28)
        Me.CBEMISOR.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "RFC Emisor"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(28, 75)
        Me.LBLDE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(428, 64)
        Me.LBLDE.TabIndex = 116
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'LBLDN
        '
        Me.LBLDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDN.Location = New System.Drawing.Point(639, 75)
        Me.LBLDN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLDN.Name = "LBLDN"
        Me.LBLDN.Size = New System.Drawing.Size(651, 64)
        Me.LBLDN.TabIndex = 119
        Me.LBLDN.Text = "Lugar de Expedición"
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(639, 31)
        Me.CBNEG.Margin = New System.Windows.Forms.Padding(4)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(649, 28)
        Me.CBNEG.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(535, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Negocio"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(558, 226)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(297, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Nuevo Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTDE
        '
        Me.DTDE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(539, 178)
        Me.DTDE.Margin = New System.Windows.Forms.Padding(4)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(167, 30)
        Me.DTDE.TabIndex = 3
        '
        'TXTRFC
        '
        Me.TXTRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRFC.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFC.Location = New System.Drawing.Point(155, 233)
        Me.TXTRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTRFC.MaxLength = 13
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(297, 31)
        Me.TXTRFC.TabIndex = 4
        Me.TXTRFC.Text = "1IL6G2Z0OQ95S"
        '
        'CBTC
        '
        Me.CBTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTC.FormattingEnabled = True
        Me.CBTC.Location = New System.Drawing.Point(28, 181)
        Me.CBTC.Margin = New System.Windows.Forms.Padding(4)
        Me.CBTC.Name = "CBTC"
        Me.CBTC.Size = New System.Drawing.Size(427, 28)
        Me.CBTC.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 157)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(188, 20)
        Me.Label20.TabIndex = 1122
        Me.Label20.Text = "Tipo de Comprobante"
        '
        'TABC
        '
        Me.TABC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TABC.Controls.Add(Me.TabPage1)
        Me.TABC.Controls.Add(Me.TabPage3)
        Me.TABC.Controls.Add(Me.TabPage5)
        Me.TABC.Controls.Add(Me.TabPage2)
        Me.TABC.Controls.Add(Me.TabPage4)
        Me.TABC.Controls.Add(Me.TabPage6)
        Me.TABC.Controls.Add(Me.TabPage7)
        Me.TABC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABC.Location = New System.Drawing.Point(3, 15)
        Me.TABC.Margin = New System.Windows.Forms.Padding(4)
        Me.TABC.Name = "TABC"
        Me.TABC.SelectedIndex = 0
        Me.TABC.Size = New System.Drawing.Size(1332, 833)
        Me.TABC.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TXTCP)
        Me.TabPage1.Controls.Add(Me.Label127)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.CBEMISOR)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CBTC)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BTNCANCELAR)
        Me.TabPage1.Controls.Add(Me.BTNBUSCAR)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CBCALLE)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.TXTRFC)
        Me.TabPage1.Controls.Add(Me.DTDE)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.LBLDE)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.CBNEG)
        Me.TabPage1.Controls.Add(Me.LBLDN)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comprobante"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TXTCP
        '
        Me.TXTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCP.Location = New System.Drawing.Point(923, 425)
        Me.TXTCP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCP.MaxLength = 5
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.Size = New System.Drawing.Size(125, 26)
        Me.TXTCP.TabIndex = 9
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(869, 432)
        Me.Label127.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(44, 20)
        Me.Label127.TabIndex = 1224
        Me.Label127.Text = "C.P."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CHKCP)
        Me.GroupBox3.Controls.Add(Me.CHKINE)
        Me.GroupBox3.Controls.Add(Me.CHKCE)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 608)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(973, 154)
        Me.GroupBox3.TabIndex = 1173
        Me.GroupBox3.TabStop = False
        '
        'CHKCP
        '
        Me.CHKCP.AutoSize = True
        Me.CHKCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCP.Location = New System.Drawing.Point(49, 76)
        Me.CHKCP.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKCP.Name = "CHKCP"
        Me.CHKCP.Size = New System.Drawing.Size(126, 24)
        Me.CHKCP.TabIndex = 1171
        Me.CHKCP.Text = "Carta porte"
        Me.CHKCP.UseVisualStyleBackColor = True
        '
        'CHKINE
        '
        Me.CHKINE.AutoSize = True
        Me.CHKINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKINE.Location = New System.Drawing.Point(49, 26)
        Me.CHKINE.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKINE.Name = "CHKINE"
        Me.CHKINE.Size = New System.Drawing.Size(181, 24)
        Me.CHKINE.TabIndex = 1168
        Me.CHKINE.Text = "Complemento INE"
        Me.CHKINE.UseVisualStyleBackColor = True
        '
        'CHKCE
        '
        Me.CHKCE.AutoSize = True
        Me.CHKCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCE.Location = New System.Drawing.Point(660, 26)
        Me.CHKCE.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKCE.Name = "CHKCE"
        Me.CHKCE.Size = New System.Drawing.Size(183, 24)
        Me.CHKCE.TabIndex = 1170
        Me.CHKCE.Text = "Comercio Exterior"
        Me.CHKCE.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(24, 573)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(139, 20)
        Me.Label30.TabIndex = 1169
        Me.Label30.Text = "Complementos:"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.Location = New System.Drawing.Point(959, 316)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNCANCELAR.TabIndex = 7
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Image = CType(resources.GetObject("BTNBUSCAR.Image"), System.Drawing.Image)
        Me.BTNBUSCAR.Location = New System.Drawing.Point(959, 181)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNBUSCAR.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TXTPESO)
        Me.TabPage3.Controls.Add(Me.Label89)
        Me.TabPage3.Controls.Add(Me.TXTFA)
        Me.TabPage3.Controls.Add(Me.LBLFA)
        Me.TabPage3.Controls.Add(Me.TXTCA)
        Me.TabPage3.Controls.Add(Me.LBLCA)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.DGV)
        Me.TabPage3.Controls.Add(Me.Label74)
        Me.TabPage3.Controls.Add(Me.TXTIEPS)
        Me.TabPage3.Controls.Add(Me.CHKIR)
        Me.TabPage3.Controls.Add(Me.CHKIT)
        Me.TabPage3.Controls.Add(Me.GBRET)
        Me.TabPage3.Controls.Add(Me.GBTRAS)
        Me.TabPage3.Controls.Add(Me.Label67)
        Me.TabPage3.Controls.Add(Me.TXTCODINT)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.CBUNI)
        Me.TabPage3.Controls.Add(Me.CBPYS)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.LBLTOT)
        Me.TabPage3.Controls.Add(Me.LBLSUB)
        Me.TabPage3.Controls.Add(Me.LBLIVA)
        Me.TabPage3.Controls.Add(Me.TXTTOT)
        Me.TabPage3.Controls.Add(Me.LBLCCL)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TXTRIVA)
        Me.TabPage3.Controls.Add(Me.TXTISR)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TXTSUB)
        Me.TabPage3.Controls.Add(Me.TXTIVA)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TXTIMP)
        Me.TabPage3.Controls.Add(Me.TXTCANT)
        Me.TabPage3.Controls.Add(Me.TXTVU)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TXTDES)
        Me.TabPage3.Controls.Add(Me.TXTUNI)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.BTNQUITAR)
        Me.TabPage3.Controls.Add(Me.BTNAGREGAR)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle Factura"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TXTPESO
        '
        Me.TXTPESO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPESO.Location = New System.Drawing.Point(705, 128)
        Me.TXTPESO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPESO.MaxLength = 20
        Me.TXTPESO.Name = "TXTPESO"
        Me.TXTPESO.Size = New System.Drawing.Size(128, 26)
        Me.TXTPESO.TabIndex = 8
        Me.TXTPESO.Text = "0.01"
        Me.TXTPESO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(729, 103)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(79, 20)
        Me.Label89.TabIndex = 1509
        Me.Label89.Text = "Peso Kg"
        '
        'TXTFA
        '
        Me.TXTFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFA.Location = New System.Drawing.Point(536, 328)
        Me.TXTFA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTFA.MaxLength = 20
        Me.TXTFA.Name = "TXTFA"
        Me.TXTFA.Size = New System.Drawing.Size(128, 26)
        Me.TXTFA.TabIndex = 1506
        '
        'LBLFA
        '
        Me.LBLFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFA.Location = New System.Drawing.Point(536, 278)
        Me.LBLFA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFA.Name = "LBLFA"
        Me.LBLFA.Size = New System.Drawing.Size(129, 46)
        Me.LBLFA.TabIndex = 1507
        Me.LBLFA.Text = "Fracción Arancelaria"
        '
        'TXTCA
        '
        Me.TXTCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCA.Location = New System.Drawing.Point(540, 226)
        Me.TXTCA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCA.MaxLength = 20
        Me.TXTCA.Name = "TXTCA"
        Me.TXTCA.Size = New System.Drawing.Size(128, 26)
        Me.TXTCA.TabIndex = 1504
        '
        'LBLCA
        '
        Me.LBLCA.AutoSize = True
        Me.LBLCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCA.Location = New System.Drawing.Point(528, 202)
        Me.LBLCA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLCA.Name = "LBLCA"
        Me.LBLCA.Size = New System.Drawing.Size(151, 20)
        Me.LBLCA.TabIndex = 1505
        Me.LBLCA.Text = "Cantidad Aduana"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1261, 50)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODINT, Me.Cantidad, Me.Descripcion, Me.Unidad, Me.ValorUnitario, Me.Subtotal, Me.Iva, Me.Ieps, Me.RetIva, Me.RetIsr, Me.TotalNeto, Me.FactorIva, Me.TasaIva, Me.FactorIeps, Me.TasaIeps, Me.UniSat, Me.PYSSAT, Me.TASAIVAR, Me.TIPOFACTORIVAR, Me.IEPSR, Me.TASAIEPSR, Me.TIPOFACTORIEPSR, Me.TASAISRR, Me.TIPOFACTORISRR, Me.Peso, Me.CantidadAduana, Me.FraccionArancelaria})
        Me.DGV.Location = New System.Drawing.Point(29, 420)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1157, 258)
        Me.DGV.TabIndex = 1502
        '
        'CODINT
        '
        Me.CODINT.HeaderText = "Cod. Int"
        Me.CODINT.Name = "CODINT"
        Me.CODINT.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'ValorUnitario
        '
        Me.ValorUnitario.HeaderText = "Valor Unitario"
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Sub Total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        '
        'Ieps
        '
        Me.Ieps.HeaderText = "Ieps"
        Me.Ieps.Name = "Ieps"
        Me.Ieps.ReadOnly = True
        '
        'RetIva
        '
        Me.RetIva.HeaderText = "Ret. Iva"
        Me.RetIva.Name = "RetIva"
        Me.RetIva.ReadOnly = True
        '
        'RetIsr
        '
        Me.RetIsr.HeaderText = "Ret. Isr"
        Me.RetIsr.Name = "RetIsr"
        Me.RetIsr.ReadOnly = True
        '
        'TotalNeto
        '
        Me.TotalNeto.HeaderText = "Total Neto"
        Me.TotalNeto.Name = "TotalNeto"
        Me.TotalNeto.ReadOnly = True
        '
        'FactorIva
        '
        Me.FactorIva.HeaderText = "Factor Iva"
        Me.FactorIva.Name = "FactorIva"
        Me.FactorIva.ReadOnly = True
        Me.FactorIva.Visible = False
        '
        'TasaIva
        '
        Me.TasaIva.HeaderText = "Tasa Iva"
        Me.TasaIva.Name = "TasaIva"
        Me.TasaIva.ReadOnly = True
        Me.TasaIva.Visible = False
        '
        'FactorIeps
        '
        Me.FactorIeps.HeaderText = "Factor Ieps"
        Me.FactorIeps.Name = "FactorIeps"
        Me.FactorIeps.ReadOnly = True
        Me.FactorIeps.Visible = False
        '
        'TasaIeps
        '
        Me.TasaIeps.HeaderText = "Tasa Ieps"
        Me.TasaIeps.Name = "TasaIeps"
        Me.TasaIeps.ReadOnly = True
        Me.TasaIeps.Visible = False
        '
        'UniSat
        '
        Me.UniSat.HeaderText = "UniSat"
        Me.UniSat.Name = "UniSat"
        Me.UniSat.ReadOnly = True
        Me.UniSat.Visible = False
        '
        'PYSSAT
        '
        Me.PYSSAT.HeaderText = "PYSSAT"
        Me.PYSSAT.Name = "PYSSAT"
        Me.PYSSAT.ReadOnly = True
        Me.PYSSAT.Visible = False
        '
        'TASAIVAR
        '
        Me.TASAIVAR.HeaderText = "TASAIVAR"
        Me.TASAIVAR.Name = "TASAIVAR"
        Me.TASAIVAR.ReadOnly = True
        Me.TASAIVAR.Visible = False
        '
        'TIPOFACTORIVAR
        '
        Me.TIPOFACTORIVAR.HeaderText = "TIPOFACTORIVAR"
        Me.TIPOFACTORIVAR.Name = "TIPOFACTORIVAR"
        Me.TIPOFACTORIVAR.ReadOnly = True
        Me.TIPOFACTORIVAR.Visible = False
        '
        'IEPSR
        '
        Me.IEPSR.HeaderText = "IEPSR"
        Me.IEPSR.Name = "IEPSR"
        Me.IEPSR.ReadOnly = True
        Me.IEPSR.Visible = False
        '
        'TASAIEPSR
        '
        Me.TASAIEPSR.HeaderText = "TASAIEPSR"
        Me.TASAIEPSR.Name = "TASAIEPSR"
        Me.TASAIEPSR.ReadOnly = True
        Me.TASAIEPSR.Visible = False
        '
        'TIPOFACTORIEPSR
        '
        Me.TIPOFACTORIEPSR.HeaderText = "TIPOFACTORIEPSR"
        Me.TIPOFACTORIEPSR.Name = "TIPOFACTORIEPSR"
        Me.TIPOFACTORIEPSR.ReadOnly = True
        Me.TIPOFACTORIEPSR.Visible = False
        '
        'TASAISRR
        '
        Me.TASAISRR.HeaderText = "TASAISRR"
        Me.TASAISRR.Name = "TASAISRR"
        Me.TASAISRR.ReadOnly = True
        Me.TASAISRR.Visible = False
        '
        'TIPOFACTORISRR
        '
        Me.TIPOFACTORISRR.HeaderText = "TIPOFACTORISRR"
        Me.TIPOFACTORISRR.Name = "TIPOFACTORISRR"
        Me.TIPOFACTORISRR.ReadOnly = True
        Me.TIPOFACTORISRR.Visible = False
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        '
        'CantidadAduana
        '
        Me.CantidadAduana.HeaderText = "CantidadAduana"
        Me.CantidadAduana.Name = "CantidadAduana"
        Me.CantidadAduana.ReadOnly = True
        '
        'FraccionArancelaria
        '
        Me.FraccionArancelaria.HeaderText = "FraccionArancelaria"
        Me.FraccionArancelaria.Name = "FraccionArancelaria"
        Me.FraccionArancelaria.ReadOnly = True
        '
        'Label74
        '
        Me.Label74.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(701, 728)
        Me.Label74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(53, 25)
        Me.Label74.TabIndex = 1501
        Me.Label74.Text = "Ieps"
        '
        'TXTIEPS
        '
        Me.TXTIEPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIEPS.Location = New System.Drawing.Point(764, 727)
        Me.TXTIEPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTIEPS.MaxLength = 20
        Me.TXTIEPS.Name = "TXTIEPS"
        Me.TXTIEPS.ReadOnly = True
        Me.TXTIEPS.Size = New System.Drawing.Size(227, 26)
        Me.TXTIEPS.TabIndex = 1500
        Me.TXTIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CHKIR
        '
        Me.CHKIR.AutoSize = True
        Me.CHKIR.Location = New System.Drawing.Point(757, 182)
        Me.CHKIR.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKIR.Name = "CHKIR"
        Me.CHKIR.Size = New System.Drawing.Size(227, 24)
        Me.CHKIR.TabIndex = 1499
        Me.CHKIR.Text = "Impuestos Retenciones"
        Me.CHKIR.UseVisualStyleBackColor = True
        '
        'CHKIT
        '
        Me.CHKIT.AutoSize = True
        Me.CHKIT.Location = New System.Drawing.Point(39, 182)
        Me.CHKIT.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKIT.Name = "CHKIT"
        Me.CHKIT.Size = New System.Drawing.Size(226, 24)
        Me.CHKIT.TabIndex = 1498
        Me.CHKIT.Text = "Impuestos Trasladados"
        Me.CHKIT.UseVisualStyleBackColor = True
        '
        'GBRET
        '
        Me.GBRET.Controls.Add(Me.TXTIVAR)
        Me.GBRET.Controls.Add(Me.Label68)
        Me.GBRET.Controls.Add(Me.TXTISRR)
        Me.GBRET.Controls.Add(Me.Label69)
        Me.GBRET.Controls.Add(Me.CBFIVAR)
        Me.GBRET.Controls.Add(Me.Label70)
        Me.GBRET.Controls.Add(Me.CBFISRR)
        Me.GBRET.Controls.Add(Me.Label71)
        Me.GBRET.Controls.Add(Me.Label72)
        Me.GBRET.Controls.Add(Me.Label73)
        Me.GBRET.Location = New System.Drawing.Point(752, 214)
        Me.GBRET.Margin = New System.Windows.Forms.Padding(4)
        Me.GBRET.Name = "GBRET"
        Me.GBRET.Padding = New System.Windows.Forms.Padding(4)
        Me.GBRET.Size = New System.Drawing.Size(413, 192)
        Me.GBRET.TabIndex = 1497
        Me.GBRET.TabStop = False
        '
        'TXTIVAR
        '
        Me.TXTIVAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVAR.Location = New System.Drawing.Point(245, 43)
        Me.TXTIVAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTIVAR.MaxLength = 20
        Me.TXTIVAR.Name = "TXTIVAR"
        Me.TXTIVAR.Size = New System.Drawing.Size(128, 26)
        Me.TXTIVAR.TabIndex = 1
        Me.TXTIVAR.Text = "0"
        Me.TXTIVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(241, 20)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(80, 20)
        Me.Label68.TabIndex = 1215
        Me.Label68.Text = "Tasa Iva"
        '
        'TXTISRR
        '
        Me.TXTISRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTISRR.Location = New System.Drawing.Point(245, 129)
        Me.TXTISRR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTISRR.MaxLength = 20
        Me.TXTISRR.Name = "TXTISRR"
        Me.TXTISRR.Size = New System.Drawing.Size(128, 26)
        Me.TXTISRR.TabIndex = 3
        Me.TXTISRR.Text = "0"
        Me.TXTISRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(64, 162)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(184, 20)
        Me.Label69.TabIndex = 1493
        Me.Label69.Text = "Tasa del 0.00 al 0.35"
        '
        'CBFIVAR
        '
        Me.CBFIVAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIVAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIVAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIVAR.FormattingEnabled = True
        Me.CBFIVAR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIVAR.Location = New System.Drawing.Point(37, 41)
        Me.CBFIVAR.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFIVAR.Name = "CBFIVAR"
        Me.CBFIVAR.Size = New System.Drawing.Size(155, 28)
        Me.CBFIVAR.TabIndex = 0
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Red
        Me.Label70.Location = New System.Drawing.Point(64, 75)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(184, 20)
        Me.Label70.TabIndex = 1492
        Me.Label70.Text = "Tasa del 0.00 al 0.16"
        '
        'CBFISRR
        '
        Me.CBFISRR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFISRR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFISRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFISRR.FormattingEnabled = True
        Me.CBFISRR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFISRR.Location = New System.Drawing.Point(37, 129)
        Me.CBFISRR.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFISRR.Name = "CBFISRR"
        Me.CBFISRR.Size = New System.Drawing.Size(155, 28)
        Me.CBFISRR.TabIndex = 2
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(45, 20)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(93, 20)
        Me.Label71.TabIndex = 1233
        Me.Label71.Text = "Iva Factor"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(47, 103)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(91, 20)
        Me.Label72.TabIndex = 1235
        Me.Label72.Text = "Isr Factor"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(241, 103)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(78, 20)
        Me.Label73.TabIndex = 1237
        Me.Label73.Text = "Tasa Isr"
        '
        'GBTRAS
        '
        Me.GBTRAS.Controls.Add(Me.TXTTIVA)
        Me.GBTRAS.Controls.Add(Me.Label18)
        Me.GBTRAS.Controls.Add(Me.TXTTCIEPS)
        Me.GBTRAS.Controls.Add(Me.Label65)
        Me.GBTRAS.Controls.Add(Me.CBFIVA)
        Me.GBTRAS.Controls.Add(Me.Label66)
        Me.GBTRAS.Controls.Add(Me.CBFIEPS)
        Me.GBTRAS.Controls.Add(Me.Label35)
        Me.GBTRAS.Controls.Add(Me.Label36)
        Me.GBTRAS.Controls.Add(Me.Label37)
        Me.GBTRAS.Location = New System.Drawing.Point(39, 214)
        Me.GBTRAS.Margin = New System.Windows.Forms.Padding(4)
        Me.GBTRAS.Name = "GBTRAS"
        Me.GBTRAS.Padding = New System.Windows.Forms.Padding(4)
        Me.GBTRAS.Size = New System.Drawing.Size(436, 192)
        Me.GBTRAS.TabIndex = 1496
        Me.GBTRAS.TabStop = False
        '
        'TXTTIVA
        '
        Me.TXTTIVA.Enabled = False
        Me.TXTTIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIVA.Location = New System.Drawing.Point(239, 43)
        Me.TXTTIVA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTTIVA.MaxLength = 20
        Me.TXTTIVA.Name = "TXTTIVA"
        Me.TXTTIVA.Size = New System.Drawing.Size(128, 26)
        Me.TXTTIVA.TabIndex = 1
        Me.TXTTIVA.Text = "0"
        Me.TXTTIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(235, 20)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 1215
        Me.Label18.Text = "Tasa Iva"
        '
        'TXTTCIEPS
        '
        Me.TXTTCIEPS.Enabled = False
        Me.TXTTCIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTCIEPS.Location = New System.Drawing.Point(239, 129)
        Me.TXTTCIEPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTTCIEPS.MaxLength = 20
        Me.TXTTCIEPS.Name = "TXTTCIEPS"
        Me.TXTTCIEPS.Size = New System.Drawing.Size(128, 26)
        Me.TXTTCIEPS.TabIndex = 3
        Me.TXTTCIEPS.Text = "0"
        Me.TXTTCIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(7, 162)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(385, 20)
        Me.Label65.TabIndex = 1493
        Me.Label65.Text = "Tasa del 0.00 al 1.6 / Cuota del 0.00 al 43.77"
        '
        'CBFIVA
        '
        Me.CBFIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIVA.FormattingEnabled = True
        Me.CBFIVA.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIVA.Location = New System.Drawing.Point(37, 41)
        Me.CBFIVA.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFIVA.Name = "CBFIVA"
        Me.CBFIVA.Size = New System.Drawing.Size(155, 28)
        Me.CBFIVA.TabIndex = 0
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(64, 75)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(184, 20)
        Me.Label66.TabIndex = 1492
        Me.Label66.Text = "Tasa del 0.00 al 0.16"
        '
        'CBFIEPS
        '
        Me.CBFIEPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIEPS.FormattingEnabled = True
        Me.CBFIEPS.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIEPS.Location = New System.Drawing.Point(37, 129)
        Me.CBFIEPS.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFIEPS.Name = "CBFIEPS"
        Me.CBFIEPS.Size = New System.Drawing.Size(155, 28)
        Me.CBFIEPS.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(45, 20)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(93, 20)
        Me.Label35.TabIndex = 1233
        Me.Label35.Text = "Iva Factor"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(47, 103)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(104, 20)
        Me.Label36.TabIndex = 1235
        Me.Label36.Text = "Ieps Factor"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(235, 103)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(146, 20)
        Me.Label37.TabIndex = 1237
        Me.Label37.Text = "Tasa/Cuota Ieps"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(11, 62)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(111, 20)
        Me.Label67.TabIndex = 1495
        Me.Label67.Text = "Cod. Interno"
        '
        'TXTCODINT
        '
        Me.TXTCODINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCODINT.Location = New System.Drawing.Point(140, 54)
        Me.TXTCODINT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCODINT.MaxLength = 5000
        Me.TXTCODINT.Name = "TXTCODINT"
        Me.TXTCODINT.Size = New System.Drawing.Size(196, 26)
        Me.TXTCODINT.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(175, 122)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 31)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 31)
        Me.Button2.TabIndex = 1238
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(11, 101)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 20)
        Me.Label34.TabIndex = 1231
        Me.Label34.Text = "Unidad"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(231, 5)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(101, 46)
        Me.Label33.TabIndex = 1230
        Me.Label33.Text = "Clave Producto"
        '
        'CBUNI
        '
        Me.CBUNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUNI.FormattingEnabled = True
        Me.CBUNI.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBUNI.Location = New System.Drawing.Point(11, 123)
        Me.CBUNI.Margin = New System.Windows.Forms.Padding(4)
        Me.CBUNI.Name = "CBUNI"
        Me.CBUNI.Size = New System.Drawing.Size(155, 28)
        Me.CBUNI.TabIndex = 4
        '
        'CBPYS
        '
        Me.CBPYS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBPYS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPYS.FormattingEnabled = True
        Me.CBPYS.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBPYS.Location = New System.Drawing.Point(340, -43)
        Me.CBPYS.Margin = New System.Windows.Forms.Padding(4)
        Me.CBPYS.Name = "CBPYS"
        Me.CBPYS.Size = New System.Drawing.Size(229, 28)
        Me.CBPYS.TabIndex = 1228
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(11, 156)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(110, 20)
        Me.Label32.TabIndex = 1227
        Me.Label32.Text = "Descripción"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(659, 5)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(653, 46)
        Me.Label31.TabIndex = 1226
        Me.Label31.Text = "Descripción"
        '
        'LBLTOT
        '
        Me.LBLTOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTOT.AutoSize = True
        Me.LBLTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOT.Location = New System.Drawing.Point(372, 728)
        Me.LBLTOT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTOT.Name = "LBLTOT"
        Me.LBLTOT.Size = New System.Drawing.Size(79, 25)
        Me.LBLTOT.TabIndex = 1193
        Me.LBLTOT.Text = "Ret Iva"
        '
        'LBLSUB
        '
        Me.LBLSUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLSUB.AutoSize = True
        Me.LBLSUB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUB.Location = New System.Drawing.Point(957, 690)
        Me.LBLSUB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLSUB.Name = "LBLSUB"
        Me.LBLSUB.Size = New System.Drawing.Size(100, 25)
        Me.LBLSUB.TabIndex = 1194
        Me.LBLSUB.Text = "SubTotal"
        '
        'LBLIVA
        '
        Me.LBLIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLIVA.AutoSize = True
        Me.LBLIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIVA.Location = New System.Drawing.Point(28, 728)
        Me.LBLIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLIVA.Name = "LBLIVA"
        Me.LBLIVA.Size = New System.Drawing.Size(74, 25)
        Me.LBLIVA.TabIndex = 1195
        Me.LBLIVA.Text = "Ret Isr"
        '
        'TXTTOT
        '
        Me.TXTTOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOT.Location = New System.Drawing.Point(1073, 724)
        Me.TXTTOT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTTOT.MaxLength = 20
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.ReadOnly = True
        Me.TXTTOT.Size = New System.Drawing.Size(227, 26)
        Me.TXTTOT.TabIndex = 1209
        Me.TXTTOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLCCL
        '
        Me.LBLCCL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLCCL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCCL.Location = New System.Drawing.Point(8, 756)
        Me.LBLCCL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLCCL.Name = "LBLCCL"
        Me.LBLCCL.Size = New System.Drawing.Size(1267, 32)
        Me.LBLCCL.TabIndex = 1196
        Me.LBLCCL.Text = "Cantidad con Letra"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1000, 727)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 25)
        Me.Label15.TabIndex = 1208
        Me.Label15.Text = "Total"
        '
        'TXTRIVA
        '
        Me.TXTRIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTRIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRIVA.Location = New System.Drawing.Point(469, 725)
        Me.TXTRIVA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTRIVA.MaxLength = 20
        Me.TXTRIVA.Name = "TXTRIVA"
        Me.TXTRIVA.ReadOnly = True
        Me.TXTRIVA.Size = New System.Drawing.Size(227, 26)
        Me.TXTRIVA.TabIndex = 1207
        Me.TXTRIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTISR
        '
        Me.TXTISR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTISR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTISR.Location = New System.Drawing.Point(121, 725)
        Me.TXTISR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTISR.MaxLength = 20
        Me.TXTISR.Name = "TXTISR"
        Me.TXTISR.ReadOnly = True
        Me.TXTISR.Size = New System.Drawing.Size(227, 26)
        Me.TXTISR.TabIndex = 1206
        Me.TXTISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(409, 690)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 25)
        Me.Label13.TabIndex = 1205
        Me.Label13.Text = "IVA"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 691)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 25)
        Me.Label12.TabIndex = 1204
        Me.Label12.Text = "Importe"
        '
        'TXTSUB
        '
        Me.TXTSUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTSUB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSUB.Location = New System.Drawing.Point(1073, 687)
        Me.TXTSUB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTSUB.MaxLength = 20
        Me.TXTSUB.Name = "TXTSUB"
        Me.TXTSUB.ReadOnly = True
        Me.TXTSUB.Size = New System.Drawing.Size(227, 26)
        Me.TXTSUB.TabIndex = 1203
        Me.TXTSUB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTIVA
        '
        Me.TXTIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVA.Location = New System.Drawing.Point(469, 689)
        Me.TXTIVA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTIVA.MaxLength = 20
        Me.TXTIVA.Name = "TXTIVA"
        Me.TXTIVA.ReadOnly = True
        Me.TXTIVA.Size = New System.Drawing.Size(227, 26)
        Me.TXTIVA.TabIndex = 1202
        Me.TXTIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1197
        Me.Label1.Text = "Cantidad"
        '
        'TXTIMP
        '
        Me.TXTIMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIMP.Location = New System.Drawing.Point(121, 691)
        Me.TXTIMP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTIMP.MaxLength = 20
        Me.TXTIMP.Name = "TXTIMP"
        Me.TXTIMP.ReadOnly = True
        Me.TXTIMP.Size = New System.Drawing.Size(227, 26)
        Me.TXTIMP.TabIndex = 1201
        Me.TXTIMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTCANT
        '
        Me.TXTCANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANT.Location = New System.Drawing.Point(120, 16)
        Me.TXTCANT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCANT.MaxLength = 20
        Me.TXTCANT.Name = "TXTCANT"
        Me.TXTCANT.Size = New System.Drawing.Size(92, 26)
        Me.TXTCANT.TabIndex = 0
        '
        'TXTVU
        '
        Me.TXTVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTVU.Location = New System.Drawing.Point(476, 128)
        Me.TXTVU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTVU.MaxLength = 20
        Me.TXTVU.Name = "TXTVU"
        Me.TXTVU.Size = New System.Drawing.Size(192, 26)
        Me.TXTVU.TabIndex = 7
        Me.TXTVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(347, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 1198
        Me.Label8.Text = "Descripción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(532, 103)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 20)
        Me.Label11.TabIndex = 1200
        Me.Label11.Text = "Valor Unitario"
        '
        'TXTDES
        '
        Me.TXTDES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDES.Location = New System.Drawing.Point(476, 54)
        Me.TXTDES.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTDES.MaxLength = 5000
        Me.TXTDES.Name = "TXTDES"
        Me.TXTDES.Size = New System.Drawing.Size(776, 26)
        Me.TXTDES.TabIndex = 2
        '
        'TXTUNI
        '
        Me.TXTUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNI.Location = New System.Drawing.Point(277, 128)
        Me.TXTUNI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTUNI.MaxLength = 20
        Me.TXTUNI.Name = "TXTUNI"
        Me.TXTUNI.Size = New System.Drawing.Size(128, 26)
        Me.TXTUNI.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(301, 103)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 20)
        Me.Label10.TabIndex = 1199
        Me.Label10.Text = "Unidad"
        '
        'BTNQUITAR
        '
        Me.BTNQUITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQUITAR.Image = CType(resources.GetObject("BTNQUITAR.Image"), System.Drawing.Image)
        Me.BTNQUITAR.Location = New System.Drawing.Point(1195, 581)
        Me.BTNQUITAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNQUITAR.Name = "BTNQUITAR"
        Me.BTNQUITAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNQUITAR.TabIndex = 1185
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.ForeColor = System.Drawing.Color.White
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(1195, 420)
        Me.BTNAGREGAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(107, 96)
        Me.BTNAGREGAR.TabIndex = 9
        Me.BTNAGREGAR.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label130)
        Me.TabPage5.Controls.Add(Me.GBIAPG)
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(Me.TXTFREL)
        Me.TabPage5.Controls.Add(Me.Label121)
        Me.TabPage5.Controls.Add(Me.CBREL)
        Me.TabPage5.Controls.Add(Me.Label120)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.TXTCOM)
        Me.TabPage5.Controls.Add(Me.Label38)
        Me.TabPage5.Controls.Add(Me.CBUSO)
        Me.TabPage5.Controls.Add(Me.LLBLP)
        Me.TabPage5.Controls.Add(Me.LLBLD)
        Me.TabPage5.Controls.Add(Me.LLBLF)
        Me.TabPage5.Controls.Add(Me.LBLTC)
        Me.TabPage5.Controls.Add(Me.TXTTC)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.CBMON)
        Me.TabPage5.Controls.Add(Me.CBCP)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.TXTTAR)
        Me.TabPage5.Controls.Add(Me.CBFP)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.CBMP)
        Me.TabPage5.Controls.Add(Me.BTNGUARDAR)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Finalizar Comprobante"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(1242, 399)
        Me.Label130.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(32, 20)
        Me.Label130.TabIndex = 1261
        Me.Label130.Text = "FA"
        '
        'GBIAPG
        '
        Me.GBIAPG.Controls.Add(Me.Label128)
        Me.GBIAPG.Controls.Add(Me.CBIAAÑO)
        Me.GBIAPG.Controls.Add(Me.CBIAPER)
        Me.GBIAPG.Controls.Add(Me.Label136)
        Me.GBIAPG.Controls.Add(Me.Label129)
        Me.GBIAPG.Controls.Add(Me.CBIAMES)
        Me.GBIAPG.Location = New System.Drawing.Point(38, 202)
        Me.GBIAPG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBIAPG.Name = "GBIAPG"
        Me.GBIAPG.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBIAPG.Size = New System.Drawing.Size(1122, 132)
        Me.GBIAPG.TabIndex = 1260
        Me.GBIAPG.TabStop = False
        Me.GBIAPG.Text = "Información Adicional ( Público en general )"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(16, 42)
        Me.Label128.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(113, 20)
        Me.Label128.TabIndex = 1252
        Me.Label128.Text = "Periodicidad"
        '
        'CBIAAÑO
        '
        Me.CBIAAÑO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIAAÑO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIAAÑO.FormattingEnabled = True
        Me.CBIAAÑO.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBIAAÑO.Location = New System.Drawing.Point(869, 75)
        Me.CBIAAÑO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBIAAÑO.Name = "CBIAAÑO"
        Me.CBIAAÑO.Size = New System.Drawing.Size(221, 28)
        Me.CBIAAÑO.TabIndex = 2
        '
        'CBIAPER
        '
        Me.CBIAPER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIAPER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIAPER.FormattingEnabled = True
        Me.CBIAPER.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBIAPER.Location = New System.Drawing.Point(14, 75)
        Me.CBIAPER.Margin = New System.Windows.Forms.Padding(4)
        Me.CBIAPER.Name = "CBIAPER"
        Me.CBIAPER.Size = New System.Drawing.Size(278, 28)
        Me.CBIAPER.TabIndex = 0
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(871, 42)
        Me.Label136.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(41, 20)
        Me.Label136.TabIndex = 1256
        Me.Label136.Text = "Año"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(323, 42)
        Me.Label129.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(138, 20)
        Me.Label129.TabIndex = 1254
        Me.Label129.Text = "Mes / Bimestre"
        '
        'CBIAMES
        '
        Me.CBIAMES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIAMES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIAMES.FormattingEnabled = True
        Me.CBIAMES.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBIAMES.Location = New System.Drawing.Point(322, 75)
        Me.CBIAMES.Margin = New System.Windows.Forms.Padding(4)
        Me.CBIAMES.Name = "CBIAMES"
        Me.CBIAMES.Size = New System.Drawing.Size(520, 28)
        Me.CBIAMES.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1006, 58)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 31)
        Me.Button6.TabIndex = 1251
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TXTFREL
        '
        Me.TXTFREL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFREL.Location = New System.Drawing.Point(194, 60)
        Me.TXTFREL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTFREL.MaxLength = 100
        Me.TXTFREL.Name = "TXTFREL"
        Me.TXTFREL.Size = New System.Drawing.Size(792, 26)
        Me.TXTFREL.TabIndex = 1
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(10, 66)
        Me.Label121.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(165, 20)
        Me.Label121.TabIndex = 1250
        Me.Label121.Text = "Folio Relacionado:"
        '
        'CBREL
        '
        Me.CBREL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBREL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBREL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBREL.FormattingEnabled = True
        Me.CBREL.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBREL.Location = New System.Drawing.Point(194, 19)
        Me.CBREL.Margin = New System.Windows.Forms.Padding(4)
        Me.CBREL.Name = "CBREL"
        Me.CBREL.Size = New System.Drawing.Size(792, 28)
        Me.CBREL.TabIndex = 0
        '
        'Label120
        '
        Me.Label120.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(47, 27)
        Me.Label120.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(128, 20)
        Me.Label120.TabIndex = 1247
        Me.Label120.Text = "Relacion Cfdi:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(41, 102)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 20)
        Me.Label17.TabIndex = 1246
        Me.Label17.Text = "Comentario"
        '
        'TXTCOM
        '
        Me.TXTCOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOM.Location = New System.Drawing.Point(48, 126)
        Me.TXTCOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCOM.MaxLength = 1000
        Me.TXTCOM.Multiline = True
        Me.TXTCOM.Name = "TXTCOM"
        Me.TXTCOM.Size = New System.Drawing.Size(1112, 56)
        Me.TXTCOM.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(167, 372)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 20)
        Me.Label38.TabIndex = 1244
        Me.Label38.Text = "Uso Cfdi:"
        '
        'CBUSO
        '
        Me.CBUSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUSO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUSO.FormattingEnabled = True
        Me.CBUSO.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBUSO.Location = New System.Drawing.Point(269, 362)
        Me.CBUSO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBUSO.Name = "CBUSO"
        Me.CBUSO.Size = New System.Drawing.Size(752, 28)
        Me.CBUSO.TabIndex = 3
        '
        'LLBLP
        '
        Me.LLBLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLP.AutoSize = True
        Me.LLBLP.Location = New System.Drawing.Point(617, 535)
        Me.LLBLP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLBLP.Name = "LLBLP"
        Me.LLBLP.Size = New System.Drawing.Size(94, 20)
        Me.LLBLP.TabIndex = 1242
        Me.LLBLP.TabStop = True
        Me.LLBLP.Text = "Dólar Hoy"
        '
        'LLBLD
        '
        Me.LLBLD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLD.AutoSize = True
        Me.LLBLD.Location = New System.Drawing.Point(449, 535)
        Me.LLBLD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLBLD.Name = "LLBLD"
        Me.LLBLD.Size = New System.Drawing.Size(94, 20)
        Me.LLBLD.TabIndex = 1241
        Me.LLBLD.TabStop = True
        Me.LLBLD.Text = "Dólar Hoy"
        '
        'LLBLF
        '
        Me.LLBLF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLF.AutoSize = True
        Me.LLBLF.Location = New System.Drawing.Point(270, 535)
        Me.LLBLF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLBLF.Name = "LLBLF"
        Me.LLBLF.Size = New System.Drawing.Size(94, 20)
        Me.LLBLF.TabIndex = 1240
        Me.LLBLF.TabStop = True
        Me.LLBLF.Text = "Dólar Hoy"
        '
        'LBLTC
        '
        Me.LBLTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLTC.AutoSize = True
        Me.LBLTC.Location = New System.Drawing.Point(46, 535)
        Me.LBLTC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTC.Name = "LBLTC"
        Me.LBLTC.Size = New System.Drawing.Size(94, 20)
        Me.LBLTC.TabIndex = 1239
        Me.LBLTC.TabStop = True
        Me.LBLTC.Text = "Dólar Hoy"
        '
        'TXTTC
        '
        Me.TXTTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTC.Location = New System.Drawing.Point(939, 527)
        Me.TXTTC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTTC.MaxLength = 15
        Me.TXTTC.Name = "TXTTC"
        Me.TXTTC.Size = New System.Drawing.Size(128, 26)
        Me.TXTTC.TabIndex = 1237
        Me.TXTTC.Text = "1.0"
        Me.TXTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(790, 535)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 20)
        Me.Label29.TabIndex = 1238
        Me.Label29.Text = "Tipo Cambio"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(950, 467)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 20)
        Me.Label28.TabIndex = 1236
        Me.Label28.Text = "Moneda"
        '
        'CBMON
        '
        Me.CBMON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBMON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMON.FormattingEnabled = True
        Me.CBMON.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBMON.Location = New System.Drawing.Point(939, 490)
        Me.CBMON.Margin = New System.Windows.Forms.Padding(4)
        Me.CBMON.Name = "CBMON"
        Me.CBMON.Size = New System.Drawing.Size(263, 28)
        Me.CBMON.TabIndex = 8
        '
        'CBCP
        '
        Me.CBCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCP.FormattingEnabled = True
        Me.CBCP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCP.Location = New System.Drawing.Point(269, 405)
        Me.CBCP.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCP.Name = "CBCP"
        Me.CBCP.Size = New System.Drawing.Size(340, 28)
        Me.CBCP.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(47, 415)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(192, 20)
        Me.Label19.TabIndex = 1233
        Me.Label19.Text = "Condiciones de Pago:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 467)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 1230
        Me.Label4.Text = "Forma de Pago"
        '
        'TXTTAR
        '
        Me.TXTTAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTAR.Location = New System.Drawing.Point(790, 493)
        Me.TXTTAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTTAR.MaxLength = 4
        Me.TXTTAR.Name = "TXTTAR"
        Me.TXTTAR.Size = New System.Drawing.Size(128, 26)
        Me.TXTTAR.TabIndex = 7
        '
        'CBFP
        '
        Me.CBFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFP.FormattingEnabled = True
        Me.CBFP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFP.Location = New System.Drawing.Point(347, 490)
        Me.CBFP.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFP.Name = "CBFP"
        Me.CBFP.Size = New System.Drawing.Size(403, 28)
        Me.CBFP.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(790, 419)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 68)
        Me.Label16.TabIndex = 1232
        Me.Label16.Text = "4 dígitos Tarjeta o Cheque"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 468)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 1231
        Me.Label6.Text = "Método de Pago"
        '
        'CBMP
        '
        Me.CBMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMP.FormattingEnabled = True
        Me.CBMP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBMP.Location = New System.Drawing.Point(46, 490)
        Me.CBMP.Margin = New System.Windows.Forms.Padding(4)
        Me.CBMP.Name = "CBMP"
        Me.CBMP.Size = New System.Drawing.Size(271, 28)
        Me.CBMP.TabIndex = 5
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.White
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(1115, 362)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNGUARDAR.TabIndex = 9
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.RB7)
        Me.TabPage2.Controls.Add(Me.RB1)
        Me.TabPage2.Controls.Add(Me.RB2)
        Me.TabPage2.Controls.Add(Me.GB2)
        Me.TabPage2.Controls.Add(Me.GB1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complemento INE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(51, 690)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(236, 20)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://sif.ine.mx/loginUTF/"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 657)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(479, 20)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Lugar donde el cliente puede obtener el Id Contabilidad "
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(719, 495)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(569, 141)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = resources.GetString("Label22.Text")
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(49, 495)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(639, 141)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = resources.GetString("Label23.Text")
        '
        'RB7
        '
        Me.RB7.AutoSize = True
        Me.RB7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB7.Location = New System.Drawing.Point(1033, 22)
        Me.RB7.Margin = New System.Windows.Forms.Padding(4)
        Me.RB7.Name = "RB7"
        Me.RB7.Size = New System.Drawing.Size(143, 24)
        Me.RB7.TabIndex = 24
        Me.RB7.Text = "Pre Campaña"
        Me.RB7.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(49, 22)
        Me.RB1.Margin = New System.Windows.Forms.Padding(4)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(108, 24)
        Me.RB1.TabIndex = 23
        Me.RB1.Text = "Ordinario"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Checked = True
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(727, 22)
        Me.RB2.Margin = New System.Windows.Forms.Padding(4)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(108, 24)
        Me.RB2.TabIndex = 22
        Me.RB2.TabStop = True
        Me.RB2.Text = "Campaña"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.BTNQC)
        Me.GB2.Controls.Add(Me.BTNAC)
        Me.GB2.Controls.Add(Me.LBC)
        Me.GB2.Controls.Add(Me.Label24)
        Me.GB2.Controls.Add(Me.TXTCC)
        Me.GB2.Controls.Add(Me.CBEC)
        Me.GB2.Controls.Add(Me.Label25)
        Me.GB2.Controls.Add(Me.RB5)
        Me.GB2.Controls.Add(Me.RB6)
        Me.GB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB2.Location = New System.Drawing.Point(719, 43)
        Me.GB2.Margin = New System.Windows.Forms.Padding(4)
        Me.GB2.Name = "GB2"
        Me.GB2.Padding = New System.Windows.Forms.Padding(4)
        Me.GB2.Size = New System.Drawing.Size(569, 437)
        Me.GB2.TabIndex = 21
        Me.GB2.TabStop = False
        '
        'BTNQC
        '
        Me.BTNQC.BackColor = System.Drawing.SystemColors.Control
        Me.BTNQC.Image = CType(resources.GetObject("BTNQC.Image"), System.Drawing.Image)
        Me.BTNQC.Location = New System.Drawing.Point(289, 25)
        Me.BTNQC.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNQC.Name = "BTNQC"
        Me.BTNQC.Size = New System.Drawing.Size(100, 92)
        Me.BTNQC.TabIndex = 19
        Me.BTNQC.UseVisualStyleBackColor = False
        '
        'BTNAC
        '
        Me.BTNAC.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAC.Image = CType(resources.GetObject("BTNAC.Image"), System.Drawing.Image)
        Me.BTNAC.Location = New System.Drawing.Point(167, 25)
        Me.BTNAC.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAC.Name = "BTNAC"
        Me.BTNAC.Size = New System.Drawing.Size(100, 92)
        Me.BTNAC.TabIndex = 18
        Me.BTNAC.UseVisualStyleBackColor = False
        '
        'LBC
        '
        Me.LBC.FormattingEnabled = True
        Me.LBC.ItemHeight = 20
        Me.LBC.Location = New System.Drawing.Point(8, 177)
        Me.LBC.Margin = New System.Windows.Forms.Padding(4)
        Me.LBC.Name = "LBC"
        Me.LBC.Size = New System.Drawing.Size(552, 224)
        Me.LBC.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 66)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 20)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Id Contabilidad"
        '
        'TXTCC
        '
        Me.TXTCC.Location = New System.Drawing.Point(8, 90)
        Me.TXTCC.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCC.MaxLength = 6
        Me.TXTCC.Name = "TXTCC"
        Me.TXTCC.Size = New System.Drawing.Size(149, 26)
        Me.TXTCC.TabIndex = 15
        '
        'CBEC
        '
        Me.CBEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEC.FormattingEnabled = True
        Me.CBEC.Location = New System.Drawing.Point(8, 127)
        Me.CBEC.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEC.Name = "CBEC"
        Me.CBEC.Size = New System.Drawing.Size(552, 28)
        Me.CBEC.TabIndex = 14
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(420, 20)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 20)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Ámbito"
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Location = New System.Drawing.Point(424, 58)
        Me.RB5.Margin = New System.Windows.Forms.Padding(4)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(76, 24)
        Me.RB5.TabIndex = 12
        Me.RB5.TabStop = True
        Me.RB5.Text = "Local"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB6
        '
        Me.RB6.AutoSize = True
        Me.RB6.Location = New System.Drawing.Point(424, 90)
        Me.RB6.Margin = New System.Windows.Forms.Padding(4)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(93, 24)
        Me.RB6.TabIndex = 11
        Me.RB6.TabStop = True
        Me.RB6.Text = "Federal"
        Me.RB6.UseVisualStyleBackColor = True
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.BTNQO)
        Me.GB1.Controls.Add(Me.BTNAO)
        Me.GB1.Controls.Add(Me.LBO)
        Me.GB1.Controls.Add(Me.Label26)
        Me.GB1.Controls.Add(Me.TXTCO)
        Me.GB1.Controls.Add(Me.CBEO)
        Me.GB1.Controls.Add(Me.Label27)
        Me.GB1.Controls.Add(Me.RB3)
        Me.GB1.Controls.Add(Me.RB4)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(41, 43)
        Me.GB1.Margin = New System.Windows.Forms.Padding(4)
        Me.GB1.Name = "GB1"
        Me.GB1.Padding = New System.Windows.Forms.Padding(4)
        Me.GB1.Size = New System.Drawing.Size(647, 437)
        Me.GB1.TabIndex = 20
        Me.GB1.TabStop = False
        '
        'BTNQO
        '
        Me.BTNQO.BackColor = System.Drawing.SystemColors.Control
        Me.BTNQO.Image = CType(resources.GetObject("BTNQO.Image"), System.Drawing.Image)
        Me.BTNQO.Location = New System.Drawing.Point(289, 27)
        Me.BTNQO.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNQO.Name = "BTNQO"
        Me.BTNQO.Size = New System.Drawing.Size(100, 92)
        Me.BTNQO.TabIndex = 10
        Me.BTNQO.UseVisualStyleBackColor = False
        '
        'BTNAO
        '
        Me.BTNAO.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAO.Image = CType(resources.GetObject("BTNAO.Image"), System.Drawing.Image)
        Me.BTNAO.Location = New System.Drawing.Point(167, 27)
        Me.BTNAO.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAO.Name = "BTNAO"
        Me.BTNAO.Size = New System.Drawing.Size(100, 92)
        Me.BTNAO.TabIndex = 9
        Me.BTNAO.UseVisualStyleBackColor = False
        '
        'LBO
        '
        Me.LBO.FormattingEnabled = True
        Me.LBO.ItemHeight = 20
        Me.LBO.Location = New System.Drawing.Point(8, 177)
        Me.LBO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBO.Name = "LBO"
        Me.LBO.Size = New System.Drawing.Size(623, 224)
        Me.LBO.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 69)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(134, 20)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Id Contabilidad"
        '
        'TXTCO
        '
        Me.TXTCO.Location = New System.Drawing.Point(8, 92)
        Me.TXTCO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCO.MaxLength = 6
        Me.TXTCO.Name = "TXTCO"
        Me.TXTCO.Size = New System.Drawing.Size(149, 26)
        Me.TXTCO.TabIndex = 6
        '
        'CBEO
        '
        Me.CBEO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEO.FormattingEnabled = True
        Me.CBEO.Location = New System.Drawing.Point(8, 127)
        Me.CBEO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEO.Name = "CBEO"
        Me.CBEO.Size = New System.Drawing.Size(623, 28)
        Me.CBEO.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(420, 22)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 20)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Tipo Comité"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(424, 60)
        Me.RB3.Margin = New System.Windows.Forms.Padding(4)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(172, 24)
        Me.RB3.TabIndex = 1
        Me.RB3.TabStop = True
        Me.RB3.Text = "Ejecutivo Estatal"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Location = New System.Drawing.Point(424, 92)
        Me.RB4.Margin = New System.Windows.Forms.Padding(4)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(186, 24)
        Me.RB4.TabIndex = 0
        Me.RB4.TabStop = True
        Me.RB4.Text = "Ejecutivo Nacional"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label88)
        Me.TabPage4.Controls.Add(Me.Label64)
        Me.TabPage4.Controls.Add(Me.TXTCEOBS)
        Me.TabPage4.Controls.Add(Me.Label63)
        Me.TabPage4.Controls.Add(Me.GBCEDES)
        Me.TabPage4.Controls.Add(Me.CBCEINCO)
        Me.TabPage4.Controls.Add(Me.Label49)
        Me.TabPage4.Controls.Add(Me.Label48)
        Me.TabPage4.Controls.Add(Me.TXTCETUSD)
        Me.TabPage4.Controls.Add(Me.Label47)
        Me.TabPage4.Controls.Add(Me.TXTCETC)
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.CBCESUB)
        Me.TabPage4.Controls.Add(Me.Label45)
        Me.TabPage4.Controls.Add(Me.Label44)
        Me.TabPage4.Controls.Add(Me.TXTCECURP)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.TXTCERFP)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.Label41)
        Me.TabPage4.Controls.Add(Me.TXTCENCO)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.TXTCECO)
        Me.TabPage4.Controls.Add(Me.CHKCEDD)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.TXTCECPED)
        Me.TabPage4.Controls.Add(Me.CBCETO)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Complemento Comercio Exterior"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(693, 74)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(211, 20)
        Me.Label88.TabIndex = 1216
        Me.Label88.Text = "* 20-5718444 (Meridian)"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(360, 599)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(134, 20)
        Me.Label64.TabIndex = 1215
        Me.Label64.Text = "Observaciones"
        '
        'TXTCEOBS
        '
        Me.TXTCEOBS.Location = New System.Drawing.Point(364, 622)
        Me.TXTCEOBS.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCEOBS.MaxLength = 5000
        Me.TXTCEOBS.Multiline = True
        Me.TXTCEOBS.Name = "TXTCEOBS"
        Me.TXTCEOBS.Size = New System.Drawing.Size(916, 68)
        Me.TXTCEOBS.TabIndex = 1214
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(364, 535)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(95, 20)
        Me.Label63.TabIndex = 1213
        Me.Label63.Text = "Incoterm *"
        '
        'GBCEDES
        '
        Me.GBCEDES.Controls.Add(Me.Label62)
        Me.GBCEDES.Controls.Add(Me.CBCEPAIS)
        Me.GBCEDES.Controls.Add(Me.Label61)
        Me.GBCEDES.Controls.Add(Me.CBCEEDO)
        Me.GBCEDES.Controls.Add(Me.TXTCEREF)
        Me.GBCEDES.Controls.Add(Me.Label60)
        Me.GBCEDES.Controls.Add(Me.TXTCENOINT)
        Me.GBCEDES.Controls.Add(Me.Label59)
        Me.GBCEDES.Controls.Add(Me.TXTCENOEXT)
        Me.GBCEDES.Controls.Add(Me.Label58)
        Me.GBCEDES.Controls.Add(Me.TXTCEMUN)
        Me.GBCEDES.Controls.Add(Me.Label57)
        Me.GBCEDES.Controls.Add(Me.TXTCELOC)
        Me.GBCEDES.Controls.Add(Me.Label56)
        Me.GBCEDES.Controls.Add(Me.TXTCECP)
        Me.GBCEDES.Controls.Add(Me.Label55)
        Me.GBCEDES.Controls.Add(Me.TextBox14)
        Me.GBCEDES.Controls.Add(Me.Label54)
        Me.GBCEDES.Controls.Add(Me.TXTCECALLE)
        Me.GBCEDES.Controls.Add(Me.Label53)
        Me.GBCEDES.Controls.Add(Me.TXTCEDDNOM)
        Me.GBCEDES.Controls.Add(Me.Label52)
        Me.GBCEDES.Controls.Add(Me.TXTCEDDCURP)
        Me.GBCEDES.Controls.Add(Me.Label51)
        Me.GBCEDES.Controls.Add(Me.TXTCERFC)
        Me.GBCEDES.Controls.Add(Me.Label50)
        Me.GBCEDES.Enabled = False
        Me.GBCEDES.Location = New System.Drawing.Point(364, 169)
        Me.GBCEDES.Margin = New System.Windows.Forms.Padding(4)
        Me.GBCEDES.Name = "GBCEDES"
        Me.GBCEDES.Padding = New System.Windows.Forms.Padding(4)
        Me.GBCEDES.Size = New System.Drawing.Size(917, 363)
        Me.GBCEDES.TabIndex = 1188
        Me.GBCEDES.TabStop = False
        Me.GBCEDES.Text = "Destinatario"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(472, 293)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(65, 20)
        Me.Label62.TabIndex = 1211
        Me.Label62.Text = "* País:"
        '
        'CBCEPAIS
        '
        Me.CBCEPAIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEPAIS.FormattingEnabled = True
        Me.CBCEPAIS.Location = New System.Drawing.Point(551, 287)
        Me.CBCEPAIS.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCEPAIS.Name = "CBCEPAIS"
        Me.CBCEPAIS.Size = New System.Drawing.Size(317, 28)
        Me.CBCEPAIS.TabIndex = 1210
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(49, 293)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(86, 20)
        Me.Label61.TabIndex = 1209
        Me.Label61.Text = "* Estado:"
        '
        'CBCEEDO
        '
        Me.CBCEEDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEEDO.FormattingEnabled = True
        Me.CBCEEDO.Location = New System.Drawing.Point(152, 287)
        Me.CBCEEDO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCEEDO.Name = "CBCEEDO"
        Me.CBCEEDO.Size = New System.Drawing.Size(268, 28)
        Me.CBCEEDO.TabIndex = 1208
        '
        'TXTCEREF
        '
        Me.TXTCEREF.Location = New System.Drawing.Point(152, 324)
        Me.TXTCEREF.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCEREF.MaxLength = 200
        Me.TXTCEREF.Name = "TXTCEREF"
        Me.TXTCEREF.Size = New System.Drawing.Size(716, 26)
        Me.TXTCEREF.TabIndex = 1207
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(27, 324)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(106, 20)
        Me.Label60.TabIndex = 1206
        Me.Label60.Text = "Referencia:"
        '
        'TXTCENOINT
        '
        Me.TXTCENOINT.Location = New System.Drawing.Point(551, 251)
        Me.TXTCENOINT.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCENOINT.MaxLength = 200
        Me.TXTCENOINT.Name = "TXTCENOINT"
        Me.TXTCENOINT.Size = New System.Drawing.Size(317, 26)
        Me.TXTCENOINT.TabIndex = 1205
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(425, 255)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(109, 20)
        Me.Label59.TabIndex = 1204
        Me.Label59.Text = "No. Interior:"
        '
        'TXTCENOEXT
        '
        Me.TXTCENOEXT.Location = New System.Drawing.Point(152, 251)
        Me.TXTCENOEXT.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCENOEXT.MaxLength = 200
        Me.TXTCENOEXT.Name = "TXTCENOEXT"
        Me.TXTCENOEXT.Size = New System.Drawing.Size(264, 26)
        Me.TXTCENOEXT.TabIndex = 1203
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(20, 255)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(115, 20)
        Me.Label58.TabIndex = 1202
        Me.Label58.Text = "No. Exterior:"
        '
        'TXTCEMUN
        '
        Me.TXTCEMUN.Location = New System.Drawing.Point(551, 217)
        Me.TXTCEMUN.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCEMUN.MaxLength = 200
        Me.TXTCEMUN.Name = "TXTCEMUN"
        Me.TXTCEMUN.Size = New System.Drawing.Size(317, 26)
        Me.TXTCEMUN.TabIndex = 1201
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(439, 220)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(95, 20)
        Me.Label57.TabIndex = 1200
        Me.Label57.Text = "Municipio:"
        '
        'TXTCELOC
        '
        Me.TXTCELOC.Location = New System.Drawing.Point(152, 217)
        Me.TXTCELOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCELOC.MaxLength = 200
        Me.TXTCELOC.Name = "TXTCELOC"
        Me.TXTCELOC.Size = New System.Drawing.Size(264, 26)
        Me.TXTCELOC.TabIndex = 1199
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(36, 220)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(96, 20)
        Me.Label56.TabIndex = 1198
        Me.Label56.Text = "Localidad:"
        '
        'TXTCECP
        '
        Me.TXTCECP.Location = New System.Drawing.Point(551, 182)
        Me.TXTCECP.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCECP.MaxLength = 200
        Me.TXTCECP.Name = "TXTCECP"
        Me.TXTCECP.Size = New System.Drawing.Size(317, 26)
        Me.TXTCECP.TabIndex = 1197
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(481, 186)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(57, 20)
        Me.Label55.TabIndex = 1196
        Me.Label55.Text = "*C.P.:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(152, 182)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.MaxLength = 200
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(264, 26)
        Me.TextBox14.TabIndex = 1195
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(57, 186)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 20)
        Me.Label54.TabIndex = 1194
        Me.Label54.Text = "Colonia:"
        '
        'TXTCECALLE
        '
        Me.TXTCECALLE.Location = New System.Drawing.Point(152, 148)
        Me.TXTCECALLE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCECALLE.MaxLength = 200
        Me.TXTCECALLE.Name = "TXTCECALLE"
        Me.TXTCECALLE.Size = New System.Drawing.Size(716, 26)
        Me.TXTCECALLE.TabIndex = 1193
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(72, 151)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(65, 20)
        Me.Label53.TabIndex = 1192
        Me.Label53.Text = "*Calle:"
        '
        'TXTCEDDNOM
        '
        Me.TXTCEDDNOM.Location = New System.Drawing.Point(152, 101)
        Me.TXTCEDDNOM.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCEDDNOM.MaxLength = 200
        Me.TXTCEDDNOM.Name = "TXTCEDDNOM"
        Me.TXTCEDDNOM.Size = New System.Drawing.Size(716, 26)
        Me.TXTCEDDNOM.TabIndex = 1191
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(55, 105)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(80, 20)
        Me.Label52.TabIndex = 1190
        Me.Label52.Text = "Nombre:"
        '
        'TXTCEDDCURP
        '
        Me.TXTCEDDCURP.Location = New System.Drawing.Point(152, 65)
        Me.TXTCEDDCURP.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCEDDCURP.MaxLength = 200
        Me.TXTCEDDCURP.Name = "TXTCEDDCURP"
        Me.TXTCEDDCURP.Size = New System.Drawing.Size(716, 26)
        Me.TXTCEDDCURP.TabIndex = 1189
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(72, 69)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(66, 20)
        Me.Label51.TabIndex = 1188
        Me.Label51.Text = "CURP:"
        '
        'TXTCERFC
        '
        Me.TXTCERFC.Location = New System.Drawing.Point(152, 26)
        Me.TXTCERFC.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCERFC.MaxLength = 200
        Me.TXTCERFC.Name = "TXTCERFC"
        Me.TXTCERFC.Size = New System.Drawing.Size(716, 26)
        Me.TXTCERFC.TabIndex = 1187
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(88, 30)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(52, 20)
        Me.Label50.TabIndex = 1186
        Me.Label50.Text = "RFC:"
        '
        'CBCEINCO
        '
        Me.CBCEINCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEINCO.FormattingEnabled = True
        Me.CBCEINCO.Location = New System.Drawing.Point(364, 558)
        Me.CBCEINCO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCEINCO.Name = "CBCEINCO"
        Me.CBCEINCO.Size = New System.Drawing.Size(916, 28)
        Me.CBCEINCO.TabIndex = 1212
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(19, 670)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(186, 20)
        Me.Label49.TabIndex = 1187
        Me.Label49.Text = "* Campos Requiridos"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(19, 560)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(109, 20)
        Me.Label48.TabIndex = 1186
        Me.Label48.Text = "Total USD *"
        '
        'TXTCETUSD
        '
        Me.TXTCETUSD.Enabled = False
        Me.TXTCETUSD.Location = New System.Drawing.Point(19, 583)
        Me.TXTCETUSD.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCETUSD.MaxLength = 50
        Me.TXTCETUSD.Name = "TXTCETUSD"
        Me.TXTCETUSD.ReadOnly = True
        Me.TXTCETUSD.Size = New System.Drawing.Size(276, 26)
        Me.TXTCETUSD.TabIndex = 1185
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(19, 492)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(172, 20)
        Me.Label47.TabIndex = 1184
        Me.Label47.Text = "Tipo Cambio USD *"
        '
        'TXTCETC
        '
        Me.TXTCETC.Enabled = False
        Me.TXTCETC.Location = New System.Drawing.Point(19, 515)
        Me.TXTCETC.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCETC.MaxLength = 50
        Me.TXTCETC.Name = "TXTCETC"
        Me.TXTCETC.ReadOnly = True
        Me.TXTCETC.Size = New System.Drawing.Size(276, 26)
        Me.TXTCETC.TabIndex = 1183
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(29, 415)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(128, 20)
        Me.Label46.TabIndex = 1182
        Me.Label46.Text = "Sub División *"
        '
        'CBCESUB
        '
        Me.CBCESUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCESUB.FormattingEnabled = True
        Me.CBCESUB.Items.AddRange(New Object() {"0 - No tiene", "1 - Si tiene"})
        Me.CBCESUB.Location = New System.Drawing.Point(29, 438)
        Me.CBCESUB.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCESUB.Name = "CBCESUB"
        Me.CBCESUB.Size = New System.Drawing.Size(276, 28)
        Me.CBCESUB.TabIndex = 1181
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(29, 41)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(150, 20)
        Me.Label45.TabIndex = 1180
        Me.Label45.Text = "Tipo Operación *"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(404, 102)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(324, 20)
        Me.Label44.TabIndex = 1179
        Me.Label44.Text = "CURP Receptor (Solo persona física)"
        '
        'TXTCECURP
        '
        Me.TXTCECURP.Location = New System.Drawing.Point(404, 126)
        Me.TXTCECURP.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCECURP.MaxLength = 50
        Me.TXTCECURP.Name = "TXTCECURP"
        Me.TXTCECURP.Size = New System.Drawing.Size(280, 26)
        Me.TXTCECURP.TabIndex = 1178
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(404, 43)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(338, 20)
        Me.Label43.TabIndex = 1177
        Me.Label43.Text = "Identificación o Registro fiscal del país"
        '
        'TXTCERFP
        '
        Me.TXTCERFP.Location = New System.Drawing.Point(404, 66)
        Me.TXTCERFP.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCERFP.MaxLength = 50
        Me.TXTCERFP.Name = "TXTCERFP"
        Me.TXTCERFP.Size = New System.Drawing.Size(280, 26)
        Me.TXTCERFP.TabIndex = 1176
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(29, 300)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(256, 20)
        Me.Label42.TabIndex = 1175
        Me.Label42.Text = "Número Exportador Confiable"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(29, 324)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(276, 26)
        Me.TextBox5.TabIndex = 1174
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(29, 241)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(234, 20)
        Me.Label41.TabIndex = 1173
        Me.Label41.Text = "Número Certificado Origen"
        '
        'TXTCENCO
        '
        Me.TXTCENCO.Location = New System.Drawing.Point(29, 265)
        Me.TXTCENCO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCENCO.MaxLength = 50
        Me.TXTCENCO.Name = "TXTCENCO"
        Me.TXTCENCO.Size = New System.Drawing.Size(276, 26)
        Me.TXTCENCO.TabIndex = 1172
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(29, 180)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(176, 20)
        Me.Label40.TabIndex = 1171
        Me.Label40.Text = "Certificado Origen *"
        '
        'TXTCECO
        '
        Me.TXTCECO.Location = New System.Drawing.Point(29, 203)
        Me.TXTCECO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCECO.MaxLength = 50
        Me.TXTCECO.Name = "TXTCECO"
        Me.TXTCECO.Size = New System.Drawing.Size(276, 26)
        Me.TXTCECO.TabIndex = 1170
        Me.TXTCECO.Text = "0"
        '
        'CHKCEDD
        '
        Me.CHKCEDD.AutoSize = True
        Me.CHKCEDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCEDD.Location = New System.Drawing.Point(984, 66)
        Me.CHKCEDD.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKCEDD.Name = "CHKCEDD"
        Me.CHKCEDD.Size = New System.Drawing.Size(218, 24)
        Me.CHKCEDD.TabIndex = 1169
        Me.CHKCEDD.Text = "Destinatario Diferente"
        Me.CHKCEDD.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(29, 117)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(163, 20)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Clave Pedimento *"
        '
        'TXTCECPED
        '
        Me.TXTCECPED.Location = New System.Drawing.Point(29, 140)
        Me.TXTCECPED.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCECPED.MaxLength = 50
        Me.TXTCECPED.Name = "TXTCECPED"
        Me.TXTCECPED.Size = New System.Drawing.Size(276, 26)
        Me.TXTCECPED.TabIndex = 17
        Me.TXTCECPED.Text = "A1"
        '
        'CBCETO
        '
        Me.CBCETO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCETO.FormattingEnabled = True
        Me.CBCETO.Items.AddRange(New Object() {"Exportación", "Exportación de servicios"})
        Me.CBCETO.Location = New System.Drawing.Point(29, 64)
        Me.CBCETO.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCETO.Name = "CBCETO"
        Me.CBCETO.Size = New System.Drawing.Size(276, 28)
        Me.CBCETO.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DTHORA)
        Me.TabPage6.Controls.Add(Me.BTNBCER)
        Me.TabPage6.Controls.Add(Me.CBCRPTCP)
        Me.TabPage6.Controls.Add(Me.DGVCRP)
        Me.TabPage6.Controls.Add(Me.Label92)
        Me.TabPage6.Controls.Add(Me.TXTCRPSELLO)
        Me.TabPage6.Controls.Add(Me.Label87)
        Me.TabPage6.Controls.Add(Me.TXTCRPCAD)
        Me.TabPage6.Controls.Add(Me.Label86)
        Me.TabPage6.Controls.Add(Me.TXTCRPCER)
        Me.TabPage6.Controls.Add(Me.Label85)
        Me.TabPage6.Controls.Add(Me.Label84)
        Me.TabPage6.Controls.Add(Me.TXTCRPCB)
        Me.TabPage6.Controls.Add(Me.Label83)
        Me.TabPage6.Controls.Add(Me.TXTCRPRFCCB)
        Me.TabPage6.Controls.Add(Me.Label82)
        Me.TabPage6.Controls.Add(Me.TXTCRPCO)
        Me.TabPage6.Controls.Add(Me.Label81)
        Me.TabPage6.Controls.Add(Me.TXTCRPNBCO)
        Me.TabPage6.Controls.Add(Me.Label80)
        Me.TabPage6.Controls.Add(Me.TXTCRPRFCCO)
        Me.TabPage6.Controls.Add(Me.Label79)
        Me.TabPage6.Controls.Add(Me.TXTCRPNOPE)
        Me.TabPage6.Controls.Add(Me.Label78)
        Me.TabPage6.Controls.Add(Me.TXTCRPTC)
        Me.TabPage6.Controls.Add(Me.Label77)
        Me.TabPage6.Controls.Add(Me.Label76)
        Me.TabPage6.Controls.Add(Me.CBCRPMON)
        Me.TabPage6.Controls.Add(Me.Label75)
        Me.TabPage6.Controls.Add(Me.CBCRPFP)
        Me.TabPage6.Controls.Add(Me.DTPCRPFP)
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.BTNCRPAGREGAR)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Complemento Recepción Pagos"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DTHORA
        '
        Me.DTHORA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHORA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTHORA.Location = New System.Drawing.Point(788, 30)
        Me.DTHORA.Margin = New System.Windows.Forms.Padding(4)
        Me.DTHORA.Name = "DTHORA"
        Me.DTHORA.ShowUpDown = True
        Me.DTHORA.Size = New System.Drawing.Size(207, 30)
        Me.DTHORA.TabIndex = 1508
        Me.DTHORA.Value = New Date(2018, 9, 1, 12, 0, 0, 0)
        '
        'BTNBCER
        '
        Me.BTNBCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBCER.Location = New System.Drawing.Point(1240, 291)
        Me.BTNBCER.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNBCER.Name = "BTNBCER"
        Me.BTNBCER.Size = New System.Drawing.Size(72, 41)
        Me.BTNBCER.TabIndex = 1505
        Me.BTNBCER.Text = "..."
        Me.BTNBCER.UseVisualStyleBackColor = True
        '
        'CBCRPTCP
        '
        Me.CBCRPTCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPTCP.FormattingEnabled = True
        Me.CBCRPTCP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPTCP.Location = New System.Drawing.Point(859, 224)
        Me.CBCRPTCP.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCRPTCP.Name = "CBCRPTCP"
        Me.CBCRPTCP.Size = New System.Drawing.Size(375, 28)
        Me.CBCRPTCP.TabIndex = 1504
        '
        'DGVCRP
        '
        Me.DGVCRP.AllowUserToAddRows = False
        Me.DGVCRP.AllowUserToDeleteRows = False
        Me.DGVCRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serie, Me.CFolio, Me.UUID, Me.TotalComprobante, Me.SaldoAnterior, Me.NumParcialidad, Me.Importe, Me.NuevoSaldo})
        Me.DGVCRP.Location = New System.Drawing.Point(15, 415)
        Me.DGVCRP.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVCRP.Name = "DGVCRP"
        Me.DGVCRP.Size = New System.Drawing.Size(1169, 270)
        Me.DGVCRP.TabIndex = 1503
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'CFolio
        '
        Me.CFolio.HeaderText = "CFolio"
        Me.CFolio.Name = "CFolio"
        Me.CFolio.ReadOnly = True
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        '
        'TotalComprobante
        '
        Me.TotalComprobante.HeaderText = "Total Comprobante"
        Me.TotalComprobante.Name = "TotalComprobante"
        Me.TotalComprobante.ReadOnly = True
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.HeaderText = "Saldo Anterior"
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.ReadOnly = True
        '
        'NumParcialidad
        '
        Me.NumParcialidad.HeaderText = "Num Parcialidad"
        Me.NumParcialidad.Name = "NumParcialidad"
        Me.NumParcialidad.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'NuevoSaldo
        '
        Me.NuevoSaldo.HeaderText = "Nuevo Saldo"
        Me.NuevoSaldo.Name = "NuevoSaldo"
        Me.NuevoSaldo.ReadOnly = True
        '
        'Label92
        '
        Me.Label92.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(437, 42)
        Me.Label92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(147, 20)
        Me.Label92.TabIndex = 1269
        Me.Label92.Text = "* Fecha de Pago"
        '
        'TXTCRPSELLO
        '
        Me.TXTCRPSELLO.Enabled = False
        Me.TXTCRPSELLO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPSELLO.Location = New System.Drawing.Point(204, 380)
        Me.TXTCRPSELLO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPSELLO.MaxLength = 20
        Me.TXTCRPSELLO.Name = "TXTCRPSELLO"
        Me.TXTCRPSELLO.ReadOnly = True
        Me.TXTCRPSELLO.Size = New System.Drawing.Size(1028, 26)
        Me.TXTCRPSELLO.TabIndex = 1259
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(81, 383)
        Me.Label87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(99, 20)
        Me.Label87.TabIndex = 1260
        Me.Label87.Text = "Sello Pago"
        '
        'TXTCRPCAD
        '
        Me.TXTCRPCAD.Enabled = False
        Me.TXTCRPCAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCAD.Location = New System.Drawing.Point(204, 343)
        Me.TXTCRPCAD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPCAD.MaxLength = 20
        Me.TXTCRPCAD.Name = "TXTCRPCAD"
        Me.TXTCRPCAD.ReadOnly = True
        Me.TXTCRPCAD.Size = New System.Drawing.Size(1028, 26)
        Me.TXTCRPCAD.TabIndex = 1257
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(57, 344)
        Me.Label86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(120, 20)
        Me.Label86.TabIndex = 1258
        Me.Label86.Text = "Cadena Pago"
        '
        'TXTCRPCER
        '
        Me.TXTCRPCER.Enabled = False
        Me.TXTCRPCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCER.Location = New System.Drawing.Point(204, 305)
        Me.TXTCRPCER.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPCER.MaxLength = 20
        Me.TXTCRPCER.Name = "TXTCRPCER"
        Me.TXTCRPCER.ReadOnly = True
        Me.TXTCRPCER.Size = New System.Drawing.Size(1028, 26)
        Me.TXTCRPCER.TabIndex = 1255
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(29, 309)
        Me.Label85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(149, 20)
        Me.Label85.TabIndex = 1256
        Me.Label85.Text = "Certificado Pago"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(663, 225)
        Me.Label84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(162, 20)
        Me.Label84.TabIndex = 1254
        Me.Label84.Text = "Tipo Cadena Pago"
        '
        'TXTCRPCB
        '
        Me.TXTCRPCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCB.Location = New System.Drawing.Point(859, 184)
        Me.TXTCRPCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPCB.MaxLength = 20
        Me.TXTCRPCB.Name = "TXTCRPCB"
        Me.TXTCRPCB.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPCB.TabIndex = 1251
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(691, 189)
        Me.Label83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(145, 20)
        Me.Label83.TabIndex = 1252
        Me.Label83.Text = "Cta Beneficiario"
        '
        'TXTCRPRFCCB
        '
        Me.TXTCRPRFCCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPRFCCB.Location = New System.Drawing.Point(859, 147)
        Me.TXTCRPRFCCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPRFCCB.MaxLength = 20
        Me.TXTCRPRFCCB.Name = "TXTCRPRFCCB"
        Me.TXTCRPRFCCB.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPRFCCB.TabIndex = 1249
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(660, 151)
        Me.Label82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(177, 20)
        Me.Label82.TabIndex = 1250
        Me.Label82.Text = "Rfc Emisor Cta Ben"
        '
        'TXTCRPCO
        '
        Me.TXTCRPCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCO.Location = New System.Drawing.Point(251, 251)
        Me.TXTCRPCO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPCO.MaxLength = 20
        Me.TXTCRPCO.Name = "TXTCRPCO"
        Me.TXTCRPCO.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPCO.TabIndex = 1247
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(100, 255)
        Me.Label81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(131, 20)
        Me.Label81.TabIndex = 1248
        Me.Label81.Text = "Cta Ordenante"
        '
        'TXTCRPNBCO
        '
        Me.TXTCRPNBCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPNBCO.Location = New System.Drawing.Point(251, 216)
        Me.TXTCRPNBCO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPNBCO.MaxLength = 20
        Me.TXTCRPNBCO.Name = "TXTCRPNBCO"
        Me.TXTCRPNBCO.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPNBCO.TabIndex = 1245
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(53, 219)
        Me.Label80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(176, 20)
        Me.Label80.TabIndex = 1246
        Me.Label80.Text = "Nom Banco Ord Ext"
        '
        'TXTCRPRFCCO
        '
        Me.TXTCRPRFCCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPRFCCO.Location = New System.Drawing.Point(251, 182)
        Me.TXTCRPRFCCO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPRFCCO.MaxLength = 20
        Me.TXTCRPRFCCO.Name = "TXTCRPRFCCO"
        Me.TXTCRPRFCCO.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPRFCCO.TabIndex = 1243
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(57, 183)
        Me.Label79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(175, 20)
        Me.Label79.TabIndex = 1244
        Me.Label79.Text = "Rfc Emisor Cta Ord"
        '
        'TXTCRPNOPE
        '
        Me.TXTCRPNOPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPNOPE.Location = New System.Drawing.Point(251, 147)
        Me.TXTCRPNOPE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPNOPE.MaxLength = 20
        Me.TXTCRPNOPE.Name = "TXTCRPNOPE"
        Me.TXTCRPNOPE.Size = New System.Drawing.Size(375, 26)
        Me.TXTCRPNOPE.TabIndex = 1241
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(29, 147)
        Me.Label78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(192, 20)
        Me.Label78.TabIndex = 1242
        Me.Label78.Text = "Número de Operación"
        '
        'TXTCRPTC
        '
        Me.TXTCRPTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTCRPTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPTC.Location = New System.Drawing.Point(1056, 99)
        Me.TXTCRPTC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCRPTC.MaxLength = 15
        Me.TXTCRPTC.Name = "TXTCRPTC"
        Me.TXTCRPTC.Size = New System.Drawing.Size(128, 26)
        Me.TXTCRPTC.TabIndex = 1239
        Me.TXTCRPTC.Text = "1.0"
        Me.TXTCRPTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label77
        '
        Me.Label77.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(907, 106)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(114, 20)
        Me.Label77.TabIndex = 1240
        Me.Label77.Text = "Tipo Cambio"
        '
        'Label76
        '
        Me.Label76.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(541, 75)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(87, 20)
        Me.Label76.TabIndex = 1238
        Me.Label76.Text = "* Moneda"
        '
        'CBCRPMON
        '
        Me.CBCRPMON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPMON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPMON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPMON.FormattingEnabled = True
        Me.CBCRPMON.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPMON.Location = New System.Drawing.Point(541, 99)
        Me.CBCRPMON.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCRPMON.Name = "CBCRPMON"
        Me.CBCRPMON.Size = New System.Drawing.Size(305, 28)
        Me.CBCRPMON.TabIndex = 1237
        '
        'Label75
        '
        Me.Label75.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(44, 75)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(149, 20)
        Me.Label75.TabIndex = 1232
        Me.Label75.Text = "* Forma de Pago"
        '
        'CBCRPFP
        '
        Me.CBCRPFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPFP.FormattingEnabled = True
        Me.CBCRPFP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPFP.Location = New System.Drawing.Point(44, 99)
        Me.CBCRPFP.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCRPFP.Name = "CBCRPFP"
        Me.CBCRPFP.Size = New System.Drawing.Size(403, 28)
        Me.CBCRPFP.TabIndex = 1231
        '
        'DTPCRPFP
        '
        Me.DTPCRPFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPCRPFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPCRPFP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPCRPFP.Location = New System.Drawing.Point(612, 30)
        Me.DTPCRPFP.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPCRPFP.Name = "DTPCRPFP"
        Me.DTPCRPFP.Size = New System.Drawing.Size(167, 30)
        Me.DTPCRPFP.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(1205, 542)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 98)
        Me.Button5.TabIndex = 1507
        '
        'BTNCRPAGREGAR
        '
        Me.BTNCRPAGREGAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCRPAGREGAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNCRPAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCRPAGREGAR.ForeColor = System.Drawing.Color.White
        Me.BTNCRPAGREGAR.Image = CType(resources.GetObject("BTNCRPAGREGAR.Image"), System.Drawing.Image)
        Me.BTNCRPAGREGAR.Location = New System.Drawing.Point(1205, 415)
        Me.BTNCRPAGREGAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCRPAGREGAR.Name = "BTNCRPAGREGAR"
        Me.BTNCRPAGREGAR.Size = New System.Drawing.Size(107, 96)
        Me.BTNCRPAGREGAR.TabIndex = 1506
        Me.BTNCRPAGREGAR.UseVisualStyleBackColor = False
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TABCP)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1324, 800)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Carta Porte"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TABCP
        '
        Me.TABCP.Controls.Add(Me.TabPage8)
        Me.TABCP.Controls.Add(Me.TabPage9)
        Me.TABCP.Controls.Add(Me.TabPage10)
        Me.TABCP.Controls.Add(Me.TabPage11)
        Me.TABCP.Location = New System.Drawing.Point(5, 3)
        Me.TABCP.Name = "TABCP"
        Me.TABCP.SelectedIndex = 0
        Me.TABCP.Size = New System.Drawing.Size(1316, 862)
        Me.TABCP.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.TXTPOLMA)
        Me.TabPage8.Controls.Add(Me.Label90)
        Me.TabPage8.Controls.Add(Me.TXTASEMA)
        Me.TabPage8.Controls.Add(Me.Label91)
        Me.TabPage8.Controls.Add(Me.TXTPOL)
        Me.TabPage8.Controls.Add(Me.Label93)
        Me.TabPage8.Controls.Add(Me.TXTASE)
        Me.TabPage8.Controls.Add(Me.Label94)
        Me.TabPage8.Controls.Add(Me.BTNBUSCON)
        Me.TabPage8.Controls.Add(Me.BTNBUSPER)
        Me.TabPage8.Controls.Add(Me.NUDMOD)
        Me.TabPage8.Controls.Add(Me.CBCON)
        Me.TabPage8.Controls.Add(Me.CBPER)
        Me.TabPage8.Controls.Add(Me.Label95)
        Me.TabPage8.Controls.Add(Me.TXTPLACAS)
        Me.TabPage8.Controls.Add(Me.Label96)
        Me.TabPage8.Controls.Add(Me.Label97)
        Me.TabPage8.Controls.Add(Me.TXTNUMPER)
        Me.TabPage8.Controls.Add(Me.Label98)
        Me.TabPage8.Controls.Add(Me.Label99)
        Me.TabPage8.Location = New System.Drawing.Point(4, 29)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1308, 829)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Vehículo"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TXTPOLMA
        '
        Me.TXTPOLMA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPOLMA.Location = New System.Drawing.Point(483, 411)
        Me.TXTPOLMA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPOLMA.MaxLength = 200
        Me.TXTPOLMA.Name = "TXTPOLMA"
        Me.TXTPOLMA.Size = New System.Drawing.Size(341, 29)
        Me.TXTPOLMA.TabIndex = 115
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(483, 384)
        Me.Label90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(218, 22)
        Me.Label90.TabIndex = 124
        Me.Label90.Text = "Poliza Medio Ambiente"
        '
        'TXTASEMA
        '
        Me.TXTASEMA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTASEMA.Location = New System.Drawing.Point(17, 411)
        Me.TXTASEMA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTASEMA.MaxLength = 200
        Me.TXTASEMA.Name = "TXTASEMA"
        Me.TXTASEMA.Size = New System.Drawing.Size(341, 29)
        Me.TXTASEMA.TabIndex = 114
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(17, 384)
        Me.Label91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(282, 22)
        Me.Label91.TabIndex = 123
        Me.Label91.Text = "Aseguradora Medio Ambiente"
        '
        'TXTPOL
        '
        Me.TXTPOL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPOL.Location = New System.Drawing.Point(483, 352)
        Me.TXTPOL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPOL.MaxLength = 200
        Me.TXTPOL.Name = "TXTPOL"
        Me.TXTPOL.Size = New System.Drawing.Size(341, 29)
        Me.TXTPOL.TabIndex = 113
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(483, 325)
        Me.Label93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(73, 22)
        Me.Label93.TabIndex = 122
        Me.Label93.Text = "Poliza*"
        '
        'TXTASE
        '
        Me.TXTASE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTASE.Location = New System.Drawing.Point(17, 352)
        Me.TXTASE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTASE.MaxLength = 200
        Me.TXTASE.Name = "TXTASE"
        Me.TXTASE.Size = New System.Drawing.Size(341, 29)
        Me.TXTASE.TabIndex = 112
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(17, 325)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(137, 22)
        Me.Label94.TabIndex = 121
        Me.Label94.Text = "Aseguradora*"
        '
        'BTNBUSCON
        '
        Me.BTNBUSCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCON.Location = New System.Drawing.Point(749, 137)
        Me.BTNBUSCON.Name = "BTNBUSCON"
        Me.BTNBUSCON.Size = New System.Drawing.Size(75, 31)
        Me.BTNBUSCON.TabIndex = 108
        Me.BTNBUSCON.Text = "..."
        Me.BTNBUSCON.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNBUSCON.UseVisualStyleBackColor = True
        '
        'BTNBUSPER
        '
        Me.BTNBUSPER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSPER.Location = New System.Drawing.Point(749, 17)
        Me.BTNBUSPER.Name = "BTNBUSPER"
        Me.BTNBUSPER.Size = New System.Drawing.Size(75, 30)
        Me.BTNBUSPER.TabIndex = 105
        Me.BTNBUSPER.Text = "..."
        Me.BTNBUSPER.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNBUSPER.UseVisualStyleBackColor = True
        '
        'NUDMOD
        '
        Me.NUDMOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDMOD.Location = New System.Drawing.Point(212, 268)
        Me.NUDMOD.Name = "NUDMOD"
        Me.NUDMOD.Size = New System.Drawing.Size(120, 27)
        Me.NUDMOD.TabIndex = 111
        Me.NUDMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CBCON
        '
        Me.CBCON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCON.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCON.FormattingEnabled = True
        Me.CBCON.Items.AddRange(New Object() {"O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+", "ORH-", "ORH+", "RH-", "RH+", "UNIVERSAL", ""})
        Me.CBCON.Location = New System.Drawing.Point(21, 176)
        Me.CBCON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBCON.Name = "CBCON"
        Me.CBCON.Size = New System.Drawing.Size(803, 30)
        Me.CBCON.TabIndex = 109
        '
        'CBPER
        '
        Me.CBPER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPER.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPER.FormattingEnabled = True
        Me.CBPER.Items.AddRange(New Object() {"O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+", "ORH-", "ORH+", "RH-", "RH+", "UNIVERSAL", ""})
        Me.CBPER.Location = New System.Drawing.Point(21, 55)
        Me.CBPER.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBPER.Name = "CBPER"
        Me.CBPER.Size = New System.Drawing.Size(803, 30)
        Me.CBPER.TabIndex = 106
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(104, 273)
        Me.Label95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(84, 22)
        Me.Label95.TabIndex = 120
        Me.Label95.Text = "Modelo*"
        '
        'TXTPLACAS
        '
        Me.TXTPLACAS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPLACAS.Location = New System.Drawing.Point(212, 223)
        Me.TXTPLACAS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPLACAS.MaxLength = 200
        Me.TXTPLACAS.Name = "TXTPLACAS"
        Me.TXTPLACAS.Size = New System.Drawing.Size(341, 29)
        Me.TXTPLACAS.TabIndex = 110
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(109, 230)
        Me.Label96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(79, 22)
        Me.Label96.TabIndex = 119
        Me.Label96.Text = "Placas*"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(17, 149)
        Me.Label97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(225, 22)
        Me.Label97.TabIndex = 118
        Me.Label97.Text = "Configuración vehicular"
        '
        'TXTNUMPER
        '
        Me.TXTNUMPER.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNUMPER.Location = New System.Drawing.Point(212, 95)
        Me.TXTNUMPER.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTNUMPER.MaxLength = 200
        Me.TXTNUMPER.Name = "TXTNUMPER"
        Me.TXTNUMPER.Size = New System.Drawing.Size(612, 29)
        Me.TXTNUMPER.TabIndex = 107
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(29, 101)
        Me.Label98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(176, 22)
        Me.Label98.TabIndex = 117
        Me.Label98.Text = "Num Permiso SCT"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(17, 28)
        Me.Label99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(129, 22)
        Me.Label99.TabIndex = 116
        Me.Label99.Text = "Permiso SCT"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.CBTF)
        Me.TabPage9.Controls.Add(Me.Label100)
        Me.TabPage9.Controls.Add(Me.TXTPAIS)
        Me.TabPage9.Controls.Add(Me.Label101)
        Me.TabPage9.Controls.Add(Me.TXTNRI)
        Me.TabPage9.Controls.Add(Me.Label102)
        Me.TabPage9.Controls.Add(Me.TXTLIC)
        Me.TabPage9.Controls.Add(Me.Label103)
        Me.TabPage9.Controls.Add(Me.TXTRFCCHO)
        Me.TabPage9.Controls.Add(Me.Label104)
        Me.TabPage9.Controls.Add(Me.TXTNOMCHO)
        Me.TabPage9.Controls.Add(Me.Label105)
        Me.TabPage9.Location = New System.Drawing.Point(4, 29)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(1308, 829)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "Chofer"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'CBTF
        '
        Me.CBTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTF.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTF.FormattingEnabled = True
        Me.CBTF.Items.AddRange(New Object() {"O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+", "ORH-", "ORH+", "RH-", "RH+", "UNIVERSAL", ""})
        Me.CBTF.Location = New System.Drawing.Point(161, 38)
        Me.CBTF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBTF.Name = "CBTF"
        Me.CBTF.Size = New System.Drawing.Size(648, 30)
        Me.CBTF.TabIndex = 81
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(24, 46)
        Me.Label100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(126, 22)
        Me.Label100.TabIndex = 92
        Me.Label100.Text = "Tipo Figura *"
        '
        'TXTPAIS
        '
        Me.TXTPAIS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPAIS.Location = New System.Drawing.Point(161, 214)
        Me.TXTPAIS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPAIS.MaxLength = 50
        Me.TXTPAIS.Name = "TXTPAIS"
        Me.TXTPAIS.ReadOnly = True
        Me.TXTPAIS.Size = New System.Drawing.Size(648, 29)
        Me.TXTPAIS.TabIndex = 86
        Me.TXTPAIS.Text = "MEX - México"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(101, 224)
        Me.Label101.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(49, 22)
        Me.Label101.TabIndex = 91
        Me.Label101.Text = "Pais"
        '
        'TXTNRI
        '
        Me.TXTNRI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNRI.Location = New System.Drawing.Point(161, 179)
        Me.TXTNRI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTNRI.MaxLength = 200
        Me.TXTNRI.Name = "TXTNRI"
        Me.TXTNRI.ReadOnly = True
        Me.TXTNRI.Size = New System.Drawing.Size(648, 29)
        Me.TXTNRI.TabIndex = 85
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(33, 187)
        Me.Label102.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(117, 22)
        Me.Label102.TabIndex = 90
        Me.Label102.Text = "Num Reg Id"
        '
        'TXTLIC
        '
        Me.TXTLIC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLIC.Location = New System.Drawing.Point(161, 145)
        Me.TXTLIC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTLIC.MaxLength = 10
        Me.TXTLIC.Name = "TXTLIC"
        Me.TXTLIC.Size = New System.Drawing.Size(648, 29)
        Me.TXTLIC.TabIndex = 84
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(51, 156)
        Me.Label103.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(99, 22)
        Me.Label103.TabIndex = 89
        Me.Label103.Text = "Licencia *"
        '
        'TXTRFCCHO
        '
        Me.TXTRFCCHO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFCCHO.Location = New System.Drawing.Point(161, 110)
        Me.TXTRFCCHO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTRFCCHO.MaxLength = 200
        Me.TXTRFCCHO.Name = "TXTRFCCHO"
        Me.TXTRFCCHO.Size = New System.Drawing.Size(648, 29)
        Me.TXTRFCCHO.TabIndex = 83
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(88, 121)
        Me.Label104.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(62, 22)
        Me.Label104.TabIndex = 88
        Me.Label104.Text = "RFC *"
        '
        'TXTNOMCHO
        '
        Me.TXTNOMCHO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMCHO.Location = New System.Drawing.Point(161, 76)
        Me.TXTNOMCHO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTNOMCHO.MaxLength = 100
        Me.TXTNOMCHO.Name = "TXTNOMCHO"
        Me.TXTNOMCHO.Size = New System.Drawing.Size(648, 29)
        Me.TXTNOMCHO.TabIndex = 82
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(67, 87)
        Me.Label105.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(83, 22)
        Me.Label105.TabIndex = 87
        Me.Label105.Text = "Nombre"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.Label117)
        Me.TabPage10.Controls.Add(Me.Label118)
        Me.TabPage10.Controls.Add(Me.TXTCPORI)
        Me.TabPage10.Controls.Add(Me.CBEDOORI)
        Me.TabPage10.Controls.Add(Me.Label119)
        Me.TabPage10.Controls.Add(Me.Label106)
        Me.TabPage10.Controls.Add(Me.TXTDIS)
        Me.TabPage10.Controls.Add(Me.Label107)
        Me.TabPage10.Controls.Add(Me.DTHORALLEG)
        Me.TabPage10.Controls.Add(Me.Label108)
        Me.TabPage10.Controls.Add(Me.DTFLLEG)
        Me.TabPage10.Controls.Add(Me.Label109)
        Me.TabPage10.Controls.Add(Me.TXTMONTO)
        Me.TabPage10.Controls.Add(Me.Label110)
        Me.TabPage10.Controls.Add(Me.TXTPOLCAR)
        Me.TabPage10.Controls.Add(Me.Label111)
        Me.TabPage10.Controls.Add(Me.TXTASECAR)
        Me.TabPage10.Controls.Add(Me.Label112)
        Me.TabPage10.Controls.Add(Me.DTHORASAL)
        Me.TabPage10.Controls.Add(Me.Label113)
        Me.TabPage10.Controls.Add(Me.DTFSAL)
        Me.TabPage10.Controls.Add(Me.Label114)
        Me.TabPage10.Controls.Add(Me.Label115)
        Me.TabPage10.Controls.Add(Me.TXTCPDES)
        Me.TabPage10.Controls.Add(Me.CBEDODES)
        Me.TabPage10.Controls.Add(Me.Label116)
        Me.TabPage10.Location = New System.Drawing.Point(4, 29)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(1308, 829)
        Me.TabPage10.TabIndex = 2
        Me.TabPage10.Text = "Origen y Destino"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(334, 38)
        Me.Label117.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(65, 20)
        Me.Label117.TabIndex = 1176
        Me.Label117.Text = "Origen"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(497, 83)
        Me.Label118.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(51, 20)
        Me.Label118.TabIndex = 1175
        Me.Label118.Text = "C.P.*"
        '
        'TXTCPORI
        '
        Me.TXTCPORI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCPORI.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCPORI.Location = New System.Drawing.Point(554, 72)
        Me.TXTCPORI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCPORI.MaxLength = 13
        Me.TXTCPORI.Name = "TXTCPORI"
        Me.TXTCPORI.Size = New System.Drawing.Size(172, 31)
        Me.TXTCPORI.TabIndex = 1174
        '
        'CBEDOORI
        '
        Me.CBEDOORI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEDOORI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEDOORI.FormattingEnabled = True
        Me.CBEDOORI.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEDOORI.Location = New System.Drawing.Point(93, 75)
        Me.CBEDOORI.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEDOORI.Name = "CBEDOORI"
        Me.CBEDOORI.Size = New System.Drawing.Size(380, 28)
        Me.CBEDOORI.TabIndex = 1172
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(18, 83)
        Me.Label119.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(67, 20)
        Me.Label119.TabIndex = 1173
        Me.Label119.Text = "Estado"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(334, 129)
        Me.Label106.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(74, 20)
        Me.Label106.TabIndex = 1171
        Me.Label106.Text = "Destino"
        '
        'TXTDIS
        '
        Me.TXTDIS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIS.Location = New System.Drawing.Point(393, 502)
        Me.TXTDIS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTDIS.MaxLength = 10
        Me.TXTDIS.Name = "TXTDIS"
        Me.TXTDIS.Size = New System.Drawing.Size(341, 29)
        Me.TXTDIS.TabIndex = 1169
        Me.TXTDIS.Text = "0"
        Me.TXTDIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(393, 475)
        Me.Label107.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(204, 22)
        Me.Label107.TabIndex = 1170
        Me.Label107.Text = "Distancia Recorrida *"
        '
        'DTHORALLEG
        '
        Me.DTHORALLEG.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHORALLEG.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTHORALLEG.Location = New System.Drawing.Point(578, 319)
        Me.DTHORALLEG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTHORALLEG.Name = "DTHORALLEG"
        Me.DTHORALLEG.ShowUpDown = True
        Me.DTHORALLEG.Size = New System.Drawing.Size(171, 29)
        Me.DTHORALLEG.TabIndex = 1167
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(410, 326)
        Me.Label108.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(160, 22)
        Me.Label108.TabIndex = 1168
        Me.Label108.Text = "Hora de Llegada"
        '
        'DTFLLEG
        '
        Me.DTFLLEG.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFLLEG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFLLEG.Location = New System.Drawing.Point(205, 319)
        Me.DTFLLEG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTFLLEG.Name = "DTFLLEG"
        Me.DTFLLEG.Size = New System.Drawing.Size(171, 29)
        Me.DTFLLEG.TabIndex = 1165
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(26, 326)
        Me.Label109.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(171, 22)
        Me.Label109.TabIndex = 1166
        Me.Label109.Text = "Fecha de Llegada"
        '
        'TXTMONTO
        '
        Me.TXTMONTO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMONTO.Location = New System.Drawing.Point(30, 502)
        Me.TXTMONTO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTMONTO.MaxLength = 10
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(341, 29)
        Me.TXTMONTO.TabIndex = 1163
        Me.TXTMONTO.Text = "0"
        Me.TXTMONTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(30, 475)
        Me.Label110.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(171, 22)
        Me.Label110.TabIndex = 1164
        Me.Label110.Text = "Monto Asegurado"
        '
        'TXTPOLCAR
        '
        Me.TXTPOLCAR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPOLCAR.Location = New System.Drawing.Point(393, 428)
        Me.TXTPOLCAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPOLCAR.MaxLength = 200
        Me.TXTPOLCAR.Name = "TXTPOLCAR"
        Me.TXTPOLCAR.Size = New System.Drawing.Size(341, 29)
        Me.TXTPOLCAR.TabIndex = 1160
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(393, 401)
        Me.Label111.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(126, 22)
        Me.Label111.TabIndex = 1162
        Me.Label111.Text = "Poliza Carga"
        '
        'TXTASECAR
        '
        Me.TXTASECAR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTASECAR.Location = New System.Drawing.Point(30, 428)
        Me.TXTASECAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTASECAR.MaxLength = 200
        Me.TXTASECAR.Name = "TXTASECAR"
        Me.TXTASECAR.Size = New System.Drawing.Size(341, 29)
        Me.TXTASECAR.TabIndex = 1159
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(30, 401)
        Me.Label112.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(190, 22)
        Me.Label112.TabIndex = 1161
        Me.Label112.Text = "Aseguradora Carga"
        '
        'DTHORASAL
        '
        Me.DTHORASAL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHORASAL.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTHORASAL.Location = New System.Drawing.Point(578, 265)
        Me.DTHORASAL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTHORASAL.Name = "DTHORASAL"
        Me.DTHORASAL.ShowUpDown = True
        Me.DTHORASAL.Size = New System.Drawing.Size(171, 29)
        Me.DTHORASAL.TabIndex = 1157
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(410, 272)
        Me.Label113.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(144, 22)
        Me.Label113.TabIndex = 1158
        Me.Label113.Text = "Hora de Salida"
        '
        'DTFSAL
        '
        Me.DTFSAL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFSAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFSAL.Location = New System.Drawing.Point(205, 265)
        Me.DTFSAL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTFSAL.Name = "DTFSAL"
        Me.DTFSAL.Size = New System.Drawing.Size(171, 29)
        Me.DTFSAL.TabIndex = 1155
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(42, 272)
        Me.Label114.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(155, 22)
        Me.Label114.TabIndex = 1156
        Me.Label114.Text = "Fecha de Salida"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(497, 174)
        Me.Label115.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(51, 20)
        Me.Label115.TabIndex = 1154
        Me.Label115.Text = "C.P.*"
        '
        'TXTCPDES
        '
        Me.TXTCPDES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCPDES.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCPDES.Location = New System.Drawing.Point(554, 163)
        Me.TXTCPDES.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCPDES.MaxLength = 13
        Me.TXTCPDES.Name = "TXTCPDES"
        Me.TXTCPDES.Size = New System.Drawing.Size(172, 31)
        Me.TXTCPDES.TabIndex = 1153
        '
        'CBEDODES
        '
        Me.CBEDODES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEDODES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEDODES.FormattingEnabled = True
        Me.CBEDODES.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEDODES.Location = New System.Drawing.Point(93, 166)
        Me.CBEDODES.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEDODES.Name = "CBEDODES"
        Me.CBEDODES.Size = New System.Drawing.Size(380, 28)
        Me.CBEDODES.TabIndex = 1151
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(18, 174)
        Me.Label116.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(67, 20)
        Me.Label116.TabIndex = 1152
        Me.Label116.Text = "Estado"
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.Button8)
        Me.TabPage11.Controls.Add(Me.LBLUUIDR)
        Me.TabPage11.Controls.Add(Me.LBLFOLIOR)
        Me.TabPage11.Controls.Add(Me.LBLSERIER)
        Me.TabPage11.Controls.Add(Me.Label125)
        Me.TabPage11.Controls.Add(Me.Label124)
        Me.TabPage11.Controls.Add(Me.Label123)
        Me.TabPage11.Controls.Add(Me.DGVMCP)
        Me.TabPage11.Controls.Add(Me.Label122)
        Me.TabPage11.Controls.Add(Me.Button7)
        Me.TabPage11.Location = New System.Drawing.Point(4, 29)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(1308, 829)
        Me.TabPage11.TabIndex = 3
        Me.TabPage11.Text = "Mercancías"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1055, 57)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(235, 31)
        Me.Button8.TabIndex = 1261
        Me.Button8.Text = "Copiar Detalles"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'LBLUUIDR
        '
        Me.LBLUUIDR.AutoSize = True
        Me.LBLUUIDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUUIDR.ForeColor = System.Drawing.Color.Navy
        Me.LBLUUIDR.Location = New System.Drawing.Point(515, 57)
        Me.LBLUUIDR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLUUIDR.Name = "LBLUUIDR"
        Me.LBLUUIDR.Size = New System.Drawing.Size(0, 20)
        Me.LBLUUIDR.TabIndex = 1260
        '
        'LBLFOLIOR
        '
        Me.LBLFOLIOR.AutoSize = True
        Me.LBLFOLIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFOLIOR.ForeColor = System.Drawing.Color.Navy
        Me.LBLFOLIOR.Location = New System.Drawing.Point(781, 15)
        Me.LBLFOLIOR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFOLIOR.Name = "LBLFOLIOR"
        Me.LBLFOLIOR.Size = New System.Drawing.Size(0, 20)
        Me.LBLFOLIOR.TabIndex = 1259
        '
        'LBLSERIER
        '
        Me.LBLSERIER.AutoSize = True
        Me.LBLSERIER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSERIER.ForeColor = System.Drawing.Color.Navy
        Me.LBLSERIER.Location = New System.Drawing.Point(514, 15)
        Me.LBLSERIER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLSERIER.Name = "LBLSERIER"
        Me.LBLSERIER.Size = New System.Drawing.Size(0, 20)
        Me.LBLSERIER.TabIndex = 1258
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(447, 57)
        Me.Label125.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(60, 20)
        Me.Label125.TabIndex = 1257
        Me.Label125.Text = "UUID:"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(717, 15)
        Me.Label124.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(56, 20)
        Me.Label124.TabIndex = 1256
        Me.Label124.Text = "Folio:"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(447, 15)
        Me.Label123.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(59, 20)
        Me.Label123.TabIndex = 1255
        Me.Label123.Text = "Serie:"
        '
        'DGVMCP
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGVMCP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMCP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVMCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MCPPySSat, Me.MCPCodInt, Me.MCPCantidad, Me.MCPDescripcion, Me.MCPUnidad, Me.MCPImporte, Me.MCPPeso, Me.MCPUniSat, Me.MCPFa})
        Me.DGVMCP.Location = New System.Drawing.Point(13, 114)
        Me.DGVMCP.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVMCP.Name = "DGVMCP"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMCP.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMCP.Size = New System.Drawing.Size(1277, 662)
        Me.DGVMCP.TabIndex = 1254
        '
        'MCPPySSat
        '
        Me.MCPPySSat.HeaderText = "PySSat"
        Me.MCPPySSat.Name = "MCPPySSat"
        '
        'MCPCodInt
        '
        Me.MCPCodInt.HeaderText = "Codigo"
        Me.MCPCodInt.Name = "MCPCodInt"
        '
        'MCPCantidad
        '
        Me.MCPCantidad.HeaderText = "Cantidad"
        Me.MCPCantidad.Name = "MCPCantidad"
        '
        'MCPDescripcion
        '
        Me.MCPDescripcion.HeaderText = "Descripcion"
        Me.MCPDescripcion.Name = "MCPDescripcion"
        '
        'MCPUnidad
        '
        Me.MCPUnidad.HeaderText = "Unidad"
        Me.MCPUnidad.Name = "MCPUnidad"
        '
        'MCPImporte
        '
        Me.MCPImporte.HeaderText = "Importe"
        Me.MCPImporte.Name = "MCPImporte"
        '
        'MCPPeso
        '
        Me.MCPPeso.HeaderText = "PesoUnitario"
        Me.MCPPeso.Name = "MCPPeso"
        '
        'MCPUniSat
        '
        Me.MCPUniSat.HeaderText = "UnidadSat"
        Me.MCPUniSat.Name = "MCPUniSat"
        '
        'MCPFa
        '
        Me.MCPFa.HeaderText = "FraccionArancelaria"
        Me.MCPFa.Name = "MCPFa"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(34, 51)
        Me.Label122.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(222, 20)
        Me.Label122.TabIndex = 1253
        Me.Label122.Text = "Seleccionar comprobante"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(321, 46)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(51, 31)
        Me.Button7.TabIndex = 1252
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BGW
        '
        '
        'TTT
        '
        Me.TTT.BackColor = System.Drawing.Color.Blue
        Me.TTT.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TTT.IsBalloon = True
        Me.TTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTT.ToolTipTitle = "Información"
        '
        'frmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 853)
        Me.Controls.Add(Me.TABC)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1350, 798)
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TABC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRET.ResumeLayout(False)
        Me.GBRET.PerformLayout()
        Me.GBTRAS.ResumeLayout(False)
        Me.GBTRAS.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GBIAPG.ResumeLayout(False)
        Me.GBIAPG.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GBCEDES.ResumeLayout(False)
        Me.GBCEDES.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.DGVCRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TABCP.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.NUDMOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        CType(Me.DGVMCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Private WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTNCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBCALLE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLDD As System.Windows.Forms.Label
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLDE As System.Windows.Forms.Label
    Friend WithEvents LBLDN As System.Windows.Forms.Label
    Friend WithEvents CBNEG As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTRFC As System.Windows.Forms.TextBox
    Friend WithEvents CBTC As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TABC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RB7 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNQC As System.Windows.Forms.Button
    Friend WithEvents BTNAC As System.Windows.Forms.Button
    Friend WithEvents LBC As System.Windows.Forms.ListBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TXTCC As System.Windows.Forms.TextBox
    Friend WithEvents CBEC As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents RB5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB6 As System.Windows.Forms.RadioButton
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNQO As System.Windows.Forms.Button
    Friend WithEvents BTNAO As System.Windows.Forms.Button
    Friend WithEvents LBO As System.Windows.Forms.ListBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TXTCO As System.Windows.Forms.TextBox
    Friend WithEvents CBEO As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB4 As System.Windows.Forms.RadioButton
    Friend WithEvents CHKINE As System.Windows.Forms.CheckBox
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents CHKCE As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TXTTCIEPS As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LBLTOT As System.Windows.Forms.Label
    Private WithEvents BTNQUITAR As System.Windows.Forms.Button
    Friend WithEvents LBLSUB As System.Windows.Forms.Label
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents LBLIVA As System.Windows.Forms.Label
    Friend WithEvents TXTTOT As System.Windows.Forms.TextBox
    Friend WithEvents LBLCCL As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTRIVA As System.Windows.Forms.TextBox
    Friend WithEvents TXTISR As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTSUB As System.Windows.Forms.TextBox
    Friend WithEvents TXTIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTIMP As System.Windows.Forms.TextBox
    Friend WithEvents TXTCANT As System.Windows.Forms.TextBox
    Friend WithEvents TXTVU As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTDES As System.Windows.Forms.TextBox
    Friend WithEvents TXTUNI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CBPYS As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CBUNI As System.Windows.Forms.ComboBox
    Friend WithEvents TXTTIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CBFIEPS As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents CBFIVA As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TXTCETUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TXTCETC As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents CBCESUB As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TXTCECURP As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TXTCERFP As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TXTCENCO As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TXTCECO As System.Windows.Forms.TextBox
    Friend WithEvents CHKCEDD As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TXTCECPED As System.Windows.Forms.TextBox
    Friend WithEvents CBCETO As System.Windows.Forms.ComboBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents TXTCEOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GBCEDES As System.Windows.Forms.GroupBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents CBCEPAIS As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents CBCEEDO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCEREF As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents TXTCENOINT As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents TXTCENOEXT As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents TXTCEMUN As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TXTCELOC As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TXTCECP As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TXTCECALLE As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TXTCEDDNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TXTCEDDCURP As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TXTCERFC As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents CBCEINCO As System.Windows.Forms.ComboBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CBUSO As System.Windows.Forms.ComboBox
    Friend WithEvents LLBLP As System.Windows.Forms.LinkLabel
    Friend WithEvents LLBLD As System.Windows.Forms.LinkLabel
    Friend WithEvents LLBLF As System.Windows.Forms.LinkLabel
    Friend WithEvents LBLTC As System.Windows.Forms.LinkLabel
    Friend WithEvents TXTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CBMON As System.Windows.Forms.ComboBox
    Friend WithEvents CBCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTTAR As System.Windows.Forms.TextBox
    Friend WithEvents CBFP As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBMP As System.Windows.Forms.ComboBox
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXTCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents TXTCODINT As System.Windows.Forms.TextBox
    Friend WithEvents GBRET As System.Windows.Forms.GroupBox
    Friend WithEvents TXTIVAR As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents TXTISRR As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents CBFIVAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents CBFISRR As System.Windows.Forms.ComboBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents GBTRAS As System.Windows.Forms.GroupBox
    Friend WithEvents CHKIR As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIT As System.Windows.Forms.CheckBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents TXTIEPS As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TXTCRPTC As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents CBCRPMON As System.Windows.Forms.ComboBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents CBCRPFP As System.Windows.Forms.ComboBox
    Friend WithEvents DTPCRPFP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTCRPNOPE As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TTT As System.Windows.Forms.ToolTip
    Friend WithEvents TXTCRPCO As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPNBCO As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPRFCCO As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPRFCCB As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCB As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPSELLO As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCAD As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCER As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents DGVCRP As System.Windows.Forms.DataGridView
    Friend WithEvents CBCRPTCP As System.Windows.Forms.ComboBox
    Friend WithEvents BTNBCER As System.Windows.Forms.Button
    Friend WithEvents BTNCRPAGREGAR As System.Windows.Forms.Button
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumParcialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NuevoSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents TXTFA As System.Windows.Forms.TextBox
    Friend WithEvents LBLFA As System.Windows.Forms.Label
    Friend WithEvents TXTCA As System.Windows.Forms.TextBox
    Friend WithEvents LBLCA As System.Windows.Forms.Label
    Friend WithEvents DTHORA As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTPESO As TextBox
    Friend WithEvents Label89 As Label
    Friend WithEvents CHKCP As CheckBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TABCP As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TXTPOLMA As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents TXTASEMA As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents TXTPOL As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents TXTASE As TextBox
    Friend WithEvents Label94 As Label
    Friend WithEvents BTNBUSCON As Button
    Friend WithEvents BTNBUSPER As Button
    Friend WithEvents NUDMOD As NumericUpDown
    Friend WithEvents CBCON As ComboBox
    Friend WithEvents CBPER As ComboBox
    Friend WithEvents Label95 As Label
    Friend WithEvents TXTPLACAS As TextBox
    Friend WithEvents Label96 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents TXTNUMPER As TextBox
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents CBTF As ComboBox
    Friend WithEvents Label100 As Label
    Friend WithEvents TXTPAIS As TextBox
    Friend WithEvents Label101 As Label
    Friend WithEvents TXTNRI As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents TXTLIC As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents TXTRFCCHO As TextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents TXTNOMCHO As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents Label117 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents TXTCPORI As TextBox
    Friend WithEvents CBEDOORI As ComboBox
    Friend WithEvents Label119 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents TXTDIS As TextBox
    Friend WithEvents Label107 As Label
    Friend WithEvents DTHORALLEG As DateTimePicker
    Friend WithEvents Label108 As Label
    Friend WithEvents DTFLLEG As DateTimePicker
    Friend WithEvents Label109 As Label
    Friend WithEvents TXTMONTO As TextBox
    Friend WithEvents Label110 As Label
    Friend WithEvents TXTPOLCAR As TextBox
    Friend WithEvents Label111 As Label
    Friend WithEvents TXTASECAR As TextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents DTHORASAL As DateTimePicker
    Friend WithEvents Label113 As Label
    Friend WithEvents DTFSAL As DateTimePicker
    Friend WithEvents Label114 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents TXTCPDES As TextBox
    Friend WithEvents CBEDODES As ComboBox
    Friend WithEvents Label116 As Label
    Friend WithEvents CBREL As ComboBox
    Friend WithEvents Label120 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TXTFREL As TextBox
    Friend WithEvents Label121 As Label
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents Label122 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents LBLUUIDR As Label
    Friend WithEvents LBLFOLIOR As Label
    Friend WithEvents LBLSERIER As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents DGVMCP As DataGridView
    Friend WithEvents GBIAPG As GroupBox
    Friend WithEvents Label128 As Label
    Friend WithEvents CBIAAÑO As ComboBox
    Friend WithEvents CBIAPER As ComboBox
    Friend WithEvents Label136 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents CBIAMES As ComboBox
    Friend WithEvents CBRF As ComboBox
    Friend WithEvents Label126 As Label
    Friend WithEvents TXTCP As TextBox
    Friend WithEvents Label127 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents CODINT As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
    Friend WithEvents Ieps As DataGridViewTextBoxColumn
    Friend WithEvents RetIva As DataGridViewTextBoxColumn
    Friend WithEvents RetIsr As DataGridViewTextBoxColumn
    Friend WithEvents TotalNeto As DataGridViewTextBoxColumn
    Friend WithEvents FactorIva As DataGridViewTextBoxColumn
    Friend WithEvents TasaIva As DataGridViewTextBoxColumn
    Friend WithEvents FactorIeps As DataGridViewTextBoxColumn
    Friend WithEvents TasaIeps As DataGridViewTextBoxColumn
    Friend WithEvents UniSat As DataGridViewTextBoxColumn
    Friend WithEvents PYSSAT As DataGridViewTextBoxColumn
    Friend WithEvents TASAIVAR As DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORIVAR As DataGridViewTextBoxColumn
    Friend WithEvents IEPSR As DataGridViewTextBoxColumn
    Friend WithEvents TASAIEPSR As DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORIEPSR As DataGridViewTextBoxColumn
    Friend WithEvents TASAISRR As DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORISRR As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents CantidadAduana As DataGridViewTextBoxColumn
    Friend WithEvents FraccionArancelaria As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents MCPPySSat As DataGridViewTextBoxColumn
    Friend WithEvents MCPCodInt As DataGridViewTextBoxColumn
    Friend WithEvents MCPCantidad As DataGridViewTextBoxColumn
    Friend WithEvents MCPDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents MCPUnidad As DataGridViewTextBoxColumn
    Friend WithEvents MCPImporte As DataGridViewTextBoxColumn
    Friend WithEvents MCPPeso As DataGridViewTextBoxColumn
    Friend WithEvents MCPUniSat As DataGridViewTextBoxColumn
    Friend WithEvents MCPFa As DataGridViewTextBoxColumn
End Class
