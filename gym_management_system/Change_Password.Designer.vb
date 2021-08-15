<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtoldp = New System.Windows.Forms.TextBox()
        Me.txtnewp = New System.Windows.Forms.TextBox()
        Me.txtcnew = New System.Windows.Forms.TextBox()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "New Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm New Password :"
        '
        'txtoldp
        '
        Me.txtoldp.Location = New System.Drawing.Point(120, 123)
        Me.txtoldp.Name = "txtoldp"
        Me.txtoldp.Size = New System.Drawing.Size(224, 22)
        Me.txtoldp.TabIndex = 5
        '
        'txtnewp
        '
        Me.txtnewp.Location = New System.Drawing.Point(120, 206)
        Me.txtnewp.Name = "txtnewp"
        Me.txtnewp.Size = New System.Drawing.Size(224, 22)
        Me.txtnewp.TabIndex = 6
        '
        'txtcnew
        '
        Me.txtcnew.Location = New System.Drawing.Point(120, 297)
        Me.txtcnew.Name = "txtcnew"
        Me.txtcnew.Size = New System.Drawing.Size(224, 22)
        Me.txtcnew.TabIndex = 7
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.Moccasin
        Me.btnchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnchange.Location = New System.Drawing.Point(108, 362)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(176, 33)
        Me.btnchange.TabIndex = 8
        Me.btnchange.Text = "Change Password "
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Coral
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclose.Location = New System.Drawing.Point(344, 362)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 33)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.gym_management_system.My.Resources.Resources.img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 452)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.txtcnew)
        Me.Controls.Add(Me.txtnewp)
        Me.Controls.Add(Me.txtoldp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtoldp As System.Windows.Forms.TextBox
    Friend WithEvents txtnewp As System.Windows.Forms.TextBox
    Friend WithEvents txtcnew As System.Windows.Forms.TextBox
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
