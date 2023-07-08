Public Class frmCancelarFactura
    Dim LNEG As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmCancelarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LLENACOMBOBOX2LISTAS(CBEMISOR, LDE, LTIPO, "SELECT NOMBRE,TIPO,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
    End Sub

    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        LLENACOMBOBOX2(CBNEG, LNEG, "SELECT CLAVE,NOMBRE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos los Negocios", "")
        LBLDE.Text = LDE(CBEMISOR.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,N.NOMBRE NEGOCIO,F.RFCCLIENTE,C.NOMBRE CLIENTE,DBO.FNMETODOPAGO(F.METODOPAGO,F.NFORMAPAGO )FORMAPAGO,CONVERT(VARCHAR(10),F.FECHA,103)FECHA,F.SUBTOTAL,F.IVA,F.TOTAL,F.RETISR RETENCIONISR,F.RETIVA RETENCIONIVA,E.NOMBRE ESTADO,CONVERT(BIT,0,0)CANCELAR FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC  INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE  WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<=@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"
        DGV.DataSource = LLENATABLAIF(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))
        DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
        DGV.Columns(7).ReadOnly = True
        DGV.Columns(8).ReadOnly = True
        DGV.Columns(9).ReadOnly = True
        DGV.Columns(10).ReadOnly = True
        DGV.Columns(11).ReadOnly = True
        DGV.Columns(12).ReadOnly = True
        DGV.Columns(13).ReadOnly = True
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea Guardar la Información?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        GUARDAR()
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("", frmPrincipal.CONX)

        Dim X As Integer
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(14, X).Value, Boolean) Then
                If LTIPO(CBEMISOR.SelectedIndex) = 2 Then
                    SQL.CommandText = "UPDATE FACTURAS SET ESTADO=6 WHERE RFCEMISOR='" + DGV.Item(0, X).Value.ToString + "' AND SERIE='" + DGV.Item(1, X).Value.ToString + " ' AND FOLIO='" + DGV.Item(2, X).Value.ToString + " '"
                    SQL.ExecuteNonQuery()
                Else
                    SQL.CommandText = "UPDATE FACTURAS SET ESTADO=6 WHERE RFCEMISOR='" + DGV.Item(0, X).Value.ToString + "' AND SERIE='" + DGV.Item(1, X).Value.ToString + " ' AND FOLIO='" + DGV.Item(2, X).Value.ToString + " '"
                    SQL.ExecuteNonQuery()
                End If
            End If
        Next
        SQL.Dispose()
        CARGADATOS()
    End Sub
End Class