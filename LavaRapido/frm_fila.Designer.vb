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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fila))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_hoje
        '
        Me.cb_hoje.AutoSize = True
        Me.cb_hoje.Location = New System.Drawing.Point(403, 112)
        Me.cb_hoje.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_hoje.Name = "cb_hoje"
        Me.cb_hoje.Size = New System.Drawing.Size(137, 15)
        Me.cb_hoje.TabIndex = 1
        Me.cb_hoje.Text = "Carros para lavar hoje"
        Me.cb_hoje.UseSelectable = True
        '
        'dtp_selecionarDia
        '
        Me.dtp_selecionarDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_selecionarDia.Location = New System.Drawing.Point(112, 103)
        Me.dtp_selecionarDia.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_selecionarDia.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_selecionarDia.Name = "dtp_selecionarDia"
        Me.dtp_selecionarDia.Size = New System.Drawing.Size(262, 29)
        Me.dtp_selecionarDia.TabIndex = 2
        '
        'rd_todos
        '
        Me.rd_todos.AutoSize = True
        Me.rd_todos.Location = New System.Drawing.Point(573, 90)
        Me.rd_todos.Name = "rd_todos"
        Me.rd_todos.Size = New System.Drawing.Size(55, 15)
        Me.rd_todos.TabIndex = 3
        Me.rd_todos.TabStop = True
        Me.rd_todos.Text = "Todos"
        Me.rd_todos.UseSelectable = True
        '
        'rd_concluidos
        '
        Me.rd_concluidos.AutoSize = True
        Me.rd_concluidos.Location = New System.Drawing.Point(573, 113)
        Me.rd_concluidos.Name = "rd_concluidos"
        Me.rd_concluidos.Size = New System.Drawing.Size(83, 15)
        Me.rd_concluidos.TabIndex = 4
        Me.rd_concluidos.TabStop = True
        Me.rd_concluidos.Text = "Concluídos"
        Me.rd_concluidos.UseSelectable = True
        '
        'rd_emfila
        '
        Me.rd_emfila.AutoSize = True
        Me.rd_emfila.Location = New System.Drawing.Point(573, 136)
        Me.rd_emfila.Name = "rd_emfila"
        Me.rd_emfila.Size = New System.Drawing.Size(61, 15)
        Me.rd_emfila.TabIndex = 5
        Me.rd_emfila.TabStop = True
        Me.rd_emfila.Text = "Em Fila"
        Me.rd_emfila.UseSelectable = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fila.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_fila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fila.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.btn_concluido, Me.Column7, Me.btn_pagar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_fila.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_fila.EnableHeadersVisualStyles = False
        Me.dgv_fila.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_fila.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_fila.Location = New System.Drawing.Point(8, 201)
        Me.dgv_fila.Name = "dgv_fila"
        Me.dgv_fila.ReadOnly = True
        Me.dgv_fila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fila.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_fila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_fila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_fila.Size = New System.Drawing.Size(953, 325)
        Me.dgv_fila.TabIndex = 6
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
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Dia"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.btn_concluido.HeaderText = "Concluído"
        Me.btn_concluido.Image = CType(resources.GetObject("btn_concluido.Image"), System.Drawing.Image)
        Me.btn_concluido.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btn_concluido.Name = "btn_concluido"
        Me.btn_concluido.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle4.Format = "C2"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle4
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
        'frm_fila
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 539)
        Me.Controls.Add(Me.dgv_fila)
        Me.Controls.Add(Me.rd_emfila)
        Me.Controls.Add(Me.rd_concluidos)
        Me.Controls.Add(Me.rd_todos)
        Me.Controls.Add(Me.dtp_selecionarDia)
        Me.Controls.Add(Me.cb_hoje)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_fila"
        Me.Text = "Fila de carros"
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
