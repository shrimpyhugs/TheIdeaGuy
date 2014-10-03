<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlMain
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuMain = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDateLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBalanceLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBalance = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMain.SuspendLayout()
        Me.pnlHolder.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMain
        '
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.CreateNewProjectToolStripMenuItem, Me.ViewProjectsToolStripMenuItem, Me.ViewHomePageToolStripMenuItem, Me.GameSpeedToolStripMenuItem})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Size = New System.Drawing.Size(655, 24)
        Me.MenuMain.TabIndex = 0
        Me.MenuMain.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'CreateNewProjectToolStripMenuItem
        '
        Me.CreateNewProjectToolStripMenuItem.Name = "CreateNewProjectToolStripMenuItem"
        Me.CreateNewProjectToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.CreateNewProjectToolStripMenuItem.Text = "Create New Project"
        '
        'ViewProjectsToolStripMenuItem
        '
        Me.ViewProjectsToolStripMenuItem.Name = "ViewProjectsToolStripMenuItem"
        Me.ViewProjectsToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ViewProjectsToolStripMenuItem.Text = "View Projects"
        '
        'ViewHomePageToolStripMenuItem
        '
        Me.ViewHomePageToolStripMenuItem.Name = "ViewHomePageToolStripMenuItem"
        Me.ViewHomePageToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ViewHomePageToolStripMenuItem.Text = "View Home Page"
        '
        'GameSpeedToolStripMenuItem
        '
        Me.GameSpeedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PauseToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem8})
        Me.GameSpeedToolStripMenuItem.Name = "GameSpeedToolStripMenuItem"
        Me.GameSpeedToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.GameSpeedToolStripMenuItem.Text = "Game Speed: Normal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "really slow"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "slow"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "normal"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "Fast"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem6.Text = "Very Fast"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem8.Text = "Super Fast"
        '
        'pnlHolder
        '
        Me.pnlHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHolder.Controls.Add(Me.StatusStrip1)
        Me.pnlHolder.Location = New System.Drawing.Point(3, 27)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(649, 313)
        Me.pnlHolder.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDateLabel, Me.lblDate, Me.lblBalanceLabel, Me.lblBalance})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 291)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(649, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDateLabel
        '
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(39, 17)
        Me.lblDateLabel.Text = "DATE:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(59, 17)
        Me.lblDate.Text = "XX/XX/XX"
        '
        'lblBalanceLabel
        '
        Me.lblBalanceLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblBalanceLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.lblBalanceLabel.Name = "lblBalanceLabel"
        Me.lblBalanceLabel.Size = New System.Drawing.Size(66, 17)
        Me.lblBalanceLabel.Text = "BALANCE:"
        '
        'lblBalance
        '
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(48, 17)
        Me.lblBalance.Text = "$XXXXX"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'pnlMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.pnlHolder)
        Me.Controls.Add(Me.MenuMain)
        Me.Name = "pnlMain"
        Me.Size = New System.Drawing.Size(655, 341)
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.pnlHolder.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHolder As System.Windows.Forms.Panel
    Friend WithEvents ViewHomePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameSpeedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDateLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBalanceLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBalance As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
