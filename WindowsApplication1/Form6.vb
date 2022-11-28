Public Class Form6
    Dim conexion As conexion = New conexion()
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form4.Show()
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim agregar As String = ""
        agregar = "insert into factura values (" + txtCodFactura.Text + ", " + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDNI.Text + "', " + txtTelefono.Text + ", " + txtTotal.Text + ", '" + txtFecha.Text + "')"

        If conexion.Insertar(agregar) Then
            MsgBox("Factura agregado exitosamente")
        Else
            MsgBox("Error al agregar")
        End If


    End Sub
End Class