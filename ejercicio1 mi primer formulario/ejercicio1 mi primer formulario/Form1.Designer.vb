<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.Tapellido = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Tapenom = New System.Windows.Forms.TextBox()
        Me.Lapellido = New System.Windows.Forms.Label()
        Me.Lnombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bguardar
        '
        Me.Bguardar.Location = New System.Drawing.Point(47, 145)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(75, 23)
        Me.Bguardar.TabIndex = 0
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.UseVisualStyleBackColor = True
        '
        'Beliminar
        '
        Me.Beliminar.Location = New System.Drawing.Point(160, 145)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(75, 23)
        Me.Beliminar.TabIndex = 1
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(204, 214)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(75, 23)
        Me.Bsalir.TabIndex = 2
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Tapellido
        '
        Me.Tapellido.Location = New System.Drawing.Point(105, 38)
        Me.Tapellido.Name = "Tapellido"
        Me.Tapellido.Size = New System.Drawing.Size(100, 20)
        Me.Tapellido.TabIndex = 3
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(105, 83)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(100, 20)
        Me.Tnombre.TabIndex = 4
        '
        'Tapenom
        '
        Me.Tapenom.Location = New System.Drawing.Point(286, 41)
        Me.Tapenom.Multiline = True
        Me.Tapenom.Name = "Tapenom"
        Me.Tapenom.Size = New System.Drawing.Size(173, 127)
        Me.Tapenom.TabIndex = 5
        '
        'Lapellido
        '
        Me.Lapellido.AutoSize = True
        Me.Lapellido.Location = New System.Drawing.Point(13, 44)
        Me.Lapellido.Name = "Lapellido"
        Me.Lapellido.Size = New System.Drawing.Size(44, 13)
        Me.Lapellido.TabIndex = 6
        Me.Lapellido.Text = "Apellido"
        '
        'Lnombre
        '
        Me.Lnombre.AutoSize = True
        Me.Lnombre.Location = New System.Drawing.Point(16, 89)
        Me.Lnombre.Name = "Lnombre"
        Me.Lnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lnombre.TabIndex = 7
        Me.Lnombre.Text = "Nombre"
        '
        'formulario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.Lnombre)
        Me.Controls.Add(Me.Lapellido)
        Me.Controls.Add(Me.Tapenom)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Tapellido)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bguardar)
        Me.Name = "formulario"
        Me.Text = "Mi primer Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bguardar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bsalir As Button
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Tapenom As TextBox
    Friend WithEvents Lapellido As Label
    Friend WithEvents Lnombre As Label
End Class
