' ELABORADO POR: Alberto Rodríguez (Kripto-Software )
' FECHA: Diciembre de 2010
' LUGAR: México D.F
' La licencia de este Software incluye realizar cambios
' y adaptaciones según las necesidades del comprador pero
' atendiendo las disposiciones que señala el SAT.
' QUEDA ESTRICTAMENTE PROHIBIDO VENDER, REPRODUCIR, COPIAR, 
' DISTRIBUIR Y/O DONAR EL PRODUCTO SIN EL CONSENTIMIENTO DEL DESARROLLADOR
' POR FAVOR RESPETA EL TRABAJO DE LOS DEMAS COLEGAS. GRACIAS

Imports System.Security.Cryptography
Imports System.IO

Module mGlobal
    'Public Function Encrypt(ByVal strText As String, Optional ByVal strEncrKey As String = "&%#@?,:*") As String
    '    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    '    Try
    '        Dim bykey() As Byte = System.Text.Encoding.UTF8.GetBytes(Microsoft.VisualBasic.Strings.Left(strEncrKey, 8))
    '        Dim InputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
    '        Dim des As New DESCryptoServiceProvider
    '        Dim ms As New MemoryStream
    '        Dim cs As New CryptoStream(ms, des.CreateEncryptor(bykey, IV), CryptoStreamMode.Write)
    '        cs.Write(InputByteArray, 0, InputByteArray.Length)
    '        cs.FlushFinalBlock()
    '        Return Convert.ToBase64String(ms.ToArray())
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    'End Function

    'Public Function Decrypt(ByVal strText As String, Optional ByVal sDecrKey As String = "&%#@?,:*") As String
    '    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    '    Dim inputByteArray(strText.Length) As Byte
    '    Try
    '        Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Microsoft.VisualBasic.Strings.Left(sDecrKey, 8))
    '        Dim des As New DESCryptoServiceProvider
    '        inputByteArray = Convert.FromBase64String(strText)
    '        Dim ms As New MemoryStream
    '        Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)
    '        cs.Write(inputByteArray, 0, inputByteArray.Length)
    '        cs.FlushFinalBlock()
    '        Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
    '        Return encoding.GetString(ms.ToArray())
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try
    'End Function

    Public Function App_Path() As String
        Dim sPath As String = System.AppDomain.CurrentDomain.BaseDirectory()
        If sPath.EndsWith("\") Then
            Return sPath
        Else
            Return sPath & "\"
        End If
    End Function

    Public Function App_Path_Sistema() As String
        Dim sPath As String = System.AppDomain.CurrentDomain.BaseDirectory()
        If sPath.EndsWith("\") Then
            Return sPath & "Sistema\"
        Else
            Return sPath & "\Sistema\"
        End If
    End Function

    Public Function App_Path_Sistema_SAT() As String
        Dim sPath As String = System.AppDomain.CurrentDomain.BaseDirectory()
        If sPath.EndsWith("\") Then
            Return sPath & "Sistema\SAT\"
        Else
            Return sPath & "\Sistema\SAT\"
        End If
    End Function

    Public Function LimpiarRFC(ByVal RFC As String) As String
        Dim RFCGenerico As String = "XAXX010101000"
        Dim sRFC As String = RFC.Trim

        If Not String.IsNullOrEmpty(RFC) Then
            sRFC = Replace(sRFC, " ", String.Empty)
            sRFC = Replace(sRFC, "-", String.Empty)
            sRFC = Trim(sRFC)
            If sRFC.Length = 0 Then
                sRFC = RFCGenerico
            ElseIf sRFC.Length < 12 Then
                sRFC = RFCGenerico
            ElseIf sRFC.Length > 13 Then
                sRFC = RFCGenerico
            End If
        Else
            sRFC = RFCGenerico
        End If

        Return sRFC
    End Function

    Public Function ComprobarCampo(ByVal Campo As Object) As Boolean
        Dim bRes As Boolean = True
        If IsDBNull(Campo) Then
            bRes = False
        Else
            If String.IsNullOrEmpty(Campo.ToString) Then
                bRes = False
            End If
        End If
        Return bRes
    End Function

    Public Function ValidaTablaFactura(ByVal Tabla As Data.DataTable) As Boolean
        Dim bRes As Boolean = True

        Dim Campos As New List(Of String)
        Campos.Add("Folio")
        Campos.Add("Serie")
        Campos.Add("Nombre")
        Campos.Add("RFC")
        Campos.Add("Calle")
        Campos.Add("NoExterior")
        Campos.Add("NoInterior")
        Campos.Add("Colonia")
        Campos.Add("CodigoPostal")
        Campos.Add("Estado")
        Campos.Add("Localidad")
        Campos.Add("Municipio")
        Campos.Add("Pais")
        Campos.Add("Referencia")
        Campos.Add("IVA")
        Campos.Add("Descuento")
        Campos.Add("Fecha")
        Campos.Add("FormaPago")

        For Each Col As Data.DataColumn In Tabla.Columns
            If Col.Ordinal < Campos.Count Then
                If Not Col.ColumnName.ToLower.Equals(Campos(Col.Ordinal).ToLower) Then
                    bRes = False
                    Exit For
                End If
            End If
        Next

        Return bRes
    End Function

    Public Function ValidaTablaFacturaDetalle(ByVal Tabla As Data.DataTable) As Boolean
        Dim bRes As Boolean = True

        Dim Campos As New List(Of String)
        Campos.Add("Folio")
        Campos.Add("Serie")
        Campos.Add("Unidad")
        Campos.Add("Descripcion")
        Campos.Add("Cantidad")
        Campos.Add("Precio")
        Campos.Add("Importe")
        Campos.Add("Codigo")

        For Each Col As Data.DataColumn In Tabla.Columns
            If Col.Ordinal < Campos.Count Then
                If Not Col.ColumnName.ToLower.Equals(Campos(Col.Ordinal).ToLower) Then
                    bRes = False
                    Exit For
                End If
            End If
        Next

        Return bRes
    End Function
End Module
