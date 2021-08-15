<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomerform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomerform))
        Me.lblcid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.txtadds = New System.Windows.Forms.TextBox()
        Me.txtmobilno = New System.Windows.Forms.TextBox()
        Me.cmbpackage = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtjoin = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbtime = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbwork = New System.Windows.Forms.ComboBox()
        Me.lblerror = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcid
        '
        Me.lblcid.AutoSize = True
        Me.lblcid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcid.Location = New System.Drawing.Point(129, 63)
        Me.lblcid.Name = "lblcid"
        Me.lblcid.Size = New System.Drawing.Size(127, 20)
        Me.lblcid.TabIndex = 0
        Me.lblcid.Text = "Customer ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(107, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(536, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(139, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(518, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(104, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Joinig Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(129, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(114, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Mobile No :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(127, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Package :"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(239, 103)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(204, 22)
        Me.txtfname.TabIndex = 10
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(654, 103)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(213, 22)
        Me.txtlname.TabIndex = 11
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(239, 145)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(204, 24)
        Me.cmbgender.TabIndex = 12
        '
        'txtadds
        '
        Me.txtadds.Location = New System.Drawing.Point(239, 242)
        Me.txtadds.Multiline = True
        Me.txtadds.Name = "txtadds"
        Me.txtadds.Size = New System.Drawing.Size(276, 74)
        Me.txtadds.TabIndex = 26
        '
        'txtmobilno
        '
        Me.txtmobilno.Location = New System.Drawing.Point(239, 345)
        Me.txtmobilno.Name = "txtmobilno"
        Me.txtmobilno.Size = New System.Drawing.Size(204, 22)
        Me.txtmobilno.TabIndex = 28
        '
        'cmbpackage
        '
        Me.cmbpackage.FormattingEnabled = True
        Me.cmbpackage.Items.AddRange(New Object() {"1 Month", "3 Month", "6 Month", "1 Year"})
        Me.cmbpackage.Location = New System.Drawing.Point(239, 399)
        Me.cmbpackage.Name = "cmbpackage"
        Me.cmbpackage.Size = New System.Drawing.Size(204, 24)
        Me.cmbpackage.TabIndex = 29
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.PeachPuff
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(963, 118)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 33)
        Me.btnsave.TabIndex = 30
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.PeachPuff
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(961, 182)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 33)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.PeachPuff
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.Location = New System.Drawing.Point(961, 242)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 33)
        Me.btnupdate.TabIndex = 32
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclear.Location = New System.Drawing.Point(961, 304)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(95, 33)
        Me.btnclear.TabIndex = 33
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(239, 464)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(628, 22)
        Me.txtsearch.TabIndex = 34
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.LightCoral
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Snow
        Me.btnsearch.Location = New System.Drawing.Point(930, 457)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(99, 34)
        Me.btnsearch.TabIndex = 35
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(98, 532)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1019, 195)
        Me.DataGridView1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(582, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "City :"
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(655, 242)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(213, 22)
        Me.txtcity.TabIndex = 38
        '
        'txtjoin
        '
        Me.txtjoin.Location = New System.Drawing.Point(239, 192)
        Me.txtjoin.Name = "txtjoin"
        Me.txtjoin.Size = New System.Drawing.Size(204, 22)
        Me.txtjoin.TabIndex = 40
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(655, 142)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(212, 22)
        Me.txtdob.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(531, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Batch Time :"
        '
        'cmbtime
        '
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbtime.Location = New System.Drawing.Point(655, 345)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.Size = New System.Drawing.Size(64, 24)
        Me.cmbtime.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(554, 399)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "WorkOut :"
        '
        'cmbwork
        '
        Me.cmbwork.FormattingEnabled = True
        Me.cmbwork.Location = New System.Drawing.Point(655, 395)
        Me.cmbwork.Name = "cmbwork"
        Me.cmbwork.Size = New System.Drawing.Size(187, 24)
        Me.cmbwork.TabIndex = 45
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Red
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblerror.Location = New System.Drawing.Point(756, 39)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 20)
        Me.lblerror.TabIndex = 46
        '
        'AddCustomerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.gym_management_system.My.Resources.Resources.power_trainer
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 739)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.cmbwork)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbtime)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjoin)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbpackage)
        Me.Controls.Add(Me.txtmobilno)
        Me.Controls.Add(Me.txtadds)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblcid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddCustomerform"
        Me.Text = "AddCustomerform"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtadds As System.Windows.Forms.TextBox
    Friend WithEvents txtmobilno As System.Windows.Forms.TextBox
    Friend WithEvents cmbpackage As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtjoin As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbtime As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbwork As System.Windows.Forms.ComboBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
End Class
