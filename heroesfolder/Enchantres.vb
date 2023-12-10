﻿Public Class Enchantres
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCH1STDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCH2NDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCH3RDDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCH4THDES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCHSHARD_DES.PNG"),
        Image.FromFile("C:\Users\user\Downloads\dota2skills\dota2skills\IntelligenceHeroes\ENCHANTRESS\ENCHAGHANIMS_DES.PNG"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\EnchantCounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\Enchantitem.png")
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
    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        check = Not check
        If check Then
            ShowImage(6)
            box(1)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        check = Not check
        If check Then
            ShowImage(7)
            box(1)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub
End Class