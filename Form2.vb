Public Class Form2
    Private currentchild As Form
    Private herosearch As String = ""
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub openchildform(childform As Form)
        If currentchild IsNot Nothing Then
            currentchild.Close()
        End If
        currentchild = childform

        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        heropanel.Controls.Add(childform)
        heropanel.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If currentchild IsNot Nothing Then
            currentchild.Close()
        End If
        heropanel.BringToFront()
        heropanel.Show()
    End Sub

    Private Sub SearchIt()
        Console.WriteLine("Searching for: " & herosearch)

        For Each btn As Guna.UI2.WinForms.Guna2Button In heropanel.Controls.OfType(Of Guna.UI2.WinForms.Guna2Button)()
            If btn.Text.ToLower.Contains(herosearch) Then
                btn.Visible = True
            Else
                btn.Visible = False
            End If
        Next
    End Sub
    Private Sub Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search.KeyPress
        herosearch = Search.Text.ToLower
        SearchIt()

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub Ambtn_Click(sender As Object, e As EventArgs) Handles Ambtn.Click
        openchildform(New AM())
    End Sub
    Private Sub arcwarden_Click(sender As Object, e As EventArgs) Handles arcwardenbtn.Click
        openchildform(New Form3())
    End Sub

    Private Sub blood_Click(sender As Object, e As EventArgs) Handles bloodbtn.Click
        openchildform(New Form4())
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles bountybtn.Click
        openchildform(New Form5())
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles clinkzbtn.Click
        openchildform(New Form6())
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Alchemistbtn.Click
        openchildform(New Alchemist())
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles axebtn.Click
        openchildform(New Axe())
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles BBbtn.Click
        openchildform(New BristleBack())
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Centaurbtn.Click
        openchildform(New Centuar())
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles CKbtn.Click
        openchildform(New Chaos_Knight())
    End Sub

    Private Sub Guna2Button29_Click(sender As Object, e As EventArgs) Handles Anncientbtn.Click
        openchildform(New Ancient())
    End Sub

    Private Sub Guna2Button30_Click(sender As Object, e As EventArgs) Handles CMbtn.Click
        openchildform(New Crystal())
    End Sub

    Private Sub Guna2Button31_Click(sender As Object, e As EventArgs) Handles Deathbtn.Click
        openchildform(New DeathP())
    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs) Handles Disruptorbtn.Click
        openchildform(New Disruptor())
    End Sub

    Private Sub Guna2Button27_Click(sender As Object, e As EventArgs) Handles Enchantbtn.Click
        openchildform(New Enchantres())
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles drawbtn.Click
        openchildform(New Draw())
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Emberbtn.Click
        openchildform(New Ember())
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles voidbtn.Click
        openchildform(New Void())
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Gyrobtn.Click
        openchildform(New Gyrocopter())
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Jugbtn.Click
        openchildform(New juggernaut())
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Hoodbtn.Click
        openchildform(New Hoodwink())
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Doombtn.Click
        openchildform(New Doom())
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs) Handles DBbtn.Click
        openchildform(New Dawn())
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles DKbtn.Click
        openchildform(New DragonKnight())
    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs) Handles ESbtn.Click
        openchildform(New Earth_Shaker())
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles ESPbtn.Click
        openchildform(New EarthSpirit())
    End Sub

    Private Sub Guna2Button28_Click(sender As Object, e As EventArgs) Handles Grimbtn.Click
        openchildform(New Grimstroke())
    End Sub

    Private Sub Guna2Button24_Click(sender As Object, e As EventArgs) Handles jakirobtn.Click
        openchildform(New Jakiro())
    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs) Handles KOLbtn.Click
        openchildform(New KOL())
    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs) Handles leshrakbtn.Click
        openchildform(New Leshrak())
    End Sub

    Private Sub Guna2Button22_Click(sender As Object, e As EventArgs) Handles lichbtn.Click
        openchildform(New Lich())
    End Sub

    Private Sub Guna2Button23_Click(sender As Object, e As EventArgs) Handles linabtn.Click
        openchildform(New Lina())
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) Handles ETbtn.Click
        openchildform(New Elder_Titan())
    End Sub
    Private Sub Guna2Button41_Click(sender As Object, e As EventArgs) Handles banebtn.Click
        openchildform(New Bane())
    End Sub
    Private Sub Guna2Button44_Click(sender As Object, e As EventArgs) Handles Guna2Button44.Click
        openchildform(New Itemsform())
    End Sub

    Private Sub Guna2Button42_Click(sender As Object, e As EventArgs) Handles Batrider.Click
        openchildform(New Batrider())
    End Sub

    Private Sub Guna2Button37_Click(sender As Object, e As EventArgs) Handles BMbtn.Click
        openchildform(New Beastmaster())
    End Sub

    Private Sub Guna2Button38_Click(sender As Object, e As EventArgs) Handles BrewMbtn.Click
        openchildform(New BrewMaster())
    End Sub

    Private Sub Guna2Button39_Click(sender As Object, e As EventArgs) Handles Broodmotherbtn.Click
        openchildform(New Broodmother())
    End Sub

    Private Sub Guna2Button40_Click(sender As Object, e As EventArgs) Handles Abadonbtn.Click
        openchildform(New Abadon())
    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click
        openchildform(New About())
    End Sub

    Private Sub Guna2Button35_Click(sender As Object, e As EventArgs) Handles Guna2Button35.Click
        openchildform(New Chen())
    End Sub

    Private Sub Guna2Button36_Click(sender As Object, e As EventArgs) Handles Guna2Button36.Click
        openchildform(New Clock())
    End Sub

    Private Sub Guna2Button32_Click(sender As Object, e As EventArgs) Handles Guna2Button32.Click
        openchildform(New Dark())
    End Sub
End Class