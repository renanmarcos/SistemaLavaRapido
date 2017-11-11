<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fornecedor))
        Me.txt_parametros = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_parametros
        '
        Me.txt_parametros.Location = New System.Drawing.Point(99, 67)
        Me.txt_parametros.Name = "txt_parametros"
        Me.txt_parametros.Size = New System.Drawing.Size(386, 26)
        Me.txt_parametros.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.08392!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Digite o parâmetro de busca"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AllowUserToResizeColumns = False
        Me.dgv_dados.AllowUserToResizeRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.cpf, Me.bloquear, Me.excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(99, 125)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(974, 518)
        Me.dgv_dados.TabIndex = 20
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        '
        'cpf
        '
        DataGridViewCellStyle1.Format = "00\.000\.000-00"
        Me.cpf.DefaultCellStyle = DataGridViewCellStyle1
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        '
        'bloquear
        '
        Me.bloquear.HeaderText = "Editar"
        Me.bloquear.Image = CType(resources.GetObject("bloquear.Image"), System.Drawing.Image)
        Me.bloquear.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.bloquear.Name = "bloquear"
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.excluir.Name = "excluir"
        '
        'frm_fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 685)
        Me.Controls.Add(Me.txt_parametros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_dados)
        Me.Name = "frm_fornecedor"
        Me.Text = "frm_fornecedor"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_parametros As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents bloquear As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
