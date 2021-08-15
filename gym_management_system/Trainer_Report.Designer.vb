<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trainer_Report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tner_Report_DataSet2 = New gym_management_system.Tner_Report_DataSet2()
        Me.Trainer_mstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trainer_mstTableAdapter = New gym_management_system.Tner_Report_DataSet2TableAdapters.Trainer_mstTableAdapter()
        CType(Me.Tner_Report_DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trainer_mstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Trainer_mstBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "gym_management_system.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(897, 504)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tner_Report_DataSet2
        '
        Me.Tner_Report_DataSet2.DataSetName = "Tner_Report_DataSet2"
        Me.Tner_Report_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Trainer_mstBindingSource
        '
        Me.Trainer_mstBindingSource.DataMember = "Trainer_mst"
        Me.Trainer_mstBindingSource.DataSource = Me.Tner_Report_DataSet2
        '
        'Trainer_mstTableAdapter
        '
        Me.Trainer_mstTableAdapter.ClearBeforeFill = True
        '
        'Trainer_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 504)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Trainer_Report"
        Me.Text = "Trainer_Report"
        CType(Me.Tner_Report_DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trainer_mstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Trainer_mstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tner_Report_DataSet2 As gym_management_system.Tner_Report_DataSet2
    Friend WithEvents Trainer_mstTableAdapter As gym_management_system.Tner_Report_DataSet2TableAdapters.Trainer_mstTableAdapter
End Class
