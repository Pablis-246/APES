Public Class Form1
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text

        If (usuario = "admin") And (contraseña = "1234") Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña erronea, volver a ingresar")
        End If

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtContraseña.Focus()
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnIngresar.Focus()
        End If
    End Sub

    Private Sub MostrarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarContraseña.CheckedChanged
        If MostrarContraseña.Checked = True Then
            txtContraseña.PasswordChar = ""
        ElseIf MostrarContraseña.Checked = False Then
            txtContraseña.PasswordChar = "•"
        End If
    End Sub
End Class
