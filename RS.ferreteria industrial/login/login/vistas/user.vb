Public Class user



    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        Textusuario.Text = inicioSesion.N_Usuario
    End Sub


#Region "MOVER CON EL MOUSE"
    Private startPoint As New Point(0, 0)
    Private IsDragging As Boolean
    Private MouseOffset As Point

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If IsDragging Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub
    Private Sub panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        IsDragging = False
    End Sub
#End Region


#Region "CERRAR S, MINIMIZAR, CERRAR"

    Private Sub BcerrarS_Click(sender As Object, e As EventArgs) Handles BcerrarS.Click
        If MsgBox("Seguro desea cerrar sesion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If

    End Sub

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Variables Para El Panel"
    Dim Fventas As New realizarVentas()
    Dim Gclientes As New gestionClientes()
    Dim Gproductos As New gestionProductos()
    Dim Finforme As New DiaFecha()
#End Region



    Private Sub Bventas_Click(sender As Object, e As EventArgs) Handles Bventas.Click
        PanelUsuaio.Controls.Clear()
        Fventas.TopLevel = False
        Fventas.FormBorderStyle = FormBorderStyle.None
        Fventas.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Fventas)
        Fventas.Show()
    End Sub

    Private Sub Bclientes_Click(sender As Object, e As EventArgs) Handles Bclientes.Click
        PanelUsuaio.Controls.Clear()
        Gclientes.TopLevel = False
        Gclientes.FormBorderStyle = FormBorderStyle.None
        Gclientes.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gclientes)
        Gclientes.Show()
    End Sub


    Private Sub Bproductos_Click(sender As Object, e As EventArgs) Handles Bproductos.Click
        PanelUsuaio.Controls.Clear()
        Gproductos.TopLevel = False
        Gproductos.FormBorderStyle = FormBorderStyle.None
        Gproductos.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gproductos)
        Gproductos.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DiaFecha.Show()
    End Sub


End Class