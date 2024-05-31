Imports System.Data.SqlClient

Public Class Conexion
    Public Shared conexion As SqlConnection

    Public Shared Function Conectar(Usuario As String, Pass As String)
        Try
            conexion = New SqlConnection("Data Source=EDVINVILLATORO\SQLEXPRESS;Initial Catalog=SoporteTecnico;User ID=sa;Password=59095347")
            If (conexion.State = 0) Then
                conexion.Open()
                MsgBox("Acceso Consedido")
            End If
        Catch ex As SqlException
            MsgBox("la conecxion no se pudo establecer Verifique la contraseña o el usuario")
        End Try
    End Function
End Class
