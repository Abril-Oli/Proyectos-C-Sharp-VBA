Public Class Form1
    'Crear un programa que almacene clientes de una empresa con distintos de planes (Lite, Basic, Pro)
    '-Nombre
    '-Apellido
    '-Localidad
    '-Edad
    '-Plan (Lite, Basic, Pro)

    'El programa debe mostrar un datagridView, con los clientes ingresados

    '-Debe calcular promedio de edad de clientes.
    '-Mostrar Cantidad de clientes en Buenos Aires.
    '-Cliente mas joven
    '-Cliente mas viejo
    '-Cantidad de usuarios con cada plan''



#Region "Dependencias"
    Dim dtClientes As New DataTable
#End Region



#Region "Inicializar"
    'inicializamos la datatable '
    Private Sub InicializarDatatable()
        Dim dt As New DataTable

        'inicializamos los parametros de las columnas '
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Localidad")
        dt.Columns.Add("Edad")
        dt.Columns.Add("Plan")

        'Llamamos a la funcion setDataTable para apuntar a nuestra DataGrid'
        Me.SetdtClientes(dt)


    End Sub
#End Region


#Region "Acciones"

    'Dirigimos dataTable a dataGridView con SetDatable'
    Private Sub SetdtClientes(dt As DataTable)
        'Reenombramos nuestra datatable clientes y la conectamos con dataSource'
        Me.dtClientes = dt
        DataGridView1.DataSource = dt
    End Sub

    'Creamos nuestra funcion de estadisticas'

    Private Sub RecargarEstadisticas()
        'Declaramos tipo de dato y valor inicial de los parametros a calcular'
        Dim AcumEdad As Integer = 0
        Dim ContClientesBsAs As Integer = 0
        Dim ContPlanLite As Integer = 0
        Dim ContPlanBasic As Integer = 0
        Dim ContPlanPro As Integer = 0
        Dim edadMinima As Integer = 0
        Dim edadMaxima As Integer = 0
        Dim PromEdadClientes As Integer

        'Declaramos dato string para obtener el nombre del mas joven y mas viejo'
        Dim NombreClienteJoven As String = ""
        Dim NombreClienteViejo As String = ""

        'Recorremos los renglones con for each'

        For Each renglon As DataRow In dtClientes.Rows
            AcumEdad += renglon("edad")

            'FUNCIONALIDAD EDAD +  condicional min y max'
            'Calculo condicional edad minima'
            If edadMinima > renglon("Edad") Or edadMinima = 0 Then
                NombreClienteJoven = renglon("Nombre")
                edadMinima = renglon("Edad")
            End If

            'Calculo condicional edad Maxima'

            If edadMaxima < renglon("Edad") Or edadMaxima = 0 Then
                NombreClienteViejo = renglon("Nombre")
                edadMaxima = renglon("Edad")
            End If

            'FUNCIONALIDAD LOCALIDAD'
            'Tomamos el dato ciudad del renglon localidad'
            'Si lo ingresado en ciudad es Bs.As, entonces que sume al contador de clientes de Bs.as'
            Dim ciudad As String = renglon("Localidad")
            If ciudad.ToUpper() = "BUENOS AIRES" Then
                ContClientesBsAs += 1
            End If

            'Ponemos el tipo de dato que se ingrese en plan con un condicional de contador'
            Dim plan As String = renglon("Plan")

            'FUNCIONALIDAD PLAN'
            'Condicional de planes'

            If plan = "Lite" Then
                ContPlanLite += 1
            ElseIf plan = "Basic" Then
                ContPlanBasic += 1

            ElseIf plan = "Pro" Then
                ContPlanPro += 1
            End If


        Next
        'MUESTREO ESTADISTICAS'

        'edad promedio de los clientes'

        PromEdadClientes = AcumEdad / Me.dtClientes.Rows.Count

        LabelPromEdadClientes.Text = PromEdadClientes.ToString("#0.00")

        'Cant clientes Bs As'
        LabelClientesBsAs.Text = ContClientesBsAs.ToString("#0.00")

        'Nombre Cliente + joven'
        LabelClienteJoven.Text = NombreClienteJoven

        'Nombre Cliente + Viejo'
        LabelClienteViejo.Text = NombreClienteViejo

        'Cantidad de usuario por plan'
        LabelPlanLite.Text = ContPlanLite.ToString("Lite:#0.00")
        LabelPlanBasic.Text = ContPlanBasic.ToString("Basic:#0.00")
        LabelPlanPro.Text = ContPlanPro.ToString("Pro:#0.00")
    End Sub


#End Region



#Region "Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDatatable()
    End Sub

    Private Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click
        Dim nombre As String = TextBoxNombre.Text
        Dim Apellido As String = TextBoxApellido.Text
        Dim Localidad As String = TextBoxLocalidad.Text
        Dim edad = Double.Parse(TextBoxEdad.Text)
        Dim plan As String = ComboBoxPlan.Text

        Me.dtClientes.Rows.Add(nombre, Apellido, Localidad, edad, plan)

        RecargarEstadisticas()
    End Sub






#End Region
End Class
