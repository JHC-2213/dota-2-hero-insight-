Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cm As MySqlCommand
    Sub opencon()
        Try
            con.ConnectionString = "server=localhost; username=root; password=;database=users"
            con.Open()
            'MessageBox.Show("Connected")
        Catch ex As Exception
            'MessageBox.Show("Connection Failed")
        End Try

    End Sub

End Module
