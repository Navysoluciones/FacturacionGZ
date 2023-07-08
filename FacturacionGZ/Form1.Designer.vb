<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.SB = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Facturar33ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReImprimirMultiplesFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimbresGastadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoliosUtilizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturaciónDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasRealizadasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVigenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBCNC = New System.Windows.Forms.PictureBox()
        Me.PBFONDO = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjusteFacturasSinTimbrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBCNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFONDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SB
        '
        Me.SB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.SB.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel1})
        Me.SB.Location = New System.Drawing.Point(0, 577)
        Me.SB.Name = "SB"
        Me.SB.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SB.Size = New System.Drawing.Size(817, 25)
        Me.SB.TabIndex = 49
        Me.SB.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(138, 20)
        Me.ToolStripStatusLabel7.Text = "Los Mochis, Sinaloa"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(117, 20)
        Me.ToolStripStatusLabel8.Text = "Navy Soluciones"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 20)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.ToolStripMenuItem40})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 31)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.NegociosToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClientesToolStripMenuItem, Me.ModificarClientesToolStripMenuItem, Me.ToolStripMenuItem2, Me.Facturar33ToolStripMenuItem})
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripMenuItem7.Text = "&Archivo"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(232, 28)
        Me.ToolStripMenuItem8.Text = "Em&presa"
        '
        'NegociosToolStripMenuItem
        '
        Me.NegociosToolStripMenuItem.Name = "NegociosToolStripMenuItem"
        Me.NegociosToolStripMenuItem.Size = New System.Drawing.Size(232, 28)
        Me.NegociosToolStripMenuItem.Text = "Negocios"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(229, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(232, 28)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ModificarClientesToolStripMenuItem
        '
        Me.ModificarClientesToolStripMenuItem.Name = "ModificarClientesToolStripMenuItem"
        Me.ModificarClientesToolStripMenuItem.Size = New System.Drawing.Size(232, 28)
        Me.ModificarClientesToolStripMenuItem.Text = "Modificar Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(229, 6)
        '
        'Facturar33ToolStripMenuItem
        '
        Me.Facturar33ToolStripMenuItem.Name = "Facturar33ToolStripMenuItem"
        Me.Facturar33ToolStripMenuItem.Size = New System.Drawing.Size(232, 28)
        Me.Facturar33ToolStripMenuItem.Text = "Facturar 4.0"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelarFacturaToolStripMenuItem, Me.ReImprimirMultiplesFacturaToolStripMenuItem, Me.ToolStripMenuItem4, Me.AjusteFacturasSinTimbrarToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(126, 27)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'CancelarFacturaToolStripMenuItem
        '
        Me.CancelarFacturaToolStripMenuItem.Name = "CancelarFacturaToolStripMenuItem"
        Me.CancelarFacturaToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.CancelarFacturaToolStripMenuItem.Text = "Cancelar Factura"
        '
        'ReImprimirMultiplesFacturaToolStripMenuItem
        '
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Name = "ReImprimirMultiplesFacturaToolStripMenuItem"
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Text = "Re Imprimir Multiples Factura"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasRealizadasToolStripMenuItem, Me.TimbresGastadosToolStripMenuItem, Me.FoliosUtilizadosToolStripMenuItem, Me.ToolStripMenuItem3, Me.FacturaciónDeClientesToolStripMenuItem, Me.FacturasRealizadasToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'FacturasRealizadasToolStripMenuItem
        '
        Me.FacturasRealizadasToolStripMenuItem.Name = "FacturasRealizadasToolStripMenuItem"
        Me.FacturasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(317, 28)
        Me.FacturasRealizadasToolStripMenuItem.Text = "Facturas Realizadas"
        '
        'TimbresGastadosToolStripMenuItem
        '
        Me.TimbresGastadosToolStripMenuItem.Name = "TimbresGastadosToolStripMenuItem"
        Me.TimbresGastadosToolStripMenuItem.Size = New System.Drawing.Size(317, 28)
        Me.TimbresGastadosToolStripMenuItem.Text = "Timbres Gastados"
        '
        'FoliosUtilizadosToolStripMenuItem
        '
        Me.FoliosUtilizadosToolStripMenuItem.Name = "FoliosUtilizadosToolStripMenuItem"
        Me.FoliosUtilizadosToolStripMenuItem.Size = New System.Drawing.Size(317, 28)
        Me.FoliosUtilizadosToolStripMenuItem.Text = "Folios Utilizados"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(314, 6)
        '
        'FacturaciónDeClientesToolStripMenuItem
        '
        Me.FacturaciónDeClientesToolStripMenuItem.Name = "FacturaciónDeClientesToolStripMenuItem"
        Me.FacturaciónDeClientesToolStripMenuItem.Size = New System.Drawing.Size(317, 28)
        Me.FacturaciónDeClientesToolStripMenuItem.Text = "Facturación de Clientes"
        '
        'FacturasRealizadasToolStripMenuItem1
        '
        Me.FacturasRealizadasToolStripMenuItem1.Name = "FacturasRealizadasToolStripMenuItem1"
        Me.FacturasRealizadasToolStripMenuItem1.Size = New System.Drawing.Size(317, 28)
        Me.FacturasRealizadasToolStripMenuItem1.Text = "Facturas Realizadas Negocios"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarVigenciaToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(70, 27)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'ConsultarVigenciaToolStripMenuItem
        '
        Me.ConsultarVigenciaToolStripMenuItem.Name = "ConsultarVigenciaToolStripMenuItem"
        Me.ConsultarVigenciaToolStripMenuItem.Size = New System.Drawing.Size(235, 28)
        Me.ConsultarVigenciaToolStripMenuItem.Text = "Consultar Vigencia"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1})
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(73, 27)
        Me.ToolStripMenuItem40.Text = "&Ayuda"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(126, 28)
        Me.AyudaToolStripMenuItem1.Text = "&Navy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 29)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Version Beta 1.2"
        '
        'PBCNC
        '
        Me.PBCNC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCNC.BackColor = System.Drawing.Color.Transparent
        Me.PBCNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBCNC.Image = Global.FacturacionGZ.My.Resources.Resources.tarjetas_de_presentacion_NAVY_13
        Me.PBCNC.Location = New System.Drawing.Point(243, 122)
        Me.PBCNC.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCNC.Name = "PBCNC"
        Me.PBCNC.Size = New System.Drawing.Size(363, 404)
        Me.PBCNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBCNC.TabIndex = 395
        Me.PBCNC.TabStop = False
        '
        'PBFONDO
        '
        Me.PBFONDO.BackColor = System.Drawing.SystemColors.Control
        Me.PBFONDO.BackgroundImage = Global.FacturacionGZ.My.Resources.Resources.FONDOFACTURA
        Me.PBFONDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBFONDO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBFONDO.Location = New System.Drawing.Point(0, 0)
        Me.PBFONDO.Margin = New System.Windows.Forms.Padding(4)
        Me.PBFONDO.Name = "PBFONDO"
        Me.PBFONDO.Size = New System.Drawing.Size(817, 602)
        Me.PBFONDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFONDO.TabIndex = 390
        Me.PBFONDO.TabStop = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(323, 6)
        '
        'AjusteFacturasSinTimbrarToolStripMenuItem
        '
        Me.AjusteFacturasSinTimbrarToolStripMenuItem.Name = "AjusteFacturasSinTimbrarToolStripMenuItem"
        Me.AjusteFacturasSinTimbrarToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.AjusteFacturasSinTimbrarToolStripMenuItem.Text = "Ajuste Facturas Sin Timbrar"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 602)
        Me.Controls.Add(Me.PBCNC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PBFONDO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(833, 639)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación Electrónica: Navysoluciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SB.ResumeLayout(False)
        Me.SB.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBCNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFONDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SB As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NegociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Facturar33ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReImprimirMultiplesFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimbresGastadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoliosUtilizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturaciónDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasRealizadasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVigenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBCNC As System.Windows.Forms.PictureBox
    Friend WithEvents PBFONDO As PictureBox
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents AjusteFacturasSinTimbrarToolStripMenuItem As ToolStripMenuItem
End Class
