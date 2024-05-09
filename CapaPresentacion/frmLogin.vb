Imports CapaDeDatos

Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'CapaDeDatos.Conexion.Conectar(txtUsuario.Text, txtPass.Text)
        'CapaDeDatos.ModeloUsuarios.VerRoles(txtUsuario.Text)

        CapaDeDatos.Conexion.Conectar(txtUsuario.Text, txtPass.Text)
        Dim RolEncontrado = ModeloUsuarios.VerRoles(txtUsuario.Text)


        If (CapaDeDatos.Conexion.conexion.State = 1) Then

                If (RolEncontrado.Equals("Administrador")) Then
                contenedorAdministradores.Show()
                contenedorAdministradores.WindowState = FormWindowState.Maximized
                contenedorAdmin.MdiParent = contenedorAdministradores

                contenedorAdministradores.Show()
                contenedorAdmin.StartPosition = 1
                Me.Dispose()

                ContenedorPrincipal.Close()

                contenedorAdmin.Show()
            Else
                If (RolEncontrado.Equals("Tecnico")) Then

                Else
                    If (RolEncontrado.Equals("Cliente")) Then
                        contenedorAdministradores.Show()
                        contenedorAdministradores.WindowState = FormWindowState.Maximized
                        frmPriCliente.MdiParent = contenedorAdministradores
                        frmPriCliente.StartPosition = 1
                        contenedorAdministradores.Show()

                        Me.Dispose()

                        ContenedorPrincipal.Close()

                        frmPriCliente.Show()

                    End If
                End If
            End If
            End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
