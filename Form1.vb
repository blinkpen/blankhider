Imports System.Drawing.Imaging
Imports Microsoft.Win32

Public Class Form1
    Dim xpos As New Integer
    Dim ypos As New Integer
    Dim pos As New Point
    Dim ALFA As Integer = 255
    Dim PICH As Integer = 0
    Dim PICW As Integer = 0
    Private backgroundImage As Image
    Dim bgimg As Image
    Dim CamoMode As Boolean = False
    Public thickness As Integer = 2
    Dim borderTop As New Panel
    Dim borderBottom As New Panel
    Dim borderRight As New Panel
    Dim borderLeft As New Panel
    Dim ALFA2 As Integer = 255
    Dim ALFA3 As Integer = 255
    Dim PermaBorders As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        Panel1.Visible = False
        Label1.Visible = False
        MyToolTip1.Hide(Label1)
        PictureBox1.Parent = Me
        'PictureBox2.Dock = DockStyle.Fill
        'PictureBox2.SendToBack()
        'PictureBox2.Parent = Me
        ColorDialog1.Color = My.Settings.color

        Label1.Text = Me.Width & " x " & Me.Height

        If My.Settings.ANIMAL = False Then
            PictureBox1.BackgroundImage = My.Resources.rssblk
            Label1.ForeColor = Color.Black
        ElseIf My.Settings.ANIMAL = True Then
            PictureBox1.BackgroundImage = My.Resources.rsswte
            Label1.ForeColor = Color.White
        End If

        Me.BackColor = My.Settings.color

        Me.Width = My.Settings.width
        Me.Height = My.Settings.height

        If My.Settings.topmost = True Then
            Me.TopMost = True
            AlwaysOnTopToolStripMenuItem.Checked = True
        ElseIf My.Settings.topmost = False Then
            Me.TopMost = False
            AlwaysOnTopToolStripMenuItem.Checked = False
        End If

        If My.Settings.bgimglyt = "A" Then
            TiledToolStripMenuItem.Checked = True
            CenterToolStripMenuItem.Checked = False
            StretchToolStripMenuItem.Checked = False
            ZoomToolStripMenuItem.Checked = False
            Me.BackgroundImageLayout = ImageLayout.Tile
        ElseIf My.Settings.bgimglyt = "B" Then
            TiledToolStripMenuItem.Checked = False
            CenterToolStripMenuItem.Checked = True
            StretchToolStripMenuItem.Checked = False
            ZoomToolStripMenuItem.Checked = False
            Me.BackgroundImageLayout = ImageLayout.Center
        ElseIf My.Settings.bgimglyt = "C" Then
            TiledToolStripMenuItem.Checked = False
            CenterToolStripMenuItem.Checked = False
            StretchToolStripMenuItem.Checked = True
            ZoomToolStripMenuItem.Checked = False
            Me.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf My.Settings.bgimglyt = "D" Then
            TiledToolStripMenuItem.Checked = False
            CenterToolStripMenuItem.Checked = False
            StretchToolStripMenuItem.Checked = False
            ZoomToolStripMenuItem.Checked = True
            Me.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
            OpacityToolStripMenuItem.Text = "Opacity (Currently at " & Me.Opacity * 100 & "%)"
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        My.Settings.color = ColorDialog1.Color
        Me.BackColor = My.Settings.color
        Panel1.BackColor = My.Settings.color

        Dim ANIMAL As String = My.Settings.color.GetBrightness.ToString()

        If ANIMAL < 0.5 Then
            PictureBox1.BackgroundImage = My.Resources.rsswte
            My.Settings.ANIMAL = True
            Label1.ForeColor = Color.White
        Else
            PictureBox1.BackgroundImage = My.Resources.rssblk
            My.Settings.ANIMAL = False
            Label1.ForeColor = Color.Black
        End If
        If PermaBorders = True Then
            TurnOffBorders()
            TurnOnBorders()
        Else
        End If

    End Sub

    Private Sub BackgroundImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundImageToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        xpos = Cursor.Position.X - Me.Location.X
        ypos = Cursor.Position.Y - Me.Location.Y

        If Application.OpenForms().OfType(Of Form3).Any Then
            Form3.Close()
        End If

        If e.Button = MouseButtons.Left Then
            Panel1.Parent = Label1
            Label1.Visible = True
            Label1.BackColor = Me.BackColor
            Panel1.BackColor = Color.Transparent
            Label1.Text = Me.Left & " x " & Me.Top
            Label1.Top = thickness
            Label1.Left = thickness
            Panel1.Top = thickness
            Panel1.Left = thickness
            TurnOnBorders()
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - xpos
            pos.Y = pos.Y - ypos
            Me.Location = pos

            If Me.Width < 50 Then
                MyToolTip1.Show(Label1.Text, Label1, Label1.Left, Label1.Top, 100)
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Timer2.Stop()
        ALFA = 255

        xpos = Cursor.Position.X - Me.Width
        ypos = Cursor.Position.Y - Me.Height
        Timer1.Start()
        Timer2.Stop()
        Label1.Visible = True
        Label1.BackColor = Me.BackColor
        Panel1.Visible = False
        If Application.OpenForms().OfType(Of Form3).Any Then
            Form3.Close()
        End If

        Label1.Top = thickness
        Label1.Left = thickness
        Panel1.Top = thickness
        Panel1.Left = thickness

        TurnOnBorders()
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Timer1.Stop()
        ALFA = 255
        My.Settings.width = Me.Width
        My.Settings.height = Me.Height

        If Timer2.Enabled = True Then
            Timer2.Stop()
        ElseIf Timer2.Enabled = False Then
            Timer2.Start()
        End If

        Timer3.Start()
        Timer4.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pos = MousePosition
        pos.X = pos.X - xpos
        pos.Y = pos.Y - ypos
        Me.Width = pos.X
        Me.Height = pos.Y

        Panel1.Parent = Label1
        Panel1.BackColor = Color.Transparent
        Label1.Text = Me.Width & " x " & Me.Height

        If Me.Width < 50 Then
            MyToolTip1.Show(Label1.Text, Label1, Label1.Left, Label1.Top, 100)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If My.Settings.topmost = True Then
            My.Settings.topmost = False
        ElseIf My.Settings.topmost = False Then
            My.Settings.topmost = True
        End If

        If My.Settings.topmost = True Then
            Me.TopMost = True
            AlwaysOnTopToolStripMenuItem.Checked = True
        ElseIf My.Settings.topmost = False Then
            Me.TopMost = False
            AlwaysOnTopToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel1.Parent = Label1
        ALFA -= 15
        Dim BC As Color = Color.FromArgb(Me.BackColor.ToArgb)

        If Me.backgroundImage Is Nothing Then
            Try
                Panel1.BackColor = Color.FromArgb(ALFA, BC)
            Catch ex As Exception

            End Try

        Else
            Try
                Panel1.Visible = False
                Label1.BackColor = Color.FromArgb(ALFA, BC)
            Catch ex As Exception

            End Try
        End If

        If ALFA <= 0 Then
            Timer2.Stop()
            ALFA = 255
            Label1.Visible = False
            Panel1.Visible = False
        End If
    End Sub

    'Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
    '    xpos = Cursor.Position.X - Me.Width
    '    ypos = Cursor.Position.Y - Me.Height
    'End Sub

    'Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        pos = MousePosition
    '        pos.X = pos.X - xpos
    '        pos.Y = pos.Y - ypos
    '        Me.Location = pos
    '    End If
    'End Sub

    'Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
    '    xpos = Cursor.Position.X - Me.Width
    '    ypos = Cursor.Position.Y - Me.Height
    'End Sub

    'Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        pos = MousePosition
    '        pos.X = pos.X - xpos
    '        pos.Y = pos.Y - ypos
    '        Me.Location = pos
    '    End If
    'End Sub

    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to reset settings back to default? All your changes will be reverted back.", "Reset Settings?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
            MsgBox("Settings were not reset.")
        ElseIf result = DialogResult.Yes Then
            My.Settings.Reset()
            Me.Width = My.Settings.width
            Me.Height = My.Settings.height
            Me.BackColor = My.Settings.color
            If My.Settings.topmost = True Then
                Me.TopMost = True
                AlwaysOnTopToolStripMenuItem.Checked = True
            Else
                Me.TopMost = False
                AlwaysOnTopToolStripMenuItem.Checked = False
            End If
            PictureBox1.BackgroundImage = My.Resources.rssblk
            Label1.ForeColor = Color.Black
            TiledToolStripMenuItem.Checked = True
            CenterToolStripMenuItem.Checked = False
            StretchToolStripMenuItem.Checked = False
            ZoomToolStripMenuItem.Checked = False
            Me.BackgroundImageLayout = ImageLayout.Tile
            MsgBox("The settings have been successfully reset.")
        End If
    End Sub

    Private Sub TiledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiledToolStripMenuItem.Click
        My.Settings.bgimglyt = "A"
        TiledToolStripMenuItem.Checked = True
        CenterToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        Me.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        My.Settings.bgimglyt = "B"
        TiledToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = True
        StretchToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        Me.BackgroundImageLayout = ImageLayout.Center
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        My.Settings.bgimglyt = "C"
        TiledToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = True
        ZoomToolStripMenuItem.Checked = False
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        My.Settings.bgimglyt = "D"
        TiledToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = True
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        CamoMode = False
        CamoflaugeModeToolStripMenuItem.Checked = False
        backgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        PICW = Image.FromFile(OpenFileDialog1.FileName).Width
        PICH = Image.FromFile(OpenFileDialog1.FileName).Height
        bgimg = Image.FromFile(OpenFileDialog1.FileName)
        Me.Refresh()
    End Sub

    Private Sub ClearImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearImageToolStripMenuItem.Click
        If CamoMode = True Then
            CamoflaugeModeToolStripMenuItem.Checked = False
            CamoMode = False
            Me.Refresh()

            Dim result As DialogResult = MessageBox.Show("This will clear this background image. Are you sure that you want to do this?", "Hold up, yo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Me.backgroundImage = Nothing
            End If
            Me.Refresh()
        Else
            Me.backgroundImage = Nothing
            Me.Refresh()
        End If
    End Sub

    Private Sub SetSizeToMatchImageSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSizeToMatchImageSizeToolStripMenuItem.Click
        If PICH = 0 Or PICW = 0 Then
            MsgBox("There is no background image selected. Size was not adjusted.")
        Else
            Me.Width = PICW
            Me.Height = PICH
        End If
        Timer2.Start()
    End Sub

    Private Sub OpacityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpacityToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Function GetCurrentWallpaper() As String
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Return WallpaperPath
    End Function

    Private Sub CamoflaugeModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CamoflaugeModeToolStripMenuItem.Click
        If CamoflaugeModeToolStripMenuItem.Checked = True Then
            CamoflaugeModeToolStripMenuItem.Checked = False
            CamoMode = False
        Else
            CamoflaugeModeToolStripMenuItem.Checked = True
            CamoMode = True
            Me.backgroundImage = Image.FromFile(GetCurrentWallpaper)
        End If
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        If CamoMode = True Then
            MyBase.OnPaintBackground(e)
            Dim rc = New Rectangle(-Me.Left, -Me.Top, backgroundImage.Width, backgroundImage.Height)
            e.Graphics.DrawImage(backgroundImage, rc)
        ElseIf CamoMode = False Then
            If Me.backgroundImage Is Nothing Then
                e.Graphics.Clear(My.Settings.color)
            Else
                e.Graphics.Clear(My.Settings.color)
                If OpenFileDialog1.FileName = "" Then
                Else
                    Dim rc2 = New Rectangle(-Me.Left, -Me.Top, bgimg.Width, bgimg.Height)
                    e.Graphics.DrawImage(bgimg, rc2)
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        Panel1.Parent = Label1
        Label1.Visible = True
        Label1.BackColor = Me.BackColor
        Panel1.BackColor = Color.Transparent
        Label1.Text = Me.Left & " x " & Me.Top
        Label1.Top = thickness
        Label1.Left = thickness
        Panel1.Top = thickness
        Panel1.Left = thickness
        TurnOnBorders()
        Me.Refresh()
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        If BorderToolStripMenuItem.Checked = True Then
            BorderToolStripMenuItem.Checked = False
            PermaBorders = False
            TurnOffBorders()
        Else
            BorderToolStripMenuItem.Checked = True
            PermaBorders = True
            TurnOnBorders()
        End If
    End Sub

    Private Sub TurnOnBorders()
        borderTop.Top = 0
        borderTop.Left = 0
        borderTop.Width = Me.Width
        borderTop.Height = thickness
        borderTop.BackColor = My.Settings.color

        borderBottom.Top = Me.Height - thickness
        borderBottom.Left = 0
        borderBottom.Width = Me.Width
        borderBottom.Height = thickness
        borderBottom.BackColor = My.Settings.color

        borderRight.Top = 0
        borderRight.Left = Me.Width - thickness
        borderRight.Width = thickness
        borderRight.Height = Me.Height
        borderRight.BackColor = My.Settings.color

        borderLeft.Top = 0
        borderLeft.Left = 0
        borderLeft.Width = thickness
        borderLeft.Height = Me.Height
        borderLeft.BackColor = My.Settings.color

        Me.Controls.Add(borderTop)
        Me.Controls.Add(borderBottom)
        Me.Controls.Add(borderRight)
        Me.Controls.Add(borderLeft)

        PictureBox1.SendToBack()
    End Sub

    Private Sub TurnOffBorders()
        Me.Controls.Remove(borderTop)
        Me.Controls.Remove(borderBottom)
        Me.Controls.Remove(borderRight)
        Me.Controls.Remove(borderLeft)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TurnOnBorders()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If PermaBorders = True Then
        Else
            ALFA2 -= 15

            Dim BC As Color = Color.FromArgb(Me.BackColor.ToArgb)
            If Me.backgroundImage Is Nothing Then
                If PermaBorders = True Then
                Else
                    TurnOffBorders()
                End If
            Else
                Try
                    borderTop.BackColor = Color.FromArgb(ALFA2, BC)
                    borderLeft.BackColor = Color.FromArgb(ALFA2, BC)
                Catch ex As Exception

                End Try
            End If

            If ALFA2 <= 0 Then
                Timer3.Stop()

                TurnOffBorders()

                ALFA2 = 255
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If PermaBorders = True Then
        Else
            ALFA3 -= 15

            Dim BC As Color = Color.FromArgb(Me.BackColor.ToArgb)
            If Me.backgroundImage Is Nothing Then
                If PermaBorders = True Then
                Else
                    TurnOffBorders()
                End If
            Else
                Try
                    borderRight.BackColor = Color.FromArgb(ALFA2, BC)
                    borderBottom.BackColor = Color.FromArgb(ALFA2, BC)
                Catch ex As Exception

                End Try
            End If

            If ALFA3 <= 0 Then
                Timer4.Stop()
                If PermaBorders = True Then
                Else
                    TurnOffBorders()
                End If
                ALFA3 = 255
            End If
        End If
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If CamoMode = True Then
            Me.backgroundImage = Image.FromFile(GetCurrentWallpaper)
        End If
    End Sub
End Class
