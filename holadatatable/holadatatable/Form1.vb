Public Class Form1

#Region "Dependencias"
    Private dtPersonas As DataTable
#End Region

#Region "Acciones"

    Private Sub SetDtPersonas(dt As DataTable)
        Me.dtPersonas = dt
        DataGridView1.DataSource = dt
    End Sub

    Private Sub RecargarPromedio()

        Dim acumuladorN As Double = 0
        Dim contadorN = 0
        Dim acumulador As Double = 0
        For Each renglon As DataRow In Me.dtPersonas.Rows

            acumulador += renglon("Edad")


            Dim nombre As String = renglon("Nombre")


            If nombre.ToUpper().StartsWith("N") Then
                acumuladorN += renglon("Edad")
                contadorN += 1
            End If



        Next

        Dim promedio = acumulador / Me.dtPersonas.Rows.Count
        Dim promedioN = acumuladorN / contadorN

        Label1.Text = promedio.ToString("#.00")

        If contadorN > 0 Then
            Label2.Text = promedioN.ToString("#0.00")
        Else
            Label2.Text = "0.00"
        End If



    End Sub


    Private Sub InicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Edad")




        'DataGridView1.DataSource = dt
        Me.SetDtPersonas(dt)
    End Sub

#End Region

#Region "Eventos"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim numero = 1
        'DataTable dt = (DataTable) DataGridView1.DataSource;
        'Dim dt As DataTable = DataGridView1.DataSource

        Dim nombre = TextBox1.Text
        Dim apellido = TextBox2.Text



        Dim edad = Integer.Parse(TextBox3.Text)

        Me.dtPersonas.Rows.Add(nombre, apellido, edad)

        Me.RecargarPromedio()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        InicializarDataTable()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InicializarDataTable()

        dtPersonas.Rows.Add("gabriel", "niglio", 31)

        Me.RecargarPromedio()

    End Sub

#End Region

End Class
