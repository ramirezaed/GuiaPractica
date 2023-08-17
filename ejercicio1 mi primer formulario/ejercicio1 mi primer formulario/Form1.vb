Public Class formulario
    Private Sub Bguardar_Click(sender As Object, e As EventArgs) Handles Bguardar.Click
        Dim apellido As String = Tapellido.Text
        Dim nombre As String = Tnombre.Text
        Dim nombreCompeleto As String = apellido & " " % nombre
            
        Tapenom.Text = nombreCompeleto
    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        Tapellido.Clear()
        Tnombre.Clear()
        Tapenom.Clear()
    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub
End Class
