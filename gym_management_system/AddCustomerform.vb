Imports System.Data.SqlClient

Public Class AddCustomerform

    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sarju\gym_management_system\gym_management_system\Gym_DB.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer = 0

    Public Function Fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return cnt
    End Function


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtfname.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlname.Text = "" Then txtlname.Focus() : Exit Sub
        If cmbgender.Text = "" Then cmbgender.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtjoin.Text = "" Then txtjoin.Focus() : Exit Sub
        If txtadds.Text = "" Then txtadds.Focus() : Exit Sub
        If txtmobilno.Text = "" Then txtmobilno.Focus() : Exit Sub
        If cmbpackage.Text = "" Then cmbpackage.Focus() : Exit Sub
        If cmbtime.Text = "" Then cmbtime.Focus() : Exit Sub

        'database
        Try
            str = "Insert into Cust_mst (c_fname,c_lname,gender,join_date,adds,city,dob,mobile,package,time,workout) values('" & txtfname.Text & "','" & txtlname.Text & "','" & cmbgender.Text & "','" & txtjoin.Text & "','" & txtadds.Text & "','" & txtcity.Text & "','" & txtdob.Text & "','" & txtmobilno.Text & "','" & cmbpackage.Text & "','" & cmbtime.Text & "','" & cmbwork.Text & "')"
            cmd = New SqlCommand(str, con)
            cnt = cmd.ExecuteNonQuery()
            If (cnt > 0) Then
                MsgBox("Add Customer Successfully", MsgBoxStyle.Information)
                Loaddataingrid()
                clr()
            Else
                MsgBox("Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Loaddataingrid()
        If con.State = 1 Then con.Close()
        str = "select * from Cust_mst with(nolock)"
        ds = Fetchdata(str)
        If ds.Tables(0).Rows.Count Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub AddCustomerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblcid.Visible = True
        BindCombo()
        Loaddataingrid()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If (e.RowIndex >= 0) Then
            Try
                lblcid.Visible = True

                cnt = DataGridView1.CurrentRow.Index
                Me.lblcid.Text = DataGridView1.Item(0, cnt).Value
                Me.txtfname.Text = DataGridView1.Item(1, cnt).Value
                Me.txtlname.Text = DataGridView1.Item(2, cnt).Value
                Me.cmbgender.Text = DataGridView1.Item(3, cnt).Value
                Me.txtdob.Text = DataGridView1.Item(7, cnt).Value
                Me.txtjoin.Text = DataGridView1.Item(4, cnt).Value
                Me.txtadds.Text = DataGridView1.Item(5, cnt).Value
                Me.txtcity.Text = DataGridView1.Item(6, cnt).Value
                Me.txtmobilno.Text = DataGridView1.Item(8, cnt).Value
                Me.cmbpackage.Text = DataGridView1.Item(9, cnt).Value
                Me.cmbtime.Text = DataGridView1.Item(10, cnt).Value
                Me.cmbwork.Text = DataGridView1.Item(11, cnt).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtfname.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlname.Text = "" Then txtlname.Focus() : Exit Sub
        If cmbgender.Text = "" Then cmbgender.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtjoin.Text = "" Then txtjoin.Focus() : Exit Sub
        If txtadds.Text = "" Then txtadds.Focus() : Exit Sub
        If txtmobilno.Text = "" Then txtmobilno.Focus() : Exit Sub
        If cmbpackage.Text = "" Then cmbpackage.Focus() : Exit Sub
        If cmbtime.Text = "" Then cmbtime.Focus() : Exit Sub

        'Update Record
        Try
            str = "Update Cust_mst set c_fname='" & txtfname.Text & "',c_lname='" & txtlname.Text & "',gender='" & cmbgender.Text & "',join_date='" & txtjoin.Text & "',adds='" & txtadds.Text & "',city='" & txtcity.Text & "',dob='" & txtdob.Text & "',mobile='" & txtmobilno.Text & "',package='" & cmbpackage.Text & "',time='" & cmbtime.Text & "',workout='" & cmbwork.Text & "' where custid=" & lblcid.Text & ""
            cnt = Insertdata(str)
            If (cnt > 0) Then
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                Loaddataingrid()
                clr()
            Else
                MsgBox("Updated Failed", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As Integer = MsgBox("Do you want to Delete Customer?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            If (lblcid.Text = "") Then
                MsgBox("select any row from gridview for Delete", MsgBoxStyle.Critical)
            Else
                Try
                    str = "Delete from Cust_mst where custid=" & lblcid.Text & ""
                    cnt = Insertdata(str)
                    If (cnt > 0) Then
                        MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                        Loaddataingrid()
                        clr()
                    Else
                        MsgBox("Deleted cmd Failed", MsgBoxStyle.Critical)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub clr()
        lblcid.Text = ""
        txtfname.Clear()
        txtlname.Clear()
        txtdob.Clear()
        txtjoin.Clear()
        txtadds.Clear()
        txtcity.Clear()
        txtmobilno.Clear()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
       
        clr()

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click

        Loaddataingrid()
        If txtsearch.Text = "" Then
            MsgBox("Enter Customer Name", MsgBoxStyle.Critical)
            Loaddataingrid()
            Exit Sub
        Else
            str = "select * from Cust_mst with (nolock)"
            str &= "where c_fname LIKE'%' + '" & txtsearch.Text & "'+'%'  or city LIKE'%' + '" & txtsearch.Text & "'+'%'"
            ds = Fetchdata(str)
            If (DataGridView1.Rows.Count > 0) Then
                clr()
                DataGridView1.DataSource = ds.Tables(0)
            Else

                clr()
                MsgBox("Record not found ....try again", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub BindCombo()
        cmbwork.Items.Clear()
        ds.Clear()
        str = "select * from Workout_mst with (nolock)"
        ds = Fetchdata(str)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                cmbwork.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("No Data Found ..", MsgBoxStyle.Exclamation)

        End If
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

   

    Private Sub txtmobilno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobilno.LostFocus
        Dim sname As String = "^[0-9\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtmobilno.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter 10 Digits Only!"

            txtmobilno.Focus()

            txtmobilno.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
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

   
    
    
   
    
   
    
End Class