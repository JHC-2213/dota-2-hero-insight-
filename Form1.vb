Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports TheArtOfDevHtmlRenderer

Public Class Form1
    Dim Mysqlcon As MySqlConnection
    Dim command As MySqlCommand

    Dim code As String = Guid.NewGuid().ToString 'verificationcode
    Dim username As String = "dotadraftpickadvisorytool@gmail.com" ' gmail gamit sa pag send ug code
    Dim password As String = "qayh kdhn qiyi aohl" ' Replace with your app password 
    'send a code to email
    Private Sub send()
        Try
            Dim from As New MailAddress("dotadraftpickadvisorytool@gmail.com", "hello")
            Dim toaddress As New MailAddress(EmailBox.Text)
            Dim subject As String = "Verify email"
            Dim body As String = $"Code: {code}"

            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(username, password)

            Dim message As New MailMessage(from, toaddress)
            message.Subject = subject
            message.Body = body

            smtp.Send(message)
            MsgBox("Code sent successfully.")
            verifypanel.BringToFront()
            P1.Enabled = False
            P2.Enabled = False
        Catch ex As Exception
            MsgBox("Failed to send code. Error: " & ex.Message)
        End Try
    End Sub

    'Exit
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    'bring login panel front
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        P2.BringToFront()
    End Sub
    'bring register panel front
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        P1.BringToFront()
    End Sub


    'login
    Sub login()
        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = "server=localhost; username=root; password=;database=users"
        Dim reader As MySqlDataReader
        If UsernameBox1.Text <> "" AndAlso passBox1.Text <> "" Then
            Try
                Mysqlcon.Open()
                Dim query As String
                query = "select * from user_details where username ='" & UsernameBox1.Text & "' and password='" & passBox1.Text & "' "
                command = New MySqlCommand(query, Mysqlcon)
                reader = command.ExecuteReader

                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While

                If count = 1 Then
                    MessageBox.Show("Successfully login")
                    Me.Hide()
                    Dim form2Instance As New Form2()
                    form2Instance.Label1.Text = "" & UsernameBox1.Text ' Set the label in Form2

                    form2Instance.Show()
                ElseIf count > 1 Then
                    MessageBox.Show("Username and password duplicate")
                Else
                    MessageBox.Show("Username and password incorrect")
                End If

                Mysqlcon.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                Mysqlcon.Dispose()
            End Try
        Else
            ' Handle the case when either UsernameBox or passBox1 is empty
            MessageBox.Show("Username and password cannot be empty.")
        End If
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        login()
    End Sub

    'Register
    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        If UsernameBox2.Text <> "" AndAlso PassBox2.Text <> "" AndAlso EmailBox.Text <> "" Then
            send()

        Else
            MessageBox.Show("Username, password, and email cannot be empty.")
        End If

    End Sub
    Sub showw(textBox As Guna.UI2.WinForms.Guna2TextBox)
        If textBox.UseSystemPasswordChar Then
            textBox.UseSystemPasswordChar = False
        Else
            textBox.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passBox1.UseSystemPasswordChar = True
        PassBox2.UseSystemPasswordChar = True
        opencon()
    End Sub

    Private Sub switch1_CheckedChanged(sender As Object, e As EventArgs) Handles switch1.CheckedChanged
        showw(passBox1)
    End Sub

    Private Sub switch2_CheckedChanged(sender As Object, e As EventArgs) Handles switch2.CheckedChanged
        showw(PassBox2)
    End Sub

    'check the verification code if correct
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim entercode As String = verify.Text
        If entercode.Equals(code, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Account Successfully Created")
            Try
                cm = New MySqlCommand("INSERT INTO  user_details  (username, password, email) VALUES ('" & UsernameBox2.Text & "','" & PassBox2.Text & "','" & EmailBox.Text & "')", con)
                cm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Hide()
            Dim form2Instance As New Form2()
            form2Instance.Label1.Text = "" & UsernameBox1.Text ' Set the label in Form2

            form2Instance.Show()
        Else
            MsgBox("Invalid Code")
        End If
    End Sub
End Class