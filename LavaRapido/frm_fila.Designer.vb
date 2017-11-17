<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fila
    Inherits System.Windows.Forms.Form

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
        Me.dgv_fila = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_hoje = New System.Windows.Forms.CheckBox()
        Me.dtp_selecionarDia = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_fila
        '
        Me.dgv_fila.AllowUserToAddRows = False
        Me.dgv_fila.AllowUserToDeleteRows = False
        Me.dgv_fila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_fila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fila.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.registro, Me.dia, Me.hora, Me.carro, Me.placa})
        Me.dgv_fila.Location = New System.Drawing.Point(-2, 90)
        Me.dgv_fila.Name = "dgv_fila"
        Me.dgv_fila.ReadOnly = True
        Me.dgv_fila.RowTemplate.Height = 28
        Me.dgv_fila.Size = New System.Drawing.Size(1217, 517)
        Me.dgv_fila.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Nº"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'registro
        '
        Me.registro.HeaderText = "RG"
        Me.registro.Name = "registro"
        Me.registro.ReadOnly = True
        '
        'dia
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dia.DefaultCellStyle = DataGridViewCellStyle1
        Me.dia.HeaderText = "Dia"
        Me.dia.Name = "dia"
        Me.dia.ReadOnly = True
        '
        'hora
        '
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.hora.DefaultCellStyle = DataGridViewCellStyle2
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'carro
        '
        Me.carro.HeaderText = "Carro"
        Me.carro.Name = "carro"
        Me.carro.ReadOnly = True
        '
        'placa
        '
        Me.placa.HeaderText = "Placa"
        Me.placa.Name = "placa"
        Me.placa.ReadOnly = True
        '
        'cb_hoje
        '
        Me.cb_hoje.AutoSize = True
        Me.cb_hoje.Location = New System.Drawing.Point(991, 40)
        Me.cb_hoje.Name = "cb_hoje"
        Me.cb_hoje.Size = New System.Drawing.Size(185, 24)
        Me.cb_hoje.TabIndex = 1
        Me.cb_hoje.Text = "Carros para lavar hoje"
        Me.cb_hoje.UseVisualStyleBackColor = True
        '
        'dtp_selecionarDia
        '
        Me.dtp_selecionarDia.Location = New System.Drawing.Point(579, 40)
        Me.dtp_selecionarDia.Name = "dtp_selecionarDia"
        Me.dtp_selecionarDia.Size = New System.Drawing.Size(341, 26)
        Me.dtp_selecionarDia.TabIndex = 2
        '
        'frm_fila
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 645)
        Me.Controls.Add(Me.dtp_selecionarDia)
        Me.Controls.Add(Me.cb_hoje)
        Me.Controls.Add(Me.dgv_fila)
        Me.Name = "frm_fila"
        Me.Text = "frm_fila"
        CType(Me.dgv_fila, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_fila As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents registro As DataGridViewTextBoxColumn
    Friend WithEvents dia As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents carro As DataGridViewTextBoxColumn
    Friend WithEvents placa As DataGridViewTextBoxColumn
    Friend WithEvents cb_hoje As CheckBox
    Friend WithEvents dtp_selecionarDia As DateTimePicker
End Class
