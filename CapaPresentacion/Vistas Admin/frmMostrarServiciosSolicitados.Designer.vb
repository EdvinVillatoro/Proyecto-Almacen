<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarServiciosSolicitados
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodServicio = New System.Windows.Forms.TextBox()
        Me.txtDpiTecnico = New System.Windows.Forms.TextBox()
        Me.btnVerEstado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEstadoServicio = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvEstadoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Del Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DPI Tecnico"
        '
        'txtCodServicio
        '
        Me.txtCodServicio.Location = New System.Drawing.Point(403, 123)
        Me.txtCodServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodServicio.Name = "txtCodServicio"
        Me.txtCodServicio.Size = New System.Drawing.Size(132, 22)
        Me.txtCodServicio.TabIndex = 5
        '
        'txtDpiTecnico
        '
        Me.txtDpiTecnico.Location = New System.Drawing.Point(403, 164)
        Me.txtDpiTecnico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDpiTecnico.Name = "txtDpiTecnico"
        Me.txtDpiTecnico.Size = New System.Drawing.Size(132, 22)
        Me.txtDpiTecnico.TabIndex = 8
        '
        'btnVerEstado
        '
        Me.btnVerEstado.Location = New System.Drawing.Point(623, 127)
        Me.btnVerEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVerEstado.Name = "btnVerEstado"
        Me.btnVerEstado.Size = New System.Drawing.Size(135, 57)
        Me.btnVerEstado.TabIndex = 10
        Me.btnVerEstado.Text = "Asignar servicio al tecnico"
        Me.btnVerEstado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ver el estado del servicio"
        '
        'dgvEstadoServicio
        '
        Me.dgvEstadoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadoServicio.Location = New System.Drawing.Point(129, 273)
        Me.dgvEstadoServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEstadoServicio.Name = "dgvEstadoServicio"
        Me.dgvEstadoServicio.RowHeadersWidth = 51
        Me.dgvEstadoServicio.Size = New System.Drawing.Size(1018, 318)
        Me.dgvEstadoServicio.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.dgvEstadoServicio)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1266, 637)
        Me.Panel1.TabIndex = 13
        '
        'frmMostrarServiciosSolicitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 635)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVerEstado)
        Me.Controls.Add(Me.txtDpiTecnico)
        Me.Controls.Add(Me.txtCodServicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMostrarServiciosSolicitados"
        Me.Text = "Servicios"
        CType(Me.dgvEstadoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodServicio As TextBox
    Friend WithEvents txtDpiTecnico As TextBox
    Friend WithEvents btnVerEstado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvEstadoServicio As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
