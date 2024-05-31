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
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnActualizarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnVerUsuarios = New System.Windows.Forms.Button()
        Me.txtPassUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOficinaUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(30, 158)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarUsuario.TabIndex = 0
        Me.btnAgregarUsuario.Text = "Agregar Usuario"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de DPI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'txtNumeroDpiUsuario
        '
        Me.txtNumeroDpiUsuario.Location = New System.Drawing.Point(121, 63)
        Me.txtNumeroDpiUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDpiUsuario.Name = "txtNumeroDpiUsuario"
        Me.txtNumeroDpiUsuario.Size = New System.Drawing.Size(116, 20)
        Me.txtNumeroDpiUsuario.TabIndex = 6
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(357, 67)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(109, 20)
        Me.txtNombreUsuario.TabIndex = 7
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(357, 100)
        Me.txtApellidoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(109, 20)
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
        Me.Label6.Size = New System.Drawing.Size(236, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Agregar Nuevo Usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtRol)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.btnActualizarUsuario)
        Me.Panel1.Controls.Add(Me.btnEliminarUsuario)
        Me.Panel1.Controls.Add(Me.btnVerUsuarios)
        Me.Panel1.Controls.Add(Me.btnAgregarUsuario)
        Me.Panel1.Controls.Add(Me.txtPassUsuario)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtOficinaUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumeroDpiUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtApellidoUsuario)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 621)
        Me.Panel1.TabIndex = 12
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(357, 127)
        Me.txtRol.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(109, 20)
        Me.txtRol.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Rol"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(30, 214)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(668, 316)
        Me.dgvUsuarios.TabIndex = 22
        '
        'btnActualizarUsuario
        '
        Me.btnActualizarUsuario.Location = New System.Drawing.Point(357, 158)
        Me.btnActualizarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarUsuario.Name = "btnActualizarUsuario"
        Me.btnActualizarUsuario.Size = New System.Drawing.Size(102, 29)
        Me.btnActualizarUsuario.TabIndex = 21
        Me.btnActualizarUsuario.Text = "Actualizar Usuario"
        Me.btnActualizarUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(242, 158)
        Me.btnEliminarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(102, 29)
        Me.btnEliminarUsuario.TabIndex = 20
        Me.btnEliminarUsuario.Text = "Eliminar Usuario"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnVerUsuarios
        '
        Me.btnVerUsuarios.Location = New System.Drawing.Point(136, 158)
        Me.btnVerUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerUsuarios.Name = "btnVerUsuarios"
        Me.btnVerUsuarios.Size = New System.Drawing.Size(102, 29)
        Me.btnVerUsuarios.TabIndex = 19
        Me.btnVerUsuarios.Text = "Ver Usuarios"
        Me.btnVerUsuarios.UseVisualStyleBackColor = True
        '
        'txtPassUsuario
        '
        Me.txtPassUsuario.Location = New System.Drawing.Point(121, 123)
        Me.txtPassUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassUsuario.Name = "txtPassUsuario"
        Me.txtPassUsuario.Size = New System.Drawing.Size(116, 20)
        Me.txtPassUsuario.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Contraseña"
        '
        'txtOficinaUsuario
        '
        Me.txtOficinaUsuario.Location = New System.Drawing.Point(121, 96)
        Me.txtOficinaUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOficinaUsuario.Name = "txtOficinaUsuario"
        Me.txtOficinaUsuario.Size = New System.Drawing.Size(116, 20)
        Me.txtOficinaUsuario.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Oficina"
        '
        'frmMostrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMostrarClientes"
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnActualizarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnVerUsuarios As Button
    Friend WithEvents txtPassUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOficinaUsuario As TextBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents Label8 As Label
End Class
