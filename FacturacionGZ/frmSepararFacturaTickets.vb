Public Class frmSepararFacturaTickets
    Dim RFC, SERIE As String
    Dim FOLIO As Integer
    Private Sub frmSepararFacturaTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
    End Sub
    Public Sub MOSTRAR(ByVal VRFC As String, ByVal VSERIE As String, ByVal VFOLIO As Integer)
        RFC = VRFC
        SERIE = VSERIE
        FOLIO = VFOLIO
        CARGADATOS()
        Me.ShowDialog()
    End Sub

    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim QUERY As String
        QUERY = ""
        DGV.DataSource = LLENATABLA(QUERY, frmPrincipal.CadenaConexion)
    End Sub
End Class