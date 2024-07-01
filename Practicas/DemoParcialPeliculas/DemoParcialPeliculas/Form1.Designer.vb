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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelPeli = New System.Windows.Forms.Label()
        Me.LabelGen = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TextBoxPeli = New System.Windows.Forms.TextBox()
        Me.TextBoxGenero = New System.Windows.Forms.TextBox()
        Me.LabelDuracion = New System.Windows.Forms.Label()
        Me.TextBoxDuracion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPromDuracion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEstadisticas = New System.Windows.Forms.GroupBox()
        Me.LabelDuracionTotal = New System.Windows.Forms.Label()
        Me.LabelPromedioDuracion = New System.Windows.Forms.Label()
        Me.LabelPeliculasComedia = New System.Windows.Forms.Label()
        Me.LabelPromedioPeliculasTerror = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxEstadisticas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(664, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(601, 707)
        Me.DataGridView1.TabIndex = 0
        '
        'LabelPeli
        '
        Me.LabelPeli.AutoSize = True
        Me.LabelPeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPeli.Location = New System.Drawing.Point(12, 45)
        Me.LabelPeli.Name = "LabelPeli"
        Me.LabelPeli.Size = New System.Drawing.Size(80, 25)
        Me.LabelPeli.TabIndex = 1
        Me.LabelPeli.Text = "Pelicula"
        '
        'LabelGen
        '
        Me.LabelGen.AutoSize = True
        Me.LabelGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGen.Location = New System.Drawing.Point(15, 125)
        Me.LabelGen.Name = "LabelGen"
        Me.LabelGen.Size = New System.Drawing.Size(77, 25)
        Me.LabelGen.TabIndex = 2
        Me.LabelGen.Text = "Genero"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(183, 323)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(131, 68)
        Me.ButtonAgregar.TabIndex = 3
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TextBoxPeli
        '
        Me.TextBoxPeli.Location = New System.Drawing.Point(17, 82)
        Me.TextBoxPeli.Name = "TextBoxPeli"
        Me.TextBoxPeli.Size = New System.Drawing.Size(506, 45)
        Me.TextBoxPeli.TabIndex = 4
        '
        'TextBoxGenero
        '
        Me.TextBoxGenero.Location = New System.Drawing.Point(17, 165)
        Me.TextBoxGenero.Name = "TextBoxGenero"
        Me.TextBoxGenero.Size = New System.Drawing.Size(506, 45)
        Me.TextBoxGenero.TabIndex = 5
        '
        'LabelDuracion
        '
        Me.LabelDuracion.AutoSize = True
        Me.LabelDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDuracion.Location = New System.Drawing.Point(15, 218)
        Me.LabelDuracion.Name = "LabelDuracion"
        Me.LabelDuracion.Size = New System.Drawing.Size(90, 25)
        Me.LabelDuracion.TabIndex = 6
        Me.LabelDuracion.Text = "Duracion"
        '
        'TextBoxDuracion
        '
        Me.TextBoxDuracion.Location = New System.Drawing.Point(17, 272)
        Me.TextBoxDuracion.Name = "TextBoxDuracion"
        Me.TextBoxDuracion.Size = New System.Drawing.Size(506, 45)
        Me.TextBoxDuracion.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Duracion total:"
        '
        'LabelPromDuracion
        '
        Me.LabelPromDuracion.AutoSize = True
        Me.LabelPromDuracion.Location = New System.Drawing.Point(6, 113)
        Me.LabelPromDuracion.Name = "LabelPromDuracion"
        Me.LabelPromDuracion.Size = New System.Drawing.Size(237, 29)
        Me.LabelPromDuracion.TabIndex = 9
        Me.LabelPromDuracion.Text = "Promedio Duracion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Peliculas de Comedia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 36)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Promedio pelis Terror:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelPeli)
        Me.GroupBox1.Controls.Add(Me.TextBoxPeli)
        Me.GroupBox1.Controls.Add(Me.LabelGen)
        Me.GroupBox1.Controls.Add(Me.TextBoxGenero)
        Me.GroupBox1.Controls.Add(Me.LabelDuracion)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Controls.Add(Me.TextBoxDuracion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 404)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'GroupBoxEstadisticas
        '
        Me.GroupBoxEstadisticas.Controls.Add(Me.LabelPromedioPeliculasTerror)
        Me.GroupBoxEstadisticas.Controls.Add(Me.LabelPeliculasComedia)
        Me.GroupBoxEstadisticas.Controls.Add(Me.LabelPromedioDuracion)
        Me.GroupBoxEstadisticas.Controls.Add(Me.LabelDuracionTotal)
        Me.GroupBoxEstadisticas.Controls.Add(Me.Label1)
        Me.GroupBoxEstadisticas.Controls.Add(Me.LabelPromDuracion)
        Me.GroupBoxEstadisticas.Controls.Add(Me.Label4)
        Me.GroupBoxEstadisticas.Controls.Add(Me.Label3)
        Me.GroupBoxEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBoxEstadisticas.Location = New System.Drawing.Point(12, 458)
        Me.GroupBoxEstadisticas.Name = "GroupBoxEstadisticas"
        Me.GroupBoxEstadisticas.Size = New System.Drawing.Size(620, 277)
        Me.GroupBoxEstadisticas.TabIndex = 13
        Me.GroupBoxEstadisticas.TabStop = False
        Me.GroupBoxEstadisticas.Text = "Estadisticas"
        '
        'LabelDuracionTotal
        '
        Me.LabelDuracionTotal.AutoSize = True
        Me.LabelDuracionTotal.Location = New System.Drawing.Point(502, 55)
        Me.LabelDuracionTotal.Name = "LabelDuracionTotal"
        Me.LabelDuracionTotal.Size = New System.Drawing.Size(34, 36)
        Me.LabelDuracionTotal.TabIndex = 12
        Me.LabelDuracionTotal.Text = "0"
        '
        'LabelPromedioDuracion
        '
        Me.LabelPromedioDuracion.AutoSize = True
        Me.LabelPromedioDuracion.Location = New System.Drawing.Point(502, 113)
        Me.LabelPromedioDuracion.Name = "LabelPromedioDuracion"
        Me.LabelPromedioDuracion.Size = New System.Drawing.Size(34, 36)
        Me.LabelPromedioDuracion.TabIndex = 13
        Me.LabelPromedioDuracion.Text = "0"
        '
        'LabelPeliculasComedia
        '
        Me.LabelPeliculasComedia.AutoSize = True
        Me.LabelPeliculasComedia.Location = New System.Drawing.Point(502, 170)
        Me.LabelPeliculasComedia.Name = "LabelPeliculasComedia"
        Me.LabelPeliculasComedia.Size = New System.Drawing.Size(34, 36)
        Me.LabelPeliculasComedia.TabIndex = 14
        Me.LabelPeliculasComedia.Text = "0"
        '
        'LabelPromedioPeliculasTerror
        '
        Me.LabelPromedioPeliculasTerror.AutoSize = True
        Me.LabelPromedioPeliculasTerror.Location = New System.Drawing.Point(502, 218)
        Me.LabelPromedioPeliculasTerror.Name = "LabelPromedioPeliculasTerror"
        Me.LabelPromedioPeliculasTerror.Size = New System.Drawing.Size(34, 36)
        Me.LabelPromedioPeliculasTerror.TabIndex = 15
        Me.LabelPromedioPeliculasTerror.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 763)
        Me.Controls.Add(Me.GroupBoxEstadisticas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxEstadisticas.ResumeLayout(False)
        Me.GroupBoxEstadisticas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelPeli As Label
    Friend WithEvents LabelGen As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxPeli As TextBox
    Friend WithEvents TextBoxGenero As TextBox
    Friend WithEvents LabelDuracion As Label
    Friend WithEvents TextBoxDuracion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelPromDuracion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxEstadisticas As GroupBox
    Friend WithEvents LabelPromedioPeliculasTerror As Label
    Friend WithEvents LabelPeliculasComedia As Label
    Friend WithEvents LabelPromedioDuracion As Label
    Friend WithEvents LabelDuracionTotal As Label
End Class
