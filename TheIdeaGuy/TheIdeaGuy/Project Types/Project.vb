﻿Public Class Project
    'a class that stores the basics for a Project, no matter what type.
    Dim Funding As Integer 'The amount raised thus far 
    Dim Backers As Integer = 0 'The amount of backers thus far
    Dim Target As Integer  'The amount needed for project to be successful
    Dim DaysToGo As Integer = 30 'the amount of days left in the Fundraising stage.
    Dim Popularity As Integer = 1 'the amount of popularity a project has garnered during fundraising

    Public Sub Update()
        'this will have code for the update each day.
    End Sub
End Class