Imports System.Drawing.Printing

Public Class frmReporteFacturaCliente
    Dim LDE As New List(Of String)
    Dim LNEG As New List(Of String)
    Private Sub frmReporteFacturaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LLENACOMBOBOX2(CBEMISOR, LDE, "SELECT NOMBRE,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion, "Todos los RFC", "Todos los RFC")
        CHECATABLA()
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        frmClsBusqueda.BUSCAR("SELECT RFC,NOMBRE,NOMBRECOMERCIAL [NOMBRE COMERCIAL] FROM CLIENTES ", " WHERE NOMBRECOMERCIAL", " ORDER BY NOMBRE", "Búsqueda de Clientes", "Nombre del Cliente", "Cliente(s)", 2, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTRFC.Text = frmClsBusqueda.TREG.Rows(0).Item(0)
            CARGACLIENTE()
        End If
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,N.NOMBRE NEGOCIO,F.RFCCLIENTE,F.NOMBRE CLIENTE,M.NOMBRE [METODO PAGO],CONVERT(VARCHAR(10),F.FECHA,103)FECHA,F.SUBTOTAL,F.IVA,F.TOTAL,F.RETISR RETENCIONISR,F.RETIVA RETENCIONIVA,F.ESTADO,E.NOMBRE NOMESTADO,F.VCFD [Versión],EM.TIPO,CONVERT(BIT,1)IMPRIMIR,DBO.NOTAFACTURA(F.RFCEMISOR,F.SERIE,F.FOLIO)[NOTA/CREDITO] FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE  INNER JOIN EMISORES EM ON F.RFCEMISOR =EM.RFC WHERE RFCCLIENTE='" + TXTRFC.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        If CBEMISOR.SelectedIndex <> 0 Then
            QUERY += " AND F.RFCEMISOR='" + CBEMISOR.Text + "'"
        End If
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"
        DGV.DataSource = LLENATABLAIF(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

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
        DGV.Columns(14).ReadOnly = True
        DGV.Columns(15).ReadOnly = True
        DGV.Columns(16).ReadOnly = True
        CHECATABLA()
    End Sub
    Private Sub CARGACLIENTE()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT NOMBRE,NOMBRECOMERCIAL FROM CLIENTES WHERE RFC='" + TXTRFC.Text + "'", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            TXTNOM.Text = LEC(0)
            TXTNCOM.Text = LEC(1)
        End If
        LEC.Close()
        SQL.Dispose()
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
            BTNMAIL2.Enabled = False
        Else
            BTNIMPRIMIR.Enabled = True
            BTNMAIL.Enabled = True
            BTNMAIL2.Enabled = True
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

    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        LBLDE.Text = LDE.Item(CBEMISOR.SelectedIndex)
        If CBEMISOR.SelectedIndex <> 0 Then
            LLENACOMBOBOX2(CBNEG, LNEG, "SELECT CLAVE,NOMBRE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos los Negocios", "")
        Else
            CBNEG.Items.Clear()
            CBNEG.Items.Add("Todos los Negocios")
        End If
        CBNEG.SelectedIndex = 0
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
        'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,C.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
        'MOSTRARREPORTE(REP, "Factura Electronica", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
        If DGV.Item(16, DGV.CurrentRow.Index).Value = "2" Then

            QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.UNIDAD, P.DESCRIPCION,P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            QUERY = "SELECT * FROM VRFACTURA F where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString

            ' QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            If CType(DGV.Item(11, DGV.CurrentRow.Index).Value, Double) > 0 Or CType(DGV.Item(12, DGV.CurrentRow.Index).Value, Double) > 0 Or CBEMISOR.Text = "COVM930214167" Or CBEMISOR.Text = "VEAA6508272F2" Then
                If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.2" Then
                    Dim REP As New rptFEBAJAMARISR
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                Else
                    Dim REP As New rptFEBAJAMARISR
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                End If
            Else
                If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.2" Then
                    If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
                        Dim REP As New rptFEBAJAMARCANC
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMAR3
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                Else
                    If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
                        Dim REP As New rptFEBAJAMARCANC
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMAR3
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                End If
            End If
        Else
            'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.UNIDAD, P.DESCRIPCION,P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            QUERY = "SELECT * FROM VRFACTURA F where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            If CType(DGV.Item(11, DGV.CurrentRow.Index).Value, Double) > 0 Or CType(DGV.Item(12, DGV.CurrentRow.Index).Value, Double) > 0 Or CBEMISOR.Text = "COVM930214167" Or CBEMISOR.Text = "VEAA6508272F2" Then
                If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.2" Then
                    Dim REP As New rptFEBAJAMARISR
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                Else
                    Dim REP As New rptFEBAJAMARISR
                    MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                End If
            Else
                If DGV.Item(15, DGV.CurrentRow.Index).Value = "3.2" Then
                    If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
                        Dim REP As New rptFEBAJAMARCANC
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMAR3
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                Else
                    If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
                        Dim REP As New rptFEBAJAMARCANC
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMAR3
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BTNMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMAIL.Click
        ENVIARCORREO()
    End Sub
    Private Sub ENVIARCORREO()
        If DGV.Item(13, DGV.CurrentRow.Index).Value = 3 Then
            MessageBox.Show("La factura no esta activada para Enviarse (Cancelada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim VCC As New frmCorreosClientesFacturas
        VCC.MOSTRARYENVIAR(DGV.Item(0, DGV.CurrentRow.Index).Value.ToString, DGV.Item(1, DGV.CurrentRow.Index).Value, DGV.Item(2, DGV.CurrentRow.Index).Value)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub

    Private Sub MOSTRAR2()
        Dim X As Integer
        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(17, X).Value, Boolean) Then
                Dim QUERY As String
                'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO  where F.RFCEMISOR='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.UNIDAD, P.DESCRIPCION,P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + DGV.Item(0, X).Value.ToString + "'AND F.SERIE='" + DGV.Item(1, X).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, X).Value.ToString
                QUERY = "SELECT * FROM VRFACTURA F where F.RFCEMISOR='" + DGV.Item(0, X).Value.ToString + "'AND F.SERIE='" + DGV.Item(1, X).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, X).Value.ToString
                If CType(DGV.Item(11, X).Value, Double) > 0 Or CType(DGV.Item(12, X).Value, Double) > 0 Or DGV.Item(0, X).Value = "COVM930214167" Or DGV.Item(0, X).Value = "VEAA6508272F2" Then
                    If DGV.Item(14, X).Value = "3.2" Then
                        Dim REP As New rptFEBAJAMARISR
                        MOSTRARREPORTE(REP, "Factura", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), NI)
                    ElseIf DGV.Item(14, X).Value = "2.0" Then
                        Dim REP As New rptFEBAJAMARISR
                        IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                    Else
                        Dim REP As New rptFEBAJAMARISR
                        IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                    End If
                Else
                    If DGV.Item(14, X).Value = "3.2" Then
                        If DGV.Item(13, X).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        Else
                            Dim REP As New rptFEBAJAMAR3
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        End If
                    ElseIf DGV.Item(14, X).Value = "2.0" Then
                        If DGV.Item(13, X).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        Else
                            Dim REP As New rptFEBAJAMAR3
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        End If
                    Else
                        If DGV.Item(13, X).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        Else
                            Dim REP As New rptFEBAJAMAR3
                            IMPRIMIRREPORTE(REP, LLENATABLA(QUERY, frmPrincipal.CadenaConexion), 1, NI)
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub ENVIARCORREO2()

        Dim X As Integer
        Dim SQL As New SqlClient.SqlCommand("ENVIARMAILFACTURAELECTRONICA", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.CommandTimeout = 300
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar)
        SQL.Parameters.Add("@SERIE", SqlDbType.VarChar)
        SQL.Parameters.Add("@FOLIO", SqlDbType.Int)

        For X = 0 To DGV.Rows.Count - 1
            If CType(DGV.Item(17, X).Value, Boolean) Then
                SQL.Parameters("@RFC").Value = DGV.Item(0, X).Value
                SQL.Parameters("@SERIE").Value = DGV.Item(1, X).Value
                SQL.Parameters("@FOLIO").Value = DGV.Item(2, X).Value
                SQL.ExecuteNonQuery()
            End If
        Next
    End Sub

    Dim NI As String
    Private Sub BTNMAIL2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMAIL2.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea imprimir las Facturas Marcadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        NI = ""
        PrintDialog1.ShowDialog()
        If PrintDialog1.ShowDialog.Yes Then
            NI = PrintDialog1.PrinterSettings.PrinterName
            MOSTRAR2()
        Else

        End If

        'Dim PD As New PrintDocument
        'Dim opd As New PrintDialog
        'opd.ShowDialog()
        'Dim result As DialogResult = opd.ShowDialog()
        'If (result = DialogResult.OK) Then
        '    NI = opd.PrinterSettings.PrinterName
        'End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea enviar el Correo de las Facturas Marcadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        ENVIARCORREO2()
    End Sub
End Class