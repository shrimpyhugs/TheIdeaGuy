Public Class Menu

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        NewGameDialog.ShowDialog() 'show game creation dialog
        'if they proceed with creating a new game
        Close()
    End Sub
End Class