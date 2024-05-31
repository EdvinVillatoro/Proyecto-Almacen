<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios1
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
        Me.dgvServiciosTecnicos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDpiTecnico = New System.Windows.Forms.TextBox()
        Me.btnBuscarServicioAsignado = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvServiciosTecnicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.dgvServiciosTecnicos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDpiTecnico)
        Me.Panel1.Controls.Add(Me.btnBuscarServicioAsignado)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 638)
        Me.Panel1.TabIndex = 6
        '
        'dgvServiciosTecnicos
        '
        Me.dgvServiciosTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosTecnicos.Location = New System.Drawing.Point(12, 186)
        Me.dgvServiciosTecnicos.Name = "dgvServiciosTecnicos"
        Me.dgvServiciosTecnicos.Size = New System.Drawing.Size(1125, 364)
        Me.dgvServiciosTecnicos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dpi Del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ver Servicios Asignados"
        '
        'txtDpiTecnico
        '
        Me.txtDpiTecnico.Location = New System.Drawing.Point(363, 103)
        Me.txtDpiTecnico.Name = "txtDpiTecnico"
        Me.txtDpiTecnico.Size = New System.Drawing.Size(100, 20)
        Me.txtDpiTecnico.TabIndex = 1
        '
        'btnBuscarServicioAsignado
        '
        Me.btnBuscarServicioAsignado.Location = New System.Drawing.Point(552, 100)
        Me.btnBuscarServicioAsignado.Name = "btnBuscarServicioAsignado"
        Me.btnBuscarServicioAsignado.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarServicioAsignado.TabIndex = 0
        Me.btnBuscarServicioAsignado.Text = "Buscar"
        Me.btnBuscarServicioAsignado.UseVisualStyleBackColor = True
        '
        'frmServicios1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmServicios1"
        Me.Text = "Servicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvServiciosTecnicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvServiciosTecnicos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDpiTecnico As TextBox
    Friend WithEvents btnBuscarServicioAsignado As Button
End Class
