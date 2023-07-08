Imports System.IO

Public Class frmConsultarVigencia
    Dim LNEG As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmConsultarVigencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LLENACOMBOBOX2LISTAS(CBEMISOR, LDE, LTIPO, "SELECT NOMBRE,TIPO,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
    End Sub
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,N.NOMBRE NEGOCIO,F.RFCCLIENTE,C.NOMBRE CLIENTE,CONVERT(VARCHAR(10),F.FECHA,103)FECHA,F.TOTAL,F.UUID,VERIFICAR=CONVERT(BIT,0,0),E.NOMBRE ESTADO,F.VCFD [Versión],STATUSSAT='' FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<=@FIN "
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
        'DGV.Columns(9).ReadOnly = False
        DGV.Columns(10).ReadOnly = True
        DGV.Columns(11).ReadOnly = True
        DGV.Columns(12).ReadOnly = True

        CHECATABLA()

    End Sub
    Private Sub CHECATABLA()

    End Sub
    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        LLENACOMBOBOX2(CBNEG, LNEG, "SELECT CLAVE,NOMBRE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos los Negocios", "")
        LBLDE.Text = LDE(CBEMISOR.SelectedIndex)
    End Sub

    Private Sub BTNIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIMPRIMIR.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea Verificar las Facturas Marcadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        VERIFICAR()
    End Sub
    Public Sub VERIFICAR()
        Cursor = Cursors.WaitCursor
        Dim X As Integer
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(9, X).Value, Boolean) Then
                Dim texto As String
                texto = "?re=" + DGV.Item(0, X).Value.ToString + "&rr=" + DGV.Item(4, X).Value.ToString + "&tt=" + Format(DGV.Item(7, X).Value, "000000000.000000") + "&id=" + DGV.Item(8, X).Value.ToString
                Dim VERI As New CONSULTASAT.ConsultaCFDIService
                Dim VIRI As String
                VIRI = VERI.Consulta(texto).Estado
                DGV.Item(12, X).Value = VIRI
            End If
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub

    Private Sub SIIMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIIMP.Click
        Dim XYZ As Short
        XYZ = MessageBox.Show("Desea Marcar los Datos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If XYZ = 6 Then
            Dim X As Integer
            For X = 0 To DGV.Rows.Count - 1
                DGV.Item(9, X).Value = True
            Next
            CHECATABLA()
        End If
    End Sub

    Private Sub NOIMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOIMP.Click
        Dim XYZ As Short
        XYZ = MessageBox.Show("Desea Desmarcar los Datos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If XYZ = 6 Then
            Dim X As Integer
            For X = 0 To DGV.Rows.Count - 1
                DGV.Item(9, X).Value = False
            Next
            CHECATABLA()
        End If
    End Sub

    Private Sub txtCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRE.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim texto As String
        Dim CANT As Double
        CANT = CType(TXTTOT.Text, Double)
        texto = "?re=" + TXTRE.Text + "&rr=" + TXTRR.Text + "&tt=" + Format(CANT, "000000000.000000") + "&id=" + TXTUUID.Text
        Dim VERI As New CONSULTASAT.ConsultaCFDIService
        Dim VIRI As String
        VIRI = VERI.Consulta(texto).Estado
        LBLRES.Text = "Resultado: " + VIRI


        'Dim ofd As New OpenFileDialog
        'ofd.Title = "Buscar XML *.xml"
        'ofd.DefaultExt = ".xml"
        'ofd.Filter = "Archivo xml (*.xml)|*.xml"
        'ofd.FilterIndex = 1
        'ofd.FileName = ""
        'If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    DGV.DataSource = StrXml2Table(ofd.FileName)
        'End If
    End Sub
    Public Function StrXml2Table(ByVal StrXML As String) As DataTable
        Dim ms As MemoryStream
        Dim returnMs As New DataTable()
        Try
            Dim buf() As Byte
            Dim ds As New DataSet

            buf = System.Text.UTF8Encoding.ASCII.GetBytes(StrXML)
            ms = New MemoryStream(buf)

            ds.ReadXml(ms)
            Return ds.Tables(0)
        Catch ex As Exception
            ' Hacer algo o mostrar mensaje de error
            Return returnMs
        Finally
            If Not ms Is Nothing Then
                ms.Close()
            End If
        End Try
    End Function
End Class