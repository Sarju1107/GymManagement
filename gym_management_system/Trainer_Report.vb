Public Class Trainer_Report

    Private Sub Trainer_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tner_Report_DataSet2.Trainer_mst' table. You can move, or remove it, as needed.
        Me.Trainer_mstTableAdapter.Fill(Me.Tner_Report_DataSet2.Trainer_mst)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class