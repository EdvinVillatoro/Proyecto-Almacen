Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class ModeloUsuarios

    Public Shared Function VerRoles(ByVal Usuario As String) As String
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
            cmd.Parameters.Add(New SqlClient.SqlParameter("@nombreUsuario", Usuario))

            ' ejecutar el procedimiento almacenado 

            rs = cmd.ExecuteReader()
            If rs.HasRows Then
                rs.Read()
                roles = rs.GetValue(0)
                MsgBox("el rol para su usuario es: " + roles)
            End If


        Catch ex As Exception
            MsgBox("no Funcan los roles y esta shit x2 " + ex.Message)
        End Try
        Return roles
    End Function
End Class
