<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(356, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 52)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAtras.Location = New System.Drawing.Point(190, 311)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(69, 52)
        Me.btnAtras.TabIndex = 42
        Me.btnAtras.Text = "ATRAS"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.Location = New System.Drawing.Point(115, 311)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(69, 52)
        Me.btnVolverInicio.TabIndex = 41
        Me.btnVolverInicio.Text = "Volver al inicio"
        Me.btnVolverInicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Agregar Clientes"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(426, 226)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(119, 20)
        Me.txtTelefono.TabIndex = 60
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(173, 226)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(119, 20)
        Me.txtDNI.TabIndex = 59
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 162)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtNombre.TabIndex = 58
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(426, 164)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(119, 20)
        Me.txtApellido.TabIndex = 57
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(239, 110)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(119, 20)
        Me.txtCodCliente.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(335, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Codigo de Cliente:"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 452)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnVolverInicio As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
