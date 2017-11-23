Public Class frm_menuinicial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ultimoForm = Me
        frm_cadastrocli.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ultimoForm = Me
        frm_login.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tipo_conta = "Visitante"
        ultimoForm = Me
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub frm_menuinicial_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class