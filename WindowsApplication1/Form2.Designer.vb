<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEmitirFactura = New System.Windows.Forms.Button()
        Me.btnVenderProductos = New System.Windows.Forms.Button()
        Me.btnSacarPresupuesto = New System.Windows.Forms.Button()
        Me.btnVerProductos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmitirFactura
        '
        Me.btnEmitirFactura.Location = New System.Drawing.Point(173, 182)
        Me.btnEmitirFactura.Name = "btnEmitirFactura"
        Me.btnEmitirFactura.Size = New System.Drawing.Size(104, 41)
        Me.btnEmitirFactura.TabIndex = 11
        Me.btnEmitirFactura.Text = "Emitir factura"
        Me.btnEmitirFactura.UseVisualStyleBackColor = True
        '
        'btnVenderProductos
        '
        Me.btnVenderProductos.Location = New System.Drawing.Point(53, 182)
        Me.btnVenderProductos.Name = "btnVenderProductos"
        Me.btnVenderProductos.Size = New System.Drawing.Size(104, 41)
        Me.btnVenderProductos.TabIndex = 10
        Me.btnVenderProductos.Text = "Vender Productos"
        Me.btnVenderProductos.UseVisualStyleBackColor = True
        '
        'btnSacarPresupuesto
        '
        Me.btnSacarPresupuesto.Location = New System.Drawing.Point(173, 131)
        Me.btnSacarPresupuesto.Name = "btnSacarPresupuesto"
        Me.btnSacarPresupuesto.Size = New System.Drawing.Size(104, 41)
        Me.btnSacarPresupuesto.TabIndex = 9
        Me.btnSacarPresupuesto.Text = "Sacar presupuesto"
        Me.btnSacarPresupuesto.UseVisualStyleBackColor = True
        '
        'btnVerProductos
        '
        Me.btnVerProductos.Location = New System.Drawing.Point(53, 131)
        Me.btnVerProductos.Name = "btnVerProductos"
        Me.btnVerProductos.Size = New System.Drawing.Size(104, 41)
        Me.btnVerProductos.TabIndex = 8
        Me.btnVerProductos.Text = "Ver productos de deposito"
        Me.btnVerProductos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Que operaciones desea realizar?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 306)
        Me.Controls.Add(Me.btnEmitirFactura)
        Me.Controls.Add(Me.btnVenderProductos)
        Me.Controls.Add(Me.btnSacarPresupuesto)
        Me.Controls.Add(Me.btnVerProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmitirFactura As System.Windows.Forms.Button
    Friend WithEvents btnVenderProductos As System.Windows.Forms.Button
    Friend WithEvents btnSacarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnVerProductos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
