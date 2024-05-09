<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServicioSolicitado = New System.Windows.Forms.TextBox()
        Me.btnServicioSol = New System.Windows.Forms.Button()
        Me.txtDpiSolicitante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpSolicitudServicio = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicitud De Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Servicio Solicitado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha para el servicio"
        '
        'txtServicioSolicitado
        '
        Me.txtServicioSolicitado.Location = New System.Drawing.Point(277, 106)
        Me.txtServicioSolicitado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtServicioSolicitado.Name = "txtServicioSolicitado"
        Me.txtServicioSolicitado.Size = New System.Drawing.Size(203, 22)
        Me.txtServicioSolicitado.TabIndex = 3
        '
        'btnServicioSol
        '
        Me.btnServicioSol.Location = New System.Drawing.Point(320, 246)
        Me.btnServicioSol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnServicioSol.Name = "btnServicioSol"
        Me.btnServicioSol.Size = New System.Drawing.Size(111, 49)
        Me.btnServicioSol.TabIndex = 5
        Me.btnServicioSol.Text = "Solicitar Servicio"
        Me.btnServicioSol.UseVisualStyleBackColor = True
        '
        'txtDpiSolicitante
        '
        Me.txtDpiSolicitante.Location = New System.Drawing.Point(277, 175)
        Me.txtDpiSolicitante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDpiSolicitante.Name = "txtDpiSolicitante"
        Me.txtDpiSolicitante.Size = New System.Drawing.Size(203, 22)
        Me.txtDpiSolicitante.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dpi"
        '
        'DtpSolicitudServicio
        '
        Me.DtpSolicitudServicio.Location = New System.Drawing.Point(277, 135)
        Me.DtpSolicitudServicio.Name = "DtpSolicitudServicio"
        Me.DtpSolicitudServicio.Size = New System.Drawing.Size(242, 22)
        Me.DtpSolicitudServicio.TabIndex = 8
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DtpSolicitudServicio)
        Me.Controls.Add(Me.txtDpiSolicitante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnServicioSol)
        Me.Controls.Add(Me.txtServicioSolicitado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmClientes"
        Me.Text = "frmProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtServicioSolicitado As TextBox
    Friend WithEvents btnServicioSol As Button
    Friend WithEvents txtDpiSolicitante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpSolicitudServicio As DateTimePicker
End Class
