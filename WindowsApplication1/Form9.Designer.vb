<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarClientes = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(260, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 337)
        Me.DataGridView1.TabIndex = 2
        '
        'btnAgregarClientes
        '
        Me.btnAgregarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarClientes.Location = New System.Drawing.Point(477, 90)
        Me.btnAgregarClientes.Name = "btnAgregarClientes"
        Me.btnAgregarClientes.Size = New System.Drawing.Size(124, 36)
        Me.btnAgregarClientes.TabIndex = 56
        Me.btnAgregarClientes.Text = "Agregar Clientes"
        Me.btnAgregarClientes.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAtras.Location = New System.Drawing.Point(175, 90)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(70, 36)
        Me.btnAtras.TabIndex = 58
        Me.btnAtras.Text = "ATRAS"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverInicio.Location = New System.Drawing.Point(58, 90)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(111, 36)
        Me.btnVolverInicio.TabIndex = 57
        Me.btnVolverInicio.Text = "Volver al inicio"
        Me.btnVolverInicio.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 502)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.btnAgregarClientes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarClientes As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnVolverInicio As Button
End Class
