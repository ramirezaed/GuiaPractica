Public Class admin

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        Textusuario.Text = inicioSesion.N_Usuario
    End Sub

#Region "CERRAR S , MINIMIZAR CERRAR"
    Private Sub Csesion_Click(sender As Object, e As EventArgs) Handles Csesion.Click
        If MsgBox("Seguro desea cerrar sesion", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        'Application.Exit()
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub BotonMIni_Click(sender As Object, e As EventArgs) Handles BotonMIni.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region


    Dim Gusuarios As New gestionUsuarios()
    Dim Gbuck As New buckup()



    Private Sub Ausuario_Click(sender As Object, e As EventArgs) Handles Ausuario.Click
        PanelUsuaio.Controls.Clear()
        Gusuarios.TopLevel = False
        Gusuarios.FormBorderStyle = FormBorderStyle.None
        Gusuarios.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gusuarios)
        Gusuarios.Show()
    End Sub
    'cerrar sesion'


    Private Sub BotonBuckup_Click(sender As Object, e As EventArgs) Handles BotonBuckup.Click
        PanelUsuaio.Controls.Clear()
        Gbuck.TopLevel = False
        Gbuck.FormBorderStyle = FormBorderStyle.None
        Gbuck.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gbuck)
        Gbuck.Show()
    End Sub




End Class


