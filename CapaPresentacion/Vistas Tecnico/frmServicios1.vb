Imports CapaDeDatos
Imports System.Data.SqlClient

Public Class frmServicios1
    Private Sub btnBuscarServicioAsignado_Click(sender As Object, e As EventArgs) Handles btnBuscarServicioAsignado.Click
        Dim dpi As String = txtDpiTecnico.Text

        If Not String.IsNullOrEmpty(dpi) Then
            Try
                Conexion.Conectar(Usuario:="Bryan", Pass:="123456")

                Using command As New SqlCommand("MostrarServiciosPrestadosPorTecnico", Conexion.conexion)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agregar parámetro para el NumeroDPI
                    command.Parameters.AddWithValue("@TecnicoDPI", dpi)

                    Dim dataTable As New DataTable()
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)

                    dgvServiciosTecnicos.DataSource = dataTable
                    dgvServiciosTecnicos.Columns("Solucion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

    Private Sub dgvServiciosTecnicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiciosTecnicos.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class