Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class ModeloUsuarios

    Public Shared Function VerRoles(ByVal Nombre As String, ByVal Contraseña As String) As String
        Dim roles As String
        Dim rs As SqlDataReader
        Dim cmd As New System.Data.SqlClient.SqlCommand
        roles = "sin Roles "


        Try
            'preprarar el comando 
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "BuscarRol"
            cmd.Connection = CapaDeDatos.Conexion.conexion
            'agregar los parametros que usa el procedimineto almacenado 
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Nombre", Nombre))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Contraseña", Contraseña))

            ' ejecutar el procedimiento almacenado 

            rs = cmd.ExecuteReader()
            If rs.HasRows Then
                rs.Read()
                roles = rs.GetValue(0)
                MsgBox("el rol para su usuario es: " + roles)
            End If


        Catch ex As Exception
            MsgBox("El rol no fue encontrado o tuvo un problema para conectarse  ")
        End Try
        Return roles
    End Function

    Public Shared Function ObtenerDPI(usuario As String, contraseña As String) As String
        Dim dpi As String = String.Empty
        Try
            ' Establecer conexión utilizando la clase de conexión personalizada
            Conexion.Conectar(Usuario:="sa", Pass:="59095347")

            ' Crear conexión y comando para obtener el DPI
            Using command As New SqlCommand("SELECT NumeroDPI FROM Usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña", Conexion.conexion)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.Parameters.AddWithValue("@Contraseña", contraseña)
                dpi = command.ExecuteScalar().ToString()
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener el DPI: " & ex.Message)
        Finally
            ' Cerrar la conexión al finalizar
            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If
        End Try
        Return dpi
    End Function
End Class
