Imports System.ComponentModel
Imports MetroFramework
Public Class frm_cadastrocli
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_perguntas.Items
            .Add("Qual é o segundo nome da mãe?")
            .Add("Primeira escola que estudou?")
            .Add("Qual era o nome do seu primeiro animal de estimação?")
            .Add("Qual é a sua comida favorita?")
            .Add("Qual é a profissão do seu avô?")
            .Add("Nome da empresa do seu primeiro emprego?")
        End With
        cmb_perguntas.SelectedIndex = 0
        conecta_banco()
    End Sub

    Private Sub cb_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizar.CheckedChanged
        If cb_visualizar.Checked Then
            txt_senha.PasswordChar = Nothing
            txt_repetir.PasswordChar = Nothing
        Else
            txt_senha.PasswordChar = "*"
            txt_repetir.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        If txt_nomecompleto.Text = Nothing Or txt_rg.MaskCompleted = False Or txt_cpf.MaskCompleted = False Or txt_dtnasc.MaskCompleted = False Or txt_foneres.MaskCompleted = False Or txt_cel.MaskCompleted = False Or txt_usuario.Text = Nothing Or txt_email.Text = Nothing Or txt_senha.Text = Nothing Or txt_repetir.Text = Nothing Or txt_resposta.Text = Nothing Then
            MetroMessageBox.Show(Me, "Todos os campos precisam ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If StrComp(txt_senha.Text, txt_repetir.Text, vbBinaryCompare) = 0 Then

                If Not IsDate(txt_dtnasc.Text) Then
                    MetroMessageBox.Show(Me, "Digite uma data de nascimento válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                txt_rg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                    sql = "SELECT * FROM tb_cliente WHERE rg='" & txt_rg.Text & "' OR usuario='" & txt_usuario.Text & "'"
                    rs = db.Execute(sql)

                If rs.EOF = True Then
                    Try
                        sql = "INSERT INTO tb_cliente (rg, nome, usuario, senha, cpf, datanasc, foneres, cel, email," &
                                  "pergunta_secreta, resposta_secreta, bonus, tipo_conta, status_conta, n_tentativas) VALUES ('" & txt_rg.Text & "', '" _
                                  & txt_nomecompleto.Text & "', '" & txt_usuario.Text & "', '" & txt_senha.Text & "', '" _
                                  & txt_cpf.Text & "', '" & txt_dtnasc.Text & "', '" & txt_foneres.Text & "', '" _
                                  & txt_cel.Text & "', '" & txt_email.Text & "', '" & cmb_perguntas.Text & "', '" _
                                  & txt_resposta.Text & "', 'nenhum', 'Cliente', 'ativa', 3)"
                        db.Execute(sql)
                        txt_rg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
                        MetroMessageBox.Show(Me, "Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txt_cel.Clear()
                        txt_cpf.Clear()
                        txt_dtnasc.Clear()
                        txt_email.Clear()
                        txt_foneres.Clear()
                        txt_nomecompleto.Clear()
                        txt_repetir.Clear()
                        txt_resposta.Clear()
                        txt_rg.Clear()
                        txt_senha.Clear()
                        txt_usuario.Clear()

                    Catch ex As Exception
                        MsgBox(ex)
                    End Try

                Else
                    MetroMessageBox.Show(Me, "Usuário já cadastrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                    MetroMessageBox.Show(Me, "Senhas não coincidem", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub frm_cadastrocli_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ultimoForm.Show()
    End Sub
End Class