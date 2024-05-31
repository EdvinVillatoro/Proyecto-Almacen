<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contenedorAdmin
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
        Me.btnAbrirEdificios = New System.Windows.Forms.Button()
        Me.btnAbrirClientes = New System.Windows.Forms.Button()
        Me.btnOficinas = New System.Windows.Forms.Button()
        Me.BtnServiciosPrestados = New System.Windows.Forms.Button()
        Me.btnServiciosSolicitados = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbrirEdificios
        '
        Me.btnAbrirEdificios.BackColor = System.Drawing.SystemColors.Control
        Me.btnAbrirEdificios.Location = New System.Drawing.Point(12, 95)
        Me.btnAbrirEdificios.Name = "btnAbrirEdificios"
        Me.btnAbrirEdificios.Size = New System.Drawing.Size(211, 51)
        Me.btnAbrirEdificios.TabIndex = 0
        Me.btnAbrirEdificios.Text = "Edificios"
        Me.btnAbrirEdificios.UseVisualStyleBackColor = False
        '
        'btnAbrirClientes
        '
        Me.btnAbrirClientes.Location = New System.Drawing.Point(268, 183)
        Me.btnAbrirClientes.Name = "btnAbrirClientes"
        Me.btnAbrirClientes.Size = New System.Drawing.Size(211, 51)
        Me.btnAbrirClientes.TabIndex = 1
        Me.btnAbrirClientes.Text = "Usuarios"
        Me.btnAbrirClientes.UseVisualStyleBackColor = True
        '
        'btnOficinas
        '
        Me.btnOficinas.Location = New System.Drawing.Point(516, 95)
        Me.btnOficinas.Name = "btnOficinas"
        Me.btnOficinas.Size = New System.Drawing.Size(211, 51)
        Me.btnOficinas.TabIndex = 3
        Me.btnOficinas.Text = "Oficinas"
        Me.btnOficinas.UseVisualStyleBackColor = True
        '
        'BtnServiciosPrestados
        '
        Me.BtnServiciosPrestados.Location = New System.Drawing.Point(13, 246)
        Me.BtnServiciosPrestados.Name = "BtnServiciosPrestados"
        Me.BtnServiciosPrestados.Size = New System.Drawing.Size(211, 51)
        Me.BtnServiciosPrestados.TabIndex = 4
        Me.BtnServiciosPrestados.Text = "Servicios Prestados"
        Me.BtnServiciosPrestados.UseVisualStyleBackColor = True
        '
        'btnServiciosSolicitados
        '
        Me.btnServiciosSolicitados.Location = New System.Drawing.Point(516, 246)
        Me.btnServiciosSolicitados.Name = "btnServiciosSolicitados"
        Me.btnServiciosSolicitados.Size = New System.Drawing.Size(211, 51)
        Me.btnServiciosSolicitados.TabIndex = 5
        Me.btnServiciosSolicitados.Text = "Servicios Solicitados"
        Me.btnServiciosSolicitados.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 73)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Administrador"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.btnAbrirClientes)
        Me.Panel1.Controls.Add(Me.btnServiciosSolicitados)
        Me.Panel1.Controls.Add(Me.BtnServiciosPrestados)
        Me.Panel1.Controls.Add(Me.btnOficinas)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 450)
        Me.Panel1.TabIndex = 8
        '
        'contenedorAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAbrirEdificios)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "contenedorAdmin"
        Me.Text = "Menu Administrador"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrirEdificios As Button
    Friend WithEvents btnAbrirClientes As Button
    Friend WithEvents btnOficinas As Button
    Friend WithEvents BtnServiciosPrestados As Button
    Friend WithEvents btnServiciosSolicitados As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
