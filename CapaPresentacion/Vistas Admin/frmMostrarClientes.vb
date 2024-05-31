Imports System.Data.SqlClient

Public Class frmMostrarClientes

    ' Cadena de conexión
    Private connectionString As String = "Data Source=EDVINVILLATORO\SQLEXPRESS;Initial Catalog=SoporteTecnico;User ID=sa;Password=59095347"

    ' Método para cargar los usuarios en el DataGridView al abrir el formulario
    Private Sub frmMostrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    ' Método para cargar los usuarios en el DataGridView
    Private Sub CargarUsuarios()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Usuarios"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dgvUsuarios.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message)
        End Try
    End Sub

    ' Método para agregar un nuevo usuario
    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim nuevoDPI As String = txtNumeroDpiUsuario.Text
        Dim oficina As String = txtOficinaUsuario.Text
        Dim password As String = txtPassUsuario.Text
        Dim nombre As String = txtNombreUsuario.Text
        Dim apellido As String = txtApellidoUsuario.Text
        Dim rol As String = txtRol.Text

        If Not String.IsNullOrEmpty(nuevoDPI) AndAlso Not String.IsNullOrEmpty(oficina) AndAlso Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(nombre) AndAlso Not String.IsNullOrEmpty(apellido) AndAlso Not String.IsNullOrEmpty(rol) Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO Usuarios (NumeroDPI, Nombre, Apellidos, NumeroOficina, Rol, Contraseña) VALUES (@DPI, @Nombre, @Apellidos, @Oficina, @Rol, @Contraseña)"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DPI", nuevoDPI)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Apellidos", apellido)
                    command.Parameters.AddWithValue("@Oficina", oficina)
                    command.Parameters.AddWithValue("@Rol", rol)
                    command.Parameters.AddWithValue("@Contraseña", password)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Usuario agregado correctamente.")
                CargarUsuarios()
            Catch ex As Exception
                MessageBox.Show("Error al agregar el usuario: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para ver todos los usuarios
    Private Sub btnVerUsuarios_Click(sender As Object, e As EventArgs) Handles btnVerUsuarios.Click
        CargarUsuarios()
    End Sub

    ' Método para eliminar un usuario
    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        Dim dpiUsuario As String = txtNumeroDpiUsuario.Text

        If Not String.IsNullOrEmpty(dpiUsuario) Then
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar al usuario con DPI " & dpiUsuario & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()
                        Dim query As String = "DELETE FROM Usuarios WHERE NumeroDPI = @DPI"
                        Dim command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@DPI", dpiUsuario)
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Usuario eliminado correctamente.")
                    CargarUsuarios()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Por favor ingrese el DPI del usuario que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para actualizar un usuario
    Private Sub btnActualizarUsuario_Click(sender As Object, e As EventArgs) Handles btnActualizarUsuario.Click
        Dim dpiUsuario As String = txtNumeroDpiUsuario.Text

        If Not String.IsNullOrEmpty(dpiUsuario) Then
            Dim nombre As String = txtNombreUsuario.Text
            Dim apellido As String = txtApellidoUsuario.Text
            Dim oficina As String = txtOficinaUsuario.Text
            Dim rol As String = txtRol.Text
            Dim password As String = txtPassUsuario.Text

            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellidos = @Apellidos, NumeroOficina = @Oficina, Rol = @Rol, Contraseña = @Contraseña WHERE NumeroDPI = @DPI"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Apellidos", apellido)
                    command.Parameters.AddWithValue("@Oficina", oficina)
                    command.Parameters.AddWithValue("@Rol", rol)
                    command.Parameters.AddWithValue("@Contraseña", password)
                    command.Parameters.AddWithValue("@DPI", dpiUsuario)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Usuario actualizado correctamente.")
                CargarUsuarios()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el usuario: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione un usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para cargar los datos de un usuario en los TextBox al hacer clic en una fila del DataGridView
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            txtNumeroDpiUsuario.Text = fila.Cells("NumeroDPI").Value.ToString()
            txtOficinaUsuario.Text = fila.Cells("NumeroOficina").Value.ToString()
            txtPassUsuario.Text = fila.Cells("Contraseña").Value.ToString()
            txtNombreUsuario.Text = fila.Cells("Nombre").Value.ToString()
            txtApellidoUsuario.Text = fila.Cells("Apellidos").Value.ToString()
            txtRol.Text = fila.Cells("Rol").Value.ToString()
        End If
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

    End Sub
End Class
