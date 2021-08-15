Imports System.Data.SqlClient
Public Class Trainer_Salary_dtl
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim tbl As New DataTable()
    Dim bmb As BindingManagerBase
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
        If txtid.Text = "" Then txtid.Focus() : Exit Sub
        If txtfname.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlname.Text = "" Then txtlname.Focus() : Exit Sub
        If txtdatep.Text = "" Then txtdatep.Focus() : Exit Sub
        If txtsal.Text = "" Then txtsal.Focus() : Exit Sub
        If txtwage.Text = "" Then txtwage.Focus() : Exit Sub
        If txtwork.Text = "" Then txtwork.Focus() : Exit Sub

        'database
        Try
            str = "Insert into Payment_mst (tner_id,t_fname,t_lname,date_paid,houtly_wage,hours_work,salary) values ('" & txtid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtdatep.Text & "','" & txtwage.Text & "','" & txtwork.Text & "','" & txtsal.Text & "')"
            cnt = Insertdata(str)

            If (cnt > 0) Then
                MsgBox("Successfully Inserted Trainer", MsgBoxStyle.Information)
            Else
                MsgBox("Insert Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btncalcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcu.Click
        Dim wage As Integer
        Dim work As Integer
        Dim sal As Integer
        wage = CInt(txtwage.Text)
        work = CInt(txtwork.Text)
        sal = wage * work
        txtsal.Text = sal
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Trainer_Salary_dtl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = 1 Then con.Close()
        str = "select * from Payment_mst"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)
        tbl = ds.Tables(0)

        'Binding data to textbox
        bmb = Me.BindingContext(tbl)
        txtid.DataBindings.Add("text", tbl, "tner_id")
        txtfname.DataBindings.Add("text", tbl, "t_fname")
        txtlname.DataBindings.Add("text", tbl, "t_lname")
        txtdatep.DataBindings.Add("text", tbl, "date_paid")
        txtwage.DataBindings.Add("text", tbl, "houtly_wage")
        txtwork.DataBindings.Add("text", tbl, "hours_work")
        txtsal.DataBindings.Add("text", tbl, "salary")

    End Sub

    Private Sub txtdatep_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtdatep.MouseClick
        clr()
    End Sub
    Private Sub clr()
        txtid.Clear()
        txtfname.Clear()
        txtlname.Clear()
        txtdatep.Clear()
        txtwage.Clear()
        txtwork.Clear()
        txtsal().Clear()
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        bmb.Position += -1
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        bmb.Position += 1
    End Sub
End Class