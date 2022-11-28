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


    Dim codigo As Integer

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtCodCliente.Text = dgv.Cells(0).Value.ToString()
        Label3.Text = txtCodCliente.Text
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (conexion.Eliminar("Cliente", " CodCliente = " + txtCodCliente.Text)) Then
            MsgBox("Cliente eliminado")
            MostrarDatos()
        Else
            MsgBox("Error al eliminar")
        End If
    End Sub
End Class