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
            PesquisaDeClienteToolStripMenuItem.Visible = False

        ElseIf tipo_conta = "Visitante" Then
            ManutençãoDeContasToolStripMenuItem.Visible = False
            ClientesToolStripMenuItem.Visible = False
            CaixaToolStripMenuItem.Visible = False
            FornecedoresToolStripMenuItem.Visible = False
        End If
    End Sub


    Private Sub ListarContasAtivasbloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarContasAtivasbloqueadasToolStripMenuItem.Click
        ultimoForm = Me
        tabela = "tb_adm"
        frm_manutencao.Show()
        Hide()
    End Sub

    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        ultimoForm = Me
        frm_cadastroadm.Show()
        Hide()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        ultimoForm = Me
        frm_cadastrocli.Show()
        Hide()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        ultimoForm = Me
        frm_fornecedor.Show()
        Hide()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        ultimoForm = Me
        frm_menuinicial.Show()
        Hide()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AdministrarFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarFilaToolStripMenuItem.Click
        ultimoForm = Me
        frm_fila.Show()
        Hide()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        ultimoForm = Me
        frm_caixa.Show()
        Hide()
    End Sub

    Private Sub frm_menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menuinicial.Show()
    End Sub

    Private Sub PesquisaDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisaDeClienteToolStripMenuItem.Click
        ultimoForm = Me
        tabela = "tb_cliente"
        frm_manutencao.Show()
        Hide()
    End Sub
End Class