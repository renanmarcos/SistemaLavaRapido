Public Class frm_menu
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo_conta = "Cliente" Then
            ManutençãoDeContasToolStripMenuItem.Visible = False
            ClientesToolStripMenuItem.Visible = False
            CaixaToolStripMenuItem.Visible = False
            FornecedoresToolStripMenuItem.Visible = False

        ElseIf tipo_conta = "Funcionário" Then
            ManutençãoDeContasToolStripMenuItem.Visible = False
            FornecedoresToolStripMenuItem.Visible = False

        ElseIf tipo_conta = "Visitante" Then
            ManutençãoDeContasToolStripMenuItem.Visible = False
            ClientesToolStripMenuItem.Visible = False
            CaixaToolStripMenuItem.Visible = False
            FornecedoresToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ListarContasAtivasbloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarContasAtivasbloqueadasToolStripMenuItem.Click
        frm_manutencao.Show()
    End Sub

    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        frm_cadastroadm.Show()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        frm_cadastrocli.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        frm_fornecedor.Show()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AdministrarFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarFilaToolStripMenuItem.Click
        frm_fila.Show()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        frm_caixa.Show()
    End Sub
End Class