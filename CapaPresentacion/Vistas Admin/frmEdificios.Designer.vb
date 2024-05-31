<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdificios
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEdificio = New System.Windows.Forms.TextBox()
        Me.btnAgregarEdificio = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvEdificios = New System.Windows.Forms.DataGridView()
        Me.btnEliminarEdificio = New System.Windows.Forms.Button()
        Me.btnVerEdificios = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEdificios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edificios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Del Edificio"
        '
        'txtNombreEdificio
        '
        Me.txtNombreEdificio.Location = New System.Drawing.Point(192, 60)
        Me.txtNombreEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEdificio.Name = "txtNombreEdificio"
        Me.txtNombreEdificio.Size = New System.Drawing.Size(135, 20)
        Me.txtNombreEdificio.TabIndex = 2
        '
        'btnAgregarEdificio
        '
        Me.btnAgregarEdificio.Location = New System.Drawing.Point(74, 107)
        Me.btnAgregarEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarEdificio.Name = "btnAgregarEdificio"
        Me.btnAgregarEdificio.Size = New System.Drawing.Size(79, 35)
        Me.btnAgregarEdificio.TabIndex = 3
        Me.btnAgregarEdificio.Text = "Agregar Edificio"
        Me.btnAgregarEdificio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.dgvEdificios)
        Me.Panel1.Controls.Add(Me.txtNombreEdificio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnEliminarEdificio)
        Me.Panel1.Controls.Add(Me.btnVerEdificios)
        Me.Panel1.Controls.Add(Me.btnAgregarEdificio)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 369)
        Me.Panel1.TabIndex = 4
        '
        'dgvEdificios
        '
        Me.dgvEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdificios.Location = New System.Drawing.Point(28, 164)
        Me.dgvEdificios.Name = "dgvEdificios"
        Me.dgvEdificios.Size = New System.Drawing.Size(485, 150)
        Me.dgvEdificios.TabIndex = 7
        '
        'btnEliminarEdificio
        '
        Me.btnEliminarEdificio.Location = New System.Drawing.Point(216, 107)
        Me.btnEliminarEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarEdificio.Name = "btnEliminarEdificio"
        Me.btnEliminarEdificio.Size = New System.Drawing.Size(79, 35)
        Me.btnEliminarEdificio.TabIndex = 5
        Me.btnEliminarEdificio.Text = "Eliminar Edificio"
        Me.btnEliminarEdificio.UseVisualStyleBackColor = True
        '
        'btnVerEdificios
        '
        Me.btnVerEdificios.Location = New System.Drawing.Point(375, 107)
        Me.btnVerEdificios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerEdificios.Name = "btnVerEdificios"
        Me.btnVerEdificios.Size = New System.Drawing.Size(79, 35)
        Me.btnVerEdificios.TabIndex = 4
        Me.btnVerEdificios.Text = "Ver Edificios"
        Me.btnVerEdificios.UseVisualStyleBackColor = True
        '
        'frmEdificios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEdificios"
        Me.Text = "Edificios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEdificios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEdificio As TextBox
    Friend WithEvents btnAgregarEdificio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEliminarEdificio As Button
    Friend WithEvents btnVerEdificios As Button
    Friend WithEvents dgvEdificios As DataGridView
End Class
