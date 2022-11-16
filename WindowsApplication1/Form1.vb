Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text

        If (usuario = "admin") And (contraseña = "1234") Then
            Form2.Show()
        Else
            MsgBox("Usuario o contraseña erronea, volver a ingresar")
        End If
    End Sub

End Class
