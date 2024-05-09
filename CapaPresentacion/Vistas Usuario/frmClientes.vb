Imports CapaDeDatos
Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtDpiSolicitante.TextChanged

    End Sub

    Private Sub btnServicioSol_Click(sender As Object, e As EventArgs) Handles btnServicioSol.Click
        ' Obtener los valores de los TextBox
        Dim servicioSolicitado As String = txtServicioSolicitado.Text
        Dim fechaSolicitud As Date = DtpSolicitudServicio.Value
        Dim dpiSolicitante As String = txtDpiSolicitante.Text

        ' Llamar a la función Conectar de la clase Conexion para establecer la conexión
        CapaDeDatos.Conexion.Conectar(Usuario:="Fabian", Pass:="123456")

        ' Verificar si la conexión se realizó con éxito
        If Conexion.conexion.State = ConnectionState.Open Then
            Try
                ' Definir la consulta SQL para insertar los datos
                Dim query As String = "INSERT INTO ServiciosSolicitados (DescripcionServicio, FechaSolicitud, SolicitanteDpi) VALUES (@DescripcionServicio, @FechaSolicitud, @SolicitanteDpi)"

                ' Crear el comando SQL con la consulta y la conexión
                Using command As New SqlCommand(query, Conexion.conexion)
                    ' Agregar parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@DescripcionServicio", servicioSolicitado)
                    command.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud)
                    command.Parameters.AddWithValue("@SolicitanteDpi", dpiSolicitante)

                    ' Ejecutar el comando SQL
                    command.ExecuteNonQuery()

                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("Los datos se han guardado correctamente.")
                End Using
            Catch ex As Exception
                ' Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al guardar los datos: " & ex.Message)
            Finally
                ' Cerrar la conexión
                Conexion.conexion.Close()
            End Try
        Else
            ' Mostrar un mensaje si la conexión no se estableció correctamente
            MessageBox.Show("No se pudo establecer la conexión.")
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class