<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTrainerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerSalaryDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddWorkoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerSalaryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.TrainerToolStripMenuItem1, Me.WorkoutToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(12, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1866, 38)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.ExitToolStripMenuItem2, Me.OtherAdminToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(108, 32)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.AddCustomerToolStripMenuItem.Text = "Add Customer"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(210, 32)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'OtherAdminToolStripMenuItem
        '
        Me.OtherAdminToolStripMenuItem.Name = "OtherAdminToolStripMenuItem"
        Me.OtherAdminToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.OtherAdminToolStripMenuItem.Text = "Other Admin"
        '
        'TrainerToolStripMenuItem1
        '
        Me.TrainerToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTrainerToolStripMenuItem1, Me.TrainerSalaryDetailsToolStripMenuItem1})
        Me.TrainerToolStripMenuItem1.Name = "TrainerToolStripMenuItem1"
        Me.TrainerToolStripMenuItem1.Size = New System.Drawing.Size(82, 32)
        Me.TrainerToolStripMenuItem1.Text = "Trainer"
        '
        'AddTrainerToolStripMenuItem1
        '
        Me.AddTrainerToolStripMenuItem1.Name = "AddTrainerToolStripMenuItem1"
        Me.AddTrainerToolStripMenuItem1.Size = New System.Drawing.Size(264, 32)
        Me.AddTrainerToolStripMenuItem1.Text = "Add Trainer"
        '
        'TrainerSalaryDetailsToolStripMenuItem1
        '
        Me.TrainerSalaryDetailsToolStripMenuItem1.Name = "TrainerSalaryDetailsToolStripMenuItem1"
        Me.TrainerSalaryDetailsToolStripMenuItem1.Size = New System.Drawing.Size(264, 32)
        Me.TrainerSalaryDetailsToolStripMenuItem1.Text = "Trainer Salary Details"
        '
        'WorkoutToolStripMenuItem
        '
        Me.WorkoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddWorkoutToolStripMenuItem, Me.WoToolStripMenuItem})
        Me.WorkoutToolStripMenuItem.Name = "WorkoutToolStripMenuItem"
        Me.WorkoutToolStripMenuItem.Size = New System.Drawing.Size(101, 32)
        Me.WorkoutToolStripMenuItem.Text = "Workout"
        '
        'AddWorkoutToolStripMenuItem
        '
        Me.AddWorkoutToolStripMenuItem.Name = "AddWorkoutToolStripMenuItem"
        Me.AddWorkoutToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.AddWorkoutToolStripMenuItem.Text = "Add Workout"
        '
        'WoToolStripMenuItem
        '
        Me.WoToolStripMenuItem.Name = "WoToolStripMenuItem"
        Me.WoToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.WoToolStripMenuItem.Text = "Update Fees"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReportToolStripMenuItem, Me.TrainerReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(91, 32)
        Me.ReportToolStripMenuItem.Text = "Reports"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(232, 32)
        Me.CustomerReportToolStripMenuItem.Text = "Customer Report"
        '
        'TrainerReportToolStripMenuItem
        '
        Me.TrainerReportToolStripMenuItem.Name = "TrainerReportToolStripMenuItem"
        Me.TrainerReportToolStripMenuItem.Size = New System.Drawing.Size(232, 32)
        Me.TrainerReportToolStripMenuItem.Text = "Trainer Report"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(176, 32)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CustomerEntryToolStripMenuItem
        '
        Me.CustomerEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.CustomerEntryToolStripMenuItem.Name = "CustomerEntryToolStripMenuItem"
        Me.CustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(96, 32)
        Me.CustomerEntryToolStripMenuItem.Text = "Custmer"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ExitToolStripMenuItem.Text = "Add Customer"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(173, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(82, 32)
        Me.TrainerToolStripMenuItem.Text = "Trainer"
        '
        'AddTrainerToolStripMenuItem
        '
        Me.AddTrainerToolStripMenuItem.Name = "AddTrainerToolStripMenuItem"
        Me.AddTrainerToolStripMenuItem.Size = New System.Drawing.Size(264, 32)
        Me.AddTrainerToolStripMenuItem.Text = "Add Trainer "
        '
        'TrainerSalaryDetailsToolStripMenuItem
        '
        Me.TrainerSalaryDetailsToolStripMenuItem.Name = "TrainerSalaryDetailsToolStripMenuItem"
        Me.TrainerSalaryDetailsToolStripMenuItem.Size = New System.Drawing.Size(264, 32)
        Me.TrainerSalaryDetailsToolStripMenuItem.Text = "Trainer Salary Details"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 1011)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1866, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.gym_management_system.My.Resources.Resources.fitness_center_page_60305a7f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1866, 1033)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Home_Page"
        Me.Text = "Home_Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerSalaryDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTrainerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerSalaryDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddWorkoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
