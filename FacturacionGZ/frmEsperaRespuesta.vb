Public Class frmEsperaRespuesta
    Dim CONT As Integer
    Dim VRFC, VSERIE As String
    Dim VFOLIO As Integer
    Dim VECES As Integer
    Dim TFAC As Integer
    Dim TEMI As Integer
    Private Sub frmEsperaRespuesta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
    End Sub
    Public Sub MOSTRAR(ByVal RFC As String, ByVal SERIE As String, ByVal FOLIO As Integer, ByVal TIPOFAC As Integer, ByVal TIPOEMISOR As Integer)
        Timer1.Start()
        CONT = 90
        BTNCANCELAR.Visible = False
        TFAC = TIPOFAC
        VECES = 1
        PBAR.Value = 0
        PBAR.Maximum = 90
        PBAR.Minimum = 0
        PBAR.Value = 0
        VRFC = RFC
        VSERIE = SERIE
        VFOLIO = FOLIO
        TEMI = TIPOEMISOR
        If TIPOEMISOR = 1 Then
            Label1.Text = "Validando ante PAC"
            Label2.Text = "Proveedor Autorizado de Certificación"
        Else
            Label1.Text = "Validando ante PAC"
            Label2.Text = "Proveedor Autorizado de Certificación"
        End If
        Me.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PBAR.Increment(1)
        CONT -= 1
        If CONT = 0 Then
            Timer1.Stop()            
            PBAR.Value = 0
            PBAR.Maximum = 30
            PBAR.Minimum = 0
            MOSTRARFACTURA()
            Timer1.Start()
        End If
    End Sub
    Private Sub MOSTRARFACTURA()
        If Not frmPrincipal.CHECACONX Then
            MessageBox.Show("La Conexión NO esta realizada, La Informacion No se ha Procesado, Intente en un momento por Favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim SSAT, NOAP, RES, UUID As String
        Dim EST As Int16
        Dim RISR, RIVA As Double
        SSAT = ""
        NOAP = ""
        RES = ""
        UUID = ""
        RISR = 0
        RIVA = 0
        EST = 1
        Dim SQL As New SqlClient.SqlCommand("SELECT F.SELLOSAT,F.NOAPROBACION,F.RESULTADO,F.ESTADO,F.RETIVA,F.RETISR,F.UUID FROM FACTURAS F where F.RFCEMISOR='" + VRFC + "' AND F.SERIE='" + VSERIE + "' AND F.FOLIO=" + VFOLIO.ToString, frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            SSAT = LEC(0)
            NOAP = LEC(1)
            RES = LEC(2)
            EST = LEC(3)
            RIVA = LEC(4)
            RISR = LEC(5)
            UUID = LEC(6)
        End If
        LEC.Close()
        SQL.Dispose()
        If TEMI = 1 Then
            If UUID = "" Then
                CONT = 30
                BTNCANCELAR.Visible = True
                If EST = 4 Then
                    MessageBox.Show("La Respuesta Obtenida fue: " + RES.ToString + ". Favor de revisar la Respuesta Obtenida, ya no se harán mas Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    frmMsg.MOSTRAR("Respuesta Obtenida", "La Respuesta del Conector fue: ", RES)
                    Me.Close()
                    Exit Sub
                End If
                If VECES >= 3 Then
                    MessageBox.Show("No se obtuvo respuesta favor de Comunicarse con Sistemas Veces=(" + VECES.ToString + ")", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                Else
                    MessageBox.Show("No se obtuvo respuesta, favor de esperar otros 30 seg. Veces=(" + VECES.ToString + ")", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                VECES += 1
                Exit Sub
            Else
                Dim QUERY As String
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,E.LOGOBIDIMENSIONAL CBBEMISOR,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.DESCRIPCION,CONVERT(NUMERIC(15,2),P.VALORUNITARIO,2)VALORUNITARIO,CONVERT(NUMERIC(15,2),P.IMPORTE,2)IMPORTE,F.RETISR,F.RETIVA,F.NOAPROBACION,F.AÑOAPROBACION,F.CBB CBBFACTURA,P.UNIDAD,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.COMENTARIO,P.IEPS,E.CURP FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + VRFC + "' AND F.SERIE='" + VSERIE + "' AND F.FOLIO=" + VFOLIO.ToString
                'Dim REP As New rptFacturaElectronica3
                If RIVA > 0 Or RISR > 0 Or VRFC = "COVM930214167" Or VRFC = "VEAA6508272F2" Then
                    Dim REP As New rptFEBAJAMARISR
                    MOSTRARREPORTE(REP, "Factura Electronica", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
                Else
                    Dim REP As New rptFEBAJAMAR3
                    MOSTRARREPORTE(REP, "Factura Electronica", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
                End If
                Me.Close()
            End If
        Else
            If NOAP = "" Then
                CONT = 30
                BTNCANCELAR.Visible = True
                If EST = 4 Then
                    MessageBox.Show("La Respuesta Obtenida fue: " + RES.ToString + ". Favor de revisar la Respuesta Obtenida, ya no se harán mas Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    frmMsg.MOSTRAR("Respuesta Obtenida", "La Respuesta del Conector fue: ", RES)
                    Me.Close()
                    Exit Sub
                End If
                If VECES >= 3 Then
                    MessageBox.Show("No se obtuvo respuesta favor de Comunicarse con Sistemas Veces=(" + VECES.ToString + ")", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                Else
                    MessageBox.Show("No se obtuvo respuesta, favor de esperar otros 30 seg. Veces=(" + VECES.ToString + ")", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                VECES += 1
                Exit Sub
            Else
                Dim QUERY As String
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,E.LOGOBIDIMENSIONAL CBBEMISOR,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.DESCRIPCION,CONVERT(NUMERIC(15,2),P.VALORUNITARIO,2)VALORUNITARIO,CONVERT(NUMERIC(15,2),P.IMPORTE,2)IMPORTE,F.RETISR,F.RETIVA,F.NOAPROBACION,F.AÑOAPROBACION,F.CBB CBBFACTURA,P.UNIDAD,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.COMENTARIO,P.IEPS,E.CURP FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + VRFC + "' AND F.SERIE='" + VSERIE + "' AND F.FOLIO=" + VFOLIO.ToString
                'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,C.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + frmPrincipal.EmisorBase + "' AND F.SERIE='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString
                Dim REP As New rptFacturaElectronicaV2_2
                MOSTRARREPORTE(REP, "Factura Electronica", LLENATABLA(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
                Me.Close()
            End If
        End If

    End Sub
End Class