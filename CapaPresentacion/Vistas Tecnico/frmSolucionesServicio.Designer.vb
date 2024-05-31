<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dgvDatosDeUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtCodServ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIngresarSolucion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaServicioPrestado = New System.Windows.Forms.DateTimePicker()
        Me.txtTecnicoDpi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDatosDeUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtTecnicoDpi)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpFechaServicioPrestado)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgvDatosDeUsuarios)
        Me.Panel1.Controls.Add(Me.txtCodServ)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSolucion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnIngresarSolucion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 662)
        Me.Panel1.TabIndex = 6
        '
        'dgvDatosDeUsuarios
        '
        Me.dgvDatosDeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosDeUsuarios.Location = New System.Drawing.Point(67, 257)
        Me.dgvDatosDeUsuarios.Name = "dgvDatosDeUsuarios"
        Me.dgvDatosDeUsuarios.Size = New System.Drawing.Size(1227, 372)
        Me.dgvDatosDeUsuarios.TabIndex = 8
        '
        'txtCodServ
        '
        Me.txtCodServ.Location = New System.Drawing.Point(115, 48)
        Me.txtCodServ.Name = "txtCodServ"
        Me.txtCodServ.Size = New System.Drawing.Size(100, 20)
        Me.txtCodServ.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo De Servicio"
        '
        'txtSolucion
        '
        Me.txtSolucion.Location = New System.Drawing.Point(428, 88)
        Me.txtSolucion.Multiline = True
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(753, 149)
        Me.txtSolucion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Solucion dada"
        '
        'btnIngresarSolucion
        '
        Me.btnIngresarSolucion.Location = New System.Drawing.Point(230, 142)
        Me.btnIngresarSolucion.Name = "btnIngresarSolucion"
        Me.btnIngresarSolucion.Size = New System.Drawing.Size(92, 40)
        Me.btnIngresarSolucion.TabIndex = 2
        Me.btnIngresarSolucion.Text = "Confirmar"
        Me.btnIngresarSolucion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soluciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha De Servicio Prestado"
        '
        'dtpFechaServicioPrestado
        '
        Me.dtpFechaServicioPrestado.Location = New System.Drawing.Point(588, 48)
        Me.dtpFechaServicioPrestado.Name = "dtpFechaServicioPrestado"
        Me.dtpFechaServicioPrestado.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaServicioPrestado.TabIndex = 10
        '
        'txtTecnicoDpi
        '
        Me.txtTecnicoDpi.Location = New System.Drawing.Point(322, 48)
        Me.txtTecnicoDpi.Name = "txtTecnicoDpi"
        Me.txtTecnicoDpi.Size = New System.Drawing.Size(100, 20)
        Me.txtTecnicoDpi.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DpiTecnico"
        '
        'frmSolucionesServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSolucionesServicio"
        Me.Text = "Soluciones Servicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDatosDeUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSolucion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIngresarSolucion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDatosDeUsuarios As DataGridView
    Friend WithEvents txtCodServ As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaServicioPrestado As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTecnicoDpi As TextBox
    Friend WithEvents Label6 As Label
End Class
