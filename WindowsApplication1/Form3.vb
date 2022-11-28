Public Class Form3
    Dim conexion As conexion = New conexion()

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatosDataGridView1()
        MostrarDatosDataGridView2()
    End Sub

    Public Sub MostrarDatosDataGridView1()
        conexion.Consulta("SELECT P.CodProducto, P.Nombre, PD.CodDeposito FROM Productos P, Producto_Deposito PD WHERE P.CodProducto = PD.CodProducto AND PD.CodDeposito = 1", "conexion")
        DataGridView1.DataSource = conexion.ds.Tables("conexion")
    End Sub
    Public Sub MostrarDatosDataGridView2()
        conexion.Consulta("SELECT P.CodProducto, P.Nombre, PD.CodDeposito FROM Productos P, Producto_Deposito PD WHERE P.CodProducto = PD.CodProducto AND PD.CodDeposito = 2", "conexion")
        DataGridView2.DataSource = conexion.ds.Tables("conexion")
    End Sub

    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form2.Show()
        Me.Close()
    End Sub


End Class