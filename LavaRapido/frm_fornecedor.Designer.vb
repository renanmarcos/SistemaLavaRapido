<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fornecedor
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_parametros = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_parametro = New MetroFramework.Controls.MetroLabel()
        Me.dgv_fornecedor = New MetroFramework.Controls.MetroGrid()
        Me.btn_Adicionar = New MetroFramework.Controls.MetroButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmb_selecao = New MetroFramework.Controls.MetroComboBox()
        CType(Me.dgv_fornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txt_parametros.Location = New System.Drawing.Point(30, 98)
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
        Me.txt_parametros.TabIndex = 22
        Me.txt_parametros.UseSelectable = True
        Me.txt_parametros.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_parametros.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbl_parametro
        '
        Me.lbl_parametro.AutoSize = True
        Me.lbl_parametro.Location = New System.Drawing.Point(27, 66)
        Me.lbl_parametro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_parametro.Name = "lbl_parametro"
        Me.lbl_parametro.Size = New System.Drawing.Size(181, 19)
        Me.lbl_parametro.TabIndex = 21
        Me.lbl_parametro.Text = "Digite o parâmetro de busca:"
        '
        'dgv_fornecedor
        '
        Me.dgv_fornecedor.AllowUserToAddRows = False
        Me.dgv_fornecedor.AllowUserToDeleteRows = False
        Me.dgv_fornecedor.AllowUserToResizeRows = False
        Me.dgv_fornecedor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_fornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_fornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_fornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fornecedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_fornecedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_fornecedor.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_fornecedor.EnableHeadersVisualStyles = False
        Me.dgv_fornecedor.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_fornecedor.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_fornecedor.Location = New System.Drawing.Point(27, 134)
        Me.dgv_fornecedor.Name = "dgv_fornecedor"
        Me.dgv_fornecedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fornecedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_fornecedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_fornecedor.Size = New System.Drawing.Size(707, 358)
        Me.dgv_fornecedor.TabIndex = 26
        '
        'btn_Adicionar
        '
        Me.btn_Adicionar.Location = New System.Drawing.Point(454, 98)
        Me.btn_Adicionar.Name = "btn_Adicionar"
        Me.btn_Adicionar.Size = New System.Drawing.Size(153, 23)
        Me.btn_Adicionar.TabIndex = 27
        Me.btn_Adicionar.Text = "Adicionar novo Registro"
        Me.btn_Adicionar.UseSelectable = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fornecedor"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantidade"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Preço"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "Data"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Editar"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Excluir"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'cmb_selecao
        '
        Me.cmb_selecao.FormattingEnabled = True
        Me.cmb_selecao.ItemHeight = 23
        Me.cmb_selecao.Location = New System.Drawing.Point(312, 92)
        Me.cmb_selecao.Name = "cmb_selecao"
        Me.cmb_selecao.Size = New System.Drawing.Size(121, 29)
        Me.cmb_selecao.TabIndex = 28
        Me.cmb_selecao.UseSelectable = True
        '
        'frm_fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 537)
        Me.Controls.Add(Me.cmb_selecao)
        Me.Controls.Add(Me.btn_Adicionar)
        Me.Controls.Add(Me.dgv_fornecedor)
        Me.Controls.Add(Me.txt_parametros)
        Me.Controls.Add(Me.lbl_parametro)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_fornecedor"
        Me.Padding = New System.Windows.Forms.Padding(13, 60, 13, 13)
        Me.Text = "Fornecedores"
        CType(Me.dgv_fornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_parametros As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_parametro As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_fornecedor As MetroFramework.Controls.MetroGrid
    Friend WithEvents btn_Adicionar As MetroFramework.Controls.MetroButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents cmb_selecao As MetroFramework.Controls.MetroComboBox
End Class
