Module Module1

    Function suma(a As Integer, b As Integer) As Integer

        Return a + b

    End Function

    Sub Main()
        Console.WriteLine("Hola")

        Dim numerin As Integer = 3

        numerin = "7"

        Console.WriteLine("numerin")

        'ingreso de dato por consola, devuelve un string'
        'dim solo corresponde a un string, al agregar integer modificamos el tipo de dato'

        Dim respuesta As Integer = Console.ReadLine()

        'el signo $ delante de un string, con las llaves ,  muestra el valor de la var en llaves (repuesta)'

        Console.WriteLine($"Ud ingreso: {respuesta}. :")


        'El signo = es de comparacion. no asignacion solo en este casp'
        If respuesta = 0 Then

            Console.WriteLine("Ingresaste cero")

        End If
        'creamos en var boolean para'
        Dim esPar As Boolean = respuesta Mod 2 = 0

        'creamos var para ver si es positivo'

        Dim esPositivo = (respuesta > 0)

        'valido si es pary positivo'
        If esPar And esPositivo Then

            'valido si es par y no positivo usando AND NOT Y OR'
        ElseIf Not esPositivo And esPar Then

        End If

        While 1 = 9

        End While

        For index = 1 To 5

            Console.WriteLine(index)
        Next

        'creamos un vector'

        Dim vecty(5) As String

        vecty(0) = 1
        Console.WriteLine($"vecty(0): {vecty(0)}")

        'creacion de lista'
        Dim listita As List(Of String) = New List(Of String)
        listita.Add(2)
        listita.Add("Hola")
        listita.Add(5)


        'con aclaracion del tipo de dato + NEW' 'En vez de .Add usamos el from con los atributos entre llaves'
        Dim listitaPiola As New List(Of String) From {5, "Hola", True, 0.8}


        ' listitaPiola.Add(listitaPiola)'    ''pasar listas no se puede''

        For Each elemento In listitaPiola
            Console.WriteLine(elemento)
        Next



        Do While 0 = 1
            Console.WriteLine("Entre al do while")

            Exit Do 'En vez del break usamos Exit + el lugar de donde estamos saliendo'

        Loop


        Dim variable = suma(1, 4)


        'este consolelog, nos sirve para mantener la consola activa'
        Console.ReadLine()


    End Sub

End Module
