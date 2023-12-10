﻿Public Class Axe
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX1STDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX2NDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX3RDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX4THDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX3RD_SHARD.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\StrengthHeroes\AXE\AX1ST_aghanims.PNG"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\axecount.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\axeitem.png")
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

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        showcounter(7, 1)
    End Sub
    Private Sub Guna2Button10_Click_1(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        showcounter(6, 1)
    End Sub

    Private Sub Guna2Button9_Click_1(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        showcounter(7, 1)
    End Sub
End Class