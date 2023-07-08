<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionaFacturaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionaFacturaPago))
        Me.LBLTF = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBLB = New System.Windows.Forms.Label
        Me.LBLA = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BTNACEPTAR = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLTF
        '
        Me.LBLTF.AutoSize = True
        Me.LBLTF.BackColor = System.Drawing.Color.Transparent
        Me.LBLTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTF.Location = New System.Drawing.Point(537, 529)
        Me.LBLTF.Name = "LBLTF"
        Me.LBLTF.Size = New System.Drawing.Size(166, 16)
        Me.LBLTF.TabIndex = 1258
        Me.LBLTF.Text = "Total de Facturas: 0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(103, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 24)
        Me.Label1.TabIndex = 1257
        Me.Label1.Text = "FAVOR DE SELECCIONAR LA REFERENCIA DE LA FACTURA"
        '
        'LBLB
        '
        Me.LBLB.AutoSize = True
        Me.LBLB.BackColor = System.Drawing.Color.Transparent
        Me.LBLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLB.Location = New System.Drawing.Point(38, 81)
        Me.LBLB.Name = "LBLB"
        Me.LBLB.Size = New System.Drawing.Size(90, 16)
        Me.LBLB.TabIndex = 1256
        Me.LBLB.Text = "RFC Emisor"
        '
        'LBLA
        '
        Me.LBLA.AutoSize = True
        Me.LBLA.BackColor = System.Drawing.Color.Transparent
        Me.LBLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLA.Location = New System.Drawing.Point(38, 55)
        Me.LBLA.Name = "LBLA"
        Me.LBLA.Size = New System.Drawing.Size(90, 16)
        Me.LBLA.TabIndex = 1255
        Me.LBLA.Text = "RFC Emisor"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 107)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(809, 397)
        Me.DGV.TabIndex = 1254
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.White
        Me.BTNACEPTAR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNACEPTAR.Image = CType(resources.GetObject("BTNACEPTAR.Image"), System.Drawing.Image)
        Me.BTNACEPTAR.Location = New System.Drawing.Point(343, 510)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(123, 112)
        Me.BTNACEPTAR.TabIndex = 1253
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'frmSeleccionaFacturaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 633)
        Me.Controls.Add(Me.LBLTF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLB)
        Me.Controls.Add(Me.LBLA)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionaFacturaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Factura de Referencia de Pago"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTF As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLB As System.Windows.Forms.Label
    Friend WithEvents LBLA As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
End Class
