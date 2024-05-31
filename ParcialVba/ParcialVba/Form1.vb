Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class Form1

#Region "Dependencias"
    'Creamos la dependencia de nuestra data table para la empresa de pintura'

    Private dtLatas As DataTable

#End Region

#Region "Inicializacion"
    'Damos inicio a nuestra nueva data table, creamos y nombramos sus columnas'
    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Color")
        dt.Columns.Add("Litros")

        Me.SetdtLatas(dt)


    End Sub

#End Region

#Region "Acciones"
    'Creamos nuestra funcion SetdtLatas declarabdola nuestra datatable'
    Private Sub SetdtLatas(dt As DataTable)
        Me.dtLatas = dt

        'Conectamos nuestra datatable a la grilla de la ventana grafica mediante un Datasource'
        DataGridView1.DataSource = dt
    End Sub


    'Creamos una funcion -RecargarEstadisticas- para guardar nuestras variables y logica'
    Private Sub RecargarEstadisticas()

        'Declaramos nuestras variables a utilizar'
        Dim acumPintura
        Dim acumPinturaRoja As Integer = 0
        Dim contPinturaRoja = 0
        Dim acumPinturaAzul As Integer = 0
        Dim contPinturaAzul As Integer = 0


        'Recorremos las filas con un for each,  para tomar los datos ingresados hacia las variables '
        For Each renglon As DataRow In dtLatas.Rows
            acumPintura = renglon("Litros")

            'Declaramos el ingreso de dato tipo String para lo que se ingrese en el el reglon Color'
            Dim color As String = renglon("Color")

            'Hacemos un condicional cuandoel color ingresado sea rojo, se guarden sus litros en un acumulador de pintura roja'
            If color.ToUpper() = "ROJO" Then
                acumPinturaRoja += renglon("Litros")

            End If

            'Condicional de filtrado, guardado y contador'  
            If color.ToUpper() = "AZUL" Then

                'cuando el color ingresado sea azul, se guardan sus litros en un acumulador de pintura Azul'
                acumPinturaAzul += renglon("Litros")

                'una vez guardada su cantidad en el acumulador, sumamos 1 al contador'
                contPinturaAzul += 1
            End If

            'Condicional para evitar errores de division por 0'
            'Si tenemos mas de 0 pinturas azules, podremos calcular un promedio'
            If contPinturaAzul > 0 Then

                'calculamos el promedio de pintura azul, con nuestros LTS acumulados divididos por la cantidad de pinturas que tenemos'
                Dim promedioAzul = acumPinturaAzul / contPinturaAzul

                'Muestreo en ventana grafica, asignamos nuestra var de promedio junto a un toString'
                LabelPromLtsAzul.Text = promedioAzul.ToString("#0.00")
            Else
                'Si no tenemos un promedio, muestra cantidad nula=0'
                LabelPromLtsAzul.Text = "#0.00"
            End If

        Next


        'muestreo de LTS totales de pintura roja, junto a un toString'
        LabelLtTotalRoja.Text = acumPinturaRoja.ToString("#0.00")




    End Sub
    'Funcion de limpieza de textboxes'
    'Esta funcion vacia textboxes despues de que se agreguen datos a la gridview'
    Private Sub LimpiarTextbox()
        TextBoxCodigo.Text = ""
        TextBoxColor.Text = ""
        TextBoxLitros.Text = ""

    End Sub


#End Region


#Region "Eventos"
    ''
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataTable()

    End Sub


    'FUNCIONALIDAD DEL BOTON AGREGAR'
    Private Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click


        '⭣ VALIDACIONES con try catch⭣ '


        Try

            'VALIDACION INGRESO SOLO DE DATOS NUMERICOS  '

            'Declaramos el tipo de dato-double,integer,string- que se debe ingresar en nuestros TextBox'
            Dim codigo As Integer = Integer.Parse(TextBoxCodigo.Text)
            Dim color As String = TextBoxColor.Text
            Dim Litros As Double = Double.Parse(TextBoxLitros.Text)


            'VALIDACION TEXTBOX VACIO'
            'Validamos que si el TextBox de color queda vacio, nos muestre un mensaje de error'

            If color = "" Then
                MessageBox.Show("Por favor, completar campo Color vacio.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return
            End If

            'VALIDACION CODIGO UNICO'
            'validamos recorriendo con un for each que el codigo actual no este repetido, sino nos muestra un msj de error'

            For Each renglon As DataRow In Me.dtLatas.Rows
                If renglon("Codigo") = codigo Then
                    MessageBox.Show("Codigo repetido, intente otro codigo", "ERROR DE REPETICION", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Return
                End If
            Next

            'VALIDACION: NUMEROS NEGATIVOS tanto para codigo como para Lts'
            'validamos que si los numeros ingresados codigo y tmb litros son  < 0(negativos), nos muestre un msj error pidiendo ingreso de num positivos'

            If codigo < 0 AndAlso Litros < 0 Then
                MessageBox.Show("Error numerico", "ingrese valores positivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Agregamos nuestros parametros a nuestra dataTable'
            Me.dtLatas.Rows.Add(codigo, color, Litros)

            'En caso de no cumplir alguna de estas validaciones, nos muestra un mensaje de error de campos'
        Catch ex As Exception
            MessageBox.Show("Verificar nuevamente los datos", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Volvemos a llamar a nuestras funciones, para limpiar los textbox y recargar de nuevo nuestras funciones del programa'

        Me.LimpiarTextbox()
        RecargarEstadisticas()
    End Sub




#End Region
End Class
