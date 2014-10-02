Public Class Skill
    Public SkillType As SkillTypes 'the type of skill
    Public SkillChoices As New Dictionary(Of SkillTypes, String) 'dictionary holds the skills and their textual representations
    Enum SkillTypes
        VideoGame 'idk about these, will work these out later
        BoardGame
        CardGame
    End Enum
    Public SkillStrength As Integer = 1 'the strength of the skill (1-100 maybe?)
    Public Sub New(ByVal tSkillType As SkillTypes)
        SkillType = tSkillType 'sets skill type
        'LOAD SKILLCHOICES
        SkillChoices.Add(SkillTypes.VideoGame, "Video Games")
        SkillChoices.Add(SkillTypes.BoardGame, "Board Games")
        SkillChoices.Add(SkillTypes.CardGame, "Card Games")
    End Sub
End Class
