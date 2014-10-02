<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnViewProject = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnViewProject
        '
        Me.btnViewProject.Location = New System.Drawing.Point(78, 165)
        Me.btnViewProject.Name = "btnViewProject"
        Me.btnViewProject.Size = New System.Drawing.Size(75, 23)
        Me.btnViewProject.TabIndex = 0
        Me.btnViewProject.Text = "View Project"
        Me.btnViewProject.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 136)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(234, 23)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 75
        '
        'ProfileBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnViewProject)
        Me.Name = "ProfileBox"
        Me.Size = New System.Drawing.Size(240, 201)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnViewProject As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
