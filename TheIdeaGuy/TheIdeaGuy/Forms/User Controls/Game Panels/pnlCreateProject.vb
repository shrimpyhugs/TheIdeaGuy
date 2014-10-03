Public Class pnlCreateProject
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        pnlMain.GameWorld.addProject(TextBox1.Text) 'adds project with project name
    End Sub
End Class
