Imports System.Data.SqlClient

Public Class frmOficinas
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Data Source=EDVINVILLATORO\SQLEXPRESS;Initial Catalog=SoporteTecnico;User ID=sa;Password=59095347"

    ' Método para ejecutar el procedimiento almacenado y realizar las operaciones CRUD
    Private Sub EjecutarProcedimiento(ByVal action As String, ByVal numeroOficina As Integer, ByVal nombreOficina As String, ByVal nombreEdificio As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("GestionarOficinas", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@NumeroOficina", numeroOficina)
                    command.Parameters.AddWithValue("@NombreOficina", nombreOficina)
                    command.Parameters.AddWithValue("@NombreEdificio", nombreEdificio)
                    command.Parameters.AddWithValue("@Action", action)
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Operación realizada correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al realizar la operación: " & ex.Message)
        End Try
    End Sub

    ' Botón para seleccionar todas las oficinas
    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        Dim dataTable As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand("GestionarOficinas", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@Action", "SELECT")
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
            dgvOficinas.DataSource = dataTable
            dgvOficinas.Columns("NombreOficina").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvOficinas.Columns("NombreEdificio").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar las oficinas: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar una nueva oficina
    Private Sub btnAgregarOficina_Click(sender As Object, e As EventArgs) Handles btnAgregarOficina.Click
        Dim numeroOficina As Integer
        Dim nombreOficina As String = txtNombreOficina.Text
        Dim nombreEdificio As String = txtNombreEdificio.Text

        If Integer.TryParse(txtNumeroOficina.Text, numeroOficina) Then
            EjecutarProcedimiento("INSERT", numeroOficina, nombreOficina, nombreEdificio)
        Else
            MessageBox.Show("El número de oficina debe ser un valor numérico.")
        End If
    End Sub

    ' Botón para eliminar una oficina
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim numeroOficina As Integer

        If Integer.TryParse(txtNumeroOficina.Text, numeroOficina) Then
            EjecutarProcedimiento("DELETE", numeroOficina, "", "")
        Else
            MessageBox.Show("El número de oficina debe ser un valor numérico.")
        End If
    End Sub

    ' Botón para actualizar una oficina
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim numeroOficina As Integer
        Dim nombreOficina As String = txtNombreOficina.Text
        Dim nombreEdificio As String = txtNombreEdificio.Text

        If Integer.TryParse(txtNumeroOficina.Text, numeroOficina) Then
            EjecutarProcedimiento("UPDATE", numeroOficina, nombreOficina, nombreEdificio)
        Else
            MessageBox.Show("El número de oficina debe ser un valor numérico.")
        End If
    End Sub

    Private Sub dgvOficinas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOficinas.CellContentClick

    End Sub
End Class