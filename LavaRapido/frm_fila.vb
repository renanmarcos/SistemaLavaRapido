Imports MetroFramework
Public Class frm_fila
    Dim resp, total As Integer
    Dim diaAnterior As String
    Private Sub frm_fila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        rg = "111111111"
        cb_hoje.Checked = True
        rd_todos.Checked = True
    End Sub

    Private Sub dtp_selecionarDia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_selecionarDia.ValueChanged
        If dtp_selecionarDia.Value.ToShortDateString = DateTime.Today.ToShortDateString Then
            dtp_selecionarDia.Enabled = False
            cb_hoje.Checked = True
        Else
            dtp_selecionarDia.Enabled = True
            cb_hoje.Checked = False

            If rd_todos.Checked Then
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
            ElseIf rd_emfila.Checked Then
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
            Else
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
            End If

        End If
    End Sub

    Private Sub cb_hoje_CheckedChanged(sender As Object, e As EventArgs) Handles cb_hoje.CheckedChanged
        If cb_hoje.Checked Then
            diaAnterior = dtp_selecionarDia.Value.ToLongDateString
            dtp_selecionarDia.Enabled = False
            dtp_selecionarDia.Value = DateTime.Today.ToLongDateString

            If rd_todos.Checked Then
                gerar_dados(DateTime.Today.ToShortDateString, Nothing, True)
            ElseIf rd_emfila.Checked Then
                gerar_dados(DateTime.Today.ToShortDateString, "em fila", False)
            Else
                gerar_dados(DateTime.Today.ToShortDateString, "concluído", False)
            End If
        Else
            dtp_selecionarDia.Enabled = True
            dtp_selecionarDia.Value = diaAnterior
            If rd_todos.Checked Then
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
            ElseIf rd_emfila.Checked Then
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
            Else
                gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
            End If
        End If
    End Sub

    Private Sub gerar_dados(data As String, status As String, todos As Boolean)
        Dim cont As Integer

        With dgv_fila
            .Rows.Clear()
            .SelectionMode = DataGridViewSelectionMode.CellSelect

            If todos Then
                sql = "SELECT * FROM tb_fila WHERE rg='" & rg & "' AND dia=#" & data & "# ORDER BY hora"
            Else
                sql = "SELECT * FROM tb_fila WHERE rg='" & rg & "' AND dia=#" & data & "# AND status='" & status & "' ORDER BY hora"
            End If

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
                resp = MetroMessageBox.Show(Me, "Tem certeza que deseja marcar como concluído?", "Marcar como concluído", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resp = DialogResult.Yes Then
                    sql = "UPDATE tb_fila SET status='concluído' WHERE rg='" & rg & "' AND placa='" & dgv_fila.CurrentRow.Cells(5).Value & "'"
                    db.Execute(sql)
                    MetroMessageBox.Show(Me, "Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    If rd_todos.Checked Then
                        gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
                    ElseIf rd_emfila.Checked Then
                        gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
                    Else
                        gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
                    End If
                End If
            ElseIf .Cells("btn_pagar").Selected Then
                MsgBox("Pagando...")
            End If
        End With
    End Sub

    Private Sub rd_concluidos_CheckedChanged(sender As Object, e As EventArgs) Handles rd_concluidos.CheckedChanged
        If rd_todos.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
        ElseIf rd_emfila.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
        Else
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
        End If
    End Sub

    Private Sub rd_emfila_CheckedChanged(sender As Object, e As EventArgs) Handles rd_emfila.CheckedChanged
        If rd_todos.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
        ElseIf rd_emfila.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
        Else
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
        End If
    End Sub

    Private Sub rd_todos_CheckedChanged(sender As Object, e As EventArgs) Handles rd_todos.CheckedChanged
        If rd_todos.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)
        ElseIf rd_emfila.Checked Then
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "em fila", False)
        Else
            gerar_dados(dtp_selecionarDia.Value.ToShortDateString, "concluído", False)
        End If
    End Sub

    Private Sub txt_placa_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_placa.MaskInputRejected
        MetroToolTip1.Show("Você precisa digitar no formato ABC-1234", txt_placa, 0, 20, 5000)
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_hora.MaskInputRejected
        MetroToolTip1.Show("Você precisa digitar no formato 00:00", txt_hora, 0, 20, 5000)
    End Sub

    Private Sub cb_basica_CheckedChanged(sender As Object, e As EventArgs) Handles cb_basica.CheckedChanged
        If cb_basica.Checked Then
            total += 20
            cb_completa.Enabled = False
        Else
            total -= 20
            cb_completa.Enabled = True
        End If
        atualizaTotal()
    End Sub

    Private Sub cb_completa_CheckedChanged(sender As Object, e As EventArgs) Handles cb_completa.CheckedChanged
        If cb_completa.Checked Then
            total += 40
            cb_basica.Enabled = False
        Else
            total -= 40
            cb_basica.Enabled = True
        End If
        atualizaTotal()
    End Sub

    Private Sub cb_enceramento_CheckedChanged(sender As Object, e As EventArgs) Handles cb_enceramento.CheckedChanged
        If cb_enceramento.Checked Then
            total += 50
        Else
            total -= 50
        End If
        atualizaTotal()
    End Sub

    Private Sub cb_polimento_CheckedChanged(sender As Object, e As EventArgs) Handles cb_polimento.CheckedChanged
        If cb_polimento.Checked Then
            total += 70
        Else
            total -= 70
        End If
        atualizaTotal()
    End Sub

    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        'Integer.Parse(txt_hora.Text)
        Dim horarioInicio As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("08:00"))
        Dim horarioAlmoco As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("12:00"))
        Dim horarioDepoisAlmoco As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("13:00"))
        Dim horarioFinal As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("17:00"))

        If ((horarioInicio < 0) Or (horarioAlmoco > 0)) And ((horarioDepoisAlmoco < 0) Or (horarioFinal > 0)) Then
            MsgBox("Horário: 8 as 12 - das 13 as 17")
        Else
            If txt_carro.Text = Nothing Or txt_placa.MaskCompleted = False Or total = 0 Or txt_hora.Text = Nothing Then
                MetroMessageBox.Show(Me, "Você precisa preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' If Integer.Parse(txt_hora.Text) Then

                'End If

                sql = "SELECT * FROM tb_fila WHERE dia=#" & dtp_dia.Value.ToShortDateString & "#" &
                      "AND hora BETWEEN #" & txt_hora.Text & "# AND #" & txt_hora.Text & "# + #00:30#"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    MetroMessageBox.Show(Me, "Esse horário está cheio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub atualizaTotal()
        lbl_total.Text = "Total: " + total.ToString("c2")
    End Sub
End Class