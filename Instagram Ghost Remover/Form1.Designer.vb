<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logOut = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.LinkLabel()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TPass = New System.Windows.Forms.TextBox()
        Me.TUser = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.buinessAcc = New System.Windows.Forms.Label()
        Me.lmediaCount = New System.Windows.Forms.Label()
        Me.lfollowing = New System.Windows.Forms.Label()
        Me.lfollowers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lv1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.allStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.more = New System.Windows.Forms.Button()
        Me.UnFollowBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.logOut)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.bLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TPass)
        Me.GroupBox1.Controls.Add(Me.TUser)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'logOut
        '
        Me.logOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logOut.Enabled = False
        Me.logOut.Location = New System.Drawing.Point(62, 110)
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(132, 23)
        Me.logOut.TabIndex = 6
        Me.logOut.Text = "Logout"
        Me.logOut.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(6, 141)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(25, 14)
        Me.status.TabIndex = 5
        Me.status.TabStop = True
        Me.status.Text = "Idle"
        '
        'bLogin
        '
        Me.bLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLogin.Location = New System.Drawing.Point(62, 81)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(132, 23)
        Me.bLogin.TabIndex = 4
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pass : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User : "
        '
        'TPass
        '
        Me.TPass.Location = New System.Drawing.Point(62, 53)
        Me.TPass.Name = "TPass"
        Me.TPass.Size = New System.Drawing.Size(132, 22)
        Me.TPass.TabIndex = 1
        Me.TPass.UseSystemPasswordChar = True
        '
        'TUser
        '
        Me.TUser.Location = New System.Drawing.Point(62, 21)
        Me.TUser.Name = "TUser"
        Me.TUser.Size = New System.Drawing.Size(132, 22)
        Me.TUser.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.buinessAcc)
        Me.GroupBox2.Controls.Add(Me.lmediaCount)
        Me.GroupBox2.Controls.Add(Me.lfollowing)
        Me.GroupBox2.Controls.Add(Me.lfollowers)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Info"
        '
        'buinessAcc
        '
        Me.buinessAcc.AutoSize = True
        Me.buinessAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.buinessAcc.Location = New System.Drawing.Point(138, 104)
        Me.buinessAcc.Name = "buinessAcc"
        Me.buinessAcc.Size = New System.Drawing.Size(13, 14)
        Me.buinessAcc.TabIndex = 7
        Me.buinessAcc.Text = "0"
        '
        'lmediaCount
        '
        Me.lmediaCount.AutoSize = True
        Me.lmediaCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lmediaCount.Location = New System.Drawing.Point(138, 80)
        Me.lmediaCount.Name = "lmediaCount"
        Me.lmediaCount.Size = New System.Drawing.Size(13, 14)
        Me.lmediaCount.TabIndex = 6
        Me.lmediaCount.Text = "0"
        '
        'lfollowing
        '
        Me.lfollowing.AutoSize = True
        Me.lfollowing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lfollowing.Location = New System.Drawing.Point(138, 56)
        Me.lfollowing.Name = "lfollowing"
        Me.lfollowing.Size = New System.Drawing.Size(13, 14)
        Me.lfollowing.TabIndex = 5
        Me.lfollowing.Text = "0"
        '
        'lfollowers
        '
        Me.lfollowers.AutoSize = True
        Me.lfollowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lfollowers.Location = New System.Drawing.Point(138, 32)
        Me.lfollowers.Name = "lfollowers"
        Me.lfollowers.Size = New System.Drawing.Size(13, 14)
        Me.lfollowers.TabIndex = 4
        Me.lfollowers.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Buisness Acc:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Posts N°: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Following: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Followers: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lv1)
        Me.GroupBox3.Location = New System.Drawing.Point(217, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 304)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inactive Followers"
        '
        'Lv1
        '
        Me.Lv1.CheckBoxes = True
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv1.FullRowSelect = True
        Me.Lv1.GridLines = True
        Me.Lv1.HideSelection = False
        Me.Lv1.Location = New System.Drawing.Point(3, 18)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.ShowItemToolTips = True
        Me.Lv1.Size = New System.Drawing.Size(389, 283)
        Me.Lv1.TabIndex = 0
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Posts N°"
        Me.ColumnHeader2.Width = 74
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Anonymous Pic"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 72
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.allStatus, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 335)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(619, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'allStatus
        '
        Me.allStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allStatus.ForeColor = System.Drawing.Color.DarkOrchid
        Me.allStatus.LinkColor = System.Drawing.Color.Maroon
        Me.allStatus.Name = "allStatus"
        Me.allStatus.Size = New System.Drawing.Size(27, 17)
        Me.allStatus.Text = "Idle"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel3.Text = "               "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(90, 17)
        Me.ToolStripStatusLabel2.Text = "Source Code"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel4.Text = "    "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Image = CType(resources.GetObject("ToolStripStatusLabel5.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel5.IsLink = True
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel5.Text = "X-SLAYER"
        '
        'more
        '
        Me.more.Cursor = System.Windows.Forms.Cursors.Hand
        Me.more.Enabled = False
        Me.more.Location = New System.Drawing.Point(541, 304)
        Me.more.Name = "more"
        Me.more.Size = New System.Drawing.Size(70, 23)
        Me.more.TabIndex = 4
        Me.more.Text = "More >>"
        Me.more.UseVisualStyleBackColor = True
        '
        'UnFollowBtn
        '
        Me.UnFollowBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UnFollowBtn.Enabled = False
        Me.UnFollowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UnFollowBtn.Location = New System.Drawing.Point(220, 304)
        Me.UnFollowBtn.Name = "UnFollowBtn"
        Me.UnFollowBtn.Size = New System.Drawing.Size(88, 23)
        Me.UnFollowBtn.TabIndex = 5
        Me.UnFollowBtn.Text = "UnFollow"
        Me.UnFollowBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 357)
        Me.Controls.Add(Me.UnFollowBtn)
        Me.Controls.Add(Me.more)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instagram Ghost Cleaner | X-SLAYER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TPass As TextBox
    Friend WithEvents TUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bLogin As Button
    Friend WithEvents status As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lv1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lfollowers As Label
    Friend WithEvents lfollowing As Label
    Friend WithEvents lmediaCount As Label
    Friend WithEvents buinessAcc As Label
    Friend WithEvents logOut As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents allStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents more As Button
    Friend WithEvents UnFollowBtn As Button
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
End Class
