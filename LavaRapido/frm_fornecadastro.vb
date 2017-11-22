Imports MetroFramework
Public Class frm_fornecadastro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Criar.Click
        If txt_nomef.Text = Nothing Or txt_nomep.Text = Nothing Or IsNumeric(txt_qtd.Text) = False Or IsNumeric(txt_preco.Text) = False Then
            MetroMessageBox.Show(Me, "Preencha todos os dados corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If frm_fornecedor.editar = 1 Then
                sql = "UPDATE tb_fornecedores set nome_fornecedor = '" & txt_nomef.Text & "' , nome_produto = '" & txt_nomep.Text &
                    "' , quantidade = '" & txt_qtd.Text & "' , preco = '" & txt_preco.Text & "' , data_compra = '" & dtp_dia.Value.ToShortDateString &
                    "' where id_produto = " & frm_fornecedor.aux & ""
            Else
                sql = "INSERT INTO tb_fornecedores (nome_fornecedor, nome_produto, quantidade, preco, data_compra) VALUES(" &
                "'" & txt_nomef.Text & "', '" & txt_nomep.Text & "', '" & txt_qtd.Text & "', " &
                "'" & txt_preco.Text & "', '" & dtp_dia.Value.ToShortDateString & "')"
            End If
            db.Execute(sql)
            MetroMessageBox.Show(Me, "Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            With frm_fornecedor.dgv_fornecedor
                .Rows.Clear()
                sql = "select * from tb_fornecedores"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rg = rs.Fields(0).Value
                    rs.MoveNext()
                Loop
            End With

        End If

    End Sub

    Private Sub frm_fornecadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub
End Class