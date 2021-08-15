Imports System.Data.SqlClient
Public Class Change_Password
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

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If con.State = 1 Then con.Close()
        If txtoldp.Text = "" Then txtoldp.Focus() : Exit Sub
        If txtnewp.Text = "" Then txtnewp.Focus() : Exit Sub
        If txtcnew.Text = "" Then txtcnew.Focus() : Exit Sub
        If txtoldp.Text = Module1.pass Then
            If txtnewp.Text = txtcnew.Text Then
                Try
                    str = "update Login_mst set password='" & txtnewp.Text & "' where username='" & Module1.user & "'"
                    cnt = Insertdata(str)
                    If cnt >= 1 Then
                        MsgBox("Password Changed Successfully")
                        txtcnew.Clear()
                        txtnewp.Focus()
                        txtoldp.Clear()
                        Module1.user = ""
                        Me.Close()
                        Dispose()
                        'Home_Page.Hide()
                        ' login.Show()
                    Else
                        MsgBox("Failed")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Old Password Not Matched", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub

   

   
End Class