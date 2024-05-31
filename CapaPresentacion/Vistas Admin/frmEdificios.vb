Imports CapaDeDatos
Imports System.Data.SqlClient

Public Class frmEdificios
    ' Método para ejecutar el procedimiento almacenado y mostrar el resultado en un control DataGridView
    Private Sub EjecutarProcedimientoYMostrarResultados(ByVal action As String)
        Try
            ' Establecer conexión utilizando la clase de conexión personalizada
            Conexion.Conectar(Usuario:="sa", Pass:="59095347")

            ' Crear comando para ejecutar el procedimiento almacenado
            Using command As New SqlCommand("GestionarEdificios", Conexion.conexion)
                command.CommandType = CommandType.StoredProcedure

                ' Definir parámetros del procedimiento almacenado
                command.Parameters.AddWithValue("@Action", action)

                ' Si se está agregando o actualizando, se agrega el nombre del edificio
                If action = "INSERT" OrElse action = "UPDATE" Then
                    command.Parameters.AddWithValue("@NombreEdificio", txtNombreEdificio.Text)
                End If

                ' Ejecutar el procedimiento almacenado
                Dim dataTable As New DataTable()
                dataTable.Load(command.ExecuteReader())


                ' Asignar el resultado al DataGridView o cualquier otro control de visualización
                dgvEdificios.DataSource = dataTable
                dgvEdificios.Columns("NombreEdificio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End Using

            ' Mensaje de éxito
            MessageBox.Show("Operación realizada correctamente.")
        Catch ex As Exception
            ' Mensaje de error
            MessageBox.Show("Error al ejecutar la operación: " & ex.Message)
        Finally
            ' Cerrar la conexión al finalizar
            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If
        End Try
    End Sub

    ' Botón para agregar un edificio
    Private Sub btnAgregarEdificio_Click(sender As Object, e As EventArgs) Handles btnAgregarEdificio.Click
        EjecutarProcedimientoYMostrarResultados("INSERT")
    End Sub

    ' Botón para eliminar un edificio
    Private Sub btnEliminarEdificio_Click(sender As Object, e As EventArgs) Handles btnEliminarEdificio.Click
        EjecutarProcedimientoYMostrarResultados("DELETE")
    End Sub

    ' Botón para ver todos los edificios
    Private Sub btnVerEdificios_Click(sender As Object, e As EventArgs) Handles btnVerEdificios.Click
        EjecutarProcedimientoYMostrarResultados("SELECT")
    End Sub

    ' Botón para actualizar la lista de edificios
    Private Sub btnUpdateEdificios_Click(sender As Object, e As EventArgs)
        EjecutarProcedimientoYMostrarResultados("UPDATE")
    End Sub

    Private Sub dgvEdificios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEdificios.CellContentClick

    End Sub
End Class
