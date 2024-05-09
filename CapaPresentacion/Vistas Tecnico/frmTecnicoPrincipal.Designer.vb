<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTecnicoPrincipal
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
        Me.btnServiciosAsignados = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSoluciones = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnServiciosAsignados
        '
        Me.btnServiciosAsignados.Location = New System.Drawing.Point(256, 127)
        Me.btnServiciosAsignados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnServiciosAsignados.Name = "btnServiciosAsignados"
        Me.btnServiciosAsignados.Size = New System.Drawing.Size(90, 35)
        Me.btnServiciosAsignados.TabIndex = 0
        Me.btnServiciosAsignados.Text = "Servicios"
        Me.btnServiciosAsignados.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Tecnico "
        '
        'btnSoluciones
        '
        Me.btnSoluciones.Location = New System.Drawing.Point(256, 191)
        Me.btnSoluciones.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSoluciones.Name = "btnSoluciones"
        Me.btnSoluciones.Size = New System.Drawing.Size(90, 35)
        Me.btnSoluciones.TabIndex = 2
        Me.btnSoluciones.Text = "Soluciones"
        Me.btnSoluciones.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 365)
        Me.Panel1.TabIndex = 6
        '
        'frmTecnicoPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnSoluciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnServiciosAsignados)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTecnicoPrincipal"
        Me.Text = "Tecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnServiciosAsignados As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSoluciones As Button
    Friend WithEvents Panel1 As Panel
End Class
