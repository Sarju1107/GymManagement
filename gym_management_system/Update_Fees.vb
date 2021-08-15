
Imports System.Data.SqlClient
Public Class Update_Fees
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer = 0
    Dim fees As Integer = 0

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return cnt
    End Function
    Public Function Fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbwork.Text = "" Then cmbwork.Focus() : Exit Sub
        If txtfees.Text = "" Then txtfees.Focus() : Exit Sub

        Try
            str = "Update Workout_mst set fees='" & txtfees.Text & "' where workitem='" & cmbwork.Text & "'"
            cnt = Insertdata(str)

            If (cnt > 0) Then
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Updated Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub BindCombo()
        str = "select * from Workout_mst with (nolock)"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            cmd = New SqlCommand(str, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim ds1 As DataSet = New DataSet
            sda.Fill(ds1, "Workout_mst")
            ' Dim a As Integer = ds1.Tables("Workout_mst").Rows.Count - 1
            Dim i As Integer = 0
            cmbwork.Items.Clear()

            For i = 0 To ds1.Tables("Workout_mst").Rows.Count - 1
                cmbwork.Items.Add(ds1.Tables("Workout_mst").Rows(i)(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not Open Connection !")
        End Try
    End Sub

   

    Private Sub Update_Fees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCombo()
    End Sub

    Private Sub cmbwork_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbwork.SelectedIndexChanged
        If con.State = 1 Then con.Close()
        txtfees.Clear()
        Try
            str = "select * from [Workout_mst] with (nolock) where workitem='" & cmbwork.Text & "'"
            cmd = New SqlCommand(str, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                txtfees.Text = dr1.Item("fees").ToString
                fees = dr1.Item("fees").ToString
            Else
                MsgBox("Fees not found")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As Integer = MsgBox("Do you want to Delete Workout?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Try
                str = "Delete from Workout_mst where fees=" & txtfees.Text & ""
                cnt = Insertdata(str)
                If (cnt > 0) Then
                    MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                    clr()
                Else
                    MsgBox("Deleted cmd Failed", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub clr()
        cmbwork.Items.Clear()
        txtfees.Clear()
    End Sub
End Class