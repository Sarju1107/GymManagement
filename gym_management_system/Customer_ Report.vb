Public Class Customer__Report

    Private Sub Customer__Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cust_Report_DataSet1.Cust_mst' table. You can move, or remove it, as needed.
        Me.Cust_mstTableAdapter.Fill(Me.Cust_Report_DataSet1.Cust_mst)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class