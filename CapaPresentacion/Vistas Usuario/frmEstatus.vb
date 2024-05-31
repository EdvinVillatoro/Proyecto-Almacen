Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaDeDatos

Public Class frmEstatus
    Private Sub frmEstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMostarEstado_Click(sender As Object, e As EventArgs) Handles btnMostarEstado.Click
        Dim dpi As String = txtDpiCliente.Text

        If Not String.IsNullOrEmpty(dpi) Then
            Try
                Conexion.Conectar(Usuario:="Fabian", Pass:="123456")

                Using command As New SqlCommand("MostrarServiciosSolicitados", Conexion.conexion)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agregar parámetro para el NumeroDPI
                    command.Parameters.AddWithValue("@NumeroDPI", dpi)

                    Dim dataTable As New DataTable()
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)

                    dgvEstadosServicios.DataSource = dataTable
                    dgvEstadosServicios.Columns("DescripcionServicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al recuperar los datos: " & ex.Message)
            Finally
                If Conexion.conexion.State <> ConnectionState.Closed Then
                    Conexion.conexion.Close()
                End If
            End Try
        Else
            MessageBox.Show("Por favor ingresa un número de DPI válido.")
        End If
    End Sub

    Private Sub dgvEstadosServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadosServicios.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class