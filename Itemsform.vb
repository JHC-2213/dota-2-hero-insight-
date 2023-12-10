Imports System.IO

Public Class Itemsform
    Private images As New List(Of Image)()
    Private Searchitem As String
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True

        ' Load images during form initialization
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\AbysalD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\AghaD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\AlacrityD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\ArcanbootsD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\ArcanebootD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\battlefurryD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\bloodstoneD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\bootsD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\bloodthornD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\bloodstoneD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\BladeMailD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\BKBD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\BracerD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\butterflyD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\BroadswordD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\bottleD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\BootsoftravelD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\CirassD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\claymoreD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\CornucoplaD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\CrimsonGuardD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\CystalysD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DaggerD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DeadlusD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DemoEdgeD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DesoD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DiffusalD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DisperserD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DivinD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DragonlanceD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\DrumD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\MordiganD.png"))
        images.Add(Image.FromFile("G:\My Drive\items\Screenshots\ShardD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\dustD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\EBD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\HarponD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\HeartD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\echoD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\FBD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\FSD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\GEMD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\GlimerD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\GSD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\HelbergD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\kayaD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\mantaD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\PBD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\kayaD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\radD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\SYD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\YKD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\wardD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\OctaD.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\SED.png"))
        images.Add(Image.FromFile("C:\Users\user\OneDrive\Pictures\Screenshots\dust\wandD.png"))
    End Sub

    Private Sub SearchIt()
        For Each pic As Guna.UI2.WinForms.Guna2PictureBox In Me.Controls.OfType(Of Guna.UI2.WinForms.Guna2PictureBox)()
            If pic.AccessibleName IsNot Nothing AndAlso pic.AccessibleName.ToLower().Contains(Searchitem.ToLower()) Then
                pic.Visible = True
            Else
                pic.Visible = False
            End If
        Next
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Searchitem = Search.Text
        SearchIt()
    End Sub
    Private Sub ShowImage(index As Integer)
        If index >= 0 AndAlso index < images.Count Then
            Show.BackColor = Color.Transparent
            Show.Visible = True
            Show.Image = images(index)
            Show.SizeMode = PictureBoxSizeMode.Zoom
            Show.Invalidate()
        End If
    End Sub
    Private Sub ResetPictureBox()
        Show.Image = Nothing
        Show.Visible = False
    End Sub
    Private Sub Items_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim x = e.X - (Show.Width \ 10)
        Dim y = e.Y - (Show.Height \ 6)

        ' Ensure the PictureBox stays within the bounds of the form
        x = Math.Max(0, Math.Min(x, Me.Width - Show.Width))
        y = Math.Max(0, Math.Min(y, Me.Height - Show.Height))

        Show.Location = New Point(x, y)
        Show.Invalidate()
    End Sub


    Private Sub Guna2PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseHover
        ShowImage(0)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseHover
        ShowImage(1)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseHover
        ShowImage(2)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseHover
        ShowImage(3)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseHover
        ShowImage(4)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseHover
        ShowImage(5)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseHover
        ShowImage(6)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox8_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseHover
        ShowImage(7)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox9.MouseHover
        ShowImage(8)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox9.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseHover
        ShowImage(9)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox11_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox11.MouseHover
        ShowImage(10)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox11.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox12_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox12.MouseHover
        ShowImage(11)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox12_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox12.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox13_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox13.MouseHover
        ShowImage(12)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox13_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox13.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox14_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox14.MouseHover
        ShowImage(13)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox14_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox14.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox15_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox15.MouseHover
        ShowImage(14)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox15_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox15.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox16_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox16.MouseHover
        ShowImage(15)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox16.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox17_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox17.MouseHover
        ShowImage(16)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox17_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox17.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox18_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox18.MouseHover
        ShowImage(17)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox18_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox18.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox19_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox19.MouseHover
        ShowImage(18)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox19_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox19.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox20_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox20.MouseHover
        ShowImage(19)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox20_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox20.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox21_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox21.MouseHover
        ShowImage(20)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox21_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox21.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox22_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox22.MouseHover
        ShowImage(21)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox22_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox22.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox23_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox23.MouseHover
        ShowImage(22)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox23_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox23.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox24_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox24.MouseHover
        ShowImage(23)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox24_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox24.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox25_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox25.MouseHover
        ShowImage(24)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox25_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox25.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox26_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox26.MouseHover
        ShowImage(25)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox26_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox26.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox27_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox27.MouseHover
        ShowImage(26)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox27_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox27.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox28_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox28.MouseHover
        ShowImage(27)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox28_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox28.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox29_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox29.MouseHover
        ShowImage(28)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox29_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox29.MouseLeave
        ResetPictureBox()
    End Sub

    Private Sub Guna2PictureBox30_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox30.MouseHover
        ShowImage(29)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox30_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox30.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox31_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox31.MouseHover
        ShowImage(30)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox31_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox31.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox32_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox32.MouseHover
        ShowImage(31)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox32_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox32.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox33_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox33.MouseHover
        ShowImage(32)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox33_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox33.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox34_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox34.MouseHover
        ShowImage(33)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox34_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox34.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox35_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox35.MouseHover
        ShowImage(34)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox35_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox35.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox36_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox36.MouseHover
        ShowImage(35)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox36_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox36.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox37_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox37.MouseHover
        ShowImage(36)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox37_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox37.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox38_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox38.MouseHover
        ShowImage(37)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox38_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox38.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox39_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox39.MouseHover
        ShowImage(38)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox39_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox39.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox40_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox40.MouseHover
        ShowImage(39)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox40_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox40.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox41_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox41.MouseHover
        ShowImage(40)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox41_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox41.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox42_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox42.MouseHover
        ShowImage(41)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox42_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox42.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox43_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox43.MouseHover
        ShowImage(42)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox43_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox43.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox44_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox44.MouseHover
        ShowImage(43)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox44_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox44.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox45_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox45.MouseHover
        ShowImage(44)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox45_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox45.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox46_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox46.MouseHover
        ShowImage(45)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox46_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox46.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox47_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox47.MouseHover
        ShowImage(46)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox47_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox47.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox48_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox48.MouseHover
        ShowImage(47)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox48_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox48.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox49_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox49.MouseHover
        ShowImage(48)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox49_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox49.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox50_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox50.MouseHover
        ShowImage(49)
        Show.Size = Show.Image.Size
    End Sub

    Private Sub Guna2PictureBox50_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox50.MouseLeave
        ResetPictureBox()
    End Sub

    Private Sub Guna2PictureBox51_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox51.MouseHover
        ShowImage(50)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox51_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox51.MouseLeave
        ResetPictureBox()
    End Sub

    Private Sub Guna2PictureBox52_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox52.MouseHover
        ShowImage(51)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox52_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox52.MouseLeave
        ResetPictureBox()
    End Sub

    Private Sub Guna2PictureBox53_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox53.MouseHover
        ShowImage(52)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox53_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox53.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox54_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox54.MouseHover
        ShowImage(53)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox54_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox54.MouseLeave
        ResetPictureBox()
    End Sub
    Private Sub Guna2PictureBox55_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox55.MouseHover
        ShowImage(54)
        Show.Size = Show.Image.Size
    End Sub
    Private Sub Guna2PictureBox55_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox55.MouseLeave
        ResetPictureBox()
    End Sub
End Class