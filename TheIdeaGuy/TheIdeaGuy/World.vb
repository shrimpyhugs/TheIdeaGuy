Public Class World
    'Main class for the whole project

    Public CurrentDate() As Integer = {1, 1, 2015} 'Date array that stores D/M/Y
    Public DayTicks As Integer = 10 'the number of ticks each day
    Public CurrentTick As Integer 'the current tick in the day
    Public MyProjects() As Project 'Array of Projects
    Public ProjectsTotal As Integer = 0 'number for the Projects Array
    Public MyProfile As New Profile 'creates player profile
    Public Trend As New Trends 'creates the current trends
    Public Week As Integer = 1 'week day 

    Public Sub New()
        'loading the world
        SpeedSet(1) 'set number of Ticks per day to 10
    End Sub
    Public Sub AddProject(ByVal tName As String)
        ProjectsTotal = ProjectsTotal + 1 'increase projects total
        ReDim Preserve MyProjects(ProjectsTotal) 'adds a new project
        MyProjects(ProjectsTotal - 1) = New Project 'instantiates Project
        MyProjects(ProjectsTotal - 1).Title = tName 'adds name
        MyProjects(ProjectsTotal - 1).Stage = Project.Stages.Funding 'sets project stage to funding
    End Sub

    Public Sub UpdateProjects()
        For i = 0 To (ProjectsTotal - 1)
            If MyProjects(i).Stage = Project.Stages.Funding Then
                MyProjects(i).DaysToGo = MyProjects(i).DaysToGo - 1 'removes a day

                '*****************************************************
                ' MONEY RECIEVED THAT DAY ALGORITHM
                '******************************************************

            End If
            If MyProjects(i).DaysToGo = 0 Then
                MyProjects(i).Stage = Project.Stages.Development
            End If
        Next
    End Sub

    Public Sub DateAdd()
        'Adding 1 day to the date values
        Select Case CurrentDate(1)
            Case 12 'if its the last month
                If CurrentDate(0) = 31 Then 'and its the last day of the month
                    CurrentDate(2) = CurrentDate(2) + 1 'increase the year
                    CurrentDate(1) = 1 'set it back to january
                    CurrentDate(0) = 1 ' set it back to start of month
                Else 'if it isnt end of month
                    CurrentDate(0) = CurrentDate(0) + 1 'increase the day of the month
                End If
            Case 2 'if its february
                If CurrentDate(0) = 28 Then 'and its the last day of february
                    CurrentDate(0) = 1 'set it to start of the month
                    CurrentDate(1) = 3 'set it to March
                Else 'if it isnt end of month
                    CurrentDate(0) = CurrentDate(0) + 1 'increase the day of the month
                End If
            Case 9, 4, 6, 11 '30 days has september april june and november
                If CurrentDate(0) = 30 Then 'and its the last day of the month
                    CurrentDate(0) = 1 'set it to start of the month
                    CurrentDate(1) = CurrentDate(1) + 1 'set it to next month
                Else 'if it isnt end of month
                    CurrentDate(0) = CurrentDate(0) + 1 'increase the day of the month
                End If
            Case Else 'All the rest have 31
                If CurrentDate(0) = 31 Then 'and its the last day of the month
                    CurrentDate(1) = CurrentDate(1) + 1 'set it to next month
                    CurrentDate(0) = 1 ' set it to start of month
                Else 'if it isnt end of month
                    CurrentDate(0) = CurrentDate(0) + 1 'increase the day of the month
                End If
        End Select

    End Sub

    Public Sub SpeedSet(ByVal NewTime As Double)
        DayTicks = Int(10 / NewTime) 'sets ticks per day as 10 / Time Modifier e.g (x2 = 10/2 = 5)
        If CurrentTick > DayTicks Then 'if its already passed that number
            DateAdd() 'add a new day
            CurrentTick = 0 'reset tick count
        End If
    End Sub
End Class
