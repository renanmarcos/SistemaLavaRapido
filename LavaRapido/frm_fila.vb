Public Class frm_fila
    Dim resp As Integer
    Private Sub frm_fila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        rg = "111111111"
        cb_hoje.Checked = True
    End Sub

    Private Sub dtp_selecionarDia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_selecionarDia.ValueChanged
        If dtp_selecionarDia.Value.ToShortDateString = DateTime.Today.ToShortDateString Then
            dtp_selecionarDia.Enabled = False
            cb_hoje.Checked = True
        Else
            dtp_selecionarDia.Enabled = True
            cb_hoje.Checked = False
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString)
        End If
    End Sub

    Private Sub cb_hoje_CheckedChanged(sender As Object, e As EventArgs) Handles cb_hoje.CheckedChanged
        If cb_hoje.Checked Then
            dtp_selecionarDia.Enabled = False
            gerar_dados(DateTime.Today.ToShortDateString)
        Else
            dtp_selecionarDia.Enabled = True
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString)
        End If
    End Sub

    Private Sub gerar_dados(data As String)
        Dim cont As Integer

        With dgv_fila
            .Rows.Clear()
            sql = "SELECT * FROM tb_fila WHERE rg='" & rg & "' AND dia=#" & data & "# ORDER BY hora"
            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("rg").Value, rs.Fields("dia").Value, rs.Fields("hora").Value,
                          rs.Fields("carro").Value, rs.Fields("placa").Value, Nothing, 0, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Private Sub dgv_fila_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fila.CellContentClick
        With dgv_fila.CurrentRow
            If .Cells("btn_concluido").Selected Then
                resp = MsgBox("Tem certeza que deseja marcar como concluído?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Marcar como concluído")

                If resp = DialogResult.Yes Then
                    MsgBox("pressionou o sim")
                Else
                    MsgBox("pressionou o nao")
                End If
            ElseIf .Cells("btn_pagar").Selected Then
                MsgBox("Pagando...")
            End If
        End With
    End Sub

    Private Sub dtp_selecionarDia_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_selecionarDia.KeyDown
        'e.SuppressKeyPress = True
    End Sub
End Class