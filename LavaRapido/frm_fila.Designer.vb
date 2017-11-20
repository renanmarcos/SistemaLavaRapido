<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_fila
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fila))
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cb_hoje = New MetroFramework.Controls.MetroCheckBox()
        Me.dtp_selecionarDia = New MetroFramework.Controls.MetroDateTime()
        Me.rd_todos = New MetroFramework.Controls.MetroRadioButton()
        Me.rd_concluidos = New MetroFramework.Controls.MetroRadioButton()
        Me.rd_emfila = New MetroFramework.Controls.MetroRadioButton()
        Me.dgv_fila = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_concluido = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_pagar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btn_agendar = New MetroFramework.Controls.MetroButton()
        Me.txt_placa = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora = New System.Windows.Forms.MaskedTextBox()
        Me.gb_servico = New System.Windows.Forms.GroupBox()
        Me.cb_completa = New MetroFramework.Controls.MetroCheckBox()
        Me.cb_enceramento = New MetroFramework.Controls.MetroCheckBox()
        Me.lbl_total = New MetroFramework.Controls.MetroLabel()
        Me.cb_basica = New MetroFramework.Controls.MetroCheckBox()
        Me.cb_polimento = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_dia = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_carro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.gb_servico.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_hoje
        '
        Me.cb_hoje.AutoSize = True
        Me.cb_hoje.Location = New System.Drawing.Point(453, 48)
        Me.cb_hoje.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_hoje.Name = "cb_hoje"
        Me.cb_hoje.Size = New System.Drawing.Size(137, 15)
        Me.cb_hoje.Style = MetroFramework.MetroColorStyle.Teal
        Me.cb_hoje.TabIndex = 11
        Me.cb_hoje.Text = "Carros para lavar hoje"
        Me.cb_hoje.UseSelectable = True
        Me.cb_hoje.UseStyleColors = True
        '
        'dtp_selecionarDia
        '
        Me.dtp_selecionarDia.Location = New System.Drawing.Point(95, 39)
        Me.dtp_selecionarDia.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_selecionarDia.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtp_selecionarDia.Name = "dtp_selecionarDia"
        Me.dtp_selecionarDia.Size = New System.Drawing.Size(329, 29)
        Me.dtp_selecionarDia.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_selecionarDia.TabIndex = 10
        '
        'rd_todos
        '
        Me.rd_todos.AutoSize = True
        Me.rd_todos.Location = New System.Drawing.Point(623, 26)
        Me.rd_todos.Name = "rd_todos"
        Me.rd_todos.Size = New System.Drawing.Size(55, 15)
        Me.rd_todos.Style = MetroFramework.MetroColorStyle.Teal
        Me.rd_todos.TabIndex = 12
        Me.rd_todos.TabStop = True
        Me.rd_todos.Text = "Todos"
        Me.rd_todos.UseSelectable = True
        Me.rd_todos.UseStyleColors = True
        '
        'rd_concluidos
        '
        Me.rd_concluidos.AutoSize = True
        Me.rd_concluidos.Location = New System.Drawing.Point(623, 49)
        Me.rd_concluidos.Name = "rd_concluidos"
        Me.rd_concluidos.Size = New System.Drawing.Size(83, 15)
        Me.rd_concluidos.Style = MetroFramework.MetroColorStyle.Teal
        Me.rd_concluidos.TabIndex = 13
        Me.rd_concluidos.TabStop = True
        Me.rd_concluidos.Text = "Concluídos"
        Me.rd_concluidos.UseSelectable = True
        Me.rd_concluidos.UseStyleColors = True
        '
        'rd_emfila
        '
        Me.rd_emfila.AutoSize = True
        Me.rd_emfila.Location = New System.Drawing.Point(623, 72)
        Me.rd_emfila.Name = "rd_emfila"
        Me.rd_emfila.Size = New System.Drawing.Size(61, 15)
        Me.rd_emfila.Style = MetroFramework.MetroColorStyle.Teal
        Me.rd_emfila.TabIndex = 14
        Me.rd_emfila.TabStop = True
        Me.rd_emfila.Text = "Em Fila"
        Me.rd_emfila.UseSelectable = True
        Me.rd_emfila.UseStyleColors = True
        '
        'dgv_fila
        '
        Me.dgv_fila.AllowUserToAddRows = False
        Me.dgv_fila.AllowUserToDeleteRows = False
        Me.dgv_fila.AllowUserToResizeRows = False
        Me.dgv_fila.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_fila.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_fila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_fila.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fila.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgv_fila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fila.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.btn_concluido, Me.Column7, Me.btn_pagar})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_fila.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgv_fila.EnableHeadersVisualStyles = False
        Me.dgv_fila.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_fila.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_fila.Location = New System.Drawing.Point(-6, 123)
        Me.dgv_fila.Name = "dgv_fila"
        Me.dgv_fila.ReadOnly = True
        Me.dgv_fila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fila.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgv_fila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_fila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_fila.Size = New System.Drawing.Size(953, 325)
        Me.dgv_fila.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgv_fila.TabIndex = 15
        Me.dgv_fila.UseStyleColors = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "RG"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle20.Format = "d"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column3.HeaderText = "Dia"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle21.Format = "t"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column4.HeaderText = "Hora"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Carro"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Placa"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btn_concluido
        '
        Me.btn_concluido.HeaderText = "Concluir"
        Me.btn_concluido.Image = CType(resources.GetObject("btn_concluido.Image"), System.Drawing.Image)
        Me.btn_concluido.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btn_concluido.Name = "btn_concluido"
        Me.btn_concluido.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle22.Format = "C2"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column7.HeaderText = "Preço Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'btn_pagar
        '
        Me.btn_pagar.HeaderText = "Pagar"
        Me.btn_pagar.Image = CType(resources.GetObject("btn_pagar.Image"), System.Drawing.Image)
        Me.btn_pagar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btn_pagar.Name = "btn_pagar"
        Me.btn_pagar.ReadOnly = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(3, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(933, 473)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 9
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btn_agendar)
        Me.MetroTabPage1.Controls.Add(Me.txt_placa)
        Me.MetroTabPage1.Controls.Add(Me.txt_hora)
        Me.MetroTabPage1.Controls.Add(Me.gb_servico)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.dtp_dia)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.txt_carro)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(925, 431)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Agendar horário"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btn_agendar
        '
        Me.btn_agendar.Location = New System.Drawing.Point(658, 293)
        Me.btn_agendar.Name = "btn_agendar"
        Me.btn_agendar.Size = New System.Drawing.Size(171, 59)
        Me.btn_agendar.TabIndex = 8
        Me.btn_agendar.Text = "Agendar horário"
        Me.btn_agendar.UseSelectable = True
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(776, 59)
        Me.txt_placa.Mask = "???-0000"
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(53, 20)
        Me.txt_placa.TabIndex = 1
        '
        'txt_hora
        '
        Me.txt_hora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_hora.Location = New System.Drawing.Point(145, 193)
        Me.txt_hora.Mask = "00:00"
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(38, 20)
        Me.txt_hora.TabIndex = 3
        '
        'gb_servico
        '
        Me.gb_servico.BackColor = System.Drawing.SystemColors.Window
        Me.gb_servico.Controls.Add(Me.cb_completa)
        Me.gb_servico.Controls.Add(Me.cb_enceramento)
        Me.gb_servico.Controls.Add(Me.lbl_total)
        Me.gb_servico.Controls.Add(Me.cb_basica)
        Me.gb_servico.Controls.Add(Me.cb_polimento)
        Me.gb_servico.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gb_servico.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        Me.gb_servico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_servico.Location = New System.Drawing.Point(569, 116)
        Me.gb_servico.Name = "gb_servico"
        Me.gb_servico.Size = New System.Drawing.Size(260, 157)
        Me.gb_servico.TabIndex = 3
        Me.gb_servico.TabStop = False
        Me.gb_servico.Text = "Selecione o serviço desejado:"
        '
        'cb_completa
        '
        Me.cb_completa.AutoSize = True
        Me.cb_completa.Location = New System.Drawing.Point(36, 57)
        Me.cb_completa.Name = "cb_completa"
        Me.cb_completa.Size = New System.Drawing.Size(177, 15)
        Me.cb_completa.Style = MetroFramework.MetroColorStyle.Teal
        Me.cb_completa.TabIndex = 5
        Me.cb_completa.Text = "Lavagem Completa - R$40,00"
        Me.cb_completa.UseSelectable = True
        '
        'cb_enceramento
        '
        Me.cb_enceramento.AutoSize = True
        Me.cb_enceramento.Location = New System.Drawing.Point(36, 78)
        Me.cb_enceramento.Name = "cb_enceramento"
        Me.cb_enceramento.Size = New System.Drawing.Size(144, 15)
        Me.cb_enceramento.Style = MetroFramework.MetroColorStyle.Teal
        Me.cb_enceramento.TabIndex = 6
        Me.cb_enceramento.Text = "Enceramento - R$50,00"
        Me.cb_enceramento.UseSelectable = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(36, 126)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(82, 19)
        Me.lbl_total.TabIndex = 16
        Me.lbl_total.Text = "Total: R$0,00"
        '
        'cb_basica
        '
        Me.cb_basica.AutoSize = True
        Me.cb_basica.Location = New System.Drawing.Point(36, 36)
        Me.cb_basica.Name = "cb_basica"
        Me.cb_basica.Size = New System.Drawing.Size(158, 15)
        Me.cb_basica.Style = MetroFramework.MetroColorStyle.Teal
        Me.cb_basica.TabIndex = 4
        Me.cb_basica.Text = "Lavagem Básica - R$20,00"
        Me.cb_basica.UseSelectable = True
        '
        'cb_polimento
        '
        Me.cb_polimento.AutoSize = True
        Me.cb_polimento.Location = New System.Drawing.Point(36, 99)
        Me.cb_polimento.Name = "cb_polimento"
        Me.cb_polimento.Size = New System.Drawing.Size(129, 15)
        Me.cb_polimento.Style = MetroFramework.MetroColorStyle.Teal
        Me.cb_polimento.TabIndex = 7
        Me.cb_polimento.Text = "Polimento - R$70,00"
        Me.cb_polimento.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(93, 193)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Hora:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(93, 146)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Dia:"
        '
        'dtp_dia
        '
        Me.dtp_dia.Location = New System.Drawing.Point(145, 140)
        Me.dtp_dia.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_dia.Name = "dtp_dia"
        Me.dtp_dia.Size = New System.Drawing.Size(288, 29)
        Me.dtp_dia.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_dia.TabIndex = 2
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(727, 59)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Placa:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(93, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Carro:"
        '
        'txt_carro
        '
        '
        '
        '
        Me.txt_carro.CustomButton.Image = Nothing
        Me.txt_carro.CustomButton.Location = New System.Drawing.Point(468, 1)
        Me.txt_carro.CustomButton.Name = ""
        Me.txt_carro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_carro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_carro.CustomButton.TabIndex = 1
        Me.txt_carro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_carro.CustomButton.UseSelectable = True
        Me.txt_carro.CustomButton.Visible = False
        Me.txt_carro.Lines = New String(-1) {}
        Me.txt_carro.Location = New System.Drawing.Point(145, 60)
        Me.txt_carro.MaxLength = 80
        Me.txt_carro.Name = "txt_carro"
        Me.txt_carro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_carro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_carro.SelectedText = ""
        Me.txt_carro.SelectionLength = 0
        Me.txt_carro.SelectionStart = 0
        Me.txt_carro.ShortcutsEnabled = True
        Me.txt_carro.Size = New System.Drawing.Size(490, 23)
        Me.txt_carro.Style = MetroFramework.MetroColorStyle.Teal
        Me.txt_carro.TabIndex = 0
        Me.txt_carro.UseSelectable = True
        Me.txt_carro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_carro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.dgv_fila)
        Me.MetroTabPage2.Controls.Add(Me.rd_emfila)
        Me.MetroTabPage2.Controls.Add(Me.dtp_selecionarDia)
        Me.MetroTabPage2.Controls.Add(Me.rd_concluidos)
        Me.MetroTabPage2.Controls.Add(Me.cb_hoje)
        Me.MetroTabPage2.Controls.Add(Me.rd_todos)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(925, 431)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Visualizar fila"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'frm_fila
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 539)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_fila"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Fila de carros"
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.gb_servico.ResumeLayout(False)
        Me.gb_servico.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_hoje As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents rd_todos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rd_concluidos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rd_emfila As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents dtp_selecionarDia As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dgv_fila As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_concluido As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btn_pagar As DataGridViewImageColumn
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_placa As MaskedTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_carro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gb_servico As GroupBox
    Friend WithEvents cb_completa As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cb_enceramento As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cb_basica As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cb_polimento As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_dia As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txt_hora As MaskedTextBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents lbl_total As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_agendar As MetroFramework.Controls.MetroButton
End Class
