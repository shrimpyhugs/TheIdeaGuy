<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlProfile
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSkill1 = New System.Windows.Forms.Label()
        Me.lblSkill2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROFILE"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 59)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Label2"
        '
        'lblSkill1
        '
        Me.lblSkill1.AutoSize = True
        Me.lblSkill1.Location = New System.Drawing.Point(32, 119)
        Me.lblSkill1.Name = "lblSkill1"
        Me.lblSkill1.Size = New System.Drawing.Size(39, 13)
        Me.lblSkill1.TabIndex = 2
        Me.lblSkill1.Text = "Label3"
        '
        'lblSkill2
        '
        Me.lblSkill2.AutoSize = True
        Me.lblSkill2.Location = New System.Drawing.Point(32, 142)
        Me.lblSkill2.Name = "lblSkill2"
        Me.lblSkill2.Size = New System.Drawing.Size(39, 13)
        Me.lblSkill2.TabIndex = 3
        Me.lblSkill2.Text = "Label4"
        '
        'pnlProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.lblSkill2)
        Me.Controls.Add(Me.lblSkill1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pnlProfile"
        Me.Size = New System.Drawing.Size(293, 196)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSkill1 As System.Windows.Forms.Label
    Friend WithEvents lblSkill2 As System.Windows.Forms.Label

End Class
