Imports System.Data.SqlClient

Public Class login
    ' Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String
    Dim cnt As Integer
    
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If (txt1.Text = "") Then
            MessageBox.Show("Enter UserName & Password ", "input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        str = "select * from Login_mst where Username=@username and password=@password"
        cmd = New SqlCommand(str, con)
        cmd.Parameters.AddWithValue("@username", txt1.Text)
        cmd.Parameters.AddWithValue("@password", txt2.Text)

        user = txt1.Text
        pass = txt2.Text

        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)

        Dim tmp As Integer
        tmp = ds.Tables(0).Rows.Count

        If tmp > 0 Then
            Me.Hide()
            'Home_Page.Show()
            Loadingform.Show()
        Else
            MessageBox.Show(" UserName & Password Not Valid ", "input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim res As Integer
        res = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Me.txt1.Clear()
            Me.txt2.Clear()
            Me.Close()
        End If
    End Sub

    
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
