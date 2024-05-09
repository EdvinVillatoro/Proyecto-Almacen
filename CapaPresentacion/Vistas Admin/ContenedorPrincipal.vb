Public Class ContenedorPrincipal
    Private Sub ContenedorPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.MdiParent = Me
        frmLogin.StartPosition = 1
        frmLogin.Show()
    End Sub
End Class
