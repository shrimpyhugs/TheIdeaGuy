Public Class pnlProfile

    Public Sub New(ByVal tGameWorld As World)
        InitializeComponent()

        lblName.Text = tGameWorld.MyProfile.CharacterName
        lblSkill1.Text = tGameWorld.MyProfile.Skills(1).SkillChoices(tGameWorld.MyProfile.Skills(1).SkillType)
        lblSkill2.Text = tGameWorld.MyProfile.Skills(2).SkillChoices(tGameWorld.MyProfile.Skills(2).SkillType)
    End Sub

End Class
