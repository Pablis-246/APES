<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAgregarClientes = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Sector Clientes"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(274, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 46)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Ver Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAgregarClientes
        '
        Me.btnAgregarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAgregarClientes.Location = New System.Drawing.Point(274, 112)
        Me.btnAgregarClientes.Name = "btnAgregarClientes"
        Me.btnAgregarClientes.Size = New System.Drawing.Size(149, 46)
        Me.btnAgregarClientes.TabIndex = 55
        Me.btnAgregarClientes.Text = "Agregar Clientes"
        Me.btnAgregarClientes.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAtras.Location = New System.Drawing.Point(133, 309)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(69, 52)
        Me.btnAtras.TabIndex = 62
        Me.btnAtras.Text = "ATRAS"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.Location = New System.Drawing.Point(58, 309)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(69, 52)
        Me.btnVolverInicio.TabIndex = 61
        Me.btnVolverInicio.Text = "Volver al inicio"
        Me.btnVolverInicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 30)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "APES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(58, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 139)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 406)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAgregarClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAgregarClientes As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnVolverInicio As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
