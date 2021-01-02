Public Class Form4
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Panel1.Height = TrackBar1.Value
        Panel2.Width = TrackBar1.Value
        Panel3.Width = TrackBar1.Value
        Panel4.Height = TrackBar1.Value
        Form1.thickness = TrackBar1.Value
        Label1.Text = Form1.thickness & "px"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.TopMost = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

        Panel1.BackColor = Form1.BackColor
        Panel2.BackColor = Form1.BackColor
        Panel3.BackColor = Form1.BackColor
        Panel4.BackColor = Form1.BackColor
        TrackBar1.Value = Form1.thickness

        Panel1.Height = TrackBar1.Value
        Panel2.Width = TrackBar1.Value
        Panel3.Width = TrackBar1.Value
        Panel4.Height = TrackBar1.Value
        Label1.Text = Form1.thickness & "px"
    End Sub
End Class