Public Class Form5

    Dim conexion As conexion = New conexion()
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Dim preciofinal As Integer
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxProducto.SelectedIndexChanged
        If cmbxProducto.SelectedItem = "Pantalón Friza" Then
            Label3.Text = "Precio por unidad: " + 250.ToString
        ElseIf cmbxProducto.SelectedItem = "Cargo Pantalon" Then
            Label3.Text = "Precio por unidad " + 300.ToString
        ElseIf cmbxProducto.SelectedItem = "Short Jean" Then
            Label3.Text = "Precio por unidad " + 210.ToString
        ElseIf cmbxProducto.SelectedItem = "Chaleco Inflable" Then
            Label3.Text = "Precio por unidad " + 250.ToString
        ElseIf cmbxProducto.SelectedItem = "Campera con Capucha" Then
            Label3.Text = "Precio por unidad " + 370.ToString
        ElseIf cmbxProducto.SelectedItem = "Camisa Cuadrille" Then
            Label3.Text = "Precio por unidad " + 350.ToString
        ElseIf cmbxProducto.SelectedItem = "Buzo Friza" Then
            Label3.Text = "Precio por unidad " + 320.ToString
        ElseIf cmbxProducto.SelectedItem = "Saco Blazer" Then
            Label3.Text = "Precio por unidad " + 400.ToString
        End If
    End Sub

    Private Sub NumericUpDownCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownCantidad.ValueChanged
        If cmbxProducto.SelectedItem = "Pantalón Friza" Then
            preciofinal = 250 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Cargo Pantalon" Then
            preciofinal = 300 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Short Jean" Then
            preciofinal = 210 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Chaleco Inflable" Then
            preciofinal = 250 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Campera con Capucha" Then
            preciofinal = 370 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Camisa Cuadrille" Then
            preciofinal = 350 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Buzo Friza" Then
            preciofinal = 320 * NumericUpDownCantidad.Value
            Label4.Text = "Precio Final: " + preciofinal.ToString
        ElseIf cmbxProducto.SelectedItem = "Saco Blazer" Then
            preciofinal = 400 * NumericUpDownCantidad.Value
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

    Private Sub btnCrearPresupuesto_Click(sender As Object, e As EventArgs) Handles btnCrearPresupuesto.Click
        Dim agregar As String = ""
        Dim CantidadString As String = ""
        Dim PrecioString As String = ""
        If cmbxProducto.SelectedItem = "Pantalón Friza" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 250, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Cargo Pantalon" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 300, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Short Jean" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 210, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Chaleco Inflable" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 250, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Campera con Capucha" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 370, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Camisa Cuadrille" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 350, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Buzo Friza" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 320, '" + CantidadString + "', '" + PrecioString + "')"
        ElseIf cmbxProducto.SelectedItem = "Saco Blazer" Then
            CantidadString = NumericUpDownCantidad.Value
            PrecioString = preciofinal
            agregar = "insert into presupuesto values (" + txtCodPresupuesto.Text + ", " + txtCodCliente.Text + ", '" + txtNombre.Text + "', '" + cmbxProducto.SelectedItem.ToString + "', 400, '" + CantidadString + "', '" + PrecioString + "')"
        End If

        If conexion.Insertar(agregar) Then
            MsgBox("Presupuesto agregado exitosamente")
        Else
            MsgBox("Error al agregar")
        End If
        Form4.Show()
        Me.Close()
    End Sub
End Class