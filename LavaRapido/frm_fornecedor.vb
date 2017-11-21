Public Class frm_fornecedor
    Public contlista As Integer
    Private Sub frm_fornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_selecao.Items
            .Add("id_produto")
            .Add("nome_fornecedor")
            .Add("nome_produto")
            .Add("data_compra")
        End With
        cmb_selecao.SelectedIndex() = 0
        conecta_banco()
        With dgv_fornecedor
            .Rows.Clear()
            sql = "select * from tb_fornecedores"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rg = rs.Fields(0).Value
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub txt_parametros_Click(sender As Object, e As EventArgs) Handles txt_parametros.Click
    End Sub

    Private Sub txt_parametros_TextChanged(sender As Object, e As EventArgs) Handles txt_parametros.TextChanged
        With dgv_fornecedor
            contlista = 1
            .Rows.Clear()
            sql = "select * from tb_fornecedores where " & cmb_selecao.Text & " Like '" & txt_parametros.Text & "%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rg = rs.Fields(0).Value
                rs.MoveNext()
                contlista = contlista + 1
            Loop
        End With
    End Sub

    Private Sub btn_Adicionar_Click(sender As Object, e As EventArgs) Handles btn_Adicionar.Click
        Me.Hide()
        frm_fornecadastro.Show()
    End Sub
End Class