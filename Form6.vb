Public Class Form6
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clinnks1stskillinfo.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clicnks2ndskillinfo.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clicnks3rdskillinfo.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clicnksultinfo.png"),
        Image.FromFile("C:\Users\user\Downloads\AgilityHereos\AgilityHereos\CLINKZ\clinksShardinfo.PNG"),
        Image.FromFile("C:\Users\user\Downloads\AgilityHereos\AgilityHereos\CLINKZ\clinksAghainfo.PNG"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clinkscount.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\clincksitem.png")
    }
    Private Sub ShowImage(index As Integer)
        If index >= 0 AndAlso index < images.Count Then
            Skillinfo.BackColor = Color.Transparent
            Skillinfo.Image = images(index)
            Skillinfo.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub box(ByVal i As Integer)
        Select Case i
            Case 0
                Skillinfo.SendToBack()
            Case 1
                Skillinfo.BringToFront()
        End Select

    End Sub
    Private Sub showcounter(ByVal i As Integer, ByVal j As Integer, ByVal check As Boolean)
        If check Then
            ShowImage(i)
            box(j)
        Else
            ResetPictureBox()
            box(j)
        End If
    End Sub
    Private Sub ResetPictureBox()
        Skillinfo.Image = Nothing
    End Sub
    Private Sub Guna2PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseHover
        ShowImage(0)
        box(1)
    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseHover
        ShowImage(1)
        box(1)
    End Sub

    Private Sub Guna2PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub
    Private Sub Guna2PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseHover
        ShowImage(2)
        box(1)
    End Sub

    Private Sub Guna2PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseHover
        ShowImage(3)
        box(1)
    End Sub

    Private Sub Guna2PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub
    Private Sub Guna2PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseHover
        ShowImage(4)
        box(1)
    End Sub

    Private Sub Guna2PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseHover
        ShowImage(5)
        box(1)
    End Sub

    Private Sub Guna2PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        check = Not check
        showcounter(6, 1, check)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        check = Not check
        showcounter(7, 1, check)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Heroes.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class