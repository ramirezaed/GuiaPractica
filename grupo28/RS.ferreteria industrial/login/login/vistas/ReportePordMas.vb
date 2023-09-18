Public Class ReportePordMas
    Private Sub ReportePordMas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New CrystalReport4
        CrystalReportViewer1.ReportSource = objreport
    End Sub
End Class