Imports System.Net.Mail, MetroFramework, System.Text

Public Class frm_recuperaradm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_email.Text = Nothing Then
            Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

            Dim sb As New StringBuilder()
            Dim rand As New Random()
            For i As Integer = 1 To 10
                Dim idx As Integer = rand.Next(0, validchars.Length)
                Dim randomChar As Char = validchars(idx)
                sb.Append(randomChar)
            Next i

            Dim randomString = sb.ToString()
            MsgBox(randomString)

            MetroMessageBox.Show(Me, "Você precisa preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("sistemalavarapido@gmail.com", "sistemalavarapidofatec")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("Lava Rápido")
                e_mail.To.Add(txt_email.Text)
                e_mail.Subject = "Recuperação de senha do Administrador"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Seu código de confirmação é: " & vbCrLf & "Digite esse código em"
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent")
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Não foi possível enviar o seu email." & vbCrLf &
                                     "Verifique se o email digitado está correto ou se você possui conexão com a Internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub frm_recuperaradm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_email.Text = usuario
    End Sub
End Class