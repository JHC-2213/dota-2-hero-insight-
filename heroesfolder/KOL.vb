Public Class KOL
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083402.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083408.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083415.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083421.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083426.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083431.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083438.png"),
        Image.FromFile("G:\My Drive\items\Hero Icons Skills\Screenshots\Screenshot 2023-11-16 083444.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\KOLcounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\KOLitem.png")
    }

    Private Sub ShowImage(index As Integer)
        If index >= 0 AndAlso index < images.Count Then
            Skillinfo.BackColor = Color.Transparent
            Skillinfo.Image = images(index)
            Skillinfo.SizeMode = PictureBoxSizeMode.Zoom
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
    Private Sub Guna2Button24_Click(sender As Object, e As EventArgs) Handles Guna2Button24.Click
        showcounter(8, 1)
    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs) Handles Guna2Button25.Click
        showcounter(9, 1)
    End Sub

    Private Sub Guna2PictureBox11_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox11.MouseHover
        ShowImage(7)
        box(1)
    End Sub
    Private Sub Guna2PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox11.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub Guna2PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseHover
        ShowImage(6)
        box(1)
    End Sub

    Private Sub Guna2PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub
End Class