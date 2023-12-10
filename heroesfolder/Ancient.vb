Public Class Ancient
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA1STDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA2NDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA3RDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA4THDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA4THDES_SHARD.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ANCIEND_APPARITION\AA3RDDES_aghanims.PNG"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\CMcounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\CMitem.png")
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

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        check = Not check
        If check Then
            ShowImage(6)
            box(1)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        check = Not check
        If check Then
            ShowImage(7)
            box(1)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class