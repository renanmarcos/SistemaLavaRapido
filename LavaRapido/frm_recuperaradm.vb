Public Class frm_recuperaradm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Digite o código de confirmação enviada no email: (em desenvolvimento)")
    End Sub

    Private Sub frm_recuperaradm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_email.Text = usuario
    End Sub
End Class