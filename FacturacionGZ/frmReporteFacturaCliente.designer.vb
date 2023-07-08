<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturaCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteFacturaCliente))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LBLRIVA = New System.Windows.Forms.Label
        Me.LBLRISR = New System.Windows.Forms.Label
        Me.LBLT = New System.Windows.Forms.Label
        Me.LBLI = New System.Windows.Forms.Label
        Me.LBLS = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTHASTA = New System.Windows.Forms.DateTimePicker
        Me.DTDE = New System.Windows.Forms.DateTimePicker
        Me.CBNEG = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LBLDE = New System.Windows.Forms.Label
        Me.CBEMISOR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.TXTRFC = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXTNCOM = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXTNOM = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.BTNBUSCAR = New System.Windows.Forms.Button
        Me.BTNMAIL = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button
        Me.BTNMAIL2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 660)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1146
        Me.Label1.Text = "Ret ISR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(781, 660)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1145
        Me.Label2.Text = "Ret IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 660)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 1144
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 660)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 1143
        Me.Label6.Text = "IVA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 660)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 1142
        Me.Label8.Text = "SubTotal"
        '
        'LBLRIVA
        '
        Me.LBLRIVA.AutoSize = True
        Me.LBLRIVA.BackColor = System.Drawing.Color.Transparent
        Me.LBLRIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRIVA.Location = New System.Drawing.Point(784, 688)
        Me.LBLRIVA.Name = "LBLRIVA"
        Me.LBLRIVA.Size = New System.Drawing.Size(57, 16)
        Me.LBLRIVA.TabIndex = 1141
        Me.LBLRIVA.Text = "TOTAL"
        '
        'LBLRISR
        '
        Me.LBLRISR.AutoSize = True
        Me.LBLRISR.BackColor = System.Drawing.Color.Transparent
        Me.LBLRISR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRISR.Location = New System.Drawing.Point(618, 688)
        Me.LBLRISR.Name = "LBLRISR"
        Me.LBLRISR.Size = New System.Drawing.Size(57, 16)
        Me.LBLRISR.TabIndex = 1140
        Me.LBLRISR.Text = "TOTAL"
        '
        'LBLT
        '
        Me.LBLT.AutoSize = True
        Me.LBLT.BackColor = System.Drawing.Color.Transparent
        Me.LBLT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLT.Location = New System.Drawing.Point(422, 688)
        Me.LBLT.Name = "LBLT"
        Me.LBLT.Size = New System.Drawing.Size(57, 16)
        Me.LBLT.TabIndex = 1139
        Me.LBLT.Text = "TOTAL"
        '
        'LBLI
        '
        Me.LBLI.AutoSize = True
        Me.LBLI.BackColor = System.Drawing.Color.Transparent
        Me.LBLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLI.Location = New System.Drawing.Point(226, 688)
        Me.LBLI.Name = "LBLI"
        Me.LBLI.Size = New System.Drawing.Size(57, 16)
        Me.LBLI.TabIndex = 1138
        Me.LBLI.Text = "TOTAL"
        '
        'LBLS
        '
        Me.LBLS.AutoSize = True
        Me.LBLS.BackColor = System.Drawing.Color.Transparent
        Me.LBLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLS.Location = New System.Drawing.Point(37, 688)
        Me.LBLS.Name = "LBLS"
        Me.LBLS.Size = New System.Drawing.Size(57, 16)
        Me.LBLS.TabIndex = 1137
        Me.LBLS.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 1134
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 1133
        Me.Label3.Text = "De:"
        '
        'DTHASTA
        '
        Me.DTHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(484, 271)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(126, 26)
        Me.DTHASTA.TabIndex = 1132
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(205, 271)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1131
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(106, 231)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(595, 24)
        Me.CBNEG.TabIndex = 1127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 1130
        Me.Label9.Text = "Negocio"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(19, 203)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(682, 22)
        Me.LBLDE.TabIndex = 1129
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Todos los Negocios"})
        Me.CBEMISOR.Location = New System.Drawing.Point(106, 172)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 1126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1128
        Me.Label7.Text = "RFC Emisor"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 303)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(992, 345)
        Me.DGV.TabIndex = 1125
        '
        'TXTRFC
        '
        Me.TXTRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRFC.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFC.Location = New System.Drawing.Point(127, 34)
        Me.TXTRFC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTRFC.MaxLength = 13
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(224, 26)
        Me.TXTRFC.TabIndex = 1148
        Me.TXTRFC.Text = "1IL6G2Z0OQ95S"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 1150
        Me.Label10.Text = "RFC Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXTNCOM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXTNOM)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 70)
        Me.GroupBox1.TabIndex = 1151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'TXTNCOM
        '
        Me.TXTNCOM.Enabled = False
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
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nombre Comercial:"
        '
        'TXTNOM
        '
        Me.TXTNOM.Enabled = False
        Me.TXTNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOM.Location = New System.Drawing.Point(156, 12)
        Me.TXTNOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNOM.MaxLength = 100
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(512, 22)
        Me.TXTNOM.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Nombre Fiscal:"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Image = CType(resources.GetObject("BTNBUSCAR.Image"), System.Drawing.Image)
        Me.BTNBUSCAR.Location = New System.Drawing.Point(366, 7)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNBUSCAR.TabIndex = 1149
        '
        'BTNMAIL
        '
        Me.BTNMAIL.BackColor = System.Drawing.SystemColors.Control
        Me.BTNMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAIL.ForeColor = System.Drawing.Color.White
        Me.BTNMAIL.Image = Global.FacturacionGZ.My.Resources.Resources.EMAIL
        Me.BTNMAIL.Location = New System.Drawing.Point(822, 188)
        Me.BTNMAIL.Name = "BTNMAIL"
        Me.BTNMAIL.Size = New System.Drawing.Size(80, 80)
        Me.BTNMAIL.TabIndex = 1147
        Me.BTNMAIL.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FacturacionGZ.My.Resources.Resources.xeyes2
        Me.Button1.Location = New System.Drawing.Point(717, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1136
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.White
        Me.BTNIMPRIMIR.Image = CType(resources.GetObject("BTNIMPRIMIR.Image"), System.Drawing.Image)
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(822, 71)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(80, 80)
        Me.BTNIMPRIMIR.TabIndex = 1135
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'BTNMAIL2
        '
        Me.BTNMAIL2.BackColor = System.Drawing.SystemColors.Control
        Me.BTNMAIL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAIL2.ForeColor = System.Drawing.Color.Red
        Me.BTNMAIL2.Image = CType(resources.GetObject("BTNMAIL2.Image"), System.Drawing.Image)
        Me.BTNMAIL2.Location = New System.Drawing.Point(920, 71)
        Me.BTNMAIL2.Name = "BTNMAIL2"
        Me.BTNMAIL2.Size = New System.Drawing.Size(80, 80)
        Me.BTNMAIL2.TabIndex = 1152
        Me.BTNMAIL2.Text = "Multiple"
        Me.BTNMAIL2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Image = Global.FacturacionGZ.My.Resources.Resources.EMAIL
        Me.Button3.Location = New System.Drawing.Point(920, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 1153
        Me.Button3.Text = "Multiple"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmReporteFacturaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 715)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BTNMAIL2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTRFC)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTNMAIL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLRIVA)
        Me.Controls.Add(Me.LBLRISR)
        Me.Controls.Add(Me.LBLT)
        Me.Controls.Add(Me.LBLI)
        Me.Controls.Add(Me.LBLS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTHASTA)
        Me.Controls.Add(Me.DTDE)
        Me.Controls.Add(Me.CBNEG)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LBLDE)
        Me.Controls.Add(Me.CBEMISOR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteFacturaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación por Cliente"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNMAIL As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLRIVA As System.Windows.Forms.Label
    Friend WithEvents LBLRISR As System.Windows.Forms.Label
    Friend WithEvents LBLT As System.Windows.Forms.Label
    Friend WithEvents LBLI As System.Windows.Forms.Label
    Friend WithEvents LBLS As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTHASTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBNEG As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLDE As System.Windows.Forms.Label
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TXTRFC As System.Windows.Forms.TextBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTNCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNMAIL2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
