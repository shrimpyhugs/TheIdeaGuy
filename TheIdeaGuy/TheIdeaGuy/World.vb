Public Class World
    'Main class for the whole project
    Public WithEvents WorldTimer As Timer
    Dim CurrentDate() As Integer = {1, 1, 2015} 'Date array that stores D/M/Y
    Dim DayTicks As Integer = 10 'the number of ticks each day
    Dim CurrentTick As Integer = 0 'the current tick in the day

    Public Sub New()

        'loading the world
        TimeSet(1) 'set number of Ticks per day to 10
        WorldTimer.Interval() = 100 'sets Timer Tick every second
        WorldTimer.Enabled = True 'starts the timer
    End Sub

    Public Sub Update() Handles WorldTimer.Tick 'whenever the timer ticks over, update.
        CurrentTick = CurrentTick + 1 'increase CurrentTick

        If CurrentTick = DayTicks Then 'if its a new day

            'updating each Day

            CurrentTick = 0 'reset CurrentTicks
            DateAdd() 'add a day
        End If
    End Sub

    Public Sub DateAdd()
        'Adding 1 day to the date values
        Select CurrentDate(2)
            Case 12 'if its the last month
                If CurrentDate(1) = 31 Then 'and its the last day of the month
                    CurrentDate(3) = CurrentDate(3) + 1 'increase the year
                    CurrentDate(2) = 1 'set it back to january
                    CurrentDate(1) = 1 ' set it back to start of month
                Else 'if it isnt end of month
                    CurrentDate(1) = CurrentDate(1) + 1 'increase the day of the month
                End If
            Case 2 'if its february
                If CurrentDate(1) = 28 Then 'and its the last day of february
                    CurrentDate(1) = 1 'set it to start of the month
                    CurrentDate(2) = 3 'set it to March
                Else 'if it isnt end of month
                    CurrentDate(1) = CurrentDate(1) + 1 'increase the day of the month
                End If
            Case 9, 4, 6, 11 '30 days has september april june and november
                If CurrentDate(1) = 30 Then 'and its the last day of the month
                    CurrentDate(1) = 1 'set it to start of the month
                    CurrentDate(2) = CurrentDate(2) + 1 'set it to next month
                Else 'if it isnt end of month
                    CurrentDate(1) = CurrentDate(1) + 1 'increase the day of the month
                End If
            Case Else 'All the rest have 31
                If CurrentDate(1) = 31 Then 'and its the last day of the month
                    CurrentDate(2) = CurrentDate(2) + 1 'set it to next month
                    CurrentDate(1) = 1 ' set it to start of month
                Else 'if it isnt end of month
                    CurrentDate(1) = CurrentDate(1) + 1 'increase the day of the month
                End If
        End Select

    End Sub

    Public Sub TimeSet(ByVal NewTime As Integer)
        DayTicks = NewTime * 10 'sets ticks per day as 10 * new time multiplier
    End Sub
End Class
