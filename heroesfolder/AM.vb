Public Class AM
    Private check As Boolean = False
    Dim images As New List(Of Image) From {
        Image.FromFile("C:\Users\user\source\repos\Dota\heroesfolder\Resources\am1stskillinfo.png"),
        Image.FromFile("C:\Users\user\source\repos\Dota\heroesfolder\Resources\am2ndskillinfo.png"),
        Image.FromFile("C:\Users\user\source\repos\Dota\heroesfolder\Resources\am3rdskillinfo.png"),
        Image.FromFile("C:\Users\user\source\repos\Dota\heroesfolder\Resources\amultinfo.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\AMCounter.png"),
        Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\AMItems.png")
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
    Private Sub showcount(ByVal i As Integer, ByVal check As Boolean)
        If check Then
            ShowImage(i)
            box(1)
        Else
            ResetPictureBox()
            box(0)
        End If
    End Sub

    Private Sub ResetPictureBox()
        Skillinfo.Image = Nothing
    End Sub
    Private Sub skill1_MouseLeave(sender As Object, e As EventArgs) Handles skill1.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub skill1_MouseHover(sender As Object, e As EventArgs) Handles skill1.MouseHover
        ShowImage(0)
        box(1)
    End Sub

    Private Sub skill2_MouseLeave(sender As Object, e As EventArgs) Handles skill2.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub skill2_MouseHover(sender As Object, e As EventArgs) Handles skill2.MouseHover
        ShowImage(1)
        box(1)
    End Sub

    Private Sub skill3_MouseLeave(sender As Object, e As EventArgs) Handles skill3.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub skill3_MouseHover(sender As Object, e As EventArgs) Handles skill3.MouseHover
        ShowImage(2)
        box(1)
    End Sub

    Private Sub skill4_MouseHover(sender As Object, e As EventArgs) Handles skill4.MouseHover
        ShowImage(3)
        box(1)
    End Sub

    Private Sub skill4_MouseLeave(sender As Object, e As EventArgs) Handles skill4.MouseLeave
        ResetPictureBox()
        box(0)
    End Sub

    Private Sub AM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        box(0)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        check = Not check
        showcount(4, check)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        check = Not check
        showcount(5, check)
    End Sub
End Class