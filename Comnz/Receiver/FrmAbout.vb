Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Application.ProductVersion
        Me.Top = FrmMAin.Top + ((FrmMAin.Height - Me.Height) / 2)
        Me.Left = FrmMAin.Left + ((FrmMAin.Width - Me.Width) / 2)
        PictureBox1.Image = My.Resources.Comnz_Blue

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("https://www.facebook.com/Hand-Water-Pump-1262766350490203/")
        Catch ex As Exception

        End Try
    End Sub
End Class