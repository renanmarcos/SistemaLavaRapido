<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManutençãoDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarContasAtivasbloqueadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarFilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManutençãoDeContasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CaixaToolStripMenuItem, Me.AdministrarFilaToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1072, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManutençãoDeContasToolStripMenuItem
        '
        Me.ManutençãoDeContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeContasToolStripMenuItem, Me.ListarContasAtivasbloqueadasToolStripMenuItem})
        Me.ManutençãoDeContasToolStripMenuItem.Name = "ManutençãoDeContasToolStripMenuItem"
        Me.ManutençãoDeContasToolStripMenuItem.Size = New System.Drawing.Size(204, 29)
        Me.ManutençãoDeContasToolStripMenuItem.Text = "Manutenção de contas"
        '
        'CadastroDeContasToolStripMenuItem
        '
        Me.CadastroDeContasToolStripMenuItem.Name = "CadastroDeContasToolStripMenuItem"
        Me.CadastroDeContasToolStripMenuItem.Size = New System.Drawing.Size(344, 30)
        Me.CadastroDeContasToolStripMenuItem.Text = "Cadastro de contas"
        '
        'ListarContasAtivasbloqueadasToolStripMenuItem
        '
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Name = "ListarContasAtivasbloqueadasToolStripMenuItem"
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Size = New System.Drawing.Size(344, 30)
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Text = "Listar contas ativas/bloqueadas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem, Me.PesquisaDeClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de clientes"
        '
        'PesquisaDeClienteToolStripMenuItem
        '
        Me.PesquisaDeClienteToolStripMenuItem.Name = "PesquisaDeClienteToolStripMenuItem"
        Me.PesquisaDeClienteToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.PesquisaDeClienteToolStripMenuItem.Text = "Pesquisa de Cliente"
        '
        'CaixaToolStripMenuItem
        '
        Me.CaixaToolStripMenuItem.Name = "CaixaToolStripMenuItem"
        Me.CaixaToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.CaixaToolStripMenuItem.Text = "Caixa"
        '
        'AdministrarFilaToolStripMenuItem
        '
        Me.AdministrarFilaToolStripMenuItem.Name = "AdministrarFilaToolStripMenuItem"
        Me.AdministrarFilaToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.AdministrarFilaToolStripMenuItem.Text = "Fila de Carros"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoToolStripMenuItem, Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar sessão"
        '
        'EncerrarSistemaToolStripMenuItem
        '
        Me.EncerrarSistemaToolStripMenuItem.Name = "EncerrarSistemaToolStripMenuItem"
        Me.EncerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.EncerrarSistemaToolStripMenuItem.Text = "Encerrar sistema"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 482)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_menu"
        Me.Text = "frm_menuadm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManutençãoDeContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarContasAtivasbloqueadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarFilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisaDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
End Class
