Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmPrincipal.CONX.State = ConnectionState.Closed Or frmPrincipal.CONX.State = ConnectionState.Broken Then
                frmPrincipal.CONX.Open()
            End If
            TXTUSER.Text = My.Settings.usuario
            TXTPWD.Text = My.Settings.contraseña
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VALIDAR()
        Dim SQLUSER As New SqlClient.SqlCommand("SELECT U.CORPORATIVO,U.NIVEL,S.NOMBRE,S.CIUDAD,U.ACTIVO FROM USUARIOS U INNER JOIN CORPORATIVOS S ON U.CORPORATIVO=S.CLAVE WHERE U.USUARIO='" + TXTUSER.Text + "' AND U.PASSWORD='" + TXTPWD.Text + "'", frmPrincipal.CONX)
        Dim LECUSER As SqlClient.SqlDataReader
        LECUSER = SQLUSER.ExecuteReader
        If frmPrincipal.CONX.State = ConnectionState.Closed Or frmPrincipal.CONX.State = ConnectionState.Broken Then
            Try
                frmPrincipal.CONX.Open()
            Catch ex As Exception
                MessageBox.Show("La Conexión NO esta realizada, La Informacion No se ha Guardado, Intente en un momento por Favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
        Dim ACTIVO As Boolean
        If LECUSER.Read() Then
            frmPrincipal.CORPORATIVO = LECUSER(0)
            frmPrincipal.NivelBase = LECUSER(1)
            frmPrincipal.NombreCorporativo = LECUSER(2)
            frmPrincipal.CIUDAD = LECUSER(3)
            frmPrincipal.Usuario = TXTUSER.Text
            ACTIVO = CType(LECUSER(4), Boolean)
            LECUSER.Close()

            My.Settings.usuario = TXTUSER.Text
            My.Settings.contraseña = ""
            My.Settings.Save()
            My.Settings.Reload()
            If Not ACTIVO Then
                MessageBox.Show("Usuario deshabilitado, favor de comunicarse con su jefe inmediato", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Dim myProcesses() As Process
            'Dim myProcess As Process
            '' Returns array containing all instances of "Notepad".
            'myProcesses = Process.GetProcessesByName("OSK")
            'For Each myProcess In myProcesses
            '    myProcess.CloseMainWindow()
            'Next
            'System.Diagnostics.Process.("osk")
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            MessageBox.Show("Nombre de Usuario y Contraseña NO encontrados favor de Verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            LECUSER.Close()
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        VALIDAR()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim xyz As Short
        xyz = MessageBox.Show("Deseas realmente Salir del Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz <> 6 Then
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub TXTUSER_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTUSER.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTPWD.Focus()
        End If
    End Sub

    Private Sub TXTPWD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPWD.KeyPress
        If e.KeyChar = Chr(13) Then
            If TXTUSER.Text = "" Or TXTPWD.Text = "" Then
            Else
                VALIDAR()
            End If
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("osk")
    End Sub
End Class
