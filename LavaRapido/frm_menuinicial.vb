﻿Public Class frm_menuinicial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_cadastrocli.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tipo_conta = "Visitante"
        frm_menu.Show()
    End Sub
End Class