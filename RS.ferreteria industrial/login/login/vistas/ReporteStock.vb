﻿Public Class ReporteStock
    Private Sub ReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New CrystalReport2
        CrystalReportViewer1.ReportSource = objreport
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class