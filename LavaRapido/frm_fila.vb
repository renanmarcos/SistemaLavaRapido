Imports MetroFramework
Imports System.Globalization
Public Class frm_fila
    Dim resp, total As Integer
    Dim diaAnterior As String
    Private Sub frm_fila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        cb_hoje.Checked = True
        rd_todos.Checked = True

        If tipo_conta = "Cliente" Or tipo_conta = "Visitante" Then
            dgv_fila.Columns("btn_concluido").Visible = False
            dgv_fila.Columns("btn_pagar").Visible = False
        End If

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
                sql = "SELECT * FROM tb_fila WHERE dia=#" & data & "# ORDER BY hora"
            Else
                sql = "SELECT * FROM tb_fila WHERE dia=#" & data & "# AND status='" & status & "' ORDER BY hora"
            End If

            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("rg").Value, rs.Fields("dia").Value, rs.Fields("hora").Value,
                          rs.Fields("carro").Value, rs.Fields("placa").Value, Nothing, rs.Fields("valor_total").Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Private Sub dgv_fila_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fila.CellContentClick
        With dgv_fila.CurrentRow
            If .Cells("btn_concluido").Selected Then
                If tipo_conta = "Cliente" Or tipo_conta = "Visitante" Then
                    MetroMessageBox.Show(Me, "Você não pode marcar um carro como concluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    resp = MetroMessageBox.Show(Me, "Tem certeza que deseja marcar como concluído?", "Marcar como concluído", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If resp = DialogResult.Yes Then
                        sql = "UPDATE tb_fila SET status='concluído' WHERE placa='" & dgv_fila.CurrentRow.Cells(5).Value & "'"
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
        If txt_carro.Text = Nothing Or txt_placa.MaskCompleted = False Or total = 0 Or txt_hora.Text = Nothing Then
            MetroMessageBox.Show(Me, "Você precisa preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If tipo_conta = "Visitante" Then
                Dim inputUsuario As New metroInput
                Dim text As String = ""
                inputUsuario.ShowDialog(text, "Digite o seu RG:", False, True, "00,000,000-0")

                If text = "" Then
                    Exit Sub
                ElseIf text = "incompleto" Then
                    MsgBox("incompleto")
                    Exit Sub
                Else
                    MsgBox(text)
                    rg = text
                End If

            End If

            Try
                Dim horarioInicio As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("08:00"))
                Dim horarioAlmoco As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("12:00").AddMinutes(-30))
                Dim horarioDepoisAlmoco As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("13:00"))
                Dim horarioFinal As Integer = DateTime.Compare(DateTime.Parse(txt_hora.Text), DateTime.Parse("17:00").AddMinutes(-30))

                If (((horarioInicio < 0) Or (horarioAlmoco > 0)) And ((horarioDepoisAlmoco < 0) Or (horarioFinal > 0))) Or (dtp_dia.Value.DayOfWeek = 6 Or dtp_dia.Value.DayOfWeek = 0) Then
                    MetroMessageBox.Show(Me, "Você precisa digitar uma hora e dia válidos." & vbCrLf &
                                         "Horário: Segunda à Sexta das 08:00 às 12:00 e das 13:00 às 17:00" & vbCrLf &
                                         "Só agendamos com 30 minutos de diferenças entre carros, pois é o tempo que levamos para lavar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    sql = "SELECT * FROM tb_fila WHERE dia=#" & dtp_dia.Value.ToShortDateString & "#" &
                          "AND hora BETWEEN #" & txt_hora.Text & "# - #00:29# AND #" & txt_hora.Text & "# + #00:30#"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        MetroMessageBox.Show(Me, "Esse horário já está sendo utilizado ou o intervalo entre carros excede 30 minutos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        sql = "INSERT INTO tb_fila (dia, hora, carro, placa, rg, status, valor_total)" &
                           "VALUES(#" & dtp_dia.Value.ToShortDateString & "#, #" & txt_hora.Text & "#," &
                            "'" & txt_carro.Text & "', '" & txt_placa.Text & "', '" & rg & "', 'em fila', " & total & ")"
                        db.Execute(sql)

                        Dim id As Integer

                        sql = "SELECT MAX(id_servico) FROM tb_fila"
                        rs = db.Execute(sql)
                        id = rs.Fields(0).Value

                        For Each C As Controls.MetroCheckBox In gb_servico.Controls.OfType(Of Controls.MetroCheckBox)()
                            If C.Checked Then
                                sql = "INSERT INTO tb_servicos VALUES(" & id & ", '" & C.Text.Split("-")(0) & "'," &
                                    "" & Double.Parse(C.Text.Split("-")(1), NumberStyles.Currency) & ")"
                                db.Execute(sql)
                            End If
                        Next

                        MetroMessageBox.Show(Me, "Carro agendado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        gerar_dados(dtp_selecionarDia.Value.ToShortDateString, Nothing, True)

                    End If
                End If

            Catch ex As FormatException
                MetroMessageBox.Show(Me, "Hora inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dtp_dia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dia.ValueChanged
        If dtp_dia.Value < DateTime.Today Then
            MetroMessageBox.Show(Me, "Você não pode marcar um dia que seja anterior à hoje", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtp_dia.Value = DateTime.Today
        ElseIf dtp_dia.Value.DayOfWeek = 0 Then
            MetroMessageBox.Show(Me, "Trabalhamos apenas de Segunda à Sexta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtp_dia.Value = dtp_dia.Value.AddDays(+1)
        ElseIf dtp_dia.Value.DayOfWeek = 6 Then
            MetroMessageBox.Show(Me, "Trabalhamos apenas de Segunda à Sexta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtp_dia.Value = dtp_dia.Value.AddDays(-1)
        End If
    End Sub

    Private Sub atualizaTotal()
        lbl_total.Text = "Total: " + total.ToString("c2")
    End Sub

    Private Sub txt_hora_LostFocus(sender As Object, e As EventArgs) Handles txt_hora.LostFocus
        If txt_hora.Text < DateTime.Now.ToString("HH:mm") Then
            MetroMessageBox.Show(Me, "Você não pode marcar uma hora menor do que a hora atual", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_hora.Text = DateTime.Now.ToShortTimeString
        End If
    End Sub
End Class