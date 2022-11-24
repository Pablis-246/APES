Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnVolverInicio_Click(sender As Object, e As EventArgs) Handles btnVolverInicio.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Form4.Show()
        Me.Close()
    End Sub


    Dim preciofinal As Integer
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxProducto.SelectedIndexChanged
        If cmbxProducto.SelectedItem = "Pantalón Friza" Then
            Label3.Text = "Precio por unidad: " + 100.ToString
        ElseIf cmbxProducto.SelectedItem = "Cargo Pantalon" Then
            Label3.Text = "Precio por unidad " + 150.ToString
        ElseIf cmbxProducto.SelectedItem = "Short Jean" Then
            Label3.Text = "Precio por unidad " + 130.ToString
        ElseIf cmbxProducto.SelectedItem = "Chaleco Inflable" Then
            Label3.Text = "Precio por unidad " + 200.ToString
        ElseIf cmbxProducto.SelectedItem = "Campera con Capucha" Then
            Label3.Text = "Precio por unidad " + 300.ToString
        ElseIf cmbxProducto.SelectedItem = "Camisa Cuadrille" Then
            Label3.Text = "Precio por unidad " + 120.ToString
        ElseIf cmbxProducto.SelectedItem = "Buzo Friza" Then
            Label3.Text = "Precio por unidad " + 250.ToString
        ElseIf cmbxProducto.SelectedItem = "Saco Blazer" Then
            Label3.Text = "Precio por unidad " + 170.ToString
        End If
    End Sub

    Private Sub NumericUpDownCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownCantidad.ValueChanged
        If cmbxProducto.SelectedItem = "Pantalón Friza" Then
            preciofinal = 100 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Cargo Pantalon" Then
            preciofinal = 150 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Short Jean" Then
            preciofinal = 130 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Chaleco Inflable" Then
            preciofinal = 200 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Campera con Capucha" Then
            preciofinal = 300 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Camisa Cuadrille" Then
            preciofinal = 120 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Buzo Friza" Then
            preciofinal = 250 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Saco Blazer" Then
            preciofinal = 170 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        End If
    End Sub


    Private Sub txtCodPresupuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPresupuesto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodCliente.Focus()
        End If
    End Sub
    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNombre.Focus()
        End If
    End Sub
End Class