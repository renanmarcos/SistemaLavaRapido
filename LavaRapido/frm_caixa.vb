Public Class frm_caixa
    Dim contlista As Integer
    Dim total As Double
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class