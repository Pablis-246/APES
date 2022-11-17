Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Bienvenido emplado " + Form1.txtUsuario.Text + " al sistema de APES"
    End Sub

    Private Sub btnVerProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProductos.Click
        Form3.Show()
    End Sub

    Private Sub btnSacarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSacarPresupuesto.Click
        Form4.Show()
    End Sub

    Private Sub btnVenderProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderProductos.Click

    End Sub

    Private Sub btnEmitirFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirFactura.Click

    End Sub
End Class