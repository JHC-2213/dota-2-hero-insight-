Public Class Elder_Titan
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082723.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082732.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082740.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082748.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082754.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 082800.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\Eldercounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\Elderitem.png")
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
    Private Sub showcounter(ByVal i As Integer, ByVal j As Integer)
        check = Not check
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
    Private Sub Guna2Button27_Click(sender As Object, e As EventArgs) Handles Guna2Button27.Click
        showcounter(6, 1)
    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs) Handles Guna2Button26.Click
        showcounter(7, 1)
    End Sub
End Class