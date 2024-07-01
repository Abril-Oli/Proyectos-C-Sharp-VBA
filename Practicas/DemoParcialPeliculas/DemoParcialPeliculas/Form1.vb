Public Class Form1


    'Crear un programa que almacene peliculas
    'Con nombre
    'Genero
    'Duracion

    'El programa debe mostrar un datagridView, con las peliculas ingresadas

    '-Debe mostrar la sumatoria de todas las duraciones
    '-Promedio de duracion
    '-Cuantas peliculas de comedia, se ingresaron.
    '-Debe mostrar promedio de peliculas de Comedia.


#Region "Dependencias"
    'Creamos y establecemos nuestra datatable de peliculas'
    Private dtPeliculas As DataTable

#End Region
#Region "Inicializacion"

    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Pelicula")
        dt.Columns.Add("Genero")
        dt.Columns.Add("Duracion")
        Me.SetdtPeliculas(dt)



    End Sub

#End Region


#Region "Acciones"

    Private Sub SetdtPeliculas(dt As DataTable)
        Me.dtPeliculas = dt
        DataGridView1.DataSource = dt
    End Sub


    'creamos la funcion del carrito'
    Private Sub RecargaPromedio()
        Dim acumulador = 0
        Dim acumuladorC = 0
        Dim contadorC = 0
        Dim acumuladorTerror = 0
        Dim contadorTerror = 0

        'Recorremos los renglones'

        For Each renglon As DataRow In dtPeliculas.Rows
            acumulador += renglon("Duracion")
            Dim genero As String = renglon("Genero")

            If genero.ToUpper() = "COMEDIA" Then
                contadorC += 1
            End If

            If genero.ToUpper() = "TERROR" Then
                acumuladorTerror += renglon("Duracion")

                contadorTerror += 1
            End If

        Next

        'mostramos la duracion total de las peliculas ingresadas'
        LabelDuracionTotal.Text = acumulador.ToString("#0.00")

        'mostramos promedio de duracion en pelis, en label del promedio'
        Dim promedio = acumulador / dtPeliculas.Rows.Count
        LabelPromedioDuracion.Text = promedio.ToString("#0.00")

        'Mostramos la cantidad de pelis de comedia'

        LabelPeliculasComedia.Text = contadorC.ToString()

        'hacemos un condicional para evitar la division por 0 y error del programa'
        If contadorTerror > 0 Then
            'Calculamos la var promedioTerror y la mostramos en label'
            Dim promedioTerror = acumuladorTerror / contadorTerror
            LabelPromedioPeliculasTerror.Text = promedioTerror.ToString("#0.00")

        Else
            'en caso de ser 0 solo mostramos el texto, sin division'
            LabelPromedioPeliculasTerror.Text = "0"


        End If


    End Sub


#End Region

#Region "Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        'Su rol es agregar valores a los textbox'
        Dim Pelicula = TextBoxPeli.Text
        Dim Genero = TextBoxGenero.Text
        Dim Duracion = Double.Parse(TextBoxDuracion.Text)

        'Una vez ingresados los parametros, agregamos la fila al datatable'
        Me.dtPeliculas.Rows.Add(Pelicula, Genero, Duracion)

        'llamamos denuevo a nuestra funcion de carrito'

        RecargaPromedio()
    End Sub

#End Region
End Class
