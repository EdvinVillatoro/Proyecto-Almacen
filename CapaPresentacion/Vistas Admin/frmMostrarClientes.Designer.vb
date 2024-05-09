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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(280, 225)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(75, 45)
        Me.btnAgregarUsuario.TabIndex = 0
        Me.btnAgregarUsuario.Text = "Agregar Usuario"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de DPI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido Cliente"
        '
        'txtNumeroDpiUsuario
        '
        Me.txtNumeroDpiUsuario.Location = New System.Drawing.Point(280, 81)
        Me.txtNumeroDpiUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDpiUsuario.Name = "txtNumeroDpiUsuario"
        Me.txtNumeroDpiUsuario.Size = New System.Drawing.Size(76, 20)
        Me.txtNumeroDpiUsuario.TabIndex = 6
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(280, 124)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(76, 20)
        Me.txtNombreUsuario.TabIndex = 7
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(280, 164)
        Me.txtApellidoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(76, 20)
        Me.txtApellidoUsuario.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Agregar Nuevo Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 366)
        Me.Panel1.TabIndex = 12
        '
        'frmMostrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.txtApellidoUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtNumeroDpiUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMostrarClientes"
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
End Class
