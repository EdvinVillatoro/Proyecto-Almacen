Public Class contenedorAdmin
    Private Sub btnAbrirEdificios_Click(sender As Object, e As EventArgs) Handles btnAbrirEdificios.Click
        frmEdificios.Show()
        frmEdificios.StartPosition = 1
    End Sub

    Private Sub btnAbrirClientes_Click(sender As Object, e As EventArgs) Handles btnAbrirClientes.Click
        frmMostrarClientes.Show()
        frmMostrarClientes.StartPosition = 1
    End Sub

    Private Sub btnTecnicos_Click(sender As Object, e As EventArgs) Handles btnTecnicos.Click
        frmMostrarTecnicos.Show()
        frmMostrarTecnicos.StartPosition = 1
    End Sub

    Private Sub btnOficinas_Click(sender As Object, e As EventArgs) Handles btnOficinas.Click
        frmOficinas.Show()
        frmOficinas.StartPosition = 1
    End Sub

    Private Sub BtnServiciosPrestados_Click(sender As Object, e As EventArgs) Handles BtnServiciosPrestados.Click
        frmEstatus.Show()
        frmEstatus.StartPosition = 1
    End Sub

    Private Sub btnServiciosSolicitados_Click(sender As Object, e As EventArgs) Handles btnServiciosSolicitados.Click
        frmMostrarServiciosSolicitados.Show()
        frmMostrarServiciosSolicitados.StartPosition = 1
    End Sub
End Class