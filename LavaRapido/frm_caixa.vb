Imports MetroFramework

Public Class frm_caixa
    Public contlista, cont, rg, caixa
    Dim total, desconto, precofinal As Double
    Dim resp As String

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caixa = 0
        conecta_banco()
        With dgv_dados
            .Rows.Clear()
            sql = "select * from tb_cliente"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lbl_precofinal.Click

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        rg = dgv_dados.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub txt_parametros_Click(sender As Object, e As EventArgs) Handles txt_parametros.Click

    End Sub

    Private Sub btn_gerarm_Click(sender As Object, e As EventArgs) Handles btn_gerarm.Click
        frm_relatoriomensal.Show()
    End Sub

    Private Sub txt_parametros_TextChanged(sender As Object, e As EventArgs) Handles txt_parametros.TextChanged
        With dgv_dados
            contlista = 1
            .Rows.Clear()
            sql = "select * from tb_cliente where rg like '" & txt_parametros.Text & "%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
                contlista = contlista + 1
            Loop
        End With

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If caixa = 1 Then
            resp = MetroMessageBox.Show(Me, "Você está certo disso", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resp = MsgBoxResult.Yes Then
                sql = "INSERT INTO tb_caixa (preco_total, data, hora, rg, mes) VALUES(" &
                "'" & precofinal & "', '" & DateTime.Today.ToShortDateString & "', '" & DateTime.Now.ToShortTimeString & "', " &
                "'" & rg & "', '" & DateTime.Today.Month & "')"
                db.Execute(sql)

            End If
        Else
            MetroMessageBox.Show(Me, "Caixa não foi iniciado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DataGridView1_CellContentChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_caixa.CellValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inciarcaixa.Click
        total = 0
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
        For Each col As DataGridViewRow In dgv_caixa.Rows
            total = total + col.Cells(1).Value
            lbl_total.Text = total.ToString("c")
        Next
        MsgBox("Caixa criado com sucesso")
        sql = "SELECT * from tb_cliente where rg ='" & rg & "'"
        rs = db.Execute(sql)
        If String.Compare(rs.Fields("bonus").ToString, "desconto") Then

            desconto = (Integer.Parse(rs.Fields("qtd_idas").Value)) * 0.42
            lbl_desconto.Text = desconto.ToString("c")
        End If
        precofinal = total - desconto
        lbl_precofinal.Text = precofinal.ToString("c")
        caixa = 1
    End Sub
End Class