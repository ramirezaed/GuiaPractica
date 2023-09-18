Imports System.ComponentModel

Public Class gestionProductos

    Dim user1 As New Vproducto()

    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user1.MostrarProductos(DataListadoProducto)

    End Sub

    Public Sub ActualizarListaProductos() 'utilizo para mostrar los productos despues de agregar  o editar
        Using db As New FERRETERIAEntities1
            ' Obtener la lista de usuarios desde la base de datos
            Dim ListadoProducto = From q In db.producto
                                  Join c In db.categoria On q.id_categoria Equals c.id_categoria
                                  Select
                                      IdProducto = q.id_producto, Codigo = q.codigo_pro, Categoria = c.descripcion, Nombre = q.nombre, Descripcion = q.descripcion,
                                      Stock = q.stock, stock_minimo = q.stock_minimo, PrecioCompra = q.precio_compra, PrecioVenta = q.precio_venta

            DataListadoProducto.DataSource = ListadoProducto.ToList()
        End Using
    End Sub




    Private Sub BhabilitarProd_Click(sender As Object, e As EventArgs) Handles BhabilitarProd.Click
        If DataListadoProducto.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoProducto.SelectedRows(0).Cells(0).Value)
            user1.AltaProductos(id)
            user1.MostrarProductos(DataListadoProducto)
        Else
            MessageBox.Show("Por favor, seleccione un producto para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BeliminarProducto_Click(sender As Object, e As EventArgs) Handles BeliminarProducto.Click
        If DataListadoProducto.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoProducto.SelectedRows(0).Cells(0).Value)
            user1.BajaProductos(id)
            user1.MostrarProductos(DataListadoProducto)
        Else
            MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub BagregarProducto_Click(sender As Object, e As EventArgs) Handles BagregarProducto.Click
        agregarProducto.Show()
    End Sub

    Private Sub BEditarProducto_Click(sender As Object, e As EventArgs) Handles BEditarProducto.Click
        EditarProducto.Show()
    End Sub


#Region "BUSCADOR en la COLUMNA CODIGO"
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataListadoProducto.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos el nombre de la columna en la que queremos buscar (en este caso, "codigo").
            Dim nombreColumnaBusqueda As String = "codigo"

            For Each row As DataGridViewRow In DataListadoProducto.Rows
                Dim cell As DataGridViewCell = row.Cells(nombreColumnaBusqueda)

                If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                    row.Selected = True
                    encontradaCoincidencia = True
                    Exit For ' Salimos del bucle de filas si encontramos una coincidencia.
                End If
            Next

            If Not encontradaCoincidencia Then
                Dim respuesta As DialogResult = MessageBox.Show("No se encontró ningún producto con este código. ¿Desea agregar un nuevo producto?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    ' Abre el formulario para agregar un cliente.
                    agregarProducto.Show()
                End If
            End If
        Else
            MessageBox.Show("El código debe tener al menos 1 carácter.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Tbuscar_keypress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tbuscar.Text

            If Char.IsDigit(e.KeyChar) Then

                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("ingrese el codigo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region
End Class



