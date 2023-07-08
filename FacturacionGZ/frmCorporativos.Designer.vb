<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorporativos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorporativos))
        Me.TXTD = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXTCP = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXTC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTNOM = New System.Windows.Forms.TextBox
        Me.CBACT = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXTCLA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTNBUSCAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXTT = New System.Windows.Forms.TextBox
        Me.TXTF = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXTCT = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TXTD
        '
        Me.TXTD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTD.Location = New System.Drawing.Point(118, 198)
        Me.TXTD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTD.MaxLength = 200
        Me.TXTD.Name = "TXTD"
        Me.TXTD.Size = New System.Drawing.Size(425, 25)
        Me.TXTD.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 1098
        Me.Label8.Text = "Dirección"
        '
        'TXTCP
        '
        Me.TXTCP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCP.Location = New System.Drawing.Point(117, 232)
        Me.TXTCP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCP.MaxLength = 5
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.Size = New System.Drawing.Size(135, 25)
        Me.TXTCP.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 17)
        Me.Label7.TabIndex = 1097
        Me.Label7.Text = "CP"
        '
        'TXTC
        '
        Me.TXTC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTC.Location = New System.Drawing.Point(118, 165)
        Me.TXTC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTC.MaxLength = 100
        Me.TXTC.Name = "TXTC"
        Me.TXTC.Size = New System.Drawing.Size(425, 25)
        Me.TXTC.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 1096
        Me.Label5.Text = "Ciudad"
        '
        'TXTNOM
        '
        Me.TXTNOM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOM.Location = New System.Drawing.Point(118, 132)
        Me.TXTNOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNOM.MaxLength = 100
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(425, 25)
        Me.TXTNOM.TabIndex = 1
        '
        'CBACT
        '
        Me.CBACT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBACT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBACT.FormattingEnabled = True
        Me.CBACT.Items.AddRange(New Object() {"Si", "No"})
        Me.CBACT.Location = New System.Drawing.Point(117, 366)
        Me.CBACT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBACT.Name = "CBACT"
        Me.CBACT.Size = New System.Drawing.Size(72, 25)
        Me.CBACT.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 1092
        Me.Label3.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 1093
        Me.Label6.Text = "Activo"
        '
        'TXTCLA
        '
        Me.TXTCLA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLA.Location = New System.Drawing.Point(139, 47)
        Me.TXTCLA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCLA.MaxLength = 3
        Me.TXTCLA.Name = "TXTCLA"
        Me.TXTCLA.Size = New System.Drawing.Size(89, 29)
        Me.TXTCLA.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 1091
        Me.Label2.Text = "Clave"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.White
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNBUSCAR.Image = CType(resources.GetObject("BTNBUSCAR.Image"), System.Drawing.Image)
        Me.BTNBUSCAR.Location = New System.Drawing.Point(373, 29)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(85, 77)
        Me.BTNBUSCAR.TabIndex = 1089
        Me.BTNBUSCAR.Text = "&b"
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.Color.White
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.Location = New System.Drawing.Point(345, 420)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 1090
        Me.BTNCANCELAR.Text = "&C"
        Me.BTNCANCELAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(159, 420)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 9
        Me.BTNGUARDAR.Text = "&G"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1099
        Me.Label1.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 1100
        Me.Label4.Text = "FAX"
        '
        'TXTT
        '
        Me.TXTT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTT.Location = New System.Drawing.Point(358, 232)
        Me.TXTT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTT.MaxLength = 50
        Me.TXTT.Name = "TXTT"
        Me.TXTT.Size = New System.Drawing.Size(185, 25)
        Me.TXTT.TabIndex = 5
        '
        'TXTF
        '
        Me.TXTF.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTF.Location = New System.Drawing.Point(119, 266)
        Me.TXTF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTF.MaxLength = 50
        Me.TXTF.Name = "TXTF"
        Me.TXTF.Size = New System.Drawing.Size(183, 25)
        Me.TXTF.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 1101
        Me.Label10.Text = "Contacto"
        '
        'TXTCT
        '
        Me.TXTCT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCT.Location = New System.Drawing.Point(119, 298)
        Me.TXTCT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCT.MaxLength = 200
        Me.TXTCT.Multiline = True
        Me.TXTCT.Name = "TXTCT"
        Me.TXTCT.Size = New System.Drawing.Size(424, 60)
        Me.TXTCT.TabIndex = 7
        '
        'frmCorporativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 522)
        Me.Controls.Add(Me.TXTCT)
        Me.Controls.Add(Me.TXTF)
        Me.Controls.Add(Me.TXTT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTCP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTNOM)
        Me.Controls.Add(Me.CBACT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.TXTCLA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCorporativos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corporativos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTCP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents CBACT As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents TXTCLA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTT As System.Windows.Forms.TextBox
    Friend WithEvents TXTF As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTCT As System.Windows.Forms.TextBox
End Class
