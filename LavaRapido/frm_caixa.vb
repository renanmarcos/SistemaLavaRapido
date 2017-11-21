Public Class frm_caixa
    Dim contlista, rg As Integer
    Dim total As Double
    Dim resp As String
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

    End Sub

    Private Sub txt_parametros_Click(sender As Object, e As EventArgs) Handles txt_parametros.Click

    End Sub

    Private Sub txt_parametros_TextChanged(sender As Object, e As EventArgs) Handles txt_parametros.TextChanged
        With dgv_dados
            contlista = 1
            .Rows.Clear()
            sql = "select * from tb_cliente where rg like '" & txt_parametros.Text & "%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                rg = rs.Fields(0).Value
                rs.MoveNext()
                contlista = contlista + 1
            Loop
        End With
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inciarcaixa.Click
        With dgv_caixa
            contlista = 1
            .Rows.Clear()
            sql = "SELECT * FROM (tb_cliente INNER JOIN tb_fila ON tb_cliente.rg = tb_fila.rg) INNER JOIN tb_servicos ON tb_fila.id_servico = tb_servicos.id_servico WHERE tb_cliente.rg='" & rg & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields("nome_servico").Value, rs.Fields("preco_servico").Value, Nothing)
                rs.MoveNext()
                contlista = contlista + 1
            Loop
        End With
        MsgBox("Caixa criado com sucesso")
    End Sub
End Class