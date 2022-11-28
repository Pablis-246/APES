Public Class Form10

    Dim conexion As conexion = New conexion()
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("select * from Factura", "conexion")
        DataGridView1.DataSource = conexion.ds.Tables("conexion")
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtCodFactura.Text = dgv.Cells(0).Value.ToString()
        Label3.Text = txtCodFactura.Text
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (conexion.Eliminar("Factura", " CodFacturaVentas = " + txtCodFactura.Text)) Then
            MsgBox("Factura eliminado")
            MostrarDatos()
        Else
            MsgBox("Error al eliminar")
        End If
    End Sub

    Private Sub btnAgregarFactura_Click(sender As Object, e As EventArgs) Handles btnAgregarFactura.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class