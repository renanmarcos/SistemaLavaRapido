<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
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
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManutençãoDeContasToolStripMenuItem
        '
        Me.ManutençãoDeContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeContasToolStripMenuItem, Me.ListarContasAtivasbloqueadasToolStripMenuItem})
        Me.ManutençãoDeContasToolStripMenuItem.Name = "ManutençãoDeContasToolStripMenuItem"
        Me.ManutençãoDeContasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ManutençãoDeContasToolStripMenuItem.Text = "Manutenção de contas"
        '
        'CadastroDeContasToolStripMenuItem
        '
        Me.CadastroDeContasToolStripMenuItem.Name = "CadastroDeContasToolStripMenuItem"
        Me.CadastroDeContasToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CadastroDeContasToolStripMenuItem.Text = "Cadastro de contas"
        '
        'ListarContasAtivasbloqueadasToolStripMenuItem
        '
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Name = "ListarContasAtivasbloqueadasToolStripMenuItem"
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ListarContasAtivasbloqueadasToolStripMenuItem.Text = "Listar contas ativas/bloqueadas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem, Me.PesquisaDeClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de clientes"
        '
        'PesquisaDeClienteToolStripMenuItem
        '
        Me.PesquisaDeClienteToolStripMenuItem.Name = "PesquisaDeClienteToolStripMenuItem"
        Me.PesquisaDeClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PesquisaDeClienteToolStripMenuItem.Text = "Pesquisa de Cliente"
        '
        'CaixaToolStripMenuItem
        '
        Me.CaixaToolStripMenuItem.Name = "CaixaToolStripMenuItem"
        Me.CaixaToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.CaixaToolStripMenuItem.Text = "Caixa"
        '
        'AdministrarFilaToolStripMenuItem
        '
        Me.AdministrarFilaToolStripMenuItem.Name = "AdministrarFilaToolStripMenuItem"
        Me.AdministrarFilaToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.AdministrarFilaToolStripMenuItem.Text = "Fila de Carros"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoToolStripMenuItem, Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar sessão"
        '
        'EncerrarSistemaToolStripMenuItem
        '
        Me.EncerrarSistemaToolStripMenuItem.Name = "EncerrarSistemaToolStripMenuItem"
        Me.EncerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EncerrarSistemaToolStripMenuItem.Text = "Encerrar sistema"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 313)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_menu"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Menu"
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
