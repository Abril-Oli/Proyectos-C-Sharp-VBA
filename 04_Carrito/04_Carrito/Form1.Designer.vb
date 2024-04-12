<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelProducto = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.GrillaProductos = New System.Windows.Forms.DataGridView()
        Me.Productos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProducto
        '
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelProducto.Location = New System.Drawing.Point(217, 76)
        Me.LabelProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(151, 29)
        Me.LabelProducto.TabIndex = 0
        Me.LabelProducto.Text = "PRODUCTO"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelPrecio.Location = New System.Drawing.Point(232, 170)
        Me.LabelPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(104, 29)
        Me.LabelPrecio.TabIndex = 1
        Me.LabelPrecio.Text = "PRECIO"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBox1.Location = New System.Drawing.Point(367, 76)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 35)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBox2.Location = New System.Drawing.Point(367, 170)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(113, 35)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 284)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelTotal.Location = New System.Drawing.Point(196, 292)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(92, 29)
        Me.LabelTotal.TabIndex = 5
        Me.LabelTotal.Text = "TOTAL"
        '
        'GrillaProductos
        '
        Me.GrillaProductos.AllowUserToAddRows = False
        Me.GrillaProductos.AllowUserToDeleteRows = False
        Me.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Productos, Me.ColumnaPrecio})
        Me.GrillaProductos.Location = New System.Drawing.Point(578, 20)
        Me.GrillaProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GrillaProductos.Name = "GrillaProductos"
        Me.GrillaProductos.ReadOnly = True
        Me.GrillaProductos.RowHeadersWidth = 51
        Me.GrillaProductos.RowTemplate.Height = 24
        Me.GrillaProductos.Size = New System.Drawing.Size(348, 405)
        Me.GrillaProductos.TabIndex = 6
        '
        'Productos
        '
        Me.Productos.HeaderText = "Productos"
        Me.Productos.MinimumWidth = 6
        Me.Productos.Name = "Productos"
        Me.Productos.ReadOnly = True
        Me.Productos.Width = 150
        '
        'ColumnaPrecio
        '
        Me.ColumnaPrecio.HeaderText = "Precio"
        Me.ColumnaPrecio.MinimumWidth = 6
        Me.ColumnaPrecio.Name = "ColumnaPrecio"
        Me.ColumnaPrecio.ReadOnly = True
        Me.ColumnaPrecio.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 457)
        Me.Controls.Add(Me.GrillaProductos)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelProducto)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProducto As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents GrillaProductos As DataGridView
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaPrecio As DataGridViewTextBoxColumn
End Class
