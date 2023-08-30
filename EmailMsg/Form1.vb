Imports System.Net.Mail
Public Class EmailForm

    Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_server.UseDefaultCredentials = True

            smtp_server.Credentials = New Net.NetworkCredential("shivulr1986@gmail.com", "zdctirmyckdmnler")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txt_From.Text)
            e_mail.To.Add(Txt_To.Text)
            e_mail.Subject = txt_Subject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = txt_Message.Text
            smtp_server.Send(e_mail)
            MsgBox("email sent successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Not Sent failed", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
