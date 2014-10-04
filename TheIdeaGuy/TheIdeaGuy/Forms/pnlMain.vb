Public Class pnlMain
    Public Shared GameWorld As New World 'create and initialise GameWorld
    Public WithEvents WorldTimer As New Timer 'Timer for all events in the world
    Public ProfilePanel As pnlProfile 'instanciates and initialises pnlprofile
    Public ViewProjectsPanel As New pnlViewProjects 'instanciates and initialises pnlViewProjects
    Public CreateProjectPanel As New pnlCreateProject 'instanciates and initialises pnlCreateProject
    Public InGameMenuPanel As New pnlInGameMenu 'instanciates and initialises pnlInGameMenu
    Public HomePagePanel As New pnlHomePage 'instanciates and initialises pnlHomePage

    Public Sub New()
        InitializeComponent() 'oi dont touch this or i'll bite ya legs off
        pnlHolder.Controls.Add(ProfilePanel) 'starting form is Profile Panel
        WorldTimer.Interval() = 1000 'sets Timer Tick every second
        WorldTimer.Enabled = True 'starts the timer
        lblDate.Text = Str(GameWorld.CurrentDate(0)) + "/" + Str(GameWorld.CurrentDate(1)) + "/" + Str(GameWorld.CurrentDate(2)) 'set the date pls
        Me.Dock = DockStyle.Fill 'docks to Screen
    End Sub

    Public Sub WorldUpdate() Handles WorldTimer.Tick 'whenever the timer ticks over, update.
        GameWorld.CurrentTick = GameWorld.CurrentTick + 1 'increase CurrentTick
        ProfilePanel.lblName.Text = Str(GameWorld.CurrentTick) + "/" + Str(GameWorld.DayTicks)
        lblBalance.Text = "$" + Str(GameWorld.MyProfile.Balance) 'loads the balance
        ViewProjectsPanel.ListBox1.Items.Clear() 'clears projects
        If pnlHolder.Controls.Contains(ViewProjectsPanel) Then 'if in View Projects 
            'display test stuffs
            For i = 0 To (GameWorld.ProjectsTotal - 1) 'for every project
                ViewProjectsPanel.ListBox1.Items.Add(GameWorld.MyProjects(i).Title)
                ViewProjectsPanel.ListBox1.Items.Add(Str(GameWorld.MyProjects(i).DaysToGo))
                ViewProjectsPanel.ListBox1.Items.Add(GameWorld.MyProjects(i).StageName(GameWorld.MyProjects(i).Stage))
            Next
        End If
        If GameWorld.CurrentTick = GameWorld.DayTicks Then 'if its a new day
            GameWorld.DateAdd() 'add a day
            GameWorld.UpdateProjects() 'updates the projects on new 
            GameWorld.Week = GameWorld.Week + 1 'update day of the week
            If GameWorld.Week = 8 Then
                GameWorld.Week = 1 'start the week again
                GameWorld.Trend.UpdateTrends() 'updates the trends for new week
            End If

            'updating Date
            lblDate.Text = Str(GameWorld.CurrentDate(0)) + "/" + Str(GameWorld.CurrentDate(1)) + "/" + Str(GameWorld.CurrentDate(2))
            GameWorld.CurrentTick = 0 'reset CurrentTicks
        End If
    End Sub
    Public Sub Start(ByVal tName As String, ByVal tSkill1 As Skill.SkillTypes, ByVal tSkill2 As Skill.SkillTypes)
        GameWorld.MyProfile.CharacterName = tName 'set Character Name
        GameWorld.MyProfile.Skills(1) = New Skill(tSkill1)
        GameWorld.MyProfile.Skills(2) = New Skill(tSkill2)
        ProfilePanel = New pnlProfile(GameWorld)

        pnlHolder.Controls.Add(ProfilePanel)
        ProfilePanel.Dock = DockStyle.Fill
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(StatusStrip1) 'readd that status strip lol
        pnlHolder.Controls.Add(ProfilePanel) 'add profile control
        ProfilePanel.Dock = DockStyle.Fill 'fill 'er up!

    End Sub

    Private Sub ViewProjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProjectsToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(StatusStrip1) 'readd that status strip lol
        pnlHolder.Controls.Add(ViewProjectsPanel) 'add View Projects control
        ViewProjectsPanel.Dock = DockStyle.Fill 'fill 'er up!

    End Sub

    Private Sub CreateNewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewProjectToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(StatusStrip1) 'readd that status strip lol
        pnlHolder.Controls.Add(CreateProjectPanel) 'add Create Projects control
        CreateProjectPanel.Dock = DockStyle.Fill 'fill 'er up!

    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(StatusStrip1) 'readd that status strip lol
        pnlHolder.Controls.Add(InGameMenuPanel) 'add View InGameMenu control
        InGameMenuPanel.Dock = DockStyle.Fill 'fill 'er up!

    End Sub

    Private Sub ViewHomePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHomePageToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(StatusStrip1) 'readd that status strip lol
        pnlHolder.Controls.Add(HomePagePanel) 'add HomePage control
        HomePagePanel.Dock = DockStyle.Fill 'fill 'er up!

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(0.25) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Really Slow" 'display the set speed
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(0.5) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Slow" 'display the set speed
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(1) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Normal" 'display the set speed
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(2) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Fast" 'display the set speed
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(3) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Very Fast" 'display the set speed
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        If WorldTimer.Enabled = False Then WorldTimer.Start() 'makes sure the timer is running
        GameWorld.SpeedSet(10) 'set game speed
        GameSpeedToolStripMenuItem.Text = "Game Speed: Super Fast" 'display the set speed
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        WorldTimer.Stop() 'pauses
    End Sub
End Class
