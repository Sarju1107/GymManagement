Imports System.Data.SqlClient
Public Class Workout
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer = 0

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return cnt
    End Function
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtwork.Text = "" Then txtwork.Focus() : Exit Sub
        If txtfees.Text = "" Then txtfees.Focus() : Exit Sub
        If cmbday.Text = "" Then cmbday.Focus() : Exit Sub

        'database
        Try
            str = "Insert into Workout_mst (workitem,fees,day) values ('" & txtwork.Text & "','" & txtfees.Text & "','" & cmbday.Text & "')"
            cnt = Insertdata(str)

            If (cnt > 0) Then
                MsgBox("Added New Workout", MsgBoxStyle.Information)
                clr()
            Else
                MsgBox("Added Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub clr()
        txtwork.Clear()
        txtfees.Clear()
        cmbday.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class