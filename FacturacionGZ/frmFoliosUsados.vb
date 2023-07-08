Public Class frmFoliosUsados

    Private Sub frmFoliosUsados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR RFC,N.NOMBRE NEGOCIO,F.SERIE,MAX(FOLIO)FOLIOS FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.NEGOCIO=N.CLAVE WHERE F.TIPOFACTURA = 2 GROUP BY F.RFCEMISOR,N.NOMBRE,F.SERIE"
        DGV.DataSource = LLENATABLA(QUERY, frmPrincipal.CadenaConexion)
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()
        Dim X As Integer
        Dim TOT As Double
        TOT = 0
        For X = 0 To DGV.Rows.Count - 1
            TOT += DGV.Item(3, X).Value
        Next
        LBLTF.Text = "Total Folios: " + FormatNumber(TOT, 2).ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub
End Class