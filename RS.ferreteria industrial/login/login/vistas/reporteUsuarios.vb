Public Class reporteUsuarios
    Private Sub reporteUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New CrystalReport3
        CrystalReportViewer1.ReportSource = objreport
    End Sub
End Class