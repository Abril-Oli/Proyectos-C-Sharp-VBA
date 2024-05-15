Imports System.Linq.Expressions
Imports PokeServices.Containers
Imports PokeServices.Models

Public Class Mainform

    'nuestro form empieza ejecutando la pokedex'
    Private Pokedex As New Pokedex


    Private Sub UpdateGrid()

        DataGridView1.DataSource = Pokedex.GetPokemons()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            'metodo dar de alta'
            Dim number As Long = ComboBox1.Text
            Dim name As String = ComboBox2.Text
            Dim type As New Type("Water")
            Dim newPokemon As New Pokemon(number, name, type)

            Dim itAdd = Pokedex.add(newPokemon)

            If itAdd Then
                MessageBox.Show("Todo bien")
                ComboBox1.Text = String.Empty
                ComboBox2.Text = ""
                UpdateGrid()

            Else
                MessageBox.Show("Error, ese pokemon esta repetido")

            End If


        Catch ex As Exception
            MessageBox.Show("Algo salio mal")

        End Try

    End Sub
End Class
