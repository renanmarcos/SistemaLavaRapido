Imports MetroFramework
Public Class frm_fornecadastro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Criar.Click
        If txt_nomef.Text = Nothing Or txt_nomep.Text = Nothing Or IsNumeric(txt_qtd.Text) = False Or IsNumeric(txt_preco.Text) = False Then
            MetroMessageBox.Show(Me, "Preencha todos os dados corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sql = "INSERT INTO tb_fornecedores (nome_fornecedor, nome_produto, quantidade, preco, data_compra) VALUES(" &
            "'" & txt_nomef.Text & "', '" & txt_nomep.Text & "', '" & txt_qtd.Text & "', " &
            "'" & txt_preco.Text & "', '" & dtp_dia.Value.ToShortDateString & "')"
            db.Execute(sql)
            MetroMessageBox.Show(Me, "Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_fornecedor.Show()
            frm_fornecedor.txt_parametros.Text = "test"
            frm_fornecedor.txt_parametros.Text = ""
        End If

    End Sub

    Private Sub frm_fornecadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub
End Class