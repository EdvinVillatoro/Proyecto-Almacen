Public Class frmTecnicoPrincipal
    Private Sub btnServiciosAsignados_Click(sender As Object, e As EventArgs) Handles btnServiciosAsignados.Click
        frmServicios1.Show()
        frmServicios1.StartPosition = 1
    End Sub

    Private Sub btnSoluciones_Click(sender As Object, e As EventArgs) Handles btnSoluciones.Click
        frmSolucionesServicio.Show()
        frmSolucionesServicio.StartPosition = 1
    End Sub
End Class