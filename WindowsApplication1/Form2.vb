Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Bienvenido " + Form1.txtUsuario.Text
    End Sub

    Private Sub btnVerProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProductos.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btnVenderProductos_Click_1(sender As Object, e As EventArgs) Handles btnVenderProductos.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarClientes_Click(sender As Object, e As EventArgs) Handles btnAgregarClientes.Click
        Form7.Show()
        Me.Close()
    End Sub
End Class