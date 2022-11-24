Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexion

    Public conexion As New SqlConnection("Data Source=LAPTOP-2TIFAL0I;Initial Catalog=APES;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
            'MsgBox("Conexion Exitosa con la Base de Datos APES")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
