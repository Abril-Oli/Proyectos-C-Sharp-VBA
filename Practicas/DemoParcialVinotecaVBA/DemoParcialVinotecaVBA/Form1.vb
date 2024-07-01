Public Class Form1
#Region "Dependencias"
    Private dtVinos As DataTable

#End Region

#Region "Inicializacion"


    Private Sub InicializarDataTable()
        Dim dt As New DataTable
        dt.Columns.Add("Marca")
        dt.Columns.Add("Descripcion")
        dt.Columns.Add("capacidad")
        dt.Columns.Add("Envase tipo")
        dt.Columns.Add("%alcohol")

        Me.setdtVinos(dt)

    End Sub

    Private Sub setDtVinos(dt As DataTable)
        Me.dtVinos = dt
        Me.DataGridView1.DataSource = dt
    End Sub

#End Region

#Region "Acciones"

    Private Sub RecargarPromedio()
        Dim contVinosBotella = 0
        Dim bebidaMasPorcentaje As String = ""
        Dim porcentajeMasAlto = 0
        Dim contAlma = 0

        'Recorrido por las data row'

        For Each renglon As DataRow In dtVinos.Rows
            If renglon("Envase tipo") = "Botella" Then
                contVinosBotella += 1
            End If

            'Condicional para obtener la bebida con mas porcentaje de alcohol'
            If renglon("%alcohol") > porcentajeMasAlto Or porcentajeMasAlto = 0 Then
                bebidaMasPorcentaje = renglon("Marca")
                porcentajeMasAlto = renglon("%alcohol")
            End If

            Dim marca As String = renglon("marca")

            If marca.ToUpper = "ALMA" Then
                contAlma += 1
            End If


        Next

        LabelCantBotella.Text = contVinosBotella.ToString("#0.00")
        LabelBebidaMasAlcohol.Text = bebidaMasPorcentaje
        LabelMarcaAlma.Text = contAlma.ToString("#0.00")


    End Sub



#End Region


#Region "Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarDataTable()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marca As String = TextBoxMarca.Text
        Dim descripcion As String = TextBoxDescripcion.Text
        Dim capacidad = Double.Parse(TextBoxCapacidad.Text)
        Dim Envasetipo As String = ComboBoxEnvase.Text
        Dim Alcohol = Double.Parse(TextBoxAlcohol.Text)

        Me.dtVinos.Rows.Add(marca, descripcion, capacidad, Envasetipo, Alcohol)

        RecargarPromedio()

    End Sub


#End Region

End Class
