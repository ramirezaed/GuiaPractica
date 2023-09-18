Public Class gerente
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultado As MsgBoxResult
        resultado = MessageBox.Show(" Cerrar Sesion?", " Cerrar Sesion ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then

            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ReportePordMas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reporteUsuarios.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReporteStock.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ventaEmpleado.Click
        DiaFecha.Show() ' reporteVentaporEmpleado.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        fecha_venta.Show()
    End Sub


End Class

