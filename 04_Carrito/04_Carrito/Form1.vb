Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'asignamos un srting y un valor apenas carga el form1'
        Me.GrillaProductos.Rows.Add("Hola tonotos", 2)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Button1.MouseHover
        Dim Productos As String = TextBox1.Text

        Try
            'guardar valores de los textbox'
            Dim Precio As Integer = TextBox2.Text

            'agregamos valores como registro nuevo en la grid'

            Me.GrillaProductos.Rows.Add(Productos, Precio)

        Catch ex As Exception

            'En caso de error, mostrar un mensaje'
            MessageBox.Show("El precio tiene que ser numerico")

        End Try

        'Sumar cada precio de los prod y hacer el total'
        Dim sumador As Integer = 0

        'recorremos cada row de la grid'

        For Each row As DataGridViewRow In Me.GrillaProductos.Rows
            sumador += row.Cells("ColumnaPrecio").Value

        Next

        'mostramos el total'
        Me.LabelTotal.Text = sumador

    End Sub

    'Funcion para limpiar textbox - asignando string vacio'

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
    End Sub


End Class
