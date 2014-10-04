<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPerk
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
        Me.lblPerkTitle = New System.Windows.Forms.Label()
        Me.lblPerkPrice = New System.Windows.Forms.Label()
        Me.lblPurchased = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPerkTitle
        '
        Me.lblPerkTitle.AutoSize = True
        Me.lblPerkTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblPerkTitle.Name = "lblPerkTitle"
        Me.lblPerkTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblPerkTitle.TabIndex = 0
        Me.lblPerkTitle.Text = "PERK TITLE"
        '
        'lblPerkPrice
        '
        Me.lblPerkPrice.AutoSize = True
        Me.lblPerkPrice.Location = New System.Drawing.Point(15, 25)
        Me.lblPerkPrice.Name = "lblPerkPrice"
        Me.lblPerkPrice.Size = New System.Drawing.Size(36, 13)
        Me.lblPerkPrice.TabIndex = 1
        Me.lblPerkPrice.Text = "$price"
        '
        'lblPurchased
        '
        Me.lblPurchased.AutoSize = True
        Me.lblPurchased.Location = New System.Drawing.Point(15, 46)
        Me.lblPurchased.Name = "lblPurchased"
        Me.lblPurchased.Size = New System.Drawing.Size(57, 13)
        Me.lblPurchased.TabIndex = 2
        Me.lblPurchased.Text = "purchased"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(18, 74)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(58, 13)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "description"
        '
        'pnlPerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblPurchased)
        Me.Controls.Add(Me.lblPerkPrice)
        Me.Controls.Add(Me.lblPerkTitle)
        Me.Name = "pnlPerk"
        Me.Size = New System.Drawing.Size(168, 162)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPerkTitle As System.Windows.Forms.Label
    Friend WithEvents lblPerkPrice As System.Windows.Forms.Label
    Friend WithEvents lblPurchased As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label

End Class
