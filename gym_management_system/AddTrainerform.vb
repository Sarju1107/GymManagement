
Imports System.Data.SqlClient
Public Class AddTrainerform

    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim tbl As New DataTable()
    Dim bmb As BindingManagerBase
    Dim str As String
    Dim cnt As Integer = 0
    Dim id As String = ""

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return cnt
    End Function
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'If txtid.Text = "" Then txtid.Focus() : Exit Sub
        If txtfname.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlname.Text = "" Then txtlname.Focus() : Exit Sub
        If txtemail.Text = "" Then txtemail.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtadds.Text = "" Then txtadds.Focus() : Exit Sub
        If txtmobile.Text = "" Then txtmobile.Focus() : Exit Sub
        If txtcity.Text = "" Then txtcity.Focus() : Exit Sub

        'database
        Try
            str = "Insert into Trainer_mst (t_fname,t_lname,email,dob,adds,city,mobile) values ('" & txtfname.Text & "','" & txtlname.Text & "','" & txtemail.Text & "','" & txtdob.Text & "','" & txtadds.Text & "','" & txtcity.Text & "','" & txtmobile.Text & "')"
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

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        'If txtid.Text = "" Then txtid.Focus() : Exit Sub
        If txtfname.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlname.Text = "" Then txtlname.Focus() : Exit Sub
        If txtemail.Text = "" Then txtemail.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtadds.Text = "" Then txtadds.Focus() : Exit Sub
        If txtmobile.Text = "" Then txtmobile.Focus() : Exit Sub
        If txtcity.Text = "" Then txtcity.Focus() : Exit Sub

        'database
        Try
            str = "Update Trainer_mst set t_fname='" & txtfname.Text & "',t_lname='" & txtlname.Text & "',email='" & txtemail.Text & "',dob='" & txtdob.Text & "',adds='" & txtadds.Text & "',city='" & txtcity.Text & "',mobile='" & txtmobile.Text & "' where tner_id=" & lblid.Text & ""
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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As Integer = MsgBox("Do you want to Delete Trainer?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Try
                str = "Delete from Trainer_mst where tner_id=" & lblid.Text & ""
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

    Private Sub AddTrainerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = 1 Then con.Close()
        str = "select * from Trainer_mst"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)
        tbl = ds.Tables(0)

        'Binding data to textbox

        bmb = Me.BindingContext(tbl)
        lblid.DataBindings.Add("text", tbl, "tner_id")
        txtfname.DataBindings.Add("text", tbl, "t_fname")
        txtlname.DataBindings.Add("text", tbl, "t_lname")
        txtemail.DataBindings.Add("text", tbl, "email")
        txtdob.DataBindings.Add("text", tbl, "dob")
        txtadds.DataBindings.Add("text", tbl, "adds")
        txtcity.DataBindings.Add("text", tbl, "city")
        txtmobile.DataBindings.Add("text", tbl, "mobile")


    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        bmb.Position += -1
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        bmb.Position += 1
    End Sub

    Private Sub clr()
        lblid.Text = "Trainer ID :"
        txtfname.Clear()
        txtlname.Clear()
        txtdob.Clear()
        txtemail.Clear()
        txtadds.Clear()
        txtcity.Clear()
        txtmobile.Clear()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clr()
    End Sub

    Private Sub txtfname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.LostFocus
        Dim sname As String = "^[a-zA-Z\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtfname.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Alphabetic Characters Only!"

            txtfname.Focus()

            txtfname.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    Private Sub txtfname_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtfname.MouseClick
        clr()
        lblid.Text = "Trainer Id:"
    End Sub

    Private Sub txtlname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.LostFocus
        Dim sname As String = "^[a-zA-Z\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtlname.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Alphabetic Characters Only!"

            txtlname.Focus()

            txtlname.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    Private Sub txtemail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.LostFocus
        Dim sname As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtemail.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Digits,Characters And @ !"

            txtemail.Focus()

            txtemail.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    Private Sub txtmobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.LostFocus
        Dim sname As String = "^[0-9\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtmobile.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter 10 Digits Only!"

            txtmobile.Focus()

            txtmobile.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

   
   
   
   
    
   
    
End Class