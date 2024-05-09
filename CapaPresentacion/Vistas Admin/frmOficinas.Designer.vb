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
        Me.SuspendLayout()
        '
        'txtNumeroOficina
        '
        Me.txtNumeroOficina.Location = New System.Drawing.Point(376, 117)
        Me.txtNumeroOficina.Name = "txtNumeroOficina"
        Me.txtNumeroOficina.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeroOficina.TabIndex = 0
        '
        'txtNombreOficina
        '
        Me.txtNombreOficina.Location = New System.Drawing.Point(376, 191)
        Me.txtNombreOficina.Name = "txtNombreOficina"
        Me.txtNombreOficina.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreOficina.TabIndex = 1
        '
        'txtNombreEdificio
        '
        Me.txtNombreEdificio.Location = New System.Drawing.Point(376, 272)
        Me.txtNombreEdificio.Name = "txtNombreEdificio"
        Me.txtNombreEdificio.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreEdificio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero Oficina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre Oficina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Edificio Al Que Pertenece"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Oficinas"
        '
        'btnAgregarOficina
        '
        Me.btnAgregarOficina.Location = New System.Drawing.Point(364, 341)
        Me.btnAgregarOficina.Name = "btnAgregarOficina"
        Me.btnAgregarOficina.Size = New System.Drawing.Size(102, 51)
        Me.btnAgregarOficina.TabIndex = 7
        Me.btnAgregarOficina.Text = "Agregar Oficina"
        Me.btnAgregarOficina.UseVisualStyleBackColor = True
        '
        'frmOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregarOficina)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreEdificio)
        Me.Controls.Add(Me.txtNombreOficina)
        Me.Controls.Add(Me.txtNumeroOficina)
        Me.Name = "frmOficinas"
        Me.Text = "frmOficinas"
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
End Class
