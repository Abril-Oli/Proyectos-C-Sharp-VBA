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
        Me.LabelEmpresa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxLitros = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLtTotalRoja = New System.Windows.Forms.Label()
        Me.LabelPromLtsAzul = New System.Windows.Forms.Label()
        Me.ButtonCargar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(582, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(600, 560)
        Me.DataGridView1.TabIndex = 0
        '
        'LabelEmpresa
        '
        Me.LabelEmpresa.AutoSize = True
        Me.LabelEmpresa.BackColor = System.Drawing.Color.Tan
        Me.LabelEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.LabelEmpresa.Location = New System.Drawing.Point(12, 9)
        Me.LabelEmpresa.Name = "LabelEmpresa"
        Me.LabelEmpresa.Size = New System.Drawing.Size(313, 54)
        Me.LabelEmpresa.TabIndex = 1
        Me.LabelEmpresa.Text = "Pigmento INC"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxLitros)
        Me.GroupBox1.Controls.Add(Me.TextBoxColor)
        Me.GroupBox1.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 217)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Litros"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(0, 56)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(411, 26)
        Me.TextBoxCodigo.TabIndex = 3
        '
        'TextBoxColor
        '
        Me.TextBoxColor.Location = New System.Drawing.Point(0, 116)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(411, 26)
        Me.TextBoxColor.TabIndex = 6
        '
        'TextBoxLitros
        '
        Me.TextBoxLitros.Location = New System.Drawing.Point(0, 189)
        Me.TextBoxLitros.Name = "TextBoxLitros"
        Me.TextBoxLitros.Size = New System.Drawing.Size(411, 26)
        Me.TextBoxLitros.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPromLtsAzul)
        Me.GroupBox2.Controls.Add(Me.LabelLtTotalRoja)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 198)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTADISTICAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total LTS Pintura Roja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Promedio LTS pintura Azul"
        '
        'LabelLtTotalRoja
        '
        Me.LabelLtTotalRoja.AutoSize = True
        Me.LabelLtTotalRoja.Location = New System.Drawing.Point(381, 36)
        Me.LabelLtTotalRoja.Name = "LabelLtTotalRoja"
        Me.LabelLtTotalRoja.Size = New System.Drawing.Size(18, 20)
        Me.LabelLtTotalRoja.TabIndex = 6
        Me.LabelLtTotalRoja.Text = "0"
        '
        'LabelPromLtsAzul
        '
        Me.LabelPromLtsAzul.AutoSize = True
        Me.LabelPromLtsAzul.Location = New System.Drawing.Point(372, 126)
        Me.LabelPromLtsAzul.Name = "LabelPromLtsAzul"
        Me.LabelPromLtsAzul.Size = New System.Drawing.Size(18, 20)
        Me.LabelPromLtsAzul.TabIndex = 7
        Me.LabelPromLtsAzul.Text = "0"
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Location = New System.Drawing.Point(145, 302)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(102, 66)
        Me.ButtonCargar.TabIndex = 4
        Me.ButtonCargar.Text = "Cargar"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 608)
        Me.Controls.Add(Me.ButtonCargar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelEmpresa)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelEmpresa As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxLitros As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelPromLtsAzul As Label
    Friend WithEvents LabelLtTotalRoja As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonCargar As Button
End Class
