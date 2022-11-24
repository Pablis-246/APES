Public Class Form7


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarClientes_Click(sender As Object, e As EventArgs) Handles btnAgregarClientes.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form9.Show()
        Me.Close()
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