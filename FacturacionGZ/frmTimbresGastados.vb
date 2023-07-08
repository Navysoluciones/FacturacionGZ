Public Class frmTimbresGastados

    Private Sub frmTimbresGastados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,E.NOMBRE,COUNT(F.RFCEMISOR)TIMBRES,DBO.TIMBRESCONTRATADOS(F.RFCEMISOR)CONTRATADOS,RESTAN=(DBO.TIMBRESCONTRATADOS(F.RFCEMISOR)-COUNT(F.RFCEMISOR)) FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC WHERE E.EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + " AND E.TIPO=1 GROUP BY F.RFCEMISOR,E.NOMBRE "
        DGV.DataSource = LLENATABLA(QUERY, frmPrincipal.CadenaConexion)
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub
End Class