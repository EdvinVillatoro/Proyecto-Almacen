<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficinas
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
        Me.txtNumeroOficina = New System.Windows.Forms.TextBox()
        Me.txtNombreOficina = New System.Windows.Forms.TextBox()
        Me.txtNombreEdificio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregarOficina = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvOficinas = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumeroOficina
        '
        Me.txtNumeroOficina.Location = New System.Drawing.Point(209, 75)
        Me.txtNumeroOficina.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroOficina.Name = "txtNumeroOficina"
        Me.txtNumeroOficina.Size = New System.Drawing.Size(76, 20)
        Me.txtNumeroOficina.TabIndex = 0
        '
        'txtNombreOficina
        '
        Me.txtNombreOficina.Location = New System.Drawing.Point(415, 75)
        Me.txtNombreOficina.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreOficina.Name = "txtNombreOficina"
        Me.txtNombreOficina.Size = New System.Drawing.Size(76, 20)
        Me.txtNombreOficina.TabIndex = 1
        '
        'txtNombreEdificio
        '
        Me.txtNombreEdificio.Location = New System.Drawing.Point(209, 106)
        Me.txtNombreEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEdificio.Name = "txtNombreEdificio"
        Me.txtNombreEdificio.Size = New System.Drawing.Size(76, 20)
        Me.txtNombreEdificio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero Oficina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre Oficina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Edificio Al Que Pertenece"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Oficinas"
        '
        'btnAgregarOficina
        '
        Me.btnAgregarOficina.Location = New System.Drawing.Point(11, 139)
        Me.btnAgregarOficina.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarOficina.Name = "btnAgregarOficina"
        Me.btnAgregarOficina.Size = New System.Drawing.Size(124, 26)
        Me.btnAgregarOficina.TabIndex = 7
        Me.btnAgregarOficina.Text = "Agregar Oficina"
        Me.btnAgregarOficina.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.dgvOficinas)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnSelecionar)
        Me.Panel1.Controls.Add(Me.btnAgregarOficina)
        Me.Panel1.Controls.Add(Me.txtNumeroOficina)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombreEdificio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombreOficina)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 368)
        Me.Panel1.TabIndex = 8
        '
        'dgvOficinas
        '
        Me.dgvOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOficinas.Location = New System.Drawing.Point(21, 181)
        Me.dgvOficinas.Name = "dgvOficinas"
        Me.dgvOficinas.Size = New System.Drawing.Size(550, 150)
        Me.dgvOficinas.TabIndex = 11
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(415, 139)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(124, 26)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar Oficina"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(287, 139)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 26)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar Oficina"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(150, 139)
        Me.btnSelecionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(124, 26)
        Me.btnSelecionar.TabIndex = 8
        Me.btnSelecionar.Text = "Ver Oficinas"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'frmOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmOficinas"
        Me.Text = "Oficinas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumeroOficina As TextBox
    Friend WithEvents txtNombreOficina As TextBox
    Friend WithEvents txtNombreEdificio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregarOficina As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvOficinas As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSelecionar As Button
End Class
