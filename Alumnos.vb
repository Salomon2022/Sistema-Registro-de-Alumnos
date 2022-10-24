Public Class Alumnos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Alumnos.MousePosition.X - Me.Location.X - ex, Alumnos.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelDatos.Visible = True
    End Sub

    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        Arrastre = False
    End Sub
End Class
