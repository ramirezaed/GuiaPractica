Public Class DiaFecha


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'generar
        Dim fechain As Date = CDate(DateTimePicker1.Text)
        Dim reporte As New DiaReporte
        reporte.fechaInicial = fechain

        reporte.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  gerente.Show()
        Me.Close()
    End Sub

    Private Sub DiaFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class