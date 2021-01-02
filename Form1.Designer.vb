<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpacityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CamoflaugeModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackgroundImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundImageLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StretchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSizeToMatchImageSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.OrangeRed
        Me.ColorDialog1.FullOpen = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem, Me.ToolStripSeparator1, Me.SizeToolStripMenuItem, Me.ColorToolStripMenuItem, Me.OpacityToolStripMenuItem, Me.BorderToolStripMenuItem, Me.CamoflaugeModeToolStripMenuItem, Me.ToolStripSeparator3, Me.BackgroundImageToolStripMenuItem, Me.BackgroundImageLayoutToolStripMenuItem, Me.ClearImageToolStripMenuItem, Me.SetSizeToMatchImageSizeToolStripMenuItem, Me.ToolStripSeparator2, Me.SettingsToolStripMenuItem, Me.ResetSettingsToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(235, 366)
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Checked = True
        Me.AlwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(231, 6)
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Image = CType(resources.GetObject("SizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SizeToolStripMenuItem.Text = "Size.."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = CType(resources.GetObject("ColorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ColorToolStripMenuItem.Text = "Color.."
        '
        'OpacityToolStripMenuItem
        '
        Me.OpacityToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OpacityToolStripMenuItem.Image = CType(resources.GetObject("OpacityToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem"
        Me.OpacityToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.OpacityToolStripMenuItem.Text = "Opacity"
        '
        'BorderToolStripMenuItem
        '
        Me.BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        Me.BorderToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.BorderToolStripMenuItem.Text = "Border"
        '
        'CamoflaugeModeToolStripMenuItem
        '
        Me.CamoflaugeModeToolStripMenuItem.Name = "CamoflaugeModeToolStripMenuItem"
        Me.CamoflaugeModeToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.CamoflaugeModeToolStripMenuItem.Text = "Chameleon Mode"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(231, 6)
        '
        'BackgroundImageToolStripMenuItem
        '
        Me.BackgroundImageToolStripMenuItem.Image = CType(resources.GetObject("BackgroundImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackgroundImageToolStripMenuItem.Name = "BackgroundImageToolStripMenuItem"
        Me.BackgroundImageToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.BackgroundImageToolStripMenuItem.Text = "Background Image.."
        '
        'BackgroundImageLayoutToolStripMenuItem
        '
        Me.BackgroundImageLayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiledToolStripMenuItem, Me.CenterToolStripMenuItem, Me.StretchToolStripMenuItem, Me.ZoomToolStripMenuItem})
        Me.BackgroundImageLayoutToolStripMenuItem.Image = CType(resources.GetObject("BackgroundImageLayoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackgroundImageLayoutToolStripMenuItem.Name = "BackgroundImageLayoutToolStripMenuItem"
        Me.BackgroundImageLayoutToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.BackgroundImageLayoutToolStripMenuItem.Text = "Background Image Layout"
        '
        'TiledToolStripMenuItem
        '
        Me.TiledToolStripMenuItem.Checked = True
        Me.TiledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TiledToolStripMenuItem.Name = "TiledToolStripMenuItem"
        Me.TiledToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TiledToolStripMenuItem.Text = "Tiled"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.StretchToolStripMenuItem.Text = "Stretch"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'ClearImageToolStripMenuItem
        '
        Me.ClearImageToolStripMenuItem.Image = CType(resources.GetObject("ClearImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearImageToolStripMenuItem.Name = "ClearImageToolStripMenuItem"
        Me.ClearImageToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ClearImageToolStripMenuItem.Text = "Clear Image"
        '
        'SetSizeToMatchImageSizeToolStripMenuItem
        '
        Me.SetSizeToMatchImageSizeToolStripMenuItem.Image = CType(resources.GetObject("SetSizeToMatchImageSizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetSizeToMatchImageSizeToolStripMenuItem.Name = "SetSizeToMatchImageSizeToolStripMenuItem"
        Me.SetSizeToMatchImageSizeToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SetSizeToMatchImageSizeToolStripMenuItem.Text = "Set Size to Match Image Size"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(231, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings.."
        '
        'ResetSettingsToolStripMenuItem
        '
        Me.ResetSettingsToolStripMenuItem.Image = CType(resources.GetObject("ResetSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetSettingsToolStripMenuItem.Name = "ResetSettingsToolStripMenuItem"
        Me.ResetSettingsToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ResetSettingsToolStripMenuItem.Text = "Reset Settings.."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(231, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Blank_Hider.My.Resources.Resources.rssblk
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PictureBox1.Location = New System.Drawing.Point(225, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg|*.jpg, *.jpeg|Png|*.png|Bmp|*.bmp" &
    "|Gif|*.gif|Ico|*.ico"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dimensions"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(65, 16)
        Me.Panel1.TabIndex = 3
        '
        'MyToolTip1
        '
        Me.MyToolTip1.BackColor = System.Drawing.Color.Black
        Me.MyToolTip1.ForeColor = System.Drawing.Color.Red
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(76, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-10, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(284, 25)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(250, 250)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blank Hider"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpacityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundImageLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyToolTip1 As ToolTip
    Friend WithEvents ResetSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ClearImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetSizeToMatchImageSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CamoflaugeModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer3 As Timer
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer4 As Timer
End Class
