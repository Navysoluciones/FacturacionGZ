Imports System.Text.RegularExpressions
Public Class frmClientes
    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LIMPIAR(True)
        ACTIVAR(True)
    End Sub
    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTRFC.Enabled = V
        txtCalle.Enabled = Not V
        txtColonia.Enabled = Not V
        txtCP.Enabled = Not V
        CBEDO.Enabled = Not V
        txtLocalidad.Enabled = Not V
        txtMunicipio.Enabled = Not V
        txtNoExterior.Enabled = Not V
        txtNoInterior.Enabled = Not V
        TXTNOM.Enabled = Not V
        txtPais.Enabled = Not V
        txtTelefono.Enabled = Not V
        TXTREF.Enabled = Not V
        TXTWEB.Enabled = Not V
        TXTMAIL.Enabled = Not V
        TXTNCOM.Enabled = Not V
        BTNAGREGAR.Enabled = Not V
        BTNQUITAR.Enabled = Not V
        If V Then
            TXTRFC.Focus()
            TXTRFC.SelectAll()
        Else
            TXTNOM.Focus()
            TXTNOM.SelectAll()
        End If
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(TXTNOM.Text) Then
            MessageBox.Show("Debe especificar un Nombre de Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("INSERT INTO CLIENTES VALUES('" + TXTRFC.Text + "','" + TXTNOM.Text + "','" + TXTNCOM.Text + "')", frmPrincipal.CONX)
        SQL.CommandTimeout = 300
        SQL.ExecuteNonQuery()
        EXISTERFC = True
    End Sub
    Private Function VALIDADATOS() As Boolean
        If TXTRFC.Text = "XAXX010101000" Then
            MessageBox.Show("La Información de Publico General no puede ser Modificada", "Aviso", MessageBoxButtons.OK)
            Return False
        End If
        If String.IsNullOrEmpty(TXTNOM.Text) Then
            MessageBox.Show("Debe especificar un Nombre de Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TXTNOM.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtCalle.Text) Then
            MessageBox.Show("Debe especificar Calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtCalle.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtColonia.Text) Then
            MessageBox.Show("Debe especificar una Colonia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtColonia.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtLocalidad.Text) Then
            MessageBox.Show("Debe especificar una Localidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtLocalidad.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtMunicipio.Text) Then
            MessageBox.Show("Debe especificar un Municipio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtMunicipio.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtCP.Text) Then
            MessageBox.Show("Debe especificar un Código Postal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End If
        If String.IsNullOrEmpty(txtNoExterior.Text) Then
            MessageBox.Show("Debe especificar un Número Exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtCP.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtPais.Text) Then
            MessageBox.Show("Debe especificar un Pais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtPais.Focus()
            Return False
        End If


        Return True
    End Function
    Private Sub AGREGAR()
        If Not VALIDADATOS() Then
            Exit Sub
        End If
        Dim SQLGC As New SqlClient.SqlCommand("SPCLIENTES", frmPrincipal.CONX)
        SQLGC.CommandType = CommandType.StoredProcedure
        SQLGC.Parameters.Add("@RFC", SqlDbType.VarChar).Value = TXTRFC.Text
        SQLGC.Parameters.Add("@NOM", SqlDbType.VarChar).Value = TXTNOM.Text
        SQLGC.Parameters.Add("@NC", SqlDbType.VarChar).Value = TXTNCOM.Text
        SQLGC.ExecuteNonQuery()
        'If Not EXISTERFC Then
        '    GUARDAR()
        'End If
        Dim SQL As New SqlClient.SqlCommand("AMDOMICILIOSCLIENTES", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.CommandTimeout = 300
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = TXTRFC.Text
        SQL.Parameters.Add("@CALLE", SqlDbType.VarChar).Value = txtCalle.Text
        SQL.Parameters.Add("@COL", SqlDbType.VarChar).Value = txtColonia.Text
        SQL.Parameters.Add("@LOC", SqlDbType.VarChar).Value = txtLocalidad.Text
        SQL.Parameters.Add("@MUN", SqlDbType.VarChar).Value = txtMunicipio.Text
        SQL.Parameters.Add("@CP", SqlDbType.VarChar).Value = txtCP.Text
        SQL.Parameters.Add("@NOEXT", SqlDbType.VarChar).Value = txtNoExterior.Text
        SQL.Parameters.Add("@NOINT", SqlDbType.VarChar).Value = txtNoInterior.Text
        SQL.Parameters.Add("@TEL", SqlDbType.VarChar).Value = txtTelefono.Text
        SQL.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = txtPais.Text
        SQL.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = TXTMAIL.Text
        SQL.Parameters.Add("@WEB", SqlDbType.VarChar).Value = TXTWEB.Text
        SQL.Parameters.Add("@REF", SqlDbType.VarChar).Value = TXTREF.Text
        SQL.Parameters.Add("@EDO", SqlDbType.VarChar).Value = CBEDO.Text
        SQL.ExecuteNonQuery()
        LIMPIAR(False)
        CARGADATOS()
    End Sub
    Private Sub QUITAR()
        If TXTRFC.Text = "XAXX010101000" Then
            MessageBox.Show("La Información de Publico General no puede ser Modificada", "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim xyz As Short
        xyz = MessageBox.Show("¿Esta seguro que desea Eliminar los elementos Agregados?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz = 6 Then
            If Not frmPrincipal.CHECACONX Then
                Exit Sub
            End If
            Dim SQL As New SqlClient.SqlCommand("DELETE FROM DOMICILIOSCLIENTES WHERE RFC='" + TXTRFC.Text + "' AND REGISTRO=" + DGV.Item(14, DGV.CurrentRow.Index).Value.ToString, frmPrincipal.CONX)
            SQL.ExecuteNonQuery()
            CARGADATOS()
        End If
    End Sub
    Dim EXISTERFC As Boolean
    Private Sub CARGARINICIO()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        ACTIVAR(False)
        EXISTERFC = False
        Dim SQL As New SqlClient.SqlCommand("SELECT NOMBRE,NOMBRECOMERCIAL FROM CLIENTES WHERE RFC='" + TXTRFC.Text + "'", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            EXISTERFC = True
            TXTNOM.Text = LEC(0)
            TXTNCOM.Text = LEC(1)
        End If
        LEC.Close()
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        DGV.DataSource = LLENATABLA("SELECT * FROM DOMICILIOSCLIENTES WHERE RFC='" + TXTRFC.Text + "'", frmPrincipal.CadenaConexion)
        If DGV.Rows.Count <= 0 Then
            BTNQUITAR.Enabled = False
        End If
    End Sub
    Private Sub LIMPIAR(ByVal TODO As Boolean)
        'DGV.Columns.Clear()

        'For Each C As Control In Me.Controls
        '    If TypeOf C Is TextBox Then
        '        C.Text = "" ' eliminar el texto   
        '    End If
        'Next
        If TODO Then
            TXTRFC.Text = ""
            TXTNOM.Text = ""
            TXTNCOM.Text = ""
            DGV.DataSource = Nothing
            DGV.Refresh()
            CBEDO.SelectedIndex = 0
        End If
        txtCalle.Text = ""
        txtColonia.Text = ""
        txtCP.Text = ""
        txtLocalidad.Text = ""
        txtMunicipio.Text = ""
        txtNoExterior.Text = ""
        txtNoInterior.Text = ""
        txtPais.Text = "MEXICO"
        txtTelefono.Text = ""
        TXTREF.Text = ""
        TXTWEB.Text = ""
        TXTMAIL.Text = ""

    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LIMPIAR(True)
        ACTIVAR(True)
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        frmClsBusqueda.BUSCAR("SELECT RFC,NOMBRE,NOMBRECOMERCIAL [NOMBRE COMERCIAL] FROM CLIENTES ", " WHERE NOMBRECOMUN", " ORDER BY NOMBRE", "Búsqueda de Clientes", "Nombre del Cliente", "Cliente(s)", 1, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTRFC.Text = frmClsBusqueda.TREG.Rows(0).Item(0)
            CARGARINICIO()
        End If
    End Sub

    Private Sub TXTNOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTWEB.KeyPress, txtTelefono.KeyPress, TXTREF.KeyPress, txtPais.KeyPress, TXTNOM.KeyPress, txtNoInterior.KeyPress, txtNoExterior.KeyPress, TXTNCOM.KeyPress, txtMunicipio.KeyPress, TXTMAIL.KeyPress, txtLocalidad.KeyPress, txtCP.KeyPress, txtColonia.KeyPress, txtCalle.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        AGREGAR()
    End Sub

    Private Sub BTNQUITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQUITAR.Click
        QUITAR()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LIMPIAR(True)
        ACTIVAR(True)
    End Sub

    Private Sub BTNCORREO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCORREO.Click
        Dim VCCRFC As New frmCorreosClientesFacturas
        VCCRFC.MOSTRAR(TXTRFC.Text)
    End Sub

    Private Sub TXTRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRFC.KeyPress
        If e.KeyChar = Chr(13) Then
            If String.IsNullOrEmpty(TXTRFC.Text) Then
            Else
                If TXTRFC.Text.Length < 12 Then
                    MessageBox.Show("RFC Incompleto, faltan Caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
                If TXTRFC.Text.Length = 13 Then
                    If Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z,&,ñ,Ñ\s]{4})\d{6}([A-Z\w]{3})$") Then
                        CARGARINICIO()
                    Else
                        MessageBox.Show("Teclee un RFC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If TXTRFC.Text.Length = 12 Then
                    If Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z,&,ñ,Ñ\s]{3})\d{6}([A-Z\w]{3})$") Then
                        CARGARINICIO()
                    Else
                        MessageBox.Show("Teclee un RFC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub
End Class