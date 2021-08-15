<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer__Report
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
        Me.Cust_Report_DataSet1 = New gym_management_system.Cust_Report_DataSet1()
        Me.Cust_mstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cust_mstTableAdapter = New gym_management_system.Cust_Report_DataSet1TableAdapters.Cust_mstTableAdapter()
        CType(Me.Cust_Report_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cust_mstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Cust_mstBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "gym_management_system.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1131, 624)
        Me.ReportViewer1.TabIndex = 0
        '
        'Cust_Report_DataSet1
        '
        Me.Cust_Report_DataSet1.DataSetName = "Cust_Report_DataSet1"
        Me.Cust_Report_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cust_mstBindingSource
        '
        Me.Cust_mstBindingSource.DataMember = "Cust_mst"
        Me.Cust_mstBindingSource.DataSource = Me.Cust_Report_DataSet1
        '
        'Cust_mstTableAdapter
        '
        Me.Cust_mstTableAdapter.ClearBeforeFill = True
        '
        'Customer__Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 624)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimizeBox = False
        Me.Name = "Customer__Report"
        Me.Text = "Customer__Report"
        CType(Me.Cust_Report_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cust_mstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Cust_mstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cust_Report_DataSet1 As gym_management_system.Cust_Report_DataSet1
    Friend WithEvents Cust_mstTableAdapter As gym_management_system.Cust_Report_DataSet1TableAdapters.Cust_mstTableAdapter
End Class
