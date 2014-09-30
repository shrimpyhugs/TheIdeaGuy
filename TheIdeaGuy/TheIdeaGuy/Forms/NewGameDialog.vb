Imports System.Windows.Forms

Public Class NewGameDialog
    Dim Skill1Previous As Integer 'stores skill 1's previous result for comparison
    Dim Skill2Previous As Integer 'stores skill 2's previous result for comparison
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtName.Text IsNot "" Then 'if Name has been specified

            Screen.Controls.Clear() 'remove main menu
            Screen.Controls.Add(New pnlMain) 'adds main game panel

            Me.Close() 'closes the Dialog
        Else 'error message
            MsgBox("You need to specify a Name for your character!", vbOKOnly, "Name Required!")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close() 'close dialog
    End Sub

    Private Sub BtnSkillRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSkillRandom.Click
        Randomize()
        'randomize the skill selections
        Dim Skill1 As Integer = Int(Rnd() * 3) 'randomize skill1
        Dim Skill2 As Integer = Int(Rnd() * 3) 'randomize skill 2
        'make sure they're not the same, repeat until different
        Do While (Skill1 = Skill2)
            Skill2 = Int(Rnd() * 3)
        Loop

        cbxSkill1.SelectedIndex = Skill1 'set skill 1
        cbxSkill2.SelectedIndex = Skill2 'set skill 2
    End Sub

    Private Sub cbxSkill1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxSkill1.SelectedIndexChanged
        If cbxSkill1.SelectedIndex = cbxSkill2.SelectedIndex Then 'if selections are the same
            MsgBox("You Cannot have two of the same skill!", vbOKOnly, "Same Skill!")
            cbxSkill1.SelectedIndex = Skill1Previous 'set it to previous selection
        Else 'let it pass, update skill1Previous
            Skill1Previous = cbxSkill1.SelectedIndex
        End If
    End Sub

    Private Sub cbxSkill2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxSkill2.SelectedIndexChanged
        If cbxSkill1.SelectedIndex = cbxSkill2.SelectedIndex Then 'if selections are the same
            MsgBox("You Cannot have two of the same skill!", vbOKOnly, "Same Skill!")
            cbxSkill2.SelectedIndex = Skill2Previous 'set it to previous selection
        Else 'let it pass, update skill1Previous
            Skill2Previous = cbxSkill2.SelectedIndex
        End If
    End Sub
End Class
