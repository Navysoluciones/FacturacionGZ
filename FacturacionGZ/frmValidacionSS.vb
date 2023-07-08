Imports System.Xml

Public Class frmValidacionSS

    Dim DTPRIN As New DataTable
    Dim CONX As New SqlClient.SqlConnection
    Dim CADENACONEXION As String
    Private Sub frmValidacionSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = frmPrincipal.Icon
        Dim IP As String
        DTPRIN.Columns.Add("EMISOR")
        DTPRIN.Columns.Add("SERIE")
        DTPRIN.Columns.Add("FOLIO")
        DTPRIN.Columns.Add("TOTAL")
        DTPRIN.Columns.Add("RECEPTOR")
        DTPRIN.Columns.Add("UUID")
        DTPRIN.Columns.Add("MENSAJE")
        DTPRIN.Columns.Add("ESCANCELABLE")
        DTPRIN.Columns.Add("ESTADO")
        DTPRIN.Columns.Add("ESTATUSCANCELACION")
        DTPRIN.Columns.Add("EstadoFac")
        DTPRIN.Columns.Add("TipoComprobante")


    End Sub
    Private Sub CARGADATOS()
        Try

            Dim DT As New DataTable
            DT = LLENATABLA("select top 5 RFCEMISOR,SERIE,FOLIO,TOTAL,RFCEMISOR RECEPTOR,UUID,ESTADO,NTIPOCOMPROBANTE from facturas with (nolock) where fecha>='01/03/2020'", CADENACONEXION)
            Dim X As Integer
            DTPRIN.Rows.Clear()

            For X = 0 To DT.Rows.Count - 1
                Dim DOW As System.Data.DataRow = DTPRIN.NewRow
                DOW(0) = DT.Rows(X).Item(0).ToString
                DOW(1) = DT.Rows(X).Item(1).ToString
                DOW(2) = DT.Rows(X).Item(2).ToString
                DOW(3) = DT.Rows(X).Item(3).ToString
                DOW(4) = DT.Rows(X).Item(4).ToString
                DOW(5) = DT.Rows(X).Item(5).ToString
                DOW(10) = DT.Rows(X).Item(6).ToString
                DOW(11) = DT.Rows(X).Item(7).ToString
                DTPRIN.Rows.Add(DOW)
            Next
            DGV.DataSource = DTPRIN

        Catch ex As Exception

        End Try
    End Sub

    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function
    Dim SX, IX, TX As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Cargar archivo de XML *.xml"
        ofd.DefaultExt = ".key"
        ofd.Filter = "Archivo XML (*.xml)|*.xml"
        ofd.FilterIndex = 1
        ofd.FileName = ""

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim xmlCfdi As New System.Xml.XmlDocument()
            'xmlCfdi.Load(ofd.FileName)
            Dim DS As New DataSet
            DS.ReadXml(ofd.FileName)
            Dim xDoc As XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt As XmlElement
            Dim xNodo2 As XmlNodeList
            xDoc = New XmlDocument
            xDoc.Load(ofd.FileName)

            DGV.DataSource = DS
            DGV.DataMember = "Concepto"
            Dim ABC As String
            For Each TABLENAME As DataTable In DS.Tables
                ABC = TABLENAME.TableName
            Next
            Try
                xNodo = xDoc.GetElementsByTagName("cfdi:Conceptos")
                If xNodo.Count > 0 Then
                    For Each xAtt In xNodo
                        xNodo2 = xAtt.GetElementsByTagName("cfdi:Traslado")
                        For Each childnodes In xNodo2
                            IX = VarXml(childnodes, "Importe")
                        Next
                    Next
                End If
                'DGV2.DataSource = DS.Tables("Traslado")
                'DGV2.DataMember = "Traslados"
                DGV2.DataSource = DS
                DGV2.DataMember = "Traslado"
            Catch ex As Exception

            End Try

            Try
                DGV3.DataSource = DS
                DGV3.DataMember = "Comprobante"
            Catch ex As Exception

            End Try
            Try
                DGV4.DataSource = DS
                DGV4.DataMember = "Mercancia"
            Catch ex As Exception

            End Try
            'Dim texto As String
            'texto = ""
            'For x = 0 To DS.Tables.Count - 1
            '    texto += DS.Tables(x).TableName + "|"
            'Next
            'MessageBox.Show(texto)
        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class