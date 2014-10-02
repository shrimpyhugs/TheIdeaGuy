Public Class pnlMain
    Public Shared GameWorld As New World 'create and initialise GameWorld
    Public ProfilePanel As pnlProfile 'instanciates and initialises pnlprofile
    Public ViewProjectsPanel As New pnlViewProjects 'instanciates and initialises pnlViewProjects
    Public CreateProjectPanel As New pnlCreateProject 'instanciates and initialises pnlCreateProject
    Public InGameMenuPanel As New pnlInGameMenu 'instanciates and initialises pnlInGameMenu
    Public HomePagePanel As New pnlHomePage 'instanciates and initialises pnlHomePage

    Public Sub New()
        InitializeComponent() 'oi dont touch this or i'll bite ya legs off
        pnlHolder.Controls.Add(ProfilePanel) 'starting form is Profile Panel
        Me.Dock = DockStyle.Fill 'docks to Screen
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
        pnlHolder.Controls.Add(ProfilePanel) 'add profile control
        ProfilePanel.Dock = DockStyle.Fill 'fill 'er up!
    End Sub

    Private Sub ViewProjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProjectsToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(ViewProjectsPanel) 'add View Projects control
        ViewProjectsPanel.Dock = DockStyle.Fill 'fill 'er up!
    End Sub

    Private Sub CreateNewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewProjectToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(CreateProjectPanel) 'add Create Projects control
        CreateProjectPanel.Dock = DockStyle.Fill 'fill 'er up!
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(InGameMenuPanel) 'add View InGameMenu control
        InGameMenuPanel.Dock = DockStyle.Fill 'fill 'er up!
    End Sub

    Private Sub ViewHomePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHomePageToolStripMenuItem.Click
        pnlHolder.Controls.Clear() 'remove other controls
        pnlHolder.Controls.Add(HomePagePanel) 'add HomePage control
        HomePagePanel.Dock = DockStyle.Fill 'fill 'er up!
    End Sub
End Class
