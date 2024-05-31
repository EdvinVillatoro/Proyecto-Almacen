Imports CapaDeDatos
Imports System.Data.SqlClient

Public Class frmMostrarServiciosSolicitados
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnVerEstado_Click(sender As Object, e As EventArgs) Handles btnVerEstado.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Actualizar los datos en el DataGridView al cargar el formulario
        ActualizarDatosUsuarios()
    End Sub

    Private Sub ActualizarDatosUsuarios()
        Try
            ' Establecer conexión utilizando la clase de conexión personalizada
            Conexion.Conectar(Usuario:="sa", Pass:="59095347")

            ' Crear conexión y comando para obtener los datos de servicios solicitados
            Using command As New SqlCommand("MostrarTodosLosDatos", Conexion.conexion)
                command.CommandType = CommandType.StoredProcedure

                ' Crear adaptador y dataset para almacenar los resultados
                Using adapter As New SqlDataAdapter(command)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Asignar los resultados al DataGridView
                    dgvEstadoServicio.DataSource = dataSet.Tables(0)
                    dgvEstadoServicio.Columns("Solucion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    dgvEstadoServicio.Columns("DescripcionServicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        Finally
            ' Cerrar la conexión al finalizar
            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If
        End Try
    End Sub
End Class