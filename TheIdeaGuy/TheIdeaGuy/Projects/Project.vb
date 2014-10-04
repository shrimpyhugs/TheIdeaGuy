Public Class Project
    'a class that stores the basics for a Project, no matter what type.
    Public Title As String 'the title for the project
    Public Desc As String 'the description of the game
    Public Funding As Integer 'The amount raised thus far 
    Public Backers As Integer = 0 'The amount of backers thus far
    Public Target As Integer  'The amount needed for project to be successful
    Public DaysToGo As Integer = 30 'the amount of days left in the Fundraising stage.
    Public Popularity As Integer = 1 'the amount of popularity a project has garnered during fundraising
    Public Workers() As Worker 'array of workers to work on project
    Public Perks() As Perk 'array of Perks for the project
    Public Stage As Stages 'stage the project is in
    Enum Stages
        Preproduction
        Funding
        Development
        Released
    End Enum
    Public StageName As New Dictionary(Of Stages, String)

    Public Sub New()
        StageName.Add(Stages.Preproduction, "Preproduction")
        StageName.Add(Stages.Funding, "Funding")
        StageName.Add(Stages.Development, "Development")
        StageName.Add(Stages.Released, "Released")
    End Sub

    Public Sub Update()
        'this will have code for the update each day.
    End Sub
End Class
