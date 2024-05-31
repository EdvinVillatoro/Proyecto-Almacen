Imports System.Data.SqlClient
Imports CapaDeDatos

Public Class frmSolucionesServicio
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatosDeUsuarios.CellContentClick

    End Sub

    Private Sub txtSolucion_TextChanged(sender As Object, e As EventArgs) Handles txtSolucion.TextChanged

    End Sub
    Private Sub btnIngresarSolucion_Click(sender As Object, e As EventArgs) Handles btnIngresarSolucion.Click
        Dim codigoServicio As Integer
        Dim fechaAtencion As Date
        Dim solucion As String
        Dim tecnicoDpi As String


        If Integer.TryParse(txtCodServ.Text, codigoServicio) AndAlso Not String.IsNullOrEmpty(txtSolucion.Text) AndAlso Date.TryParse(dtpFechaServicioPrestado.Text, fechaAtencion) AndAlso Not String.IsNullOrEmpty(txtTecnicoDpi.Text) Then
            solucion = txtSolucion.Text
            tecnicoDpi = txtTecnicoDpi.Text


            Try
                ' Establecer conexión utilizando la clase de conexión personalizada
                Conexion.Conectar(Usuario:="sa", Pass:="59095347")

                ' Crear comando para ejecutar el procedimiento almacenado
                Using command As New SqlCommand("EditarServicios", Conexion.conexion)
                    command.CommandType = CommandType.StoredProcedure

                    ' Definir parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@CodigoServicio", codigoServicio)
                    command.Parameters.AddWithValue("@FechaAtencion", fechaAtencion)
                    command.Parameters.AddWithValue("@TecnicoDpi", tecnicoDpi)
                    command.Parameters.AddWithValue("@Solucion", solucion)


                    ' Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery()

                    ' Actualizar los datos en el DataGridView
                    ActualizarDatosUsuarios()
                End Using

                MessageBox.Show("Servicio prestado agregado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al agregar el servicio prestado: " & ex.Message)
            Finally
                ' Cerrar la conexión al finalizar
                If Conexion.conexion.State <> ConnectionState.Closed Then
                    Conexion.conexion.Close()
                End If
            End Try
        Else
            MessageBox.Show("Por favor ingresa valores válidos para todos los campos.")
        End If
    End Sub

    Private usuarioDpi As String

    ' Método para establecer el DPI del usuario después de iniciar sesión
    Public Sub EstablecerUsuarioDpi(dpi As String)
        usuarioDpi = dpi
    End Sub

    ' Método para actualizar los datos en el DataGridView
    Private Sub ActualizarDatosUsuarios()
        Try
            ' Establecer conexión utilizando la clase de conexión personalizada
            Conexion.Conectar(Usuario:="sa", Pass:="59095347")

            ' Crear conexión y comando para obtener los datos de servicios solicitados
            Using command As New SqlCommand("MostrarTodosLosDatos", Conexion.conexion)
                command.CommandType = CommandType.StoredProcedure

                ' Añadir el parámetro del DPI del usuario al comando
                command.Parameters.AddWithValue("@DPI", usuarioDpi)

                ' Crear adaptador y dataset para almacenar los resultados
                Using adapter As New SqlDataAdapter(command)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Asignar los resultados al DataGridView
                    dgvDatosDeUsuarios.DataSource = dataSet.Tables(0)
                    dgvDatosDeUsuarios.Columns("Solucion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    dgvDatosDeUsuarios.Columns("DescripcionServicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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


    ' Evento Load del formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Actualizar los datos en el DataGridView al cargar el formulario
        ActualizarDatosUsuarios()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class