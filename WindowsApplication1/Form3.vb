﻿Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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