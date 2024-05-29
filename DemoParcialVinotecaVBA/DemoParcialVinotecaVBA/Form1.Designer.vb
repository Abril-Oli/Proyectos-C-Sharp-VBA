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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxCapacidad = New System.Windows.Forms.TextBox()
        Me.TextBoxAlcohol = New System.Windows.Forms.TextBox()
        Me.ComboBoxEnvase = New System.Windows.Forms.ComboBox()
        Me.LabelCantBotella = New System.Windows.Forms.Label()
        Me.LabelBebidaMasAlcohol = New System.Windows.Forms.Label()
        Me.LabelMarcaAlma = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(910, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(377, 497)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Capacidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Envase tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "%Alcohol"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cant vinos botella:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 499)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Bebida con +%Alcohol"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 550)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Bebidas marca ALMA"
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(119, 49)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxMarca.TabIndex = 10
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(119, 113)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDescripcion.TabIndex = 11
        '
        'TextBoxCapacidad
        '
        Me.TextBoxCapacidad.Location = New System.Drawing.Point(119, 174)
        Me.TextBoxCapacidad.Name = "TextBoxCapacidad"
        Me.TextBoxCapacidad.Size = New System.Drawing.Size(211, 22)
        Me.TextBoxCapacidad.TabIndex = 12
        '
        'TextBoxAlcohol
        '
        Me.TextBoxAlcohol.Location = New System.Drawing.Point(119, 288)
        Me.TextBoxAlcohol.Name = "TextBoxAlcohol"
        Me.TextBoxAlcohol.Size = New System.Drawing.Size(224, 22)
        Me.TextBoxAlcohol.TabIndex = 13
        '
        'ComboBoxEnvase
        '
        Me.ComboBoxEnvase.FormattingEnabled = True
        Me.ComboBoxEnvase.Items.AddRange(New Object() {"Botella", "Lata", "Carton"})
        Me.ComboBoxEnvase.Location = New System.Drawing.Point(119, 235)
        Me.ComboBoxEnvase.Name = "ComboBoxEnvase"
        Me.ComboBoxEnvase.Size = New System.Drawing.Size(237, 24)
        Me.ComboBoxEnvase.TabIndex = 14
        '
        'LabelCantBotella
        '
        Me.LabelCantBotella.AutoSize = True
        Me.LabelCantBotella.Location = New System.Drawing.Point(337, 433)
        Me.LabelCantBotella.Name = "LabelCantBotella"
        Me.LabelCantBotella.Size = New System.Drawing.Size(14, 16)
        Me.LabelCantBotella.TabIndex = 15
        Me.LabelCantBotella.Text = "0"
        '
        'LabelBebidaMasAlcohol
        '
        Me.LabelBebidaMasAlcohol.AutoSize = True
        Me.LabelBebidaMasAlcohol.Location = New System.Drawing.Point(330, 487)
        Me.LabelBebidaMasAlcohol.Name = "LabelBebidaMasAlcohol"
        Me.LabelBebidaMasAlcohol.Size = New System.Drawing.Size(14, 16)
        Me.LabelBebidaMasAlcohol.TabIndex = 16
        Me.LabelBebidaMasAlcohol.Text = "0"
        '
        'LabelMarcaAlma
        '
        Me.LabelMarcaAlma.AutoSize = True
        Me.LabelMarcaAlma.Location = New System.Drawing.Point(330, 550)
        Me.LabelMarcaAlma.Name = "LabelMarcaAlma"
        Me.LabelMarcaAlma.Size = New System.Drawing.Size(14, 16)
        Me.LabelMarcaAlma.TabIndex = 17
        Me.LabelMarcaAlma.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 720)
        Me.Controls.Add(Me.LabelMarcaAlma)
        Me.Controls.Add(Me.LabelBebidaMasAlcohol)
        Me.Controls.Add(Me.LabelCantBotella)
        Me.Controls.Add(Me.ComboBoxEnvase)
        Me.Controls.Add(Me.TextBoxAlcohol)
        Me.Controls.Add(Me.TextBoxCapacidad)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxCapacidad As TextBox
    Friend WithEvents TextBoxAlcohol As TextBox
    Friend WithEvents ComboBoxEnvase As ComboBox
    Friend WithEvents LabelCantBotella As Label
    Friend WithEvents LabelBebidaMasAlcohol As Label
    Friend WithEvents LabelMarcaAlma As Label
End Class
