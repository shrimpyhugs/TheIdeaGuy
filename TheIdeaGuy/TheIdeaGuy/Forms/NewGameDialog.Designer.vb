<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGameDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSkillRandom = New System.Windows.Forms.Button()
        Me.cbxSkill1 = New System.Windows.Forms.ComboBox()
        Me.cbxSkill2 = New System.Windows.Forms.ComboBox()
        Me.SkillTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SkillTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(200, 134)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Starting Skills"
        '
        'BtnSkillRandom
        '
        Me.BtnSkillRandom.Location = New System.Drawing.Point(12, 140)
        Me.BtnSkillRandom.Name = "BtnSkillRandom"
        Me.BtnSkillRandom.Size = New System.Drawing.Size(120, 23)
        Me.BtnSkillRandom.TabIndex = 6
        Me.BtnSkillRandom.Text = "Randomize Skills"
        Me.BtnSkillRandom.UseVisualStyleBackColor = True
        '
        'cbxSkill1
        '
        Me.cbxSkill1.FormattingEnabled = True
        Me.cbxSkill1.Items.AddRange(New Object() {"Video Games", "Board Games", "Card Games"})
        Me.cbxSkill1.Location = New System.Drawing.Point(12, 89)
        Me.cbxSkill1.Name = "cbxSkill1"
        Me.cbxSkill1.Size = New System.Drawing.Size(121, 21)
        Me.cbxSkill1.TabIndex = 7
        '
        'cbxSkill2
        '
        Me.cbxSkill2.FormattingEnabled = True
        Me.cbxSkill2.Items.AddRange(New Object() {"Video Games", "Board Games", "Card Games"})
        Me.cbxSkill2.Location = New System.Drawing.Point(12, 116)
        Me.cbxSkill2.Name = "cbxSkill2"
        Me.cbxSkill2.Size = New System.Drawing.Size(121, 21)
        Me.cbxSkill2.TabIndex = 8
        '
        'SkillTypesBindingSource
        '
        Me.SkillTypesBindingSource.DataSource = GetType(TheIdeaGuy.Skill.SkillTypes)
        '
        'NewGameDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(358, 175)
        Me.Controls.Add(Me.cbxSkill2)
        Me.Controls.Add(Me.cbxSkill1)
        Me.Controls.Add(Me.BtnSkillRandom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewGameDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Game!"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SkillTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSkillRandom As System.Windows.Forms.Button
    Friend WithEvents cbxSkill1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSkill2 As System.Windows.Forms.ComboBox
    Friend WithEvents SkillTypesBindingSource As System.Windows.Forms.BindingSource

End Class
