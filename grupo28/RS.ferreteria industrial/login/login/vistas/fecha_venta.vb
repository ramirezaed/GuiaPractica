Public Class fecha_venta



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechain As Date = CDate(DateTimePicker1.Text)
        Dim fechafin As Date = CDate(DateTimePicker2.Text)

        Dim reportefecha As New formulariofechaVenta

        reportefecha.fechainicial = fechain
        reportefecha.fechafinal = fechafin

        reportefecha.ShowDialog()



    End Sub

    Private Sub fecha_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gerente.Show()
        Me.Close()

    End Sub
End Class