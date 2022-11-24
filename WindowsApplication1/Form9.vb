Public Class Form9
    Dim conexion As conexion = New conexion()

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("select * from cliente", "conexion")
        DataGridView1.DataSource = conexion.ds.Tables("conexion")
    End Sub

    Private Sub btnAgregarClientes_Click(sender As Object, e As EventArgs) Handles btnAgregarClientes.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form7.Show()
        Me.Close()
    End Sub
End Class