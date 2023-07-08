Public Class frmNegocios
    Dim LDE As New List(Of String)
    Dim LPAIS As New List(Of String)
    Dim LEDO As New List(Of String)
    Dim LMUN As New List(Of String)
    Dim LLOCA As New List(Of String)

    Private Sub frmNegocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        VISUALIZACION(Me)
        LLENACOMBOBOX(cBEMISOR, LDE, "SELECT NOMBRE,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
        LLENACOMBOBOX(txtPais, LPAIS, "SELECT CLAVE,NOMBRE FROM PAISES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
        CARGAX(Me.LPAIS, txtPais, "MEX")
        LIMPIAR()
        ACTIVAR(True)


        Me.LIMPIAR()
        Me.ACTIVAR(True)
    End Sub
    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTCLA.Enabled = V
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
        txtSerie.Enabled = Not V
        txtFolioFinal.Enabled = Not V
        txtFolioInicial.Enabled = Not V
        txtAnioAprobacion.Enabled = Not V
        txtNoAprobacion.Enabled = Not V
        TXTCC.Enabled = Not V
        TXTNCC.Enabled = Not V

        BTNGUARDAR.Enabled = Not V
        BTNELIMINAR.Enabled = False
        If V Then
            TXTCLA.Focus()
            TXTCLA.SelectAll()
        Else
            TXTNOM.Focus()
            TXTNOM.SelectAll()
        End If
    End Sub
    Private Sub GUARDAR()
        If Not VALIDADATOS() Then
            Exit Sub
        End If
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(TXTNOM.Text) Then
            MessageBox.Show("Debe especificar un Nombre de Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("AMNEGOCIOS", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.CommandTimeout = 300
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@CLAVE", SqlDbType.VarChar).Value = TXTCLA.Text
        SQL.Parameters.Add("@NOM", SqlDbType.VarChar).Value = TXTNOM.Text
        SQL.Parameters.Add("@CALLE", SqlDbType.VarChar).Value = txtCalle.Text
        SQL.Parameters.Add("@COL", SqlDbType.VarChar).Value = txtColonia.Text
        SQL.Parameters.Add("@LOC", SqlDbType.VarChar).Value = txtLocalidad.Text
        SQL.Parameters.Add("@MUN", SqlDbType.VarChar).Value = txtMunicipio.Text
        SQL.Parameters.Add("@EDO", SqlDbType.VarChar).Value = CBEDO.Text
        SQL.Parameters.Add("@CP", SqlDbType.VarChar).Value = txtCP.Text
        SQL.Parameters.Add("@NOEXT", SqlDbType.VarChar).Value = txtNoExterior.Text
        SQL.Parameters.Add("@NOINT", SqlDbType.VarChar).Value = txtNoInterior.Text
        SQL.Parameters.Add("@TEL", SqlDbType.VarChar).Value = txtTelefono.Text
        SQL.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = txtPais.Text
        SQL.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = TXTMAIL.Text
        SQL.Parameters.Add("@WEB", SqlDbType.VarChar).Value = TXTWEB.Text
        SQL.Parameters.Add("@REF", SqlDbType.VarChar).Value = TXTREF.Text
        SQL.Parameters.Add("@SERIE", SqlDbType.VarChar).Value = txtSerie.Text
        SQL.Parameters.Add("@FI", SqlDbType.Int).Value = txtFolioInicial.Text
        SQL.Parameters.Add("@FF", SqlDbType.Int).Value = txtFolioFinal.Text
        SQL.Parameters.Add("@NOA", SqlDbType.VarChar).Value = txtNoAprobacion.Text
        SQL.Parameters.Add("@AÑO", SqlDbType.VarChar).Value = txtAnioAprobacion.Text
        SQL.Parameters.Add("@CC", SqlDbType.VarChar).Value = TXTCC.Text
        SQL.Parameters.Add("@NCC", SqlDbType.VarChar).Value = TXTNCC.Text

        If (Me.txtLocalidad.SelectedIndex < 0) Then
            SQL.Parameters.Add("@CLOC", SqlDbType.VarChar).Value = ""
        Else
            SQL.Parameters.Add("@CLOC", SqlDbType.VarChar).Value = LLOCA.Item(txtLocalidad.SelectedIndex)
        End If
        If (Me.txtMunicipio.SelectedIndex < 0) Then
            SQL.Parameters.Add("@CMUN", SqlDbType.VarChar).Value = ""
        Else
            SQL.Parameters.Add("@CMUN", SqlDbType.VarChar).Value = LMUN.Item(txtMunicipio.SelectedIndex)
        End If
        If (Me.CBEDO.SelectedIndex < 0) Then
            SQL.Parameters.Add("@CEDO", SqlDbType.VarChar).Value = ""
        Else
            SQL.Parameters.Add("@CEDO", SqlDbType.VarChar).Value = LEDO.Item(CBEDO.SelectedIndex)
        End If
        SQL.Parameters.Add("@CPAIS", SqlDbType.VarChar).Value = LPAIS.Item(txtPais.SelectedIndex)

        SQL.ExecuteNonQuery()
        MessageBox.Show("La información ha sido Guardada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        LIMPIAR()
        ACTIVAR(True)

    End Sub
    Private Function VALIDADATOS() As Boolean
        If TXTCLA.Text = "XAXX010101000" Then
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
            MessageBox.Show("Debe especificar un Nombre de Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End If
        If String.IsNullOrEmpty(txtNoExterior.Text) Then
            MessageBox.Show("Debe especificar un Código Postal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        ACTIVAR(False)
        Dim SQL As New SqlClient.SqlCommand("SELECT NOMBRE,CALLE,COLONIA,LOCALIDAD,MUNICIPIO,ESTADO,CP,NOEXT,NOINT,TELEFONO,PAIS,EMAIL,WEB,REFERENCIA,SERIE,FOLIOINICIAL,FOLIOFINAL,NOAPROBACION,AÑOAPROBACION,CENTROCOSTO,NOMBRECENTROCOSTO FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' AND CLAVE='" + TXTCLA.Text + "'", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            TXTNOM.Text = LEC(0)
            txtCalle.Text = LEC(1)
            txtColonia.Text = LEC(2)
            txtLocalidad.Text = LEC(3)
            txtMunicipio.Text = LEC(4)
            CBEDO.Text = LEC(5)
            txtCP.Text = LEC(6)
            txtNoExterior.Text = LEC(7)
            txtNoInterior.Text = LEC(8)
            txtTelefono.Text = LEC(10)
            txtPais.Text = LEC(10)
            TXTMAIL.Text = LEC(11)
            TXTWEB.Text = LEC(12)
            TXTREF.Text = LEC(13)
            txtSerie.Text = LEC(14)
            txtFolioInicial.Text = LEC(15)
            txtFolioFinal.Text = LEC(16)
            txtNoAprobacion.Text = LEC(17)
            txtAnioAprobacion.Text = LEC(18)
            TXTCC.Text = LEC(19)
            TXTNCC.Text = LEC(20)
            BTNELIMINAR.Enabled = True
        End If
        LEC.Close()
    End Sub
    Private Sub LIMPIAR()
        'DGV.Columns.Clear()

        'For Each C As Control In Me.Controls
        '    If TypeOf C Is TextBox Then
        '        C.Text = "" ' eliminar el texto   
        '    End If
        'Next

        TXTCLA.Text = ""
        TXTNOM.Text = ""
        CBEDO.SelectedIndex = 0

        txtCalle.Text = ""
        txtColonia.Text = ""
        txtCP.Text = ""
        txtLocalidad.Text = ""
        txtMunicipio.Text = ""
        txtNoExterior.Text = ""
        txtNoInterior.Text = ""
        txtPais.Text = ""
        txtTelefono.Text = ""
        TXTREF.Text = ""
        TXTWEB.Text = ""
        TXTMAIL.Text = ""

    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LIMPIAR()
        ACTIVAR(True)
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        frmClsBusqueda.BUSCAR("SELECT N.RFC,N.CLAVE,N.NOMBRE,N.ESTADO FROM NEGOCIOS N INNER JOIN EMISORES E ON N.RFC=E.RFC ", " WHERE E.EMPRESA='" + frmPrincipal.CORPORATIVO.ToString + "' AND NOMBRE", " ORDER BY NOMBRE", "Búsqueda de Negocios", "Nombre del Negocio", "Negocio(s)", 2, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            CBEMISOR.Text = frmClsBusqueda.TREG.Rows(0).Item(0)
            TXTCLA.Text = frmClsBusqueda.TREG.Rows(0).Item(1)
            CARGADATOS()
        End If
    End Sub


    Private Sub TXTRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCLA.KeyPress
        If e.KeyChar = Chr(13) Then
            If String.IsNullOrEmpty(TXTCLA.Text) Then
            Else
                CARGADATOS()
            End If
        End If
    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTWEB.KeyPress, txtTelefono.KeyPress, txtSerie.KeyPress, TXTREF.KeyPress, txtNoInterior.KeyPress, txtNoExterior.KeyPress, txtNoAprobacion.KeyPress, TXTMAIL.KeyPress, txtFolioInicial.KeyPress, txtFolioFinal.KeyPress, txtCP.KeyPress, txtColonia.KeyPress, txtCalle.KeyPress, txtAnioAprobacion.KeyPress, TXTNOM.KeyPress, CBEDO.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Esta seguro que desea Eliminar los elementos Agregados?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz = 6 Then
            If Not frmPrincipal.CHECACONX Then
                Exit Sub
            End If
            Dim SQL As New SqlClient.SqlCommand("DELETE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' AND CLAVE='" + TXTCLA.Text + "'", frmPrincipal.CONX)
            SQL.ExecuteNonQuery()
            MessageBox.Show("La información ha sido Eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub


    Private Sub CBEDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEDO.SelectedIndexChanged
        If frmPrincipal.CHECACONX Then
            LLENACOMBOBOX(txtMunicipio, LMUN, ("SELECT CLAVE,NOMBRE FROM MUNICIPIOS WHERE ESTADO='" & LEDO(CBEDO.SelectedIndex) & "' AND ACTIVO=1 ORDER BY NOMBRE"), frmPrincipal.CadenaConexion)
            LLENACOMBOBOX(txtLocalidad, LLOCA, ("SELECT CLAVE,NOMBRE FROM LOCALIDADES WHERE ESTADO='" & LEDO(CBEDO.SelectedIndex) & "' AND ACTIVO=1 ORDER BY NOMBRE"), frmPrincipal.CadenaConexion)
        End If        
    End Sub

    Private Sub txtPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPais.SelectedIndexChanged
        Try
            If frmPrincipal.CHECACONX Then
                MODULOGENERAL.LLENACOMBOBOX(CBEDO, LEDO, ("SELECT CLAVE,NOMBRE FROM ESTADOS WHERE PAIS='" & LPAIS(txtPais.SelectedIndex) & "' AND ACTIVO=1 ORDER BY NOMBRE"), frmPrincipal.CadenaConexion)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMunicipio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipio.SelectedIndexChanged

    End Sub

    Private Sub txtLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocalidad.SelectedIndexChanged

    End Sub
End Class