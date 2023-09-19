<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class realizarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lvendedor = New System.Windows.Forms.Label()
        Me.Lcliente = New System.Windows.Forms.Label()
        Me.Textidcliente = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Lproducto = New System.Windows.Forms.Label()
        Me.BagregarCli = New System.Windows.Forms.Button()
        Me.Bbuscarcliente = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Ltotal = New System.Windows.Forms.Label()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Txtstock_min = New System.Windows.Forms.TextBox()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.DataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.txtNumFac = New System.Windows.Forms.TextBox()
        Me.BtnMas = New System.Windows.Forms.Button()
        Me.BtnMenos = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Datadetalleventa = New System.Windows.Forms.DataGridView()
        Me.id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BprodHabilitados = New System.Windows.Forms.Button()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datadetalleventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(657, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Lvendedor
        '
        Me.Lvendedor.AutoSize = True
        Me.Lvendedor.BackColor = System.Drawing.Color.Transparent
        Me.Lvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvendedor.Location = New System.Drawing.Point(9, 114)
        Me.Lvendedor.Name = "Lvendedor"
        Me.Lvendedor.Size = New System.Drawing.Size(78, 18)
        Me.Lvendedor.TabIndex = 2
        Me.Lvendedor.Text = "ID cliente"
        '
        'Lcliente
        '
        Me.Lcliente.AutoSize = True
        Me.Lcliente.BackColor = System.Drawing.Color.Transparent
        Me.Lcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcliente.Location = New System.Drawing.Point(9, 141)
        Me.Lcliente.Name = "Lcliente"
        Me.Lcliente.Size = New System.Drawing.Size(68, 18)
        Me.Lcliente.TabIndex = 3
        Me.Lcliente.Text = "Nombre"
        '
        'Textidcliente
        '
        Me.Textidcliente.Location = New System.Drawing.Point(96, 115)
        Me.Textidcliente.Name = "Textidcliente"
        Me.Textidcliente.Size = New System.Drawing.Size(188, 20)
        Me.Textidcliente.TabIndex = 5
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(96, 141)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(188, 20)
        Me.Textnombre.TabIndex = 6
        '
        'Lproducto
        '
        Me.Lproducto.AutoSize = True
        Me.Lproducto.BackColor = System.Drawing.Color.Transparent
        Me.Lproducto.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lproducto.Location = New System.Drawing.Point(545, 24)
        Me.Lproducto.Name = "Lproducto"
        Me.Lproducto.Size = New System.Drawing.Size(228, 31)
        Me.Lproducto.TabIndex = 8
        Me.Lproducto.Text = "Lista de Productos"
        '
        'BagregarCli
        '
        Me.BagregarCli.BackColor = System.Drawing.Color.Transparent
        Me.BagregarCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BagregarCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagregarCli.Location = New System.Drawing.Point(301, 114)
        Me.BagregarCli.Name = "BagregarCli"
        Me.BagregarCli.Size = New System.Drawing.Size(135, 29)
        Me.BagregarCli.TabIndex = 14
        Me.BagregarCli.Text = "Agregar Cliente"
        Me.BagregarCli.UseVisualStyleBackColor = False
        '
        'Bbuscarcliente
        '
        Me.Bbuscarcliente.BackColor = System.Drawing.Color.Transparent
        Me.Bbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bbuscarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbuscarcliente.Location = New System.Drawing.Point(301, 149)
        Me.Bbuscarcliente.Name = "Bbuscarcliente"
        Me.Bbuscarcliente.Size = New System.Drawing.Size(135, 29)
        Me.Bbuscarcliente.TabIndex = 15
        Me.Bbuscarcliente.Text = "Nuevo Cliente"
        Me.Bbuscarcliente.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(1021, 448)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(131, 20)
        Me.txtTotal.TabIndex = 18
        '
        'Ltotal
        '
        Me.Ltotal.AutoSize = True
        Me.Ltotal.BackColor = System.Drawing.Color.Transparent
        Me.Ltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltotal.Location = New System.Drawing.Point(955, 447)
        Me.Ltotal.Name = "Ltotal"
        Me.Ltotal.Size = New System.Drawing.Size(46, 18)
        Me.Ltotal.TabIndex = 19
        Me.Ltotal.Text = "Total"
        '
        'btnRealizar
        '
        Me.btnRealizar.BackColor = System.Drawing.Color.Transparent
        Me.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizar.Location = New System.Drawing.Point(1021, 488)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(131, 36)
        Me.btnRealizar.TabIndex = 23
        Me.btnRealizar.Text = "realizar"
        Me.btnRealizar.UseVisualStyleBackColor = False
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(263, 10)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.ReadOnly = True
        Me.TextUsuario.Size = New System.Drawing.Size(123, 20)
        Me.TextUsuario.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "vendedor"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(74, 49)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.ReadOnly = True
        Me.lblFecha.Size = New System.Drawing.Size(94, 20)
        Me.lblFecha.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Datos de prodructo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "id producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Nombre"
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(111, 268)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.ReadOnly = True
        Me.TxtIdProducto.Size = New System.Drawing.Size(146, 20)
        Me.TxtIdProducto.TabIndex = 47
        '
        'TxtNombreP
        '
        Me.TxtNombreP.Location = New System.Drawing.Point(111, 304)
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.Size = New System.Drawing.Size(146, 20)
        Me.TxtNombreP.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(244, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Precio Unitario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(279, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 15)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "stock min"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(353, 269)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 54
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(353, 300)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(100, 20)
        Me.TxtStock.TabIndex = 55
        '
        'Txtstock_min
        '
        Me.Txtstock_min.Location = New System.Drawing.Point(353, 326)
        Me.Txtstock_min.Name = "Txtstock_min"
        Me.Txtstock_min.Size = New System.Drawing.Size(100, 20)
        Me.Txtstock_min.TabIndex = 56
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(353, 354)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioUnitario.TabIndex = 57
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(23, 375)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 23)
        Me.btnAgregar.TabIndex = 60
        Me.btnAgregar.Text = "Agregar producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(133, 375)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 23)
        Me.btnEliminar.TabIndex = 61
        Me.btnEliminar.Text = "Quitar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'DataListadoProducto
        '
        Me.DataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListadoProducto.Location = New System.Drawing.Point(551, 74)
        Me.DataListadoProducto.Name = "DataListadoProducto"
        Me.DataListadoProducto.Size = New System.Drawing.Size(571, 163)
        Me.DataListadoProducto.TabIndex = 62
        '
        'txtNumFac
        '
        Me.txtNumFac.Location = New System.Drawing.Point(133, 14)
        Me.txtNumFac.Name = "txtNumFac"
        Me.txtNumFac.ReadOnly = True
        Me.txtNumFac.Size = New System.Drawing.Size(35, 20)
        Me.txtNumFac.TabIndex = 63
        '
        'BtnMas
        '
        Me.BtnMas.Location = New System.Drawing.Point(501, 274)
        Me.BtnMas.Name = "BtnMas"
        Me.BtnMas.Size = New System.Drawing.Size(31, 19)
        Me.BtnMas.TabIndex = 64
        Me.BtnMas.Text = "*"
        Me.BtnMas.UseVisualStyleBackColor = True
        '
        'BtnMenos
        '
        Me.BtnMenos.Location = New System.Drawing.Point(468, 274)
        Me.BtnMenos.Name = "BtnMenos"
        Me.BtnMenos.Size = New System.Drawing.Size(27, 20)
        Me.BtnMenos.TabIndex = 65
        Me.BtnMenos.Text = "-"
        Me.BtnMenos.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "N° de factura"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(96, 170)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(188, 20)
        Me.txtApellidos.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 18)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Apellido"
        '
        'Datadetalleventa
        '
        Me.Datadetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datadetalleventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_factura, Me.cod_pro, Me.nombre, Me.cantidad, Me.Column1, Me.subtotal})
        Me.Datadetalleventa.Location = New System.Drawing.Point(551, 268)
        Me.Datadetalleventa.Name = "Datadetalleventa"
        Me.Datadetalleventa.Size = New System.Drawing.Size(571, 142)
        Me.Datadetalleventa.TabIndex = 70
        '
        'id_factura
        '
        Me.id_factura.HeaderText = "N° factura"
        Me.id_factura.Name = "id_factura"
        Me.id_factura.ReadOnly = True
        '
        'cod_pro
        '
        Me.cod_pro.HeaderText = "cod_producto"
        Me.cod_pro.Name = "cod_pro"
        Me.cod_pro.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "precio unidad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "subtotal"
        Me.subtotal.Name = "subtotal"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(353, 380)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubtotal.TabIndex = 71
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(836, 501)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'BprodHabilitados
        '
        Me.BprodHabilitados.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.BprodHabilitados.FlatAppearance.BorderSize = 0
        Me.BprodHabilitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BprodHabilitados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BprodHabilitados.Image = Global.login.My.Resources.Resources.icons8_agregar_a_carrito_de_compras_36
        Me.BprodHabilitados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BprodHabilitados.Location = New System.Drawing.Point(134, 457)
        Me.BprodHabilitados.Name = "BprodHabilitados"
        Me.BprodHabilitados.Size = New System.Drawing.Size(219, 40)
        Me.BprodHabilitados.TabIndex = 87
        Me.BprodHabilitados.Text = "Agregar"
        Me.BprodHabilitados.UseVisualStyleBackColor = True
        '
        'realizarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1164, 558)
        Me.Controls.Add(Me.BprodHabilitados)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.Datadetalleventa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnMenos)
        Me.Controls.Add(Me.BtnMas)
        Me.Controls.Add(Me.txtNumFac)
        Me.Controls.Add(Me.DataListadoProducto)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TxtPrecioUnitario)
        Me.Controls.Add(Me.Txtstock_min)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNombreP)
        Me.Controls.Add(Me.TxtIdProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.Ltotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Bbuscarcliente)
        Me.Controls.Add(Me.BagregarCli)
        Me.Controls.Add(Me.Lproducto)
        Me.Controls.Add(Me.Textnombre)
        Me.Controls.Add(Me.Textidcliente)
        Me.Controls.Add(Me.Lcliente)
        Me.Controls.Add(Me.Lvendedor)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1164, 558)
        Me.MinimumSize = New System.Drawing.Size(1164, 558)
        Me.Name = "realizarVentas"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datadetalleventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Lvendedor As Label
    Friend WithEvents Lcliente As Label
    Friend WithEvents Textidcliente As TextBox
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Lproducto As Label
    Friend WithEvents BagregarCli As Button
    Friend WithEvents Bbuscarcliente As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Ltotal As Label
    Friend WithEvents btnRealizar As Button
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Txtstock_min As TextBox
    Friend WithEvents TxtPrecioUnitario As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DataListadoProducto As DataGridView
    Friend WithEvents txtNumFac As TextBox
    Friend WithEvents BtnMas As Button
    Friend WithEvents BtnMenos As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Datadetalleventa As DataGridView
    Friend WithEvents id_factura As DataGridViewTextBoxColumn
    Friend WithEvents cod_pro As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BprodHabilitados As Button
End Class
