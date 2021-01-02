Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = Form1.Left
        Me.Top = Form1.Top
        Me.TopMost = True
        Me.Focus()

        If Form1.Width < 150 Then
            Me.Width = 269
        Else
            Me.Width = Form1.Width
        End If

        Dim dec As Decimal = Form1.Opacity
        TrackBar1.Value = dec * 100
        Label1.Text = TrackBar1.Value & "%"
        Label1.Left = Button1.Left + Button1.Width - Label1.Width + 6
        Me.BackColor = Form1.BackColor

        If My.Settings.ANIMAL = True Then
            Label1.ForeColor = Color.White
            Button1.ForeColor = Color.White
        Else
            Label1.ForeColor = Color.Black
            Button1.ForeColor = Color.Black
        End If

        'Me.Opacity = Form1.Opacity / 0.75
        Form1.PictureBox3.Visible = True

    End Sub

    Private Sub Form3_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Form1.Opacity = TrackBar1.Value / 100
        Label1.Text = TrackBar1.Value & "%"
        Label1.Left = Button1.Left + Button1.Width - Label1.Width + 6
        'Me.Opacity = Form1.Opacity / 0.75
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        Me.Close()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.PictureBox3.Visible = False
    End Sub
End Class