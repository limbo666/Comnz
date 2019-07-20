<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMAin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMAin))
        Me.updnPort = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StLbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StLbl2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StLbl3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TmrUDP = New System.Windows.Forms.Timer(Me.components)
        Me.lblIncoming = New System.Windows.Forms.Label()
        Me.chkBxServer = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TmrClearReceivedFields = New System.Windows.Forms.Timer(Me.components)
        Me.TmrClearRX = New System.Windows.Forms.Timer(Me.components)
        Me.TmrClearStatusLbl = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.NTIcn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ConMnuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl2 = New System.Windows.Forms.Panel()
        Me.Pnl1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAct4 = New System.Windows.Forms.TextBox()
        Me.TxtAct3 = New System.Windows.Forms.TextBox()
        Me.TxtAct2 = New System.Windows.Forms.TextBox()
        Me.TxtAct1 = New System.Windows.Forms.TextBox()
        Me.P5 = New System.Windows.Forms.Panel()
        Me.Lnk5 = New System.Windows.Forms.LinkLabel()
        Me.P4 = New System.Windows.Forms.Panel()
        Me.Lnk4 = New System.Windows.Forms.LinkLabel()
        Me.P3 = New System.Windows.Forms.Panel()
        Me.Lnk3 = New System.Windows.Forms.LinkLabel()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.Lnk2 = New System.Windows.Forms.LinkLabel()
        Me.P1 = New System.Windows.Forms.Panel()
        Me.Lnk1 = New System.Windows.Forms.LinkLabel()
        Me.TmrRefreshGUI = New System.Windows.Forms.Timer(Me.components)
        CType(Me.updnPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ConMnuStrip1.SuspendLayout()
        Me.Pnl2.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.P5.SuspendLayout()
        Me.P4.SuspendLayout()
        Me.P3.SuspendLayout()
        Me.P2.SuspendLayout()
        Me.P1.SuspendLayout()
        Me.SuspendLayout()
        '
        'updnPort
        '
        Me.updnPort.Location = New System.Drawing.Point(289, 19)
        Me.updnPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.updnPort.Minimum = New Decimal(New Integer() {1025, 0, 0, 0})
        Me.updnPort.Name = "updnPort"
        Me.updnPort.Size = New System.Drawing.Size(56, 20)
        Me.updnPort.TabIndex = 1
        Me.updnPort.Value = New Decimal(New Integer() {55155, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server port"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StLbl1, Me.StLbl2, Me.StLbl3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 324)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(916, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StLbl1
        '
        Me.StLbl1.AutoSize = False
        Me.StLbl1.Name = "StLbl1"
        Me.StLbl1.Size = New System.Drawing.Size(18, 17)
        '
        'StLbl2
        '
        Me.StLbl2.AutoSize = False
        Me.StLbl2.Name = "StLbl2"
        Me.StLbl2.Size = New System.Drawing.Size(18, 17)
        '
        'StLbl3
        '
        Me.StLbl3.AutoSize = False
        Me.StLbl3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StLbl3.Name = "StLbl3"
        Me.StLbl3.Size = New System.Drawing.Size(30, 17)
        '
        'TmrUDP
        '
        '
        'lblIncoming
        '
        Me.lblIncoming.BackColor = System.Drawing.Color.LightGray
        Me.lblIncoming.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIncoming.Location = New System.Drawing.Point(88, 38)
        Me.lblIncoming.Name = "lblIncoming"
        Me.lblIncoming.Size = New System.Drawing.Size(257, 20)
        Me.lblIncoming.TabIndex = 5
        Me.lblIncoming.Text = "..."
        Me.lblIncoming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkBxServer
        '
        Me.chkBxServer.AutoSize = True
        Me.chkBxServer.Location = New System.Drawing.Point(88, 36)
        Me.chkBxServer.Name = "chkBxServer"
        Me.chkBxServer.Size = New System.Drawing.Size(59, 17)
        Me.chkBxServer.TabIndex = 6
        Me.chkBxServer.Text = "Enable"
        Me.chkBxServer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Received message"
        '
        'TmrClearReceivedFields
        '
        Me.TmrClearReceivedFields.Interval = 5000
        '
        'TmrClearRX
        '
        Me.TmrClearRX.Interval = 200
        '
        'TmrClearStatusLbl
        '
        Me.TmrClearStatusLbl.Interval = 2000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.chkBxServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.updnPort)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 87)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UDP Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(289, 48)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(56, 20)
        Me.TxtID.TabIndex = 10
        Me.TxtID.Text = "AA111"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.lblIncoming)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 112)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diagnostics"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(88, 73)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Log received messages"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 87)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(88, 54)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "Start hidden to tray"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(88, 22)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Start with windows"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'NTIcn
        '
        Me.NTIcn.ContextMenuStrip = Me.ConMnuStrip1
        Me.NTIcn.Text = "Comnz"
        Me.NTIcn.Visible = True
        '
        'ConMnuStrip1
        '
        Me.ConMnuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ConMnuStrip1.Name = "ConMnuStrip1"
        Me.ConMnuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Pnl2
        '
        Me.Pnl2.BackColor = System.Drawing.Color.Gray
        Me.Pnl2.Controls.Add(Me.GroupBox1)
        Me.Pnl2.Controls.Add(Me.GroupBox2)
        Me.Pnl2.Location = New System.Drawing.Point(515, 3)
        Me.Pnl2.Name = "Pnl2"
        Me.Pnl2.Size = New System.Drawing.Size(396, 317)
        Me.Pnl2.TabIndex = 14
        '
        'Pnl1
        '
        Me.Pnl1.BackColor = System.Drawing.Color.Gray
        Me.Pnl1.Controls.Add(Me.GroupBox4)
        Me.Pnl1.Controls.Add(Me.GroupBox3)
        Me.Pnl1.Location = New System.Drawing.Point(102, 3)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(396, 317)
        Me.Pnl1.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtAct4)
        Me.GroupBox4.Controls.Add(Me.TxtAct3)
        Me.GroupBox4.Controls.Add(Me.TxtAct2)
        Me.GroupBox4.Controls.Add(Me.TxtAct1)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 188)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Actions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Button3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Button4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Button1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Button2"
        '
        'TxtAct4
        '
        Me.TxtAct4.Location = New System.Drawing.Point(134, 142)
        Me.TxtAct4.Name = "TxtAct4"
        Me.TxtAct4.Size = New System.Drawing.Size(68, 20)
        Me.TxtAct4.TabIndex = 24
        Me.TxtAct4.Text = "^a"
        '
        'TxtAct3
        '
        Me.TxtAct3.Location = New System.Drawing.Point(134, 104)
        Me.TxtAct3.Name = "TxtAct3"
        Me.TxtAct3.Size = New System.Drawing.Size(68, 20)
        Me.TxtAct3.TabIndex = 23
        Me.TxtAct3.Text = "^x"
        '
        'TxtAct2
        '
        Me.TxtAct2.Location = New System.Drawing.Point(134, 62)
        Me.TxtAct2.Name = "TxtAct2"
        Me.TxtAct2.Size = New System.Drawing.Size(67, 20)
        Me.TxtAct2.TabIndex = 22
        Me.TxtAct2.Text = "^v"
        '
        'TxtAct1
        '
        Me.TxtAct1.Location = New System.Drawing.Point(134, 22)
        Me.TxtAct1.Name = "TxtAct1"
        Me.TxtAct1.Size = New System.Drawing.Size(67, 20)
        Me.TxtAct1.TabIndex = 21
        Me.TxtAct1.Text = "^c"
        '
        'P5
        '
        Me.P5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.P5.Controls.Add(Me.Lnk5)
        Me.P5.Location = New System.Drawing.Point(0, 283)
        Me.P5.Name = "P5"
        Me.P5.Size = New System.Drawing.Size(105, 35)
        Me.P5.TabIndex = 20
        '
        'Lnk5
        '
        Me.Lnk5.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.Lnk5.AutoSize = True
        Me.Lnk5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Lnk5.LinkColor = System.Drawing.Color.White
        Me.Lnk5.Location = New System.Drawing.Point(38, 11)
        Me.Lnk5.Name = "Lnk5"
        Me.Lnk5.Size = New System.Drawing.Size(28, 13)
        Me.Lnk5.TabIndex = 0
        Me.Lnk5.TabStop = True
        Me.Lnk5.Text = "Exit"
        '
        'P4
        '
        Me.P4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.P4.Controls.Add(Me.Lnk4)
        Me.P4.Location = New System.Drawing.Point(0, 245)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(105, 35)
        Me.P4.TabIndex = 19
        '
        'Lnk4
        '
        Me.Lnk4.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.Lnk4.AutoSize = True
        Me.Lnk4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Lnk4.LinkColor = System.Drawing.Color.White
        Me.Lnk4.Location = New System.Drawing.Point(36, 11)
        Me.Lnk4.Name = "Lnk4"
        Me.Lnk4.Size = New System.Drawing.Size(33, 13)
        Me.Lnk4.TabIndex = 1
        Me.Lnk4.TabStop = True
        Me.Lnk4.Text = "Hide"
        '
        'P3
        '
        Me.P3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.P3.Controls.Add(Me.Lnk3)
        Me.P3.Location = New System.Drawing.Point(0, 207)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(105, 35)
        Me.P3.TabIndex = 18
        '
        'Lnk3
        '
        Me.Lnk3.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.Lnk3.AutoSize = True
        Me.Lnk3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Lnk3.LinkColor = System.Drawing.Color.White
        Me.Lnk3.Location = New System.Drawing.Point(33, 12)
        Me.Lnk3.Name = "Lnk3"
        Me.Lnk3.Size = New System.Drawing.Size(40, 13)
        Me.Lnk3.TabIndex = 2
        Me.Lnk3.TabStop = True
        Me.Lnk3.Text = "About"
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.P2.Controls.Add(Me.Lnk2)
        Me.P2.Location = New System.Drawing.Point(0, 41)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(105, 35)
        Me.P2.TabIndex = 17
        '
        'Lnk2
        '
        Me.Lnk2.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.Lnk2.AutoSize = True
        Me.Lnk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Lnk2.LinkColor = System.Drawing.Color.White
        Me.Lnk2.Location = New System.Drawing.Point(30, 11)
        Me.Lnk2.Name = "Lnk2"
        Me.Lnk2.Size = New System.Drawing.Size(50, 13)
        Me.Lnk2.TabIndex = 4
        Me.Lnk2.TabStop = True
        Me.Lnk2.Text = "Options"
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.P1.Controls.Add(Me.Lnk1)
        Me.P1.Location = New System.Drawing.Point(0, 3)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(105, 35)
        Me.P1.TabIndex = 16
        '
        'Lnk1
        '
        Me.Lnk1.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.Lnk1.AutoSize = True
        Me.Lnk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Lnk1.LinkColor = System.Drawing.Color.White
        Me.Lnk1.Location = New System.Drawing.Point(28, 12)
        Me.Lnk1.Name = "Lnk1"
        Me.Lnk1.Size = New System.Drawing.Size(51, 13)
        Me.Lnk1.TabIndex = 3
        Me.Lnk1.TabStop = True
        Me.Lnk1.Text = "General"
        '
        'TmrRefreshGUI
        '
        '
        'FrmMAin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(916, 346)
        Me.Controls.Add(Me.Pnl2)
        Me.Controls.Add(Me.Pnl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P4)
        Me.Controls.Add(Me.P5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMAin"
        Me.Text = "Comnz - Settings"
        CType(Me.updnPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ConMnuStrip1.ResumeLayout(False)
        Me.Pnl2.ResumeLayout(False)
        Me.Pnl1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.P5.ResumeLayout(False)
        Me.P5.PerformLayout()
        Me.P4.ResumeLayout(False)
        Me.P4.PerformLayout()
        Me.P3.ResumeLayout(False)
        Me.P3.PerformLayout()
        Me.P2.ResumeLayout(False)
        Me.P2.PerformLayout()
        Me.P1.ResumeLayout(False)
        Me.P1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updnPort As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TmrUDP As Timer
    Friend WithEvents lblIncoming As Label
    Friend WithEvents chkBxServer As CheckBox
    Friend WithEvents StLbl1 As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents TmrClearReceivedFields As Timer
    Friend WithEvents StLbl2 As ToolStripStatusLabel
    Friend WithEvents TmrClearRX As Timer
    Friend WithEvents StLbl3 As ToolStripStatusLabel
    Friend WithEvents TmrClearStatusLbl As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NTIcn As NotifyIcon
    Friend WithEvents ConMnuStrip1 As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Pnl2 As Panel
    Friend WithEvents Pnl1 As Panel
    Friend WithEvents P5 As Panel
    Friend WithEvents P4 As Panel
    Friend WithEvents P3 As Panel
    Friend WithEvents P2 As Panel
    Friend WithEvents P1 As Panel
    Friend WithEvents Lnk5 As LinkLabel
    Friend WithEvents Lnk4 As LinkLabel
    Friend WithEvents Lnk3 As LinkLabel
    Friend WithEvents Lnk2 As LinkLabel
    Friend WithEvents Lnk1 As LinkLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtAct4 As TextBox
    Friend WithEvents TxtAct3 As TextBox
    Friend WithEvents TxtAct2 As TextBox
    Friend WithEvents TxtAct1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TmrRefreshGUI As Timer
End Class
