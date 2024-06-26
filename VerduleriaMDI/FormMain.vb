Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormMain

    Private ventanaNueva As VentanaNueva

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaestrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestrosToolStripMenuItem.Click
        ' creamos obj de tipo formulario alta'
        Dim formu As New FormularioAlta

        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformesToolStripMenuItem.Click
        Dim formu As New FormularioListado
        formu.MdiParent = Me
        'enumerable, clase con datos con maximizado de wstate'
        formu.WindowState = 2
        formu.Show()
    End Sub

    Private Sub VerVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVentanaToolStripMenuItem.Click
        If ventanaNueva Is Nothing Then
            ventanaNueva = New VentanaNueva
            ventanaNueva.MdiParent = Me
        End If

        ventanaNueva.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'vector sin hardcodear contrasenas'
        Dim password = ConfigurationManager.AppSettings("password")

        Dim mensaje = $"password incorrecta, ingrese '{password}'"

        If TextBox1.Text = password Then
            '   MenuStrip1.Visible = True
            '  Panel1.Visible = False
            '  Dim pantallaCarga As New PantallaCarga
            '  PantallaCarga.Show()
            TimerCarga.Enabled = True
            mensaje = "loading..."

        End If
        LblInfo.Visible = True
        LblInfo.Text = mensaje
    End Sub

    Private Sub TimerCarga_Tick(sender As Object, e As EventArgs) Handles TimerCarga.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Panel1.Hide()
        Else
            Dim nuevoValor = ProgressBar1.Value + 10
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
        End If

    End Sub

    Private Sub CambiarFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFondoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()

        Dim rutaArchivo = OpenFileDialog1.FileName
        MessageBox.Show(rutaArchivo)

        Dim imagenBackground = Image.FromFile(rutaArchivo)
        Me.BackgroundImage = imagenBackground
        'Atributo para no repetir mosaico'
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class
