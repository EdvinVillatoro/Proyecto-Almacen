Imports System.Data.SqlClient

Public Class Conexion
    Public Shared conexion As SqlConnection

    Public Shared Function Conectar(Usuario As String, Pass As String)
        Try
            conexion = New SqlConnection("Data Source=EDVINVILLATORO\SQLEXPRESS;Initial Catalog=SoporteTecnico;User ID=" & Usuario & ";Password=" & Pass & "")
            If (conexion.State = 0) Then
                conexion.Open()
                MsgBox("Acceso Consedido")
            End If
        Catch ex As SqlException
            MsgBox("no funka esa shit" + ex.Message)
        End Try
    End Function
End Class
