Public Class Heroes
    Private Sub arcwarden_Click(sender As Object, e As EventArgs) Handles arcwarden.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Ambtn.Click

    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub blood_Click(sender As Object, e As EventArgs) Handles blood.Click
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub
    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Me.Hide()
        Axe.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Alchemist.Show()
    End Sub
End Class