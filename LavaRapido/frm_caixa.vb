Public Class frm_caixa
    Dim contlista, rg As Integer
    Dim total As Double

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        With cmb_servico.Items
            .Add("Lavagem Básica")
            .Add("Lavagem Completa")
            .Add("Enceramento")
            .Add("Polimento")
        End With
        contlista = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        If cmb_servico.SelectedItem = "Lavagem Básica" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$20,00", Nothing, Nothing)
            total = total + 20

        ElseIf cmb_servico.SelectedItem = "Lavagem Completa" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$40,00", Nothing, Nothing)
            total = total + 40

        ElseIf cmb_servico.SelectedItem = "Enceramento" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$50,00", Nothing, Nothing)
            total = total + 50

        ElseIf cmb_servico.SelectedItem = "Polimento" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$70,00", Nothing, Nothing)
            total = total + 70

        End If

        contlista = contlista + 1
        lbl_total.Text = total.ToString("c")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs)
        If cmb_servico.SelectedItem = "Lavagem Básica" Then
            total = total + 20

        ElseIf cmb_servico.SelectedItem = "Lavagem Completa" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$40,00", Nothing, Nothing)
            total = total + 40

        ElseIf cmb_servico.SelectedItem = "Enceramento" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$50,00", Nothing, Nothing)
            total = total + 50

        ElseIf cmb_servico.SelectedItem = "Polimento" Then
            dgv_caixa.Rows.Add(cmb_servico.SelectedItem, "R$70,00", Nothing, Nothing)
            total = total + 70
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inciarcaixa.Click
        With dgv_caixa
            contlista = 1
            .Rows.Clear()
            sql = "SELECT nome_servico, preco_servico FROM (tb_cliente INNER JOIN tb_fila ON tb_cliente.rg = tb_fila.rg) INNER JOIN tb_servicos ON tb_fila.id_servico = tb_servicos.id_servico WHERE tb_cliente.rg='111111111' "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields("nome_servico").Value, rs.Fields("preco_servico").Value, Nothing)
                rs.MoveNext()
                contlista = contlista + 1
            Loop
        End With
    End Sub
End Class