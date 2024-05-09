<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarClientes
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
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumeroDpiUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(373, 277)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(100, 55)
        Me.btnAgregarUsuario.TabIndex = 0
        Me.btnAgregarUsuario.Text = "Agregar Usuario"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de DPI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido Cliente"
        '
        'txtNumeroDpiUsuario
        '
        Me.txtNumeroDpiUsuario.Location = New System.Drawing.Point(373, 100)
        Me.txtNumeroDpiUsuario.Name = "txtNumeroDpiUsuario"
        Me.txtNumeroDpiUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeroDpiUsuario.TabIndex = 6
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(373, 152)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreUsuario.TabIndex = 7
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(373, 202)
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtApellidoUsuario.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Agregar Nuevo Cliente"
        '
        'frmMostrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApellidoUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtNumeroDpiUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Name = "frmMostrarClientes"
        Me.Text = "frmMostrarClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumeroDpiUsuario As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtApellidoUsuario As TextBox
    Friend WithEvents Label6 As Label
End Class
