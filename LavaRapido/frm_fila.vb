Imports System.Globalization
Imports MetroFramework
Public Class frm_fila
    Dim resp As Integer
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
            dtp_selecionarDia.Enabled = False

            If rd_todos.Checked Then
                gerar_dados(DateTime.Today.ToShortDateString, Nothing, True)
            ElseIf rd_emfila.Checked Then
                gerar_dados(DateTime.Today.ToShortDateString, "em fila", False)
            Else
                gerar_dados(DateTime.Today.ToShortDateString, "concluído", False)
            End If
        Else
            dtp_selecionarDia.Enabled = True

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

    Private Sub dtp_selecionarDia_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_selecionarDia.KeyDown
        'e.SuppressKeyPress = True
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
End Class