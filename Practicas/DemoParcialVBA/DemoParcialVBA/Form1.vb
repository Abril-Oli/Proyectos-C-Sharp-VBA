Public Class Form1

#Region "Dependencias"
    Private dtProductos As DataTable
#End Region

#Region "Inicializar"

    Private Sub inicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Producto")
        dt.Columns.Add("Precio")
        Me.SetDtProductos(dt)

    End Sub

#End Region
#Region "Acciones"

    Private Sub SetDtProductos(dt As DataTable)

        Me.dtProductos = dt
        DataGridView1.DataSource = dt
    End Sub


    Private Sub RecargaPromedio()
        Dim acumulador As Double
        Dim acumuladorP As Double
        Dim contadorP As Integer

        acumulador = 0
        acumuladorP = 0
        contadorP = 0



        For Each renglon As DataRow In dtProductos.Rows

            acumulador += renglon("Precio")

            Dim producto As String = renglon("Producto")

            If producto.ToUpper().StartsWith("P") Then
                acumuladorP += renglon("Precio")
                contadorP += 1
            End If

        Next
        'mostramos total de productos'
        LabelTotalProd.Text = acumulador.ToString("#0.00")

        'funciones de promedios'
        Dim promedio As Double
        promedio = acumulador / dtProductos.Rows.Count

        'PROMEDIO RESULTADO'
        LabelPromedio.Text = promedio.ToString("#0.00")
        'mostramos total de productos que empiecen con la p'
        LabelTotProP.Text = acumuladorP.ToString("#0.00")



        'condicional de division con 0 para evitar error'
        If contadorP > 0 Then
            Dim promedioP = acumuladorP / contadorP

            LabelPromedioP.Text = promedioP.ToString("#0.00")
        Else
            LabelPromedioP.Text = "#0.00"
        End If


    End Sub

#End Region


#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarDataTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim producto = TextBoxProd.Text
        Dim precio = Double.Parse(TextBoxPrecio.Text)

        Me.dtProductos.Rows.Add(producto, precio)

        RecargaPromedio()
    End Sub


#End Region



End Class
