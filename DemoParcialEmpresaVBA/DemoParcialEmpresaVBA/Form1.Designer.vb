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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCargar = New System.Windows.Forms.Button()
        Me.ComboBoxPlan = New System.Windows.Forms.ComboBox()
        Me.TextBoxEdad = New System.Windows.Forms.TextBox()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPlanPro = New System.Windows.Forms.Label()
        Me.LabelPlanBasic = New System.Windows.Forms.Label()
        Me.LabelPlanLite = New System.Windows.Forms.Label()
        Me.LabelClienteViejo = New System.Windows.Forms.Label()
        Me.LabelClienteJoven = New System.Windows.Forms.Label()
        Me.LabelClientesBsAs = New System.Windows.Forms.Label()
        Me.LabelPromEdadClientes = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 37.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIRANDA INC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCargar)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPlan)
        Me.GroupBox1.Controls.Add(Me.TextBoxEdad)
        Me.GroupBox1.Controls.Add(Me.TextBoxLocalidad)
        Me.GroupBox1.Controls.Add(Me.TextBoxApellido)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 369)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Clientes"
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Location = New System.Drawing.Point(655, 145)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(120, 89)
        Me.ButtonCargar.TabIndex = 10
        Me.ButtonCargar.Text = "Cargar"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'ComboBoxPlan
        '
        Me.ComboBoxPlan.FormattingEnabled = True
        Me.ComboBoxPlan.Items.AddRange(New Object() {"Lite", "Basic", "Pro"})
        Me.ComboBoxPlan.Location = New System.Drawing.Point(13, 330)
        Me.ComboBoxPlan.Name = "ComboBoxPlan"
        Me.ComboBoxPlan.Size = New System.Drawing.Size(617, 33)
        Me.ComboBoxPlan.TabIndex = 6
        Me.ComboBoxPlan.Text = "Lite"
        '
        'TextBoxEdad
        '
        Me.TextBoxEdad.Location = New System.Drawing.Point(13, 269)
        Me.TextBoxEdad.Name = "TextBoxEdad"
        Me.TextBoxEdad.Size = New System.Drawing.Size(616, 30)
        Me.TextBoxEdad.TabIndex = 9
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(14, 205)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(616, 30)
        Me.TextBoxLocalidad.TabIndex = 8
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(20, 151)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(616, 30)
        Me.TextBoxApellido.TabIndex = 7
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(20, 79)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(616, 30)
        Me.TextBoxNombre.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Plan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Localidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(808, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(758, 793)
        Me.DataGridView1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPlanPro)
        Me.GroupBox2.Controls.Add(Me.LabelPlanBasic)
        Me.GroupBox2.Controls.Add(Me.LabelPlanLite)
        Me.GroupBox2.Controls.Add(Me.LabelClienteViejo)
        Me.GroupBox2.Controls.Add(Me.LabelClienteJoven)
        Me.GroupBox2.Controls.Add(Me.LabelClientesBsAs)
        Me.GroupBox2.Controls.Add(Me.LabelPromEdadClientes)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(3, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 326)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadisticas Clientes Miranda inc"
        '
        'LabelPlanPro
        '
        Me.LabelPlanPro.AutoSize = True
        Me.LabelPlanPro.Location = New System.Drawing.Point(544, 278)
        Me.LabelPlanPro.Name = "LabelPlanPro"
        Me.LabelPlanPro.Size = New System.Drawing.Size(29, 31)
        Me.LabelPlanPro.TabIndex = 11
        Me.LabelPlanPro.Text = "0"
        '
        'LabelPlanBasic
        '
        Me.LabelPlanBasic.AutoSize = True
        Me.LabelPlanBasic.Location = New System.Drawing.Point(456, 278)
        Me.LabelPlanBasic.Name = "LabelPlanBasic"
        Me.LabelPlanBasic.Size = New System.Drawing.Size(23, 25)
        Me.LabelPlanBasic.TabIndex = 10
        Me.LabelPlanBasic.Text = "0"
        '
        'LabelPlanLite
        '
        Me.LabelPlanLite.AutoSize = True
        Me.LabelPlanLite.Location = New System.Drawing.Point(353, 278)
        Me.LabelPlanLite.Name = "LabelPlanLite"
        Me.LabelPlanLite.Size = New System.Drawing.Size(23, 25)
        Me.LabelPlanLite.TabIndex = 9
        Me.LabelPlanLite.Text = "0"
        '
        'LabelClienteViejo
        '
        Me.LabelClienteViejo.AutoSize = True
        Me.LabelClienteViejo.Location = New System.Drawing.Point(485, 213)
        Me.LabelClienteViejo.Name = "LabelClienteViejo"
        Me.LabelClienteViejo.Size = New System.Drawing.Size(23, 25)
        Me.LabelClienteViejo.TabIndex = 8
        Me.LabelClienteViejo.Text = "0"
        '
        'LabelClienteJoven
        '
        Me.LabelClienteJoven.AutoSize = True
        Me.LabelClienteJoven.Location = New System.Drawing.Point(485, 149)
        Me.LabelClienteJoven.Name = "LabelClienteJoven"
        Me.LabelClienteJoven.Size = New System.Drawing.Size(23, 25)
        Me.LabelClienteJoven.TabIndex = 7
        Me.LabelClienteJoven.Text = "0"
        '
        'LabelClientesBsAs
        '
        Me.LabelClientesBsAs.AutoSize = True
        Me.LabelClientesBsAs.Location = New System.Drawing.Point(485, 92)
        Me.LabelClientesBsAs.Name = "LabelClientesBsAs"
        Me.LabelClientesBsAs.Size = New System.Drawing.Size(23, 25)
        Me.LabelClientesBsAs.TabIndex = 6
        Me.LabelClientesBsAs.Text = "0"
        '
        'LabelPromEdadClientes
        '
        Me.LabelPromEdadClientes.AutoSize = True
        Me.LabelPromEdadClientes.Location = New System.Drawing.Point(485, 44)
        Me.LabelPromEdadClientes.Name = "LabelPromEdadClientes"
        Me.LabelPromEdadClientes.Size = New System.Drawing.Size(23, 25)
        Me.LabelPromEdadClientes.TabIndex = 5
        Me.LabelPromEdadClientes.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(275, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cantidad de Usuarios por plan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Cliente mas viejo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cliente mas joven"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Clientes en BSAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Promedio edad Clientes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 811)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelPlanLite As Label
    Friend WithEvents LabelClienteViejo As Label
    Friend WithEvents LabelClienteJoven As Label
    Friend WithEvents LabelClientesBsAs As Label
    Friend WithEvents LabelPromEdadClientes As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents LabelPlanPro As Label
    Friend WithEvents LabelPlanBasic As Label
    Friend WithEvents ButtonCargar As Button
    Public WithEvents ComboBoxPlan As ComboBox
End Class
