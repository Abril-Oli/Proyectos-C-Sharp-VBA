<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.T_login = New System.Windows.Forms.Timer(Me.components)
        Me.P_login = New System.Windows.Forms.Panel()
        Me.LBL_cargaBarra = New System.Windows.Forms.Label()
        Me.PB_barraLogin = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Txt_claveLogin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_nombreLogin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MS_menuABM = New System.Windows.Forms.MenuStrip()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReactivarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccionesClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReactivarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeAnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeAnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeEspecieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteSecundarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxIconoVete = New System.Windows.Forms.PictureBox()
        Me.LBL_nombreUsuario = New System.Windows.Forms.Label()
        Me.Btn_salirApp = New System.Windows.Forms.Button()
        Me.GroupBoxCaratula = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTituloVete = New System.Windows.Forms.Label()
        Me.P_login.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MS_menuABM.SuspendLayout()
        CType(Me.PictureBoxIconoVete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCaratula.SuspendLayout()
        Me.SuspendLayout()
        '
        'T_login
        '
        '
        'P_login
        '
        Me.P_login.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.P_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.P_login.Controls.Add(Me.LBL_cargaBarra)
        Me.P_login.Controls.Add(Me.PB_barraLogin)
        Me.P_login.Controls.Add(Me.GroupBox2)
        Me.P_login.Location = New System.Drawing.Point(420, 244)
        Me.P_login.Margin = New System.Windows.Forms.Padding(4)
        Me.P_login.MaximumSize = New System.Drawing.Size(683, 353)
        Me.P_login.MinimumSize = New System.Drawing.Size(683, 353)
        Me.P_login.Name = "P_login"
        Me.P_login.Size = New System.Drawing.Size(683, 353)
        Me.P_login.TabIndex = 7
        '
        'LBL_cargaBarra
        '
        Me.LBL_cargaBarra.AutoSize = True
        Me.LBL_cargaBarra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_cargaBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LBL_cargaBarra.Location = New System.Drawing.Point(28, 254)
        Me.LBL_cargaBarra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_cargaBarra.Name = "LBL_cargaBarra"
        Me.LBL_cargaBarra.Size = New System.Drawing.Size(0, 23)
        Me.LBL_cargaBarra.TabIndex = 9
        '
        'PB_barraLogin
        '
        Me.PB_barraLogin.Location = New System.Drawing.Point(21, 290)
        Me.PB_barraLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_barraLogin.Name = "PB_barraLogin"
        Me.PB_barraLogin.Size = New System.Drawing.Size(645, 49)
        Me.PB_barraLogin.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Login)
        Me.GroupBox2.Controls.Add(Me.Txt_claveLogin)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Txt_nombreLogin)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 27)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(645, 206)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_Login.Location = New System.Drawing.Point(204, 137)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(227, 58)
        Me.Btn_Login.TabIndex = 4
        Me.Btn_Login.Text = "I N G R E S A R"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Txt_claveLogin
        '
        Me.Txt_claveLogin.Location = New System.Drawing.Point(167, 91)
        Me.Txt_claveLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_claveLogin.Name = "Txt_claveLogin"
        Me.Txt_claveLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_claveLogin.Size = New System.Drawing.Size(405, 37)
        Me.Txt_claveLogin.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 28)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Clave"
        '
        'Txt_nombreLogin
        '
        Me.Txt_nombreLogin.Location = New System.Drawing.Point(167, 46)
        Me.Txt_nombreLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_nombreLogin.Name = "Txt_nombreLogin"
        Me.Txt_nombreLogin.Size = New System.Drawing.Size(405, 37)
        Me.Txt_nombreLogin.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'MS_menuABM
        '
        Me.MS_menuABM.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.MS_menuABM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MS_menuABM.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MS_menuABM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.BajasToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MS_menuABM.Location = New System.Drawing.Point(0, 0)
        Me.MS_menuABM.Name = "MS_menuABM"
        Me.MS_menuABM.Size = New System.Drawing.Size(1532, 36)
        Me.MS_menuABM.TabIndex = 8
        Me.MS_menuABM.Text = "MenuStrip1"
        Me.MS_menuABM.Visible = False
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuarioToolStripMenuItem, Me.BajaDeUsuarioToolStripMenuItem, Me.AToolStripMenuItem, Me.ReactivarUsuarioToolStripMenuItem})
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(101, 32)
        Me.AltasToolStripMenuItem.Text = "Usuarios"
        '
        'AltaDeUsuarioToolStripMenuItem
        '
        Me.AltaDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AltaDeUsuarioToolStripMenuItem.Name = "AltaDeUsuarioToolStripMenuItem"
        Me.AltaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(264, 28)
        Me.AltaDeUsuarioToolStripMenuItem.Text = "Alta de usuario"
        '
        'BajaDeUsuarioToolStripMenuItem
        '
        Me.BajaDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BajaDeUsuarioToolStripMenuItem.Name = "BajaDeUsuarioToolStripMenuItem"
        Me.BajaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(264, 28)
        Me.BajaDeUsuarioToolStripMenuItem.Text = "Baja de usuario"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(264, 28)
        Me.AToolStripMenuItem.Text = "Acciones"
        '
        'ReactivarUsuarioToolStripMenuItem
        '
        Me.ReactivarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ReactivarUsuarioToolStripMenuItem.Name = "ReactivarUsuarioToolStripMenuItem"
        Me.ReactivarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(264, 28)
        Me.ReactivarUsuarioToolStripMenuItem.Text = "Reactivar Usuario"
        '
        'BajasToolStripMenuItem
        '
        Me.BajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeClienteToolStripMenuItem, Me.BajaDeClienteToolStripMenuItem, Me.AccionesClientesToolStripMenuItem, Me.ReactivarClienteToolStripMenuItem})
        Me.BajasToolStripMenuItem.Name = "BajasToolStripMenuItem"
        Me.BajasToolStripMenuItem.Size = New System.Drawing.Size(101, 32)
        Me.BajasToolStripMenuItem.Text = "Clientes"
        '
        'AltaDeClienteToolStripMenuItem
        '
        Me.AltaDeClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AltaDeClienteToolStripMenuItem.Name = "AltaDeClienteToolStripMenuItem"
        Me.AltaDeClienteToolStripMenuItem.Size = New System.Drawing.Size(261, 28)
        Me.AltaDeClienteToolStripMenuItem.Text = "Alta de cliente"
        '
        'BajaDeClienteToolStripMenuItem
        '
        Me.BajaDeClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BajaDeClienteToolStripMenuItem.Name = "BajaDeClienteToolStripMenuItem"
        Me.BajaDeClienteToolStripMenuItem.Size = New System.Drawing.Size(261, 28)
        Me.BajaDeClienteToolStripMenuItem.Text = "Baja de cliente"
        '
        'AccionesClientesToolStripMenuItem
        '
        Me.AccionesClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AccionesClientesToolStripMenuItem.Name = "AccionesClientesToolStripMenuItem"
        Me.AccionesClientesToolStripMenuItem.Size = New System.Drawing.Size(261, 28)
        Me.AccionesClientesToolStripMenuItem.Text = "Acciones"
        '
        'ReactivarClienteToolStripMenuItem
        '
        Me.ReactivarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ReactivarClienteToolStripMenuItem.Name = "ReactivarClienteToolStripMenuItem"
        Me.ReactivarClienteToolStripMenuItem.Size = New System.Drawing.Size(261, 28)
        Me.ReactivarClienteToolStripMenuItem.Text = "Reactivar cliente"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeAnimalToolStripMenuItem, Me.BajaDeAnimalToolStripMenuItem, Me.AccionesToolStripMenuItem1})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(113, 32)
        Me.BusquedaToolStripMenuItem.Text = "Animales"
        '
        'AltaDeAnimalToolStripMenuItem
        '
        Me.AltaDeAnimalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AltaDeAnimalToolStripMenuItem.Name = "AltaDeAnimalToolStripMenuItem"
        Me.AltaDeAnimalToolStripMenuItem.Size = New System.Drawing.Size(242, 28)
        Me.AltaDeAnimalToolStripMenuItem.Text = "Alta de animal"
        '
        'BajaDeAnimalToolStripMenuItem
        '
        Me.BajaDeAnimalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BajaDeAnimalToolStripMenuItem.Name = "BajaDeAnimalToolStripMenuItem"
        Me.BajaDeAnimalToolStripMenuItem.Size = New System.Drawing.Size(242, 28)
        Me.BajaDeAnimalToolStripMenuItem.Text = "Baja de animal"
        '
        'AccionesToolStripMenuItem1
        '
        Me.AccionesToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AccionesToolStripMenuItem1.Name = "AccionesToolStripMenuItem1"
        Me.AccionesToolStripMenuItem1.Size = New System.Drawing.Size(242, 28)
        Me.AccionesToolStripMenuItem1.Text = "Acciones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeEspecieToolStripMenuItem, Me.AccionesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(107, 32)
        Me.ReportesToolStripMenuItem.Text = "Especies"
        '
        'AltaDeEspecieToolStripMenuItem
        '
        Me.AltaDeEspecieToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AltaDeEspecieToolStripMenuItem.Name = "AltaDeEspecieToolStripMenuItem"
        Me.AltaDeEspecieToolStripMenuItem.Size = New System.Drawing.Size(249, 28)
        Me.AltaDeEspecieToolStripMenuItem.Text = "Alta de Especie"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(249, 28)
        Me.AccionesToolStripMenuItem.Text = "Acciones"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportePrincipalToolStripMenuItem, Me.ReporteSecundarioToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(106, 32)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ReportePrincipalToolStripMenuItem
        '
        Me.ReportePrincipalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ReportePrincipalToolStripMenuItem.Name = "ReportePrincipalToolStripMenuItem"
        Me.ReportePrincipalToolStripMenuItem.Size = New System.Drawing.Size(286, 28)
        Me.ReportePrincipalToolStripMenuItem.Text = "Reporte principal"
        '
        'ReporteSecundarioToolStripMenuItem
        '
        Me.ReporteSecundarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ReporteSecundarioToolStripMenuItem.Name = "ReporteSecundarioToolStripMenuItem"
        Me.ReporteSecundarioToolStripMenuItem.Size = New System.Drawing.Size(286, 28)
        Me.ReporteSecundarioToolStripMenuItem.Text = "Reporte secundario"
        '
        'PictureBoxIconoVete
        '
        Me.PictureBoxIconoVete.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.PictureBoxIconoVete.BackgroundImage = Global.VeterinariaCleint.My.Resources.Resources.patitas
        Me.PictureBoxIconoVete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxIconoVete.Location = New System.Drawing.Point(20, 34)
        Me.PictureBoxIconoVete.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxIconoVete.MaximumSize = New System.Drawing.Size(179, 155)
        Me.PictureBoxIconoVete.MinimumSize = New System.Drawing.Size(179, 155)
        Me.PictureBoxIconoVete.Name = "PictureBoxIconoVete"
        Me.PictureBoxIconoVete.Size = New System.Drawing.Size(179, 155)
        Me.PictureBoxIconoVete.TabIndex = 10
        Me.PictureBoxIconoVete.TabStop = False
        '
        'LBL_nombreUsuario
        '
        Me.LBL_nombreUsuario.AutoSize = True
        Me.LBL_nombreUsuario.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LBL_nombreUsuario.Location = New System.Drawing.Point(617, 74)
        Me.LBL_nombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_nombreUsuario.Name = "LBL_nombreUsuario"
        Me.LBL_nombreUsuario.Size = New System.Drawing.Size(0, 80)
        Me.LBL_nombreUsuario.TabIndex = 11
        Me.LBL_nombreUsuario.Visible = False
        '
        'Btn_salirApp
        '
        Me.Btn_salirApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_salirApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_salirApp.FlatAppearance.BorderSize = 0
        Me.Btn_salirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_salirApp.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_salirApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_salirApp.Location = New System.Drawing.Point(1299, 658)
        Me.Btn_salirApp.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_salirApp.Name = "Btn_salirApp"
        Me.Btn_salirApp.Size = New System.Drawing.Size(217, 69)
        Me.Btn_salirApp.TabIndex = 12
        Me.Btn_salirApp.Text = "S A L I R"
        Me.Btn_salirApp.UseVisualStyleBackColor = False
        Me.Btn_salirApp.Visible = False
        '
        'GroupBoxCaratula
        '
        Me.GroupBoxCaratula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCaratula.Controls.Add(Me.Label12)
        Me.GroupBoxCaratula.Controls.Add(Me.Label11)
        Me.GroupBoxCaratula.Controls.Add(Me.Label8)
        Me.GroupBoxCaratula.Controls.Add(Me.Label7)
        Me.GroupBoxCaratula.Controls.Add(Me.Label6)
        Me.GroupBoxCaratula.Controls.Add(Me.Label5)
        Me.GroupBoxCaratula.Controls.Add(Me.Label4)
        Me.GroupBoxCaratula.Controls.Add(Me.Label3)
        Me.GroupBoxCaratula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCaratula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBoxCaratula.Location = New System.Drawing.Point(16, 604)
        Me.GroupBoxCaratula.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCaratula.Name = "GroupBoxCaratula"
        Me.GroupBoxCaratula.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCaratula.Size = New System.Drawing.Size(584, 123)
        Me.GroupBoxCaratula.TabIndex = 13
        Me.GroupBoxCaratula.TabStop = False
        Me.GroupBoxCaratula.Text = "ABM Veterinaria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(396, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 21)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Programacion III"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 55)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Materia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Integrantes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(396, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Niglio, Gabriel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Profesor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sio Cordich, Matias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Olivera, Abril"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buggenthin, Nicolas"
        '
        'LblTituloVete
        '
        Me.LblTituloVete.AutoSize = True
        Me.LblTituloVete.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LblTituloVete.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloVete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LblTituloVete.Location = New System.Drawing.Point(207, 34)
        Me.LblTituloVete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTituloVete.Name = "LblTituloVete"
        Me.LblTituloVete.Size = New System.Drawing.Size(638, 80)
        Me.LblTituloVete.TabIndex = 15
        Me.LblTituloVete.Text = " Patitas Veterinaria"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BackgroundImage = Global.VeterinariaCleint.My.Resources.Resources.veteW
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1532, 742)
        Me.Controls.Add(Me.GroupBoxCaratula)
        Me.Controls.Add(Me.Btn_salirApp)
        Me.Controls.Add(Me.LBL_nombreUsuario)
        Me.Controls.Add(Me.PictureBoxIconoVete)
        Me.Controls.Add(Me.P_login)
        Me.Controls.Add(Me.MS_menuABM)
        Me.Controls.Add(Me.LblTituloVete)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1551, 783)
        Me.Name = "FormularioPrincipal"
        Me.Text = "ABM Veterinaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_login.ResumeLayout(False)
        Me.P_login.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MS_menuABM.ResumeLayout(False)
        Me.MS_menuABM.PerformLayout()
        CType(Me.PictureBoxIconoVete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCaratula.ResumeLayout(False)
        Me.GroupBoxCaratula.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_login As Timer
    Friend WithEvents P_login As Panel
    Friend WithEvents LBL_cargaBarra As Label
    Friend WithEvents PB_barraLogin As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Txt_claveLogin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_nombreLogin As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MS_menuABM As MenuStrip
    Friend WithEvents AltasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxIconoVete As PictureBox
    Friend WithEvents LBL_nombreUsuario As Label
    Friend WithEvents Btn_salirApp As Button
    Friend WithEvents GroupBoxCaratula As GroupBox
    Friend WithEvents LblTituloVete As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BajaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReactivarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeEspecieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReactivarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeAnimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeAnimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportePrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteSecundarioToolStripMenuItem As ToolStripMenuItem
End Class
