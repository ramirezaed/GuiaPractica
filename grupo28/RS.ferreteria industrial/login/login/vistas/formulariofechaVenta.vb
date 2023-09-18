Public Class formulariofechaVenta
    Public fechainicial As Date
    Public fechafinal As Date


    Private Sub formulariofechaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CrystalReport5
        objreporte.SetParameterValue("@fecha", fechainicial)
        objreporte.SetParameterValue("@fecha2", fechafinal)
        CrystalReportViewer1.ReportSource = objreporte

    End Sub
End Class