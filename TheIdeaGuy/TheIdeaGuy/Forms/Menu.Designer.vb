<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(12, 12)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(203, 23)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 47)
        Me.Controls.Add(Me.btnNewGame)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
End Class
