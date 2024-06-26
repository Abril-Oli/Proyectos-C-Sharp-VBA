<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlta
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
        Me.GroupBoxIngresoAlta = New System.Windows.Forms.GroupBox()
        Me.LabelNombreAlta = New System.Windows.Forms.Label()
        Me.LabelAltaPeso = New System.Windows.Forms.Label()
        Me.LabelEdadAlta = New System.Windows.Forms.Label()
        Me.LabelClienteAlta = New System.Windows.Forms.Label()
        Me.LabelEspecieAlta = New System.Windows.Forms.Label()
        Me.TxtNombreAlta = New System.Windows.Forms.TextBox()
        Me.TxtPesoAlta = New System.Windows.Forms.TextBox()
        Me.TxtEdadAlta = New System.Windows.Forms.TextBox()
        Me.TxtClienteAlta = New System.Windows.Forms.TextBox()
        Me.TxtEspecieAlta = New System.Windows.Forms.TextBox()
        Me.GroupBoxIngresoAlta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta"
        '
        'GroupBoxIngresoAlta
        '
        Me.GroupBoxIngresoAlta.Controls.Add(Me.TxtEspecieAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.TxtClienteAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.TxtEdadAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.TxtPesoAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.TxtNombreAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.LabelEspecieAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.LabelClienteAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.LabelEdadAlta)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.LabelAltaPeso)
        Me.GroupBoxIngresoAlta.Controls.Add(Me.LabelNombreAlta)
        Me.GroupBoxIngresoAlta.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GroupBoxIngresoAlta.Location = New System.Drawing.Point(12, 113)
        Me.GroupBoxIngresoAlta.Name = "GroupBoxIngresoAlta"
        Me.GroupBoxIngresoAlta.Size = New System.Drawing.Size(593, 599)
        Me.GroupBoxIngresoAlta.TabIndex = 1
        Me.GroupBoxIngresoAlta.TabStop = False
        Me.GroupBoxIngresoAlta.Text = "Ingreso"
        '
        'LabelNombreAlta
        '
        Me.LabelNombreAlta.AutoSize = True
        Me.LabelNombreAlta.Location = New System.Drawing.Point(30, 57)
        Me.LabelNombreAlta.Name = "LabelNombreAlta"
        Me.LabelNombreAlta.Size = New System.Drawing.Size(113, 29)
        Me.LabelNombreAlta.TabIndex = 0
        Me.LabelNombreAlta.Text = "Nombre"
        '
        'LabelAltaPeso
        '
        Me.LabelAltaPeso.AutoSize = True
        Me.LabelAltaPeso.Location = New System.Drawing.Point(26, 174)
        Me.LabelAltaPeso.Name = "LabelAltaPeso"
        Me.LabelAltaPeso.Size = New System.Drawing.Size(70, 29)
        Me.LabelAltaPeso.TabIndex = 1
        Me.LabelAltaPeso.Text = "Peso"
        '
        'LabelEdadAlta
        '
        Me.LabelEdadAlta.AutoSize = True
        Me.LabelEdadAlta.Location = New System.Drawing.Point(30, 291)
        Me.LabelEdadAlta.Name = "LabelEdadAlta"
        Me.LabelEdadAlta.Size = New System.Drawing.Size(79, 29)
        Me.LabelEdadAlta.TabIndex = 2
        Me.LabelEdadAlta.Text = "Edad"
        '
        'LabelClienteAlta
        '
        Me.LabelClienteAlta.AutoSize = True
        Me.LabelClienteAlta.Location = New System.Drawing.Point(30, 412)
        Me.LabelClienteAlta.Name = "LabelClienteAlta"
        Me.LabelClienteAlta.Size = New System.Drawing.Size(99, 29)
        Me.LabelClienteAlta.TabIndex = 3
        Me.LabelClienteAlta.Text = "Cliente"
        '
        'LabelEspecieAlta
        '
        Me.LabelEspecieAlta.AutoSize = True
        Me.LabelEspecieAlta.Location = New System.Drawing.Point(30, 517)
        Me.LabelEspecieAlta.Name = "LabelEspecieAlta"
        Me.LabelEspecieAlta.Size = New System.Drawing.Size(106, 29)
        Me.LabelEspecieAlta.TabIndex = 4
        Me.LabelEspecieAlta.Text = "Especie"
        '
        'TxtNombreAlta
        '
        Me.TxtNombreAlta.Location = New System.Drawing.Point(30, 103)
        Me.TxtNombreAlta.Name = "TxtNombreAlta"
        Me.TxtNombreAlta.Size = New System.Drawing.Size(274, 40)
        Me.TxtNombreAlta.TabIndex = 5
        '
        'TxtPesoAlta
        '
        Me.TxtPesoAlta.Location = New System.Drawing.Point(30, 224)
        Me.TxtPesoAlta.Name = "TxtPesoAlta"
        Me.TxtPesoAlta.Size = New System.Drawing.Size(274, 40)
        Me.TxtPesoAlta.TabIndex = 6
        '
        'TxtEdadAlta
        '
        Me.TxtEdadAlta.Location = New System.Drawing.Point(30, 338)
        Me.TxtEdadAlta.Name = "TxtEdadAlta"
        Me.TxtEdadAlta.Size = New System.Drawing.Size(274, 40)
        Me.TxtEdadAlta.TabIndex = 7
        '
        'TxtClienteAlta
        '
        Me.TxtClienteAlta.Location = New System.Drawing.Point(30, 457)
        Me.TxtClienteAlta.Name = "TxtClienteAlta"
        Me.TxtClienteAlta.Size = New System.Drawing.Size(274, 40)
        Me.TxtClienteAlta.TabIndex = 8
        '
        'TxtEspecieAlta
        '
        Me.TxtEspecieAlta.Location = New System.Drawing.Point(30, 561)
        Me.TxtEspecieAlta.Name = "TxtEspecieAlta"
        Me.TxtEspecieAlta.Size = New System.Drawing.Size(274, 40)
        Me.TxtEspecieAlta.TabIndex = 9
        '
        'FormAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 736)
        Me.Controls.Add(Me.GroupBoxIngresoAlta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAlta"
        Me.Text = "FormAlta"
        Me.GroupBoxIngresoAlta.ResumeLayout(False)
        Me.GroupBoxIngresoAlta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxIngresoAlta As GroupBox
    Friend WithEvents LabelNombreAlta As Label
    Friend WithEvents TxtEspecieAlta As TextBox
    Friend WithEvents TxtClienteAlta As TextBox
    Friend WithEvents TxtEdadAlta As TextBox
    Friend WithEvents TxtPesoAlta As TextBox
    Friend WithEvents TxtNombreAlta As TextBox
    Friend WithEvents LabelEspecieAlta As Label
    Friend WithEvents LabelClienteAlta As Label
    Friend WithEvents LabelEdadAlta As Label
    Friend WithEvents LabelAltaPeso As Label
End Class
