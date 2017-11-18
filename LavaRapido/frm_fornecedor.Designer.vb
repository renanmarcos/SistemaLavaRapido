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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_parametros = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_parametro = New MetroFramework.Controls.MetroLabel()
        Me.dgv_dados = New MetroFramework.Controls.MetroGrid
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue
        Me.dgv_dados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.registro})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_dados.Location = New System.Drawing.Point(27, 134)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(715, 336)
        Me.dgv_dados.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'registro
        '
        Me.registro.HeaderText = "CPF"
        Me.registro.Name = "registro"
        Me.registro.ReadOnly = True
        '
        'frm_fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 537)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.txt_parametros)
        Me.Controls.Add(Me.lbl_parametro)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_fornecedor"
        Me.Padding = New System.Windows.Forms.Padding(13, 60, 13, 13)
        Me.Text = "Fornecedores"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_parametros As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_parametro As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_dados As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents registro As DataGridViewTextBoxColumn
End Class
