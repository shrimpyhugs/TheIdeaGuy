﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDateLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBalanceLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.lblBalance = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMain
        '
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.CreateNewProjectToolStripMenuItem, Me.ViewProjectsToolStripMenuItem})
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
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDateLabel, Me.lblDate, Me.lblBalanceLabel, Me.lblBalance})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 281)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(649, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDateLabel
        '
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(39, 19)
        Me.lblDateLabel.Text = "DATE:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(59, 19)
        Me.lblDate.Text = "XX/XX/XX"
        '
        'lblBalanceLabel
        '
        Me.lblBalanceLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblBalanceLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.lblBalanceLabel.Name = "lblBalanceLabel"
        Me.lblBalanceLabel.Size = New System.Drawing.Size(66, 19)
        Me.lblBalanceLabel.Text = "BALANCE:"
        '
        'pnlHolder
        '
        Me.pnlHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHolder.Controls.Add(Me.StatusStrip1)
        Me.pnlHolder.Location = New System.Drawing.Point(3, 27)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(649, 303)
        Me.pnlHolder.TabIndex = 2
        '
        'lblBalance
        '
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(48, 19)
        Me.lblBalance.Text = "$XXXXX"
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
        Me.Size = New System.Drawing.Size(655, 333)
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlHolder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDateLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlHolder As System.Windows.Forms.Panel
    Friend WithEvents lblBalanceLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBalance As System.Windows.Forms.ToolStripStatusLabel

End Class
