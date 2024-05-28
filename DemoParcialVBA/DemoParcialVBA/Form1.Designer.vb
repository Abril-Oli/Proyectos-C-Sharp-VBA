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
        Me.TextBoxProd = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelTotalProd = New System.Windows.Forms.Label()
        Me.LabelTotProP = New System.Windows.Forms.Label()
        Me.LabelPromedio = New System.Windows.Forms.Label()
        Me.LabelPromedioP = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(458, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(330, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRECIO"
        '
        'TextBoxProd
        '
        Me.TextBoxProd.Location = New System.Drawing.Point(28, 55)
        Me.TextBoxProd.Name = "TextBoxProd"
        Me.TextBoxProd.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxProd.TabIndex = 3
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(28, 142)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxPrecio.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Suma total Productos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Productos P"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Promedio Productos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Promedio Productos P"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(157, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelTotalProd
        '
        Me.LabelTotalProd.AutoSize = True
        Me.LabelTotalProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelTotalProd.Location = New System.Drawing.Point(321, 247)
        Me.LabelTotalProd.Name = "LabelTotalProd"
        Me.LabelTotalProd.Size = New System.Drawing.Size(20, 24)
        Me.LabelTotalProd.TabIndex = 13
        Me.LabelTotalProd.Text = "0"
        '
        'LabelTotProP
        '
        Me.LabelTotProP.AutoSize = True
        Me.LabelTotProP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelTotProP.Location = New System.Drawing.Point(321, 294)
        Me.LabelTotProP.Name = "LabelTotProP"
        Me.LabelTotProP.Size = New System.Drawing.Size(20, 24)
        Me.LabelTotProP.TabIndex = 14
        Me.LabelTotProP.Text = "0"
        '
        'LabelPromedio
        '
        Me.LabelPromedio.AutoSize = True
        Me.LabelPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelPromedio.Location = New System.Drawing.Point(321, 359)
        Me.LabelPromedio.Name = "LabelPromedio"
        Me.LabelPromedio.Size = New System.Drawing.Size(0, 24)
        Me.LabelPromedio.TabIndex = 15
        '
        'LabelPromedioP
        '
        Me.LabelPromedioP.AutoSize = True
        Me.LabelPromedioP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelPromedioP.Location = New System.Drawing.Point(321, 408)
        Me.LabelPromedioP.Name = "LabelPromedioP"
        Me.LabelPromedioP.Size = New System.Drawing.Size(20, 24)
        Me.LabelPromedioP.TabIndex = 16
        Me.LabelPromedioP.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelPromedioP)
        Me.Controls.Add(Me.LabelPromedio)
        Me.Controls.Add(Me.LabelTotProP)
        Me.Controls.Add(Me.LabelTotalProd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxProd)
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
    Friend WithEvents TextBoxProd As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelTotalProd As Label
    Friend WithEvents LabelTotProP As Label
    Friend WithEvents LabelPromedio As Label
    Friend WithEvents LabelPromedioP As Label
End Class
