Imports System.IO

Module Module_Log
    Public KeepHistory As Boolean
    Public Log As Boolean = True
    Public Debug As Boolean = False
    Dim PreviousLogText As String = ""
    ' Dim ComputerName = GetCurrentComputerName()

    'Function GetCurrentComputerName() As String
    '    Dim cname As String = "N/A"
    '    Try ' Added to fix bug reported by end user
    '        ' Bug possible is the one mentioned on: https://stackoverflow.com/questions/17980178/cannot-load-counter-name-data-because-an-invalid-index-exception
    '        ' Manual fix: Click Start, type cmd right click cmd.exe, and select Run as administrator. At the prompt, type lodctr /r and press ENTER.
    '        cname = My.Computer.Name.ToString()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return My.Computer.Name.ToString()
    'End Function

    Public Sub Logit(ByVal LogData As String)
        If Log = True And PreviousLogText <> LogData Then
            Try
                Using w As StreamWriter = File.AppendText(Application.StartupPath & "\Comnz_activity.log")
                    w.WriteLine(DateTime.Now & " :: " & LogData)
                    w.Close()
                    PreviousLogText = LogData
                End Using
            Catch
            End Try
        Else
            Exit Sub
        End If






    End Sub



    Public Sub Debuglog(ByVal LogData As String)
        If Debug = True And PreviousLogText <> LogData Then
            Try
                Using w As StreamWriter = File.AppendText(Application.StartupPath & "\Comnz_debug.log")
                    w.WriteLine(DateTime.Now & " :: " & LogData)
                    w.Close()
                    PreviousLogText = LogData
                End Using
            Catch
            End Try
        Else
            Exit Sub
        End If






    End Sub

    Public Sub MsgHistory(ByVal LogData As String)

        If KeepHistory = True And PreviousLogText <> LogData Then
            Try
                Using w As StreamWriter = File.AppendText(Application.StartupPath & "\Comnz_message_history.txt")
                    w.WriteLine(DateTime.Now & " :: " & LogData)
                    w.Close()
                    PreviousLogText = LogData
                End Using
            Catch
            End Try
        End If
    End Sub

End Module