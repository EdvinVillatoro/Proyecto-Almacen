﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolucionesServicio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.btnIngresarSolucion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtSolucion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnIngresarSolucion)
        Me.Panel1.Controls.Add(Me.txtEstatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 453)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soluciones"
        '
        'txtEstatus
        '
        Me.txtEstatus.Location = New System.Drawing.Point(373, 120)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(100, 20)
        Me.txtEstatus.TabIndex = 1
        '
        'btnIngresarSolucion
        '
        Me.btnIngresarSolucion.Location = New System.Drawing.Point(341, 217)
        Me.btnIngresarSolucion.Name = "btnIngresarSolucion"
        Me.btnIngresarSolucion.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresarSolucion.TabIndex = 2
        Me.btnIngresarSolucion.Text = "Confirmar"
        Me.btnIngresarSolucion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cambiar Estatus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Solucion dada"
        '
        'txtSolucion
        '
        Me.txtSolucion.Location = New System.Drawing.Point(373, 165)
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(100, 20)
        Me.txtSolucion.TabIndex = 5
        '
        'frmSolucionesServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSolucionesServicio"
        Me.Text = "Soluciones Servicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSolucion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIngresarSolucion As Button
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents Label1 As Label
End Class
