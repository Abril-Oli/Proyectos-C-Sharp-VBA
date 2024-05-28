Public Class form1

#Region "Dependencias"

    Private dtPersonas As DataTable
#End Region

#Region "Inicializar"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Edad")
        Me.SetDtPersonas(dt)

    End Sub
#End Region

#Region "Acciones"
    'Creamos el set para conectar/apuntar personas del data table'
    Private Sub SetdtPersonas(dt As DataTable)
        'Apuntamos el datatable hacia el datagridview1'
        Me.dtPersonas = dt
        DataGridView1.DataSource = dt

    End Sub

    Private Sub RecargarPromedio()
        Dim acumulador As Double = 0
        Dim acumuladorM As Double = 0
        'cant de pasadas de renglon'
        Dim contadorM As Integer = 0

        'Recorremos con un for each'

        For Each renglon As DataRow In dtPersonas.Rows
            'Por cada renglon de turno de mi dataTable de personas'
            'nombre toma el valor del renglon nombre 
            acumulador += renglon("Edad")
            Dim nombre As String = renglon("Nombre")

            'En caso de que el Nombre empiece por M, lo acumula e incrementa el contador'

            If nombre.ToUpper().StartsWith("M") Then
                acumuladorM += renglon("Edad")
                contadorM += 1
            End If

            'Para todos los elementos, el count nos dara la cantidad de elementos en tabla'
            'acumulador x cant de filas de DataTable'
            Dim promedio = acumulador / dtPersonas.Rows.Count

            'Asignamos el valor del promedio en el label6 del form1'
            'El ToString 0.00 nos da los primeros dos numeros'
            Label6.Text = promedio.ToString("#0.00")

            If contadorM > 0 Then
                Dim promedioM = acumuladorM / contadorM
                Label7.Text = promedioM.ToString("#0.00")
            Else
                Label7.Text = "0.00"
            End If


        Next



    End Sub

#End Region

#Region "Eventos"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Guarda los valores de los textos'
        Dim nombre = TextBox1.Text
        Dim apellido = TextBox2.Text
        'En la edad hacemos un pase de dato a dato entero'
        Dim Edad = Integer.Parse(TextBox3.Text)

        'agrega un fila en el DataTable, con las variables'
        Me.dtPersonas.Rows.Add(nombre, apellido, Edad)

        Me.RecargarPromedio()

    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()
    End Sub

#End Region


End Class
