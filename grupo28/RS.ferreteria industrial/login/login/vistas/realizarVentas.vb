Public Class realizarVentas


    Public tabla As New DataTable
    Public id_cliente As Integer
    Public nombre1, apellido1 As String
    Public dni As Int64

    Dim vc As Integer
    Dim vn As String
    Dim vd As String
    Dim vp, vendedor As Integer
    Dim vIm As String
    Dim vs As Integer
    Dim vm As String
    Dim ve As String
    Public vpT As Decimal


    Structure Producto
        Dim codProducto As String
        Dim nombre1 As String
        Dim cantidad1 As String
        Dim precio1 As String
        Dim Subtotal1 As String
    End Structure

    Public mercaderia(50) As Producto

    Private Sub limpiar()
        TxtIdProducto.Clear()
        TxtCantidad.Clear()
        TxtPrecioUnitario.Text = ""
        TxtSubtotal.Text = ""
        TxtStock.Text = ""
    End Sub

    Dim user1 As New Vproducto()
    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user1.MostrarHabilitados(DataListadoProducto)

    End Sub



    Private Sub DataListadoProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoProducto.CellDoubleClick
        Dim i As Integer = DataListadoProducto.CurrentRow.Index
        TxtIdProducto.Text = DataListadoProducto(0, i).Value
        TxtNombreP.Text = DataListadoProducto(2, i).Value
        TxtStock.Text = DataListadoProducto(4, i).Value
        Txtstock_min.Text = DataListadoProducto(5, i).Value
        TxtPrecioUnitario.Text = DataListadoProducto(7, i).Value

        If TxtStock.Text = Txtstock_min.Text Then

            MessageBox.Show("controlar stock", "Control stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Public Sub cargarcliente(ByVal id_cliente As Integer, ByVal nombre1 As String, ByVal apellido1 As String)
        Textidcliente.Text = id_cliente
        Textnombre.Text = nombre1
        txtApellidos.Text = apellido1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Datadetalleventa.Rows.Add(txtNumFac.Text, TxtIdProducto.Text, TxtNombreP.Text, TxtCantidad.Text, TxtPrecioUnitario.Text, TxtSubtotal.Text)
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In Datadetalleventa.Rows
            total += Convert.ToDouble(fila.Cells("subtotal").Value)
        Next

        txtTotal.Text = Convert.ToString(total)
    End Sub

    Private Sub Bbuscarcliente_Click(sender As Object, e As EventArgs) Handles Bbuscarcliente.Click
        Dim fmrP As New gestionClientes
        AddOwnedForm(fmrP)
        fmrP.ShowDialog()
    End Sub


    Private Sub realizarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        TextUsuario.Text = inicioSesion.N_Usuario
        vendedor = empleado.getIdUsuario

        lblFecha.Text = DateTimePicker1.Value.ToShortDateString
        Dim ver As New Vventa
        txtNumFac.Text = ver.MostrarUltimaFactura() + 1
        tabla.Columns.Add("CODIGO", System.Type.GetType("System.String")) '0
        tabla.Columns.Add("NOMBRE", System.Type.GetType("System.String")) '1
        tabla.Columns.Add("PRECIO UNITARIO", System.Type.GetType("System.String"))  '3
        tabla.Columns.Add("CANTIDAD", System.Type.GetType("System.String")) '4
        tabla.Columns.Add("SUBTOTAL", System.Type.GetType("System.String")) '5



    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnMas.Click




        If TxtCantidad.Text = "" Then TxtCantidad.Text = 0

        ' If (CInt(TxtCantidad.Text) < CInt(TxtStock.Text)) Then
        If (CInt(TxtStock.Text > 0)) Then
            TxtCantidad.Text = CInt(TxtCantidad.Text) + 1
            TxtSubtotal.Text = CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)
            TxtStock.Text = CInt(TxtStock.Text) - 1
            If TxtStock.Text = Txtstock_min.Text Then

                MessageBox.Show("controlar stock", "Control stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnMenos.Click
        If TxtCantidad.Text = "" Then TxtCantidad.Text = 1
        If CInt(TxtCantidad.Text) > 0 And TxtCantidad.TextLength <> 0 Then
            TxtCantidad.Text = CInt(TxtCantidad.Text) - 1
            TxtSubtotal.Text = CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)
            TxtStock.Text = CInt(TxtStock.Text) + 1
        End If
    End Sub


    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click

        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        Dim DCliente As String = Textnombre.Text + "; " + txtApellidos.Text
        If MessageBox.Show(" confirmar venta? ", " Realizar venta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                Dim agregaF As New Vventa
                agregaF.AdFactura(txtNumFac.Text, Textidcliente.Text, lblFecha.Text, txtTotal.Text, vendedor)
                While i < Datadetalleventa.Rows.Count
                    row = Datadetalleventa.Rows(i)
                    texto = ""
                    For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                        'comprobamos que la celda tenga algun valor,en caso de 
                        'permitir añadir filas
                        If celda.Value IsNot Nothing Then
                            texto += vbTab + celda.Value.ToString()
                        End If
                    Next
                    'PARA Cada linea guarda el detalle 
                    Dim agregaDetalle As New Vdetalle
                    agregaDetalle.AdDetalle(Datadetalleventa.Item(0, i).Value, Datadetalleventa.Item(1, i).Value, Datadetalleventa.Item(3, i).Value, Datadetalleventa.Item(4, i).Value)
                    Dim descuenta As New Vproducto
                    descuenta.descontarStock(Datadetalleventa.Item(1, i).Value, Datadetalleventa.Item(3, i).Value)
                    i += 1

            End While
            MsgBox("VENTA REALIZADA")
            Dim numFac As Integer
            Dim num As New FormularioFactura

            numFac = txtNumFac.Text
            num.vNro = numFac

            ' num.ShowDialog()

            'Me.Close()
            '    MsgBox("VENTA REALIZADA")

            Me.Close()
            num.ShowDialog()
            'FormularioFactura.Show()

        Else
                MsgBox("venta cancelada ")
        End If

    End Sub



    ' eliminar datos de la tabla detalle ventas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        vpT = vpT + txtTotal.Text
        vpT = vpT - Datadetalleventa.Item(4, Datadetalleventa.CurrentRow.Index).Value.ToString
        TxtSubtotal.Text = vpT
        Datadetalleventa.Rows.RemoveAt(Datadetalleventa.CurrentRow.Index) 'elimino solo el elemento seleccionado
        Datadetalleventa.Refresh() ' actualiza datagrid
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        user.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        TxtIdProducto.Clear()
        TxtCantidad.Clear()
        TxtPrecioUnitario.Text = ""
        TxtSubtotal.Text = ""
        TxtStock.Text = ""
        Txtstock_min.Text = ""
        Textidcliente.Clear()
        Textnombre.Clear()
        txtApellidos.Clear()
        TxtNombreP.Text = ""
        Datadetalleventa.DataSource = ""










    End Sub



    Private Sub Bclientenuevo_Click(sender As Object, e As EventArgs) Handles BagregarCli.Click
        clientesHabilitados.Show()
    End Sub

    Private Sub TxtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProducto.TextChanged

    End Sub

    Private Sub TxtStock_TextChanged(sender As Object, e As EventArgs) Handles TxtStock.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim fmr As New gestionClientes
        AddOwnedForm(fmr)
        fmr.ShowDialog()

    End Sub


    '------------------------------------------------

#Region "botones"
    Private Sub BprodHabilitados_Click(sender As Object, e As EventArgs) Handles BprodHabilitados.Click
        ProductosHabilitados.Show()
    End Sub

#End Region

















End Class