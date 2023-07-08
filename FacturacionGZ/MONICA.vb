Imports System.Drawing.Printing

Module MONICA
    Public RESPUESTAMG As String
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = Color.Black
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    If (ctr.Tag Is Nothing Or ctr.Tag <> "") Then
                                    Else
                                        ctr.ForeColor = COLORDEFAULT
                                    End If

                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.ForeColor = COLORDEFAULT
                        End If

                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form, ByVal ColorFuente As System.Drawing.Color)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = ColorFuente
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function CadenaVacia(ByVal texto As String) As Boolean
        If String.IsNullOrEmpty(Trim(texto)) Then
            Return True
        End If
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function BDExtraeUnDato(ByVal QUERY As String, ByVal CADENA As String) As String
        Dim REG As String
        REG = ""
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            REG = LEC(0)
        End If
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Return REG
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByRef LISTA3 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        LISTA2.Clear()
        LISTA3.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
            LISTA3.Add(LEC(2))
            CB.Items.Add(LEC(3))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String, ByVal INI As DateTime, ByVal FIN As DateTime) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.CommandTimeout = 300
        Dim DT As New DataTable
        DA.Fill(DT)
        CONX.Close()
        Return DT
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        DA.SelectCommand.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        DA.SelectCommand.CommandTimeout = 600
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NombreColumna As String = "")
        For Each DC As DataGridViewColumn In DGV.Columns
            If DC.Name <> NombreColumna Then
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Else
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NumeroColumna As Integer = -1)
        Dim NC As Integer
        NC = DGV.ColumnCount
        For X = 0 To NC
            If NC = NumeroColumna Then
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Next
    End Sub
    Public Function OPCargaX(ByRef LISTA As List(Of String), ByRef CB As ComboBox, ByVal VALOR As String) As Boolean
        Dim X As Integer
        For X = 0 To LISTA.Count - 1
            If LISTA(X) = VALOR Then
                CB.SelectedIndex = X
                Return True
            End If
        Next
        Try
            CB.SelectedIndex = 0
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Enum MsgsOk

        Corte
        Reporte
        Informacion
        Exportacion
        Importacion
        Finalizado
        Impresion
        Guardado

    End Enum
    Public Function OPMsgOK(ByVal Msg As MsgsOk) As Boolean

        Dim MM As String
        MM = ""
        Select Case Msg
            Case MsgsOk.Corte
                MM = "El corte se ha realizado correctamente"
            Case MsgsOk.Reporte
                MM = "El reporte se ha creado exitosamente"
            Case MsgsOk.Informacion
                MM = "La información ha sido procesada con éxito"
            Case MsgsOk.Exportacion
                MM = "La exportación ha concluido con éxito"
            Case MsgsOk.Importacion
                MM = "La importacion se ha realizado exitosamente"
            Case MsgsOk.Finalizado
                MM = "La tarea ha finalizado con éxito"
            Case MsgsOk.Impresion
                MM = "La impresión se ha realizado con éxito"
            Case MsgsOk.Guardado
                MM = "La información ha sido guardada correctamente"
        End Select
        MessageBox.Show(MM, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True

    End Function

    Public Function OPMsgOK(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgError(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return True
    End Function
    Public Function OPMsgGuardadoOK() As Boolean
        MessageBox.Show("La información ha sido guardada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If ABC = 6 Then
            Return True
        End If
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String, ByVal BtnNoDefault As Boolean) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ABC = 6 Then
            Return True
        End If
        Return False
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As String
        Dim REG As String
        REG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
            SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()
        Catch ex As Exception
            REG = ex.Message.ToString
        End Try

        Return REG
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String) As String

        RESPUESTAMG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()

        Catch ex As Exception
            RESPUESTAMG = ex.Message.ToString
        End Try

        Return RESPUESTAMG
    End Function
End Module
