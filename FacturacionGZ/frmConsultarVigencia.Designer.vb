<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarVigencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarVigencia))
        Me.NOIMP = New System.Windows.Forms.Button
        Me.SIIMP = New System.Windows.Forms.Button
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TXTUUID = New System.Windows.Forms.TextBox
        Me.TXTTOT = New System.Windows.Forms.TextBox
        Me.TXTRR = New System.Windows.Forms.TextBox
        Me.TXTRE = New System.Windows.Forms.TextBox
        Me.LBLRES = New System.Windows.Forms.Label
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOIMP
        '
        Me.NOIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOIMP.Location = New System.Drawing.Point(808, 96)
        Me.NOIMP.Name = "NOIMP"
        Me.NOIMP.Size = New System.Drawing.Size(99, 47)
        Me.NOIMP.TabIndex = 1200
        Me.NOIMP.Text = "Desmarcar Todos"
        Me.NOIMP.UseVisualStyleBackColor = True
        '
        'SIIMP
        '
        Me.SIIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIIMP.Location = New System.Drawing.Point(703, 96)
        Me.SIIMP.Name = "SIIMP"
        Me.SIIMP.Size = New System.Drawing.Size(99, 47)
        Me.SIIMP.TabIndex = 1199
        Me.SIIMP.Text = "Marcar Todos"
        Me.SIIMP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(401, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 1196
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 1195
        Me.Label3.Text = "De:"
        '
        'DTHASTA
        '
        Me.DTHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(475, 119)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(126, 26)
        Me.DTHASTA.TabIndex = 1194
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(196, 119)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1193
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(97, 79)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(595, 24)
        Me.CBNEG.TabIndex = 1189
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 1192
        Me.Label9.Text = "Negocio"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(10, 51)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(682, 22)
        Me.LBLDE.TabIndex = 1191
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(97, 20)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 1188
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1190
        Me.Label7.Text = "RFC Emisor"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 160)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(904, 420)
        Me.DGV.TabIndex = 1187
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FacturacionGZ.My.Resources.Resources.xeyes2
        Me.Button1.Location = New System.Drawing.Point(722, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1198
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.White
        Me.BTNIMPRIMIR.Image = CType(resources.GetObject("BTNIMPRIMIR.Image"), System.Drawing.Image)
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(824, 3)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(80, 80)
        Me.BTNIMPRIMIR.TabIndex = 1197
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(836, 586)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 1201
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(403, 619)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 16)
        Me.Label18.TabIndex = 1209
        Me.Label18.Text = "UUID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(59, 622)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 16)
        Me.Label17.TabIndex = 1208
        Me.Label17.Text = "TOTAL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(321, 597)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 16)
        Me.Label16.TabIndex = 1207
        Me.Label16.Text = "RFC RECEPTOR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 597)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 1206
        Me.Label15.Text = "RFC EMISOR"
        '
        'TXTUUID
        '
        Me.TXTUUID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTUUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUUID.Location = New System.Drawing.Point(452, 616)
        Me.TXTUUID.MaxLength = 100
        Me.TXTUUID.Name = "TXTUUID"
        Me.TXTUUID.Size = New System.Drawing.Size(363, 22)
        Me.TXTUUID.TabIndex = 1205
        '
        'TXTTOT
        '
        Me.TXTTOT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOT.Location = New System.Drawing.Point(122, 619)
        Me.TXTTOT.MaxLength = 10
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.Size = New System.Drawing.Size(193, 22)
        Me.TXTTOT.TabIndex = 1204
        '
        'TXTRR
        '
        Me.TXTRR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRR.Location = New System.Drawing.Point(452, 591)
        Me.TXTRR.MaxLength = 20
        Me.TXTRR.Name = "TXTRR"
        Me.TXTRR.Size = New System.Drawing.Size(193, 22)
        Me.TXTRR.TabIndex = 1203
        '
        'TXTRE
        '
        Me.TXTRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRE.Location = New System.Drawing.Point(122, 591)
        Me.TXTRE.MaxLength = 20
        Me.TXTRE.Name = "TXTRE"
        Me.TXTRE.Size = New System.Drawing.Size(193, 22)
        Me.TXTRE.TabIndex = 1202
        '
        'LBLRES
        '
        Me.LBLRES.AutoSize = True
        Me.LBLRES.BackColor = System.Drawing.Color.Transparent
        Me.LBLRES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRES.ForeColor = System.Drawing.Color.Green
        Me.LBLRES.Location = New System.Drawing.Point(299, 646)
        Me.LBLRES.Name = "LBLRES"
        Me.LBLRES.Size = New System.Drawing.Size(96, 20)
        Me.LBLRES.TabIndex = 1210
        Me.LBLRES.Text = "Resultado:"
        '
        'frmConsultarVigencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 675)
        Me.Controls.Add(Me.LBLRES)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXTUUID)
        Me.Controls.Add(Me.TXTTOT)
        Me.Controls.Add(Me.TXTRR)
        Me.Controls.Add(Me.TXTRE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NOIMP)
        Me.Controls.Add(Me.SIIMP)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultarVigencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Vigencia de Facturas"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NOIMP As System.Windows.Forms.Button
    Friend WithEvents SIIMP As System.Windows.Forms.Button
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTUUID As System.Windows.Forms.TextBox
    Friend WithEvents TXTTOT As System.Windows.Forms.TextBox
    Friend WithEvents TXTRR As System.Windows.Forms.TextBox
    Friend WithEvents TXTRE As System.Windows.Forms.TextBox
    Friend WithEvents LBLRES As System.Windows.Forms.Label
End Class
