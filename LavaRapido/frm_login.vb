Imports MetroFramework
Public Class frm_login
    Dim n_tentativas As Integer
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        With cmb_nivel.Items
            .Add("Cliente")
            .Add("Funcionário")
            .Add("Administrador")
        End With
        cmb_nivel.SelectedIndex = 0
        txt_usuario.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = Nothing Or txt_senha.Text = Nothing Then
            MetroMessageBox.Show(Me, "Você precisa digitar o usuário e senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If cmb_nivel.SelectedIndex = 0 Then
                verificarBanco("tb_cliente")
            Else
                verificarBanco("tb_adm")
            End If
        End If
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        If cmb_nivel.SelectedIndex = 0 Then
            verificarConta("tb_cliente")
        Else
            verificarConta("tb_adm")
        End If
    End Sub

    Private Sub cmb_nivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nivel.SelectedIndexChanged
        If cmb_nivel.SelectedIndex = 0 Then
            verificarConta("tb_cliente")
        Else
            verificarConta("tb_adm")
        End If
    End Sub

    Private Sub verificarBanco(banco As String)
        sql = "SELECT * FROM " & banco & " WHERE usuario='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            MetroMessageBox.Show(Me, "Usuário/senha está incorreto ou o tipo de conta não é a esperada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If n_tentativas <= 0 Then
                MetroMessageBox.Show(Me, "Você está bloqueado. Contacte um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn_entrar.Enabled = False
            Else
                Dim senhaExata = StrComp(txt_senha.Text, rs.Fields("senha").Value, vbBinaryCompare)
                Dim usuarioExato = StrComp(txt_usuario.Text, rs.Fields("usuario").Value, vbBinaryCompare)
                Dim emailExato = StrComp(txt_usuario.Text, rs.Fields("email").Value, vbBinaryCompare)

                If senhaExata = 0 And (usuarioExato = 0 Or emailExato = 0) Then
                    tipo_conta = cmb_nivel.Text

                    If tipo_conta = rs.Fields("tipo_conta").Value Then
                        tipo_conta = rs.Fields("tipo_conta").Value
                        rg = rs.Fields("rg").Value
                        frm_menu.Show()
                    Else
                        MetroMessageBox.Show(Me, "Você precisa acessar como " & rs.Fields("tipo_conta").Value, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MetroMessageBox.Show(Me, "Usuário ou senha está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    If Not rs.Fields("tipo_conta").Value = "Administrador" Then
                        n_tentativas = n_tentativas - 1
                        sql = "UPDATE " & banco & " SET n_tentativas =" & n_tentativas & ", status_conta='bloqueada' WHERE id_usuario = " & rs.Fields("id_usuario").Value & ""
                        db.Execute(sql)
                        lbl_tentativas.Text = n_tentativas

                        If n_tentativas = 0 Then
                            btn_entrar.Enabled = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub verificarConta(banco As String)
        sql = "SELECT * FROM " & banco & " WHERE usuario='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            lbl_tentativas.Text = rs.Fields("n_tentativas").Value.ToString
            n_tentativas = rs.Fields("n_tentativas").Value

            If n_tentativas <= 0 Then
                btn_entrar.Enabled = False
            Else
                btn_entrar.Enabled = True
            End If
        Else
            lbl_tentativas.Text = "3"
            n_tentativas = 3
            btn_entrar.Enabled = True
        End If
    End Sub

    Private Sub link_esqueceu_Click(sender As Object, e As EventArgs) Handles link_esqueceu.Click
        usuario = txt_usuario.Text
        frm_recuperar.Show()
    End Sub
End Class
