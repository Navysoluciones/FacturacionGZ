Public Class frmTimbresNegocios
    Dim LEMI As New List(Of String)

    Private Sub frmTimbresNegocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LLENACOMBOBOX2(CBEMISOR, LEMI, "SELECT RFC,NOMBRE FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion, "Todos los RFC", "")
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,E.NOMBRE,N.NOMBRE NEGOCIO,COUNT(F.RFCEMISOR)TIMBRES FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN NEGOCIOS N ON F.NEGOCIO=N.CLAVE WHERE E.EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + " AND E.TIPO=1 AND F.FECHA>=@INI AND F.FECHA<=@FIN "
        If CBEMISOR.SelectedIndex <> 0 Then
            QUERY += " AND F.RFCEMISOR='" + LEMI(CBEMISOR.SelectedIndex) + "'"
        End If
        QUERY += " GROUP BY F.RFCEMISOR,E.NOMBRE,N.NOMBRE "
        DGV.DataSource = LLENATABLAIF(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()
        Dim X, TT As Integer
        For X = 0 To DGV.Rows.Count - 1
            TT += DGV.Item(3, X).Value
        Next
        LBLTT.Text = "Timbres Totales: " + FormatNumber(TT, 2).ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub
End Class