Public Class Hoodwink
    Private check As Boolean = False

    Dim images As New List(Of Image) From {
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080804.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080815.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080822.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080834.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080843.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 080855.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\hoodcounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\hooditem.png")}

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
    Private Sub showcounter(ByVal i As Integer, ByVal j As Integer)
        If check Then
            ShowImage(i)
            box(j)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub

    Private Sub ResetPictureBox()
        Skillinfo.Image = Nothing
    End Sub


    Private Sub Guna2PictureBox1_MouseHover(sender As Object, e As EventArgs)
        ShowImage(0)
        box(1)
    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox2_MouseHover(sender As Object, e As EventArgs)
        ShowImage(1)
        box(1)
    End Sub

    Private Sub Guna2PictureBox2_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox3_MouseHover(sender As Object, e As EventArgs)
        ShowImage(2)
        box(1)
    End Sub

    Private Sub Guna2PictureBox3_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox4_MouseHover(sender As Object, e As EventArgs)
        ShowImage(3)
        box(1)
    End Sub

    Private Sub Guna2PictureBox4_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox5_MouseHover(sender As Object, e As EventArgs)
        ShowImage(4)
        box(1)
    End Sub

    Private Sub Guna2PictureBox5_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub
    Private Sub Guna2PictureBox6_MouseHover(sender As Object, e As EventArgs)
        ShowImage(5)
        box(1)
    End Sub

    Private Sub Guna2PictureBox6_MouseLeave(sender As Object, e As EventArgs)
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs) Handles Guna2Button21.Click
        showcounter(6, 1)
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        showcounter(7, 1)
    End Sub
End Class