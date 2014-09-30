Public Class pnlMain
    Public GameWorld As World
    Public Sub New()
        InitializeComponent() 'oi dont touch this or i'll bite ya legs off
        pnlHolder.Controls.Add(New pnlProfile) 'starting form is Profile Panel
        Me.Dock = DockStyle.Fill 'docks to Screen
    End Sub
    Public Sub Start(ByVal tName As String, ByVal tSkill1 As Skill.SkillTypes, ByVal tSkill2 As Skill.SkillTypes)
        GameWorld = New World 'initialise GameWorld
        GameWorld.MyProfile.CharacterName = tName 'set Character Name
        GameWorld.MyProfile.Skills(0) = New Skill(tSkill1)
    End Sub
End Class
