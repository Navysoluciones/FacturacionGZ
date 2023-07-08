Public Class frmSeleccionaFacturaPago
    Dim EMI, CLI As String
    Public CSERIE, CFOLIO As String
    Public CFECHA As DateTime
    Public CTOT As Double
    Public DTRESULTADO As New DataTable
    Private Sub frmSeleccionaFacturaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
    End Sub
    Public Sub MOSTRAR(ByVal VEMI As String, ByVal VCLI As String, ByVal NCLI As String)
        EMI = VEMI
        CLI = VCLI
        LBLA.Text = CLI
        LBLB.Text = NCLI

        CARGADATOS()
        Try
            Me.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,F.RFCCLIENTE,F.FECHA,F.TOTAL,F.UUID,MARCAR=CONVERT(BIT,0) FROM FACTURAS F WHERE RFCEMISOR='" + EMI + "' AND RFCCLIENTE='" + CLI + "' AND ESTADO=2 AND VCFD='3.3' AND NMETODOPAGO ='PPD'"
        DGV.DataSource = LLENATABLA(QUERY, frmPrincipal.CadenaConexion)
        DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If DGV.Rows.Count <= 0 Then
            MessageBox.Show("El cliente no cuenta con facturas a crédito realizadas con versión 3.3", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End If
    End Sub
    Private Sub CALCULASELECCIONADO()
        Dim TS As Double
        TS = 0
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(6, X).Value, Boolean) Then
                TS += DGV.Item(5, X).Value
            End If
        Next
        LBLTF.Text = "Total de Facturas: " + FormatNumber(TS, 2).ToString
    End Sub
    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        If DGV.Rows.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End If
        Dim ELEMSEL As Integer
        ELEMSEL = 0
        Dim X As Integer
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(7, X).Value, Boolean) Then
                ELEMSEL += 1
            End If
        Next
        If ELEMSEL <= 0 Then
            MessageBox.Show("No se ha marcado ninguna factura a relacionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        DTRESULTADO.Clear()
        DTRESULTADO.Columns.Clear()
        DTRESULTADO.Columns.Add("SERIE")
        DTRESULTADO.Columns.Add("FOLIO")
        DTRESULTADO.Columns.Add("FECHA", GetType(DateTime))
        DTRESULTADO.Columns.Add("TOTAL", GetType(Double))
        DTRESULTADO.Columns.Add("UUID")
        CTOT = 0
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(7, X).Value, Boolean) Then
                Dim DOW As DataRow = DTRESULTADO.NewRow()
                DOW(0) = DGV.Item(1, X).Value
                DOW(1) = DGV.Item(2, X).Value
                DOW(2) = DGV.Item(4, X).Value
                DOW(3) = DGV.Item(5, X).Value
                DOW(4) = DGV.Item(6, X).Value
                CTOT += DGV.Item(5, X).Value
                DTRESULTADO.Rows.Add(DOW)
            End If
        Next


        'CSERIE = DGV.Item(1, DGV.CurrentRow.Index).Value
        'CFOLIO = DGV.Item(2, DGV.CurrentRow.Index).Value
        'CFECHA = DGV.Item(4, DGV.CurrentRow.Index).Value
        'CTOT = DGV.Item(5, DGV.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        ' CALCULASELECCIONADO()
    End Sub
End Class