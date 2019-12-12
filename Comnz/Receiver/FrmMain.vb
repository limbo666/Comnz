Imports System.Net
Imports System.Text

Public Class FrmMAin
    Dim F_ID As String
    ' Dim TextToStrip As String
    Dim CommandBreak As Boolean = False

    Dim LastTabStanding As Integer

#Region "UDP Members"
    '  Public SendPort As Integer = 55155
    Dim Publisher As New Sockets.UdpClient(0)
    Dim Subscriber As New Sockets.UdpClient(0)
    Dim IndicatorToggle As Integer = 0
    Dim ReceivedText As String
    Dim TargetIp As String
    Dim TargetPort As String = "55155"
    Dim LocalServerPort As Integer
#End Region

    'Sub UDPSend(TextToSend)
    '    Try
    '        Dim e2 As Encoding = Encoding.GetEncoding(28597) ' Greek enconding 
    '        '  Dim sendbytes() As Byte = ASCII.GetBytes(TextToSend)
    '        '  Dim sendbytes() As Byte = System.Text.Encoding.Unicode.GetBytes(TextToSend)
    '        Dim sendbytes() As Byte = e2.GetBytes(TextToSend)
    '        Publisher.Connect(TargetIp, TargetPort)
    '        Publisher.Send(sendbytes, sendbytes.Length)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub TmrUDPRCV_Tick(sender As Object, e As EventArgs) Handles TmrUDP.Tick
        'This is a UDP receiver
        Try
            Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
            Dim RCVbytes() As Byte = Subscriber.Receive(ep)
            Dim e2 As Encoding = Encoding.GetEncoding(28597) ' greek enconding 
            ReceivedText = e2.GetString(RCVbytes)
            StLbl2.BackColor = Color.FromArgb(0, 54, 200)
            '  TmrClearRX.Enabled = False 
            TmrClearRX.Enabled = True
        Catch ex As Exception
        End Try
        If ReceivedText <> "" Then
            lblIncoming.Text = ReceivedText
            MsgHistory(ReceivedText)
            If ReceivedText.IndexOf(F_ID) > -1 Then
                Striptext(ReceivedText)
            End If
            ReceivedText = ""
            TmrClearReceivedFields.Enabled = False 'disabling timer forces each message to stay on screen
            TmrClearReceivedFields.Enabled = True
            CommandBreak = False
        End If
    End Sub


    Private Sub Striptext(TextToStrip As String)

        If CommandBreak = False Then
            CommandBreak = True
            Try
                Dim parts() = Split(TextToStrip, "::")
                TargetIp = parts(1)
                parts(0) = Replace(parts(0), "$$exe", "")
                parts(0) = Replace(parts(0), F_ID, "")
                If parts(0).IndexOf("keys") > -1 Then
                    parts(0) = Replace(parts(0), "keys", "")
                    Call ActAsKey(CInt(parts(0)))
                    '        ElseIf parts(0).IndexOf("prog") > -1 Then ' future usage to execute program
                    '           parts(0) = Replace(parts(0), "prog", "")
                    ReplyToSender(CInt(parts(0)), TargetIp)
                ElseIf parts(0).IndexOf("beat") > -1 Then ' here we are replying as a heartbeat
                    ReplyToSender(0, TargetIp)
                End If
            Catch ex As Exception
                ' MsgBox(ex.Message)
                StLbl3.Text = ex.Message
                TmrClearStatusLbl.Enabled = False
                TmrClearStatusLbl.Enabled = True
                Beep()

            End Try

        End If
    End Sub


    Sub ActAsKey(ComIndex As Integer)
        If ComIndex = 1 Then ' COPY
            ' SendKeys.Send("^c")
            Try
                SendKeys.Send(TxtAct1.Text)
                StLbl3.Text = TxtAct1.Text '"Copy"
            Catch ex As Exception

            End Try

        ElseIf ComIndex = 2 Then ' PASTE
            '  SendKeys.Send("^v")
            '    StLbl3.Text = "Paste"
            Try
                SendKeys.Send(TxtAct2.Text)
                StLbl3.Text = TxtAct2.Text
            Catch ex As Exception

            End Try
        ElseIf ComIndex = 3 Then ' CUT
            Try
                SendKeys.Send(TxtAct3.Text)
                StLbl3.Text = TxtAct3.Text
            Catch ex As Exception

            End Try
        ElseIf ComIndex = 4 Then
            Try
                SendKeys.Send(TxtAct4.Text)
                StLbl3.Text = TxtAct4.Text
            Catch ex As Exception

            End Try
        End If
        TmrClearStatuslbl.enabled = True
    End Sub

    Sub ReplyToSender(ComIndex As Integer, ReplyAddress As String)
        Try
            Dim e2 As Encoding = Encoding.GetEncoding(28597) ' Greek enconding 
            '  Dim sendbytes() As Byte = ASCII.GetBytes(TextToSend)
            '  Dim sendbytes() As Byte = System.Text.Encoding.Unicode.GetBytes(TextToSend)
            Dim TextToSend = "Comnz::" & ComIndex.ToString
            Dim sendbytes() As Byte = e2.GetBytes(TextToSend)
            Publisher.Connect(ReplyAddress, TargetPort)
            Publisher.Send(sendbytes, sendbytes.Length)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrRefreshGUI.Enabled = True
        Pnl2.Left = Pnl1.Left
        LoadValues()
        Me.Width = 525
        Me.Height = 385
        Me.MaximumSize = Me.Size
        Me.MaximumSize = Me.Size
        NTIcn.Icon = Me.Icon
        NTIcn.Text = "Comnz"
        NTIcn.Visible = True

        StLbl2.BackColor = Color.FromArgb(224, 224, 224)
        StLbl1.BackColor = Color.FromArgb(164, 164, 164)
        '  F_ID = TextBox1.Text


    End Sub

    Sub StoreValues()
        SaveSetting("Comnz", "Settings", "WindowTop", Me.Top)
        SaveSetting("Comnz", "Settings", "WindowLeft", Me.Left)
        SaveSetting("Comnz", "Settings", "StartHidden", CheckBox4.Checked)
        SaveSetting("Comnz", "Settings", "ID", TxtID.Text)
        SaveSetting("Comnz", "Settings", "Enabled", chkBxServer.Checked)
        SaveSetting("Comnz", "Settings", "LocalServerPort", updnPort.Value)
        SaveSetting("Comnz", "Settings", "LogReceived", CheckBox2.Checked)
        SaveSetting("Comnz", "Settings", "StartWithWindows", CheckBox3.Checked)
        SaveSetting("Comnz", "Settings", "LastTabStanting", LastTabStanding)


        SaveSetting("Comnz", "Settings", "TxtAct1", TxtAct1.Text)
        SaveSetting("Comnz", "Settings", "TxtAct2", TxtAct2.Text)
        SaveSetting("Comnz", "Settings", "TxtAct3", TxtAct3.Text)
        SaveSetting("Comnz", "Settings", "TxtAct4", TxtAct4.Text)


    End Sub

    Sub LoadValues()
        Me.Top = GetSetting("Comnz", "Settings", "WindowTop", 100)
        Me.Left = GetSetting("Comnz", "Settings", "WindowLeft", 100)
        If Me.Left < 0 Then Me.Left = 100
        If Me.Top < 0 Then Me.Top = 100
        CheckBox4.Checked = GetSetting("Comnz", "Settings", "StartHidden", False)
        If CheckBox4.Checked = True Then
            Me.Hide()
            Me.ShowInTaskbar = False
        End If
        TxtID.Text = GetSetting("Comnz", "Settings", "ID", "AA111")
        F_ID = TxtID.Text
        chkBxServer.Checked = GetSetting("Comnz", "Settings", "Enabled", False)
        updnPort.Value = GetSetting("Comnz", "Settings", "LocalServerPort", 55155)
        LocalServerPort = updnPort.Value
        CheckBox2.Checked = GetSetting("Comnz", "Settings", "LogReceived", False)
        CheckBox3.Checked = GetSetting("Comnz", "Settings", "StartWithWindows", False)
        LastTabStanding = GetSetting("Comnz", "Settings", "LastTabStanting", 1)
        If LastTabStanding = 1 Then
            Pnl2.Visible = True
            Pnl1.Visible = False
        Else
            Pnl2.Visible = False
            Pnl1.Visible = True
        End If


        TxtAct1.Text = GetSetting("Comnz", "Settings", "TxtAct1", "^c")
        TxtAct2.Text = GetSetting("Comnz", "Settings", "TxtAct2", "^v")
        TxtAct3.Text = GetSetting("Comnz", "Settings", "TxtAct3", "^x")
        TxtAct4.Text = GetSetting("Comnz", "Settings", "TxtAct4", "^a")



        NormalizePs()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub EnableDisableServer()
        If chkBxServer.Checked = True Then
            Try
                Subscriber = New Sockets.UdpClient(CInt(LocalServerPort))
                TmrUDP.Enabled = True
                Subscriber.Client.ReceiveTimeout = 100
                Subscriber.Client.Blocking = False
            Catch ex As Exception
                MsgBox(ex.Message)
                chkBxServer.Checked = False
            End Try
            StLbl1.BackColor = Color.FromArgb(0, 164, 14)
            updnPort.Enabled = False

        Else
            Subscriber.Close()
            TmrUDP.Enabled = False
            StLbl1.BackColor = Color.FromArgb(164, 164, 164)
            updnPort.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkBxServer.CheckedChanged
        EnableDisableServer()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles updnPort.ValueChanged
        LocalServerPort = updnPort.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TmrClearReceivedFields.Tick
        lblIncoming.Text = ""
        TmrClearReceivedFields.Enabled = False
    End Sub

    Private Sub TmrClearRX_Tick(sender As Object, e As EventArgs) Handles TmrClearRX.Tick
        StLbl2.BackColor = Color.FromArgb(224, 224, 224)
        TmrClearRX.Enabled = False
    End Sub

    Private Sub TmrClearStatusLbl_Tick(sender As Object, e As EventArgs) Handles TmrClearStatusLbl.Tick
        StLbl3.Text = ""
        TmrClearStatusLbl.Enabled = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NTIcn.Visible = False
        StoreValues()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        '  Me.ShowInTaskbar = False

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NTIcn.MouseDoubleClick
        Me.Show()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        KeepHistory = CheckBox2.Checked
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        F_ID = TxtID.Text
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'If CheckBox3.Checked = True Then
        '    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        'Else
        '    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        'End If
        Dim applicationName As String = Application.ProductName
        Dim applicationPath As String = Application.ExecutablePath


        If CheckBox3.Checked Then
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue(applicationName, """" & applicationPath & """")
            regKey.Close()
        Else
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue(applicationName, False)
            regKey.Close()
        End If


    End Sub

    Sub NormalizePs()
        P1.BackColor = Color.DarkSeaGreen
        P2.BackColor = Color.DarkSeaGreen
        P3.BackColor = Color.DarkSeaGreen
        P4.BackColor = Color.DarkSeaGreen
        P5.BackColor = Color.DarkSeaGreen
        If LastTabStanding = 1 Then
            P1.BackColor = Color.Indigo
        ElseIf LastTabStanding = 2 Then
            P2.BackColor = Color.Indigo
        End If
    End Sub

    Private Sub P1_MouseHover(sender As Object, e As EventArgs) Handles P1.MouseHover, Lnk1.MouseHover
        NormalizePs()
        P1.BackColor = Color.SlateBlue
    End Sub

    Private Sub P2_MouseHover(sender As Object, e As EventArgs) Handles P2.MouseHover, Lnk2.MouseHover
        NormalizePs()
        P2.BackColor = Color.SlateBlue
    End Sub
    Private Sub P3_MouseHover(sender As Object, e As EventArgs) Handles P3.MouseHover, Lnk3.MouseHover
        NormalizePs()
        P3.BackColor = Color.SlateBlue
    End Sub
    Private Sub P4_MouseHover(sender As Object, e As EventArgs) Handles P4.MouseHover, Lnk4.MouseHover
        NormalizePs()
        P4.BackColor = Color.SlateBlue
    End Sub
    Private Sub P5_MouseHover(sender As Object, e As EventArgs) Handles P5.MouseHover, Lnk5.MouseHover
        NormalizePs()
        P5.BackColor = Color.SlateBlue
    End Sub

    Private Sub Pnl1_MouseHover(sender As Object, e As EventArgs) Handles Pnl1.MouseHover
        NormalizePs()

    End Sub

    Private Sub Pnl2_MouseHover(sender As Object, e As EventArgs) Handles Pnl2.MouseHover
        NormalizePs()

    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover

        NormalizePs()


    End Sub



    Private Sub Lnk5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk5.LinkClicked
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk4.LinkClicked
        Me.Hide()
        NormalizePs()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk2.LinkClicked

        Pnl1.Visible = True
        Pnl2.Visible = False
        LastTabStanding = 2
        P2.BackColor = Color.Indigo
        NormalizePs()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk1.LinkClicked
        Pnl2.Visible = True
        Pnl1.Visible = False
        LastTabStanding = 1
        P1.BackColor = Color.Indigo
        NormalizePs()
    End Sub



    Private Sub Lnk1_MouseDown(sender As Object, e As MouseEventArgs) Handles Lnk1.MouseDown
        NormalizePs()
    End Sub

    Private Sub Lnk2_MouseDown(sender As Object, e As MouseEventArgs) Handles Lnk2.MouseDown
        NormalizePs()
    End Sub

    Private Sub TmrRefreshGUI_Tick(sender As Object, e As EventArgs) Handles TmrRefreshGUI.Tick
        If chkBxServer.Checked = True Then
            StLbl1.BackColor = Color.FromArgb(0, 164, 14)
        Else
            StLbl1.BackColor = Color.FromArgb(164, 164, 164)

        End If
    End Sub

    Private Sub Lnk3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk3.LinkClicked
        FrmAbout.ShowDialog()
        NormalizePs()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://bit.ly/38xdJa4")
    End Sub

    Private Sub P2_Paint(sender As Object, e As PaintEventArgs) Handles P2.Paint

    End Sub
End Class
