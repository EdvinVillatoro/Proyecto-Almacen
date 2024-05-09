<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstatus
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
        Me.txtDpiCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEstadosServicios = New System.Windows.Forms.DataGridView()
        Me.btnMostarEstado = New System.Windows.Forms.Button()
        CType(Me.dgvEstadosServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDpiCliente
        '
        Me.txtDpiCliente.Location = New System.Drawing.Point(294, 67)
        Me.txtDpiCliente.Name = "txtDpiCliente"
        Me.txtDpiCliente.Size = New System.Drawing.Size(210, 22)
        Me.txtDpiCliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dpi"
        '
        'dgvEstadosServicios
        '
        Me.dgvEstadosServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadosServicios.Location = New System.Drawing.Point(60, 122)
        Me.dgvEstadosServicios.Name = "dgvEstadosServicios"
        Me.dgvEstadosServicios.RowHeadersWidth = 51
        Me.dgvEstadosServicios.RowTemplate.Height = 24
        Me.dgvEstadosServicios.Size = New System.Drawing.Size(715, 299)
        Me.dgvEstadosServicios.TabIndex = 2
        '
        'btnMostarEstado
        '
        Me.btnMostarEstado.Location = New System.Drawing.Point(611, 59)
        Me.btnMostarEstado.Name = "btnMostarEstado"
        Me.btnMostarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnMostarEstado.TabIndex = 3
        Me.btnMostarEstado.Text = "Mostrar Estados"
        Me.btnMostarEstado.UseVisualStyleBackColor = True
        '
        'frmEstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMostarEstado)
        Me.Controls.Add(Me.dgvEstadosServicios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDpiCliente)
        Me.Name = "frmEstatus"
        Me.Text = "frmEstatus"
        CType(Me.dgvEstadosServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDpiCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEstadosServicios As DataGridView
    Friend WithEvents btnMostarEstado As Button
End Class
