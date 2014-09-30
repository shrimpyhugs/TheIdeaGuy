Public Class Skill
    Dim Skilltype As SkillTypes 'the type of skill
    Enum SkillTypes
        VideoGame 'idk about these, will work these out later
        BoardGame
        CardGame
    End Enum
    Dim SkillStrength As Integer = 1 'the strength of the skill (1-100 maybe?)
    Public Sub New(ByVal tSkillType As SkillTypes)
        Skilltype = tSkillType 'sets skill type
    End Sub


End Class
