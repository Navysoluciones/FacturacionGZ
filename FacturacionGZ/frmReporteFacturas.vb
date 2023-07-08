Public Class frmReporteFacturas
    Dim LNEG As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmReporteFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        LLENACOMBOBOX2LISTAS(CBEMISOR, LDE, LTIPO, "SELECT NOMBRE,TIPO,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
        CHECATABLA()
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
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,N.NOMBRE NEGOCIO,F.RFCCLIENTE,F.NOMBRE CLIENTE,DBO.FNMETODOPAGO(F.METODOPAGO,F.NFORMAPAGO )FORMAPAGO,CONVERT(VARCHAR(10),F.FECHA,103)FECHA,F.SUBTOTAL,F.IVA,F.TOTAL,F.RETISR RETENCIONISR,F.RETIVA RETENCIONIVA,F.ESTADO,E.NOMBRE NOMESTADO,F.VCFD [Versión],NTIPOCOMPROBANTE FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"
        DGV.DataSource = LLENATABLAIF(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))

        DGV.Columns(8).DefaultCellStyle = FORMATONUMERICO()
        DGV.Columns(9).DefaultCellStyle = FORMATONUMERICO()
        DGV.Columns(10).DefaultCellStyle = FORMATONUMERICO()
        DGV.Columns(11).DefaultCellStyle = FORMATONUMERICO()
        DGV.Columns(12).DefaultCellStyle = FORMATONUMERICO()
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()
        Dim S, I, T, RISR, RIVA As Double
        S = 0
        I = 0
        T = 0
        RISR = 0
        RIVA = 0
        Dim X As Integer
        If DGV.Rows.Count <= 0 Then
            BTNIMPRIMIR.Enabled = False
            BTNMAIL.Enabled = False
        Else
            BTNIMPRIMIR.Enabled = True
            BTNMAIL.Enabled = True
            For X = 0 To DGV.Rows.Count - 1
                If DGV.Item(13, X).Value = 2 Then
                    S += DGV.Item(8, X).Value
                    I += DGV.Item(9, X).Value
                    T += DGV.Item(10, X).Value
                    RISR += DGV.Item(11, X).Value
                    RIVA += DGV.Item(12, X).Value
                End If
            Next
        End If
       
        LBLS.Text = FormatNumber(S, 2).ToString
        LBLI.Text = FormatNumber(I, 2).ToString
        LBLT.Text = FormatNumber(T, 2).ToString
        LBLRISR.Text = FormatNumber(RISR, 2).ToString
        LBLRIVA.Text = FormatNumber(RIVA, 2).ToString
    End Sub

    Private Sub BTNIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIMPRIMIR.Click
        MOSTRAR()
    End Sub
    Private Sub MOSTRAR()
        If DGV.Item(13, DGV.CurrentRow.Index).Value <> 2 Then
            Dim xyz As Short
            xyz = MessageBox.Show("La Factura se encuentra Cancelada, o sin Timbrar ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If xyz <> 6 Then
                Exit Sub
            End If
        End If
        Dim QUERY As String
        Dim ESTADO As String
        ESTADO = DGV.Item(14, DGV.CurrentRow.Index).Value.ToString
        If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.3" Then
            QUERY = "SELECT * FROM VRFACTURA33 F where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            If ESTADO = "Cancelada" Then
                Dim REP As New rptFEBajamar33CANC
                MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
            Else
                If DGV.Item(16, DGV.CurrentRow.Index).Value = "P" Then
                    Dim REP As New rptRecepcionPagos
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                Else
                    Dim REP As New rptFEBajamar33
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                End If

            End If

        Else
            'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,C.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            'MOSTRARREPORTE(REP, "Factura Electronica", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
            If LTIPO(CBEMISOR.SelectedIndex) = 2 Then
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,NOCERTIFICADO='00001000000104182352',F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,E.LOGOBIDIMENSIONAL CBBEMISOR,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.DESCRIPCION,CONVERT(NUMERIC(15,2),P.VALORUNITARIO,2)VALORUNITARIO,CONVERT(NUMERIC(15,2),P.IMPORTE,2)IMPORTE,F.RETISR,F.RETIVA,F.NOAPROBACION,F.AÑOAPROBACION,F.CBB CBBFACTURA,P.UNIDAD,F.DIGITOSTC,E.REGIMEN FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                If DGV.Item(15, DGV.CurrentRow.Index).Value = "2.2" Then
                    Dim REP As New rptFacturaElectronicaV2_2
                    MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                Else
                    Dim REP As New rptFacturaElectronica4
                    MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                End If
            Else
                'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                'Dim REP As New rptFacturaElectronica3
                'MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                If CType(DGV.Item(11, DGV.CurrentRow.Index).Value, Double) > 0 Then
                    If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.0" Then
                        Dim REP As New rptFacturaElectronica2
                        MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptReporteFacturaElectronicaISRV3_2
                        MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                Else
                    If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.0" Then
                        Dim REP As New rptFacturaElectronica3
                        MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptReporteFacturaElectronicaV3_2
                        MOSTRARREPORTE(REP, "Reporte de Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                End If

            End If
        End If
    End Sub
    Private Sub ENVIARCORREO()
        If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
            MessageBox.Show("La factura no esta activada para Enviarse (Cancelada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim VCC As New frmCorreosClientesFacturas
        VCC.MOSTRARYENVIAR(DGV.Item(0, DGV.CurrentRow.Index).Value.ToString, DGV.Item(1, DGV.CurrentRow.Index).Value.ToString, DGV.Item(2, DGV.CurrentRow.Index).Value)
    End Sub
    Private Sub BTNMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMAIL.Click
        ENVIARCORREO()
    End Sub
End Class