<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manutencao
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manutencao))
        Me.dgv_dados = New MetroFramework.Controls.MetroGrid()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ativar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_parametros = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_todas = New MetroFramework.Controls.MetroRadioButton()
        Me.cmb_selecione = New MetroFramework.Controls.MetroComboBox()
        Me.rd_bloqueadas = New MetroFramework.Controls.MetroRadioButton()
        Me.rd_ativas = New MetroFramework.Controls.MetroRadioButton()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AllowUserToResizeColumns = False
        Me.dgv_dados.AllowUserToResizeRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.usuario, Me.status, Me.ativar, Me.bloquear, Me.excluir})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados.EnableHeadersVisualStyles = False
        Me.dgv_dados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_dados.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dados.Location = New System.Drawing.Point(25, 128)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_dados.Size = New System.Drawing.Size(649, 337)
        Me.dgv_dados.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status conta"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'ativar
        '
        Me.ativar.HeaderText = "Ativar"
        Me.ativar.Image = CType(resources.GetObject("ativar.Image"), System.Drawing.Image)
        Me.ativar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ativar.Name = "ativar"
        Me.ativar.ReadOnly = True
        Me.ativar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ativar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'bloquear
        '
        Me.bloquear.HeaderText = "Bloquear"
        Me.bloquear.Image = CType(resources.GetObject("bloquear.Image"), System.Drawing.Image)
        Me.bloquear.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.bloquear.Name = "bloquear"
        Me.bloquear.ReadOnly = True
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        '
        'txt_parametros
        '
        '
        '
        '
        Me.txt_parametros.CustomButton.Image = Nothing
        Me.txt_parametros.CustomButton.Location = New System.Drawing.Point(241, 2)
        Me.txt_parametros.CustomButton.Name = ""
        Me.txt_parametros.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txt_parametros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_parametros.CustomButton.TabIndex = 1
        Me.txt_parametros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_parametros.CustomButton.UseSelectable = True
        Me.txt_parametros.CustomButton.Visible = False
        Me.txt_parametros.Lines = New String(-1) {}
        Me.txt_parametros.Location = New System.Drawing.Point(35, 97)
        Me.txt_parametros.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_parametros.MaxLength = 32767
        Me.txt_parametros.Name = "txt_parametros"
        Me.txt_parametros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_parametros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_parametros.SelectedText = ""
        Me.txt_parametros.SelectionLength = 0
        Me.txt_parametros.SelectionStart = 0
        Me.txt_parametros.ShortcutsEnabled = True
        Me.txt_parametros.Size = New System.Drawing.Size(259, 20)
        Me.txt_parametros.TabIndex = 19
        Me.txt_parametros.UseSelectable = True
        Me.txt_parametros.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_parametros.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Digite o parâmetro de busca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_todas)
        Me.GroupBox1.Controls.Add(Me.cmb_selecione)
        Me.GroupBox1.Controls.Add(Me.rd_bloqueadas)
        Me.GroupBox1.Controls.Add(Me.rd_ativas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.06993!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(321, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(354, 85)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione"
        '
        'rd_todas
        '
        Me.rd_todas.AutoSize = True
        Me.rd_todas.Location = New System.Drawing.Point(249, 58)
        Me.rd_todas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_todas.Name = "rd_todas"
        Me.rd_todas.Size = New System.Drawing.Size(54, 15)
        Me.rd_todas.TabIndex = 23
        Me.rd_todas.Text = "Todas"
        Me.rd_todas.UseSelectable = True
        '
        'cmb_selecione
        '
        Me.cmb_selecione.FormattingEnabled = True
        Me.cmb_selecione.ItemHeight = 23
        Me.cmb_selecione.Location = New System.Drawing.Point(12, 27)
        Me.cmb_selecione.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_selecione.Name = "cmb_selecione"
        Me.cmb_selecione.Size = New System.Drawing.Size(211, 29)
        Me.cmb_selecione.TabIndex = 0
        Me.cmb_selecione.UseSelectable = True
        '
        'rd_bloqueadas
        '
        Me.rd_bloqueadas.AutoSize = True
        Me.rd_bloqueadas.Location = New System.Drawing.Point(249, 38)
        Me.rd_bloqueadas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_bloqueadas.Name = "rd_bloqueadas"
        Me.rd_bloqueadas.Size = New System.Drawing.Size(84, 15)
        Me.rd_bloqueadas.TabIndex = 22
        Me.rd_bloqueadas.Text = "Bloqueadas"
        Me.rd_bloqueadas.UseSelectable = True
        '
        'rd_ativas
        '
        Me.rd_ativas.AutoSize = True
        Me.rd_ativas.Checked = True
        Me.rd_ativas.Location = New System.Drawing.Point(249, 19)
        Me.rd_ativas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_ativas.Name = "rd_ativas"
        Me.rd_ativas.Size = New System.Drawing.Size(55, 15)
        Me.rd_ativas.TabIndex = 21
        Me.rd_ativas.TabStop = True
        Me.rd_ativas.Text = "Ativas"
        Me.rd_ativas.UseSelectable = True
        '
        'frm_manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_parametros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_dados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(711, 496)
        Me.Name = "frm_manutencao"
        Me.Padding = New System.Windows.Forms.Padding(13, 60, 13, 13)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Contas Ativas/Bloqueadas"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_parametros As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_selecione As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rd_todas As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rd_bloqueadas As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rd_ativas As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ativar As DataGridViewImageColumn
    Friend WithEvents bloquear As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
