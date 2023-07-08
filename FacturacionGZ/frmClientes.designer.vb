<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BTNBUSCAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXTNCOM = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXTNOM = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CBEDO = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXTWEB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTMAIL = New System.Windows.Forms.TextBox
        Me.TXTREF = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.txtColonia = New System.Windows.Forms.TextBox
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.txtNoExterior = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPais = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNoInterior = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMunicipio = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCP = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BTNQUITAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BTNCORREO = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.TXTRFC = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Image = CType(resources.GetObject("BTNBUSCAR.Image"), System.Drawing.Image)
        Me.BTNBUSCAR.Location = New System.Drawing.Point(450, 13)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNBUSCAR.TabIndex = 6
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.Location = New System.Drawing.Point(572, 13)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTNCOM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXTNOM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 101)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TXTNCOM
        '
        Me.TXTNCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNCOM.Location = New System.Drawing.Point(156, 42)
        Me.TXTNCOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNCOM.MaxLength = 100
        Me.TXTNCOM.Name = "TXTNCOM"
        Me.TXTNCOM.Size = New System.Drawing.Size(512, 22)
        Me.TXTNCOM.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nombre Comercial:"
        '
        'TXTNOM
        '
        Me.TXTNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOM.Location = New System.Drawing.Point(156, 12)
        Me.TXTNOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNOM.MaxLength = 100
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(512, 22)
        Me.TXTNOM.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre Fiscal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "RFC"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBEDO)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXTWEB)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TXTMAIL)
        Me.GroupBox2.Controls.Add(Me.TXTREF)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCalle)
        Me.GroupBox2.Controls.Add(Me.txtColonia)
        Me.GroupBox2.Controls.Add(Me.txtLocalidad)
        Me.GroupBox2.Controls.Add(Me.txtNoExterior)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPais)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtNoInterior)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMunicipio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCP)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(689, 202)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CBEDO
        '
        Me.CBEDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEDO.FormattingEnabled = True
        Me.CBEDO.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEDO.Location = New System.Drawing.Point(122, 117)
        Me.CBEDO.Name = "CBEDO"
        Me.CBEDO.Size = New System.Drawing.Size(228, 24)
        Me.CBEDO.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Web:"
        '
        'TXTWEB
        '
        Me.TXTWEB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTWEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTWEB.Location = New System.Drawing.Point(475, 174)
        Me.TXTWEB.MaxLength = 100
        Me.TXTWEB.Name = "TXTWEB"
        Me.TXTWEB.Size = New System.Drawing.Size(193, 22)
        Me.TXTWEB.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Referencia:"
        '
        'TXTMAIL
        '
        Me.TXTMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMAIL.Location = New System.Drawing.Point(122, 171)
        Me.TXTMAIL.MaxLength = 100
        Me.TXTMAIL.Name = "TXTMAIL"
        Me.TXTMAIL.Size = New System.Drawing.Size(228, 22)
        Me.TXTMAIL.TabIndex = 11
        '
        'TXTREF
        '
        Me.TXTREF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTREF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREF.Location = New System.Drawing.Point(475, 146)
        Me.TXTREF.MaxLength = 50
        Me.TXTREF.Name = "TXTREF"
        Me.TXTREF.Size = New System.Drawing.Size(193, 22)
        Me.TXTREF.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "e-Mail:"
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(122, 13)
        Me.txtCalle.MaxLength = 100
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(546, 22)
        Me.txtCalle.TabIndex = 0
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(122, 39)
        Me.txtColonia.MaxLength = 100
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(228, 22)
        Me.txtColonia.TabIndex = 1
        '
        'txtLocalidad
        '
        Me.txtLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(122, 65)
        Me.txtLocalidad.MaxLength = 100
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(228, 22)
        Me.txtLocalidad.TabIndex = 3
        '
        'txtNoExterior
        '
        Me.txtNoExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoExterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoExterior.Location = New System.Drawing.Point(122, 91)
        Me.txtNoExterior.MaxLength = 10
        Me.txtNoExterior.Name = "txtNoExterior"
        Me.txtNoExterior.Size = New System.Drawing.Size(100, 22)
        Me.txtNoExterior.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(426, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 16)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "País:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(381, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "No. Interior:"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(122, 145)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(228, 22)
        Me.txtTelefono.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(391, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 16)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Municipio:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(429, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "C.P.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Calle:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Colonia:"
        '
        'txtPais
        '
        Me.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(475, 118)
        Me.txtPais.MaxLength = 50
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(193, 22)
        Me.txtPais.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Localidad:"
        '
        'txtNoInterior
        '
        Me.txtNoInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoInterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInterior.Location = New System.Drawing.Point(475, 92)
        Me.txtNoInterior.MaxLength = 10
        Me.txtNoInterior.Name = "txtNoInterior"
        Me.txtNoInterior.Size = New System.Drawing.Size(193, 22)
        Me.txtNoInterior.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "No. Exterior:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Location = New System.Drawing.Point(475, 66)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(193, 22)
        Me.txtMunicipio.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Estado:"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(475, 40)
        Me.txtCP.MaxLength = 10
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(193, 22)
        Me.txtCP.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Teléfono:"
        '
        'BTNQUITAR
        '
        Me.BTNQUITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQUITAR.Image = CType(resources.GetObject("BTNQUITAR.Image"), System.Drawing.Image)
        Me.BTNQUITAR.Location = New System.Drawing.Point(732, 270)
        Me.BTNQUITAR.Name = "BTNQUITAR"
        Me.BTNQUITAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNQUITAR.TabIndex = 5
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.ForeColor = System.Drawing.Color.White
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(735, 135)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(80, 78)
        Me.BTNAGREGAR.TabIndex = 3
        Me.BTNAGREGAR.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 386)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(800, 243)
        Me.DGV.TabIndex = 37
        '
        'BTNCORREO
        '
        Me.BTNCORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCORREO.Image = Global.FacturacionGZ.My.Resources.Resources.EMAIL
        Me.BTNCORREO.Location = New System.Drawing.Point(732, 13)
        Me.BTNCORREO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCORREO.Name = "BTNCORREO"
        Me.BTNCORREO.Size = New System.Drawing.Size(80, 80)
        Me.BTNCORREO.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(41, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(403, 32)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Favor de Revisar el RFC y tratar de no confundir las letras como el ejemplo que s" & _
            "e muestra"
        '
        'TXTRFC
        '
        Me.TXTRFC.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFC.Location = New System.Drawing.Point(115, 26)
        Me.TXTRFC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTRFC.MaxLength = 13
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(224, 26)
        Me.TXTRFC.TabIndex = 40
        Me.TXTRFC.Text = "1Il6G2Z0Oq95S"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 641)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTRFC)
        Me.Controls.Add(Me.BTNCORREO)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNQUITAR)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes para Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Private WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTNCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNoExterior As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoInterior As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents BTNQUITAR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTWEB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTMAIL As System.Windows.Forms.TextBox
    Friend WithEvents TXTREF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBEDO As System.Windows.Forms.ComboBox
    Private WithEvents BTNCORREO As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTRFC As System.Windows.Forms.TextBox
End Class
