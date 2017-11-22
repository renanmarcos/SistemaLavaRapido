Imports System.Net.Mail, MetroFramework, System.Text

Public Class frm_recuperaradm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txt_email.Text = Nothing Then
            MetroMessageBox.Show(Me, "Você precisa preencher o campo de E-Mail.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sql = "SELECT * FROM tb_adm WHERE email='" & txt_email.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF Then
                MetroMessageBox.Show(Me, "Não encontramos seu E-Mail em nosso banco. Por favor, verifique se o campo está preenchido corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

                Dim sb As New StringBuilder()
                Dim rand As New Random()

                For i As Integer = 1 To 6
                    Dim idx As Integer = rand.Next(0, validchars.Length)
                    Dim randomChar As Char = validchars(idx)
                    sb.Append(randomChar)
                Next i

                Dim codigoConfirmacao = sb.ToString()

                Try
                    Dim Smtp_Server As New SmtpClient
                    Dim e_mail As New MailMessage()
                    Smtp_Server.UseDefaultCredentials = False
                    Smtp_Server.Credentials = New Net.NetworkCredential("sistemalavarapido@gmail.com", "sistemalavarapidofatec")
                    Smtp_Server.Port = 587
                    Smtp_Server.EnableSsl = True
                    Smtp_Server.Host = "smtp.gmail.com"

                    e_mail = New MailMessage()
                    e_mail.From = New MailAddress("sistemalavarapido@gmail.com")
                    e_mail.To.Add(txt_email.Text)
                    e_mail.Subject = "Recuperação de senha do Administrador"
                    e_mail.IsBodyHtml = False
                    e_mail.Body = "Seu código de confirmação é: " & codigoConfirmacao & vbCrLf & "Digite esse código no programa."
                    Smtp_Server.Send(e_mail)
                Catch ex As Exception
                    MetroMessageBox.Show(Me, "Não foi possível enviar o seu email." & vbCrLf &
                                        "Verifique se o email digitado está correto ou se você possui conexão com a Internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                Dim inputUsuario As New metroInput
                Dim text As String = ""
                inputUsuario.ShowDialog(text, "Digite o código de confirmação:", False, False, Nothing)

                If text = codigoConfirmacao Then
                    MetroMessageBox.Show(Me, "Sua senha é: " & rs.Fields("senha").Value, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf text = "" Then
                    Exit Sub
                Else
                    MetroMessageBox.Show(Me, "O código informado está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub frm_recuperaradm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        txt_email.Text = usuario
    End Sub
End Class