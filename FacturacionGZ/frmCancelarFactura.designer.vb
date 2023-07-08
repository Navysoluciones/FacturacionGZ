<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelarFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelarFactura))
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
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 1128
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 1127
        Me.Label3.Text = "De:"
        '
        'DTHASTA
        '
        Me.DTHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(473, 112)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(126, 26)
        Me.DTHASTA.TabIndex = 1126
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(194, 112)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1125
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(95, 72)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(595, 24)
        Me.CBNEG.TabIndex = 1121
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 1124
        Me.Label9.Text = "Negocio"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(8, 44)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(682, 22)
        Me.LBLDE.TabIndex = 1123
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(95, 13)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 1120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1122
        Me.Label7.Text = "RFC Emisor"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 165)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(904, 458)
        Me.DGV.TabIndex = 1119
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.White
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(823, 16)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1131
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FacturacionGZ.My.Resources.Resources.xeyes2
        Me.Button1.Location = New System.Drawing.Point(720, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1130
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmCancelarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 631)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "frmCancelarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelación de Facturas (en Sistema)"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
End Class
