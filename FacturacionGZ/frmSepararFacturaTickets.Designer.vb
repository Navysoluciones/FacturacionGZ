<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSepararFacturaTickets
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
        Me.TCTICKETS = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.TCTICKETS.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCTICKETS
        '
        Me.TCTICKETS.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TCTICKETS.Controls.Add(Me.TabPage1)
        Me.TCTICKETS.Controls.Add(Me.TabPage2)
        Me.TCTICKETS.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TCTICKETS.ItemSize = New System.Drawing.Size(30, 120)
        Me.TCTICKETS.Location = New System.Drawing.Point(716, 12)
        Me.TCTICKETS.Multiline = True
        Me.TCTICKETS.Name = "TCTICKETS"
        Me.TCTICKETS.SelectedIndex = 0
        Me.TCTICKETS.Size = New System.Drawing.Size(423, 651)
        Me.TCTICKETS.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TCTICKETS.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(255, 643)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(295, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(620, 664)
        Me.DGV.TabIndex = 4
        '
        'frmSepararFacturaTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 688)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TCTICKETS)
        Me.Name = "frmSepararFacturaTickets"
        Me.Text = "frmSepararFacturaTickets"
        Me.TCTICKETS.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCTICKETS As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
