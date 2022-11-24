Public Class Form8

    Dim conexion As conexion = New conexion()

    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDNI.Focus()
        End If
    End Sub
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTelefono.Focus()
        End If
    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1.Focus()
        End If
    End Sub
    Private Sub btnVolverInicio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtras.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim agregar As String = "insert into cliente values (" + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDNI.Text + "', " + txtTelefono.Text + ")"
        If (conexion.Insertar(agregar)) Then
            MsgBox("Cliente agregado exitosamente")
        Else
            MsgBox("Error al agregar")
        End If

        Form7.Show()
        Me.Close()
    End Sub

End Class