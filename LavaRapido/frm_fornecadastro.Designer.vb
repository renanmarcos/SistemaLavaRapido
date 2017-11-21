<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_fornecadastro
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
        Me.GroupBox2 = New MetroFramework.Controls.MetroPanel()
        Me.dtp_dia = New MetroFramework.Controls.MetroDateTime()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_nomef = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Criar = New MetroFramework.Controls.MetroButton()
        Me.txt_nomep = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_preco = New MetroFramework.Controls.MetroTextBox()
        Me.txt_qtd = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_qtd)
        Me.GroupBox2.Controls.Add(Me.txt_preco)
        Me.GroupBox2.Controls.Add(Me.dtp_dia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_nomef)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_Criar)
        Me.GroupBox2.Controls.Add(Me.txt_nomep)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.HorizontalScrollbarBarColor = True
        Me.GroupBox2.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox2.HorizontalScrollbarSize = 10
        Me.GroupBox2.Location = New System.Drawing.Point(14, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 287)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.VerticalScrollbarBarColor = True
        Me.GroupBox2.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox2.VerticalScrollbarSize = 10
        '
        'dtp_dia
        '
        Me.dtp_dia.Location = New System.Drawing.Point(481, 172)
        Me.dtp_dia.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_dia.Name = "dtp_dia"
        Me.dtp_dia.Size = New System.Drawing.Size(258, 29)
        Me.dtp_dia.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_dia.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome do Fornecedor"
        '
        'txt_nomef
        '
        '
        '
        '
        Me.txt_nomef.CustomButton.Image = Nothing
        Me.txt_nomef.CustomButton.Location = New System.Drawing.Point(685, 2)
        Me.txt_nomef.CustomButton.Name = ""
        Me.txt_nomef.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nomef.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nomef.CustomButton.TabIndex = 1
        Me.txt_nomef.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nomef.CustomButton.UseSelectable = True
        Me.txt_nomef.CustomButton.Visible = False
        Me.txt_nomef.Lines = New String(-1) {}
        Me.txt_nomef.Location = New System.Drawing.Point(24, 39)
        Me.txt_nomef.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomef.MaxLength = 32767
        Me.txt_nomef.Name = "txt_nomef"
        Me.txt_nomef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomef.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nomef.SelectedText = ""
        Me.txt_nomef.SelectionLength = 0
        Me.txt_nomef.SelectionStart = 0
        Me.txt_nomef.ShortcutsEnabled = True
        Me.txt_nomef.Size = New System.Drawing.Size(715, 32)
        Me.txt_nomef.TabIndex = 15
        Me.txt_nomef.UseSelectable = True
        Me.txt_nomef.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nomef.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nome do Produto"
        '
        'btn_Criar
        '
        Me.btn_Criar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Criar.Location = New System.Drawing.Point(606, 224)
        Me.btn_Criar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Criar.Name = "btn_Criar"
        Me.btn_Criar.Size = New System.Drawing.Size(133, 50)
        Me.btn_Criar.TabIndex = 29
        Me.btn_Criar.Text = "Gravar"
        Me.btn_Criar.UseSelectable = True
        '
        'txt_nomep
        '
        '
        '
        '
        Me.txt_nomep.CustomButton.Image = Nothing
        Me.txt_nomep.CustomButton.Location = New System.Drawing.Point(685, 2)
        Me.txt_nomep.CustomButton.Name = ""
        Me.txt_nomep.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nomep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nomep.CustomButton.TabIndex = 1
        Me.txt_nomep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nomep.CustomButton.UseSelectable = True
        Me.txt_nomep.CustomButton.Visible = False
        Me.txt_nomep.Lines = New String(-1) {}
        Me.txt_nomep.Location = New System.Drawing.Point(24, 104)
        Me.txt_nomep.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomep.MaxLength = 32767
        Me.txt_nomep.Name = "txt_nomep"
        Me.txt_nomep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomep.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nomep.SelectedText = ""
        Me.txt_nomep.SelectionLength = 0
        Me.txt_nomep.SelectionStart = 0
        Me.txt_nomep.ShortcutsEnabled = True
        Me.txt_nomep.Size = New System.Drawing.Size(715, 32)
        Me.txt_nomep.TabIndex = 17
        Me.txt_nomep.UseSelectable = True
        Me.txt_nomep.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nomep.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Quantidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Preço de cada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Data de Compra"
        '
        'txt_preco
        '
        '
        '
        '
        Me.txt_preco.CustomButton.Image = Nothing
        Me.txt_preco.CustomButton.Location = New System.Drawing.Point(187, 2)
        Me.txt_preco.CustomButton.Name = ""
        Me.txt_preco.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_preco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_preco.CustomButton.TabIndex = 1
        Me.txt_preco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_preco.CustomButton.UseSelectable = True
        Me.txt_preco.CustomButton.Visible = False
        Me.txt_preco.Lines = New String(-1) {}
        Me.txt_preco.Location = New System.Drawing.Point(248, 169)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.MaxLength = 32767
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_preco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_preco.SelectedText = ""
        Me.txt_preco.SelectionLength = 0
        Me.txt_preco.SelectionStart = 0
        Me.txt_preco.ShortcutsEnabled = True
        Me.txt_preco.Size = New System.Drawing.Size(217, 32)
        Me.txt_preco.TabIndex = 33
        Me.txt_preco.UseSelectable = True
        Me.txt_preco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_preco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_qtd
        '
        '
        '
        '
        Me.txt_qtd.CustomButton.Image = Nothing
        Me.txt_qtd.CustomButton.Location = New System.Drawing.Point(187, 2)
        Me.txt_qtd.CustomButton.Name = ""
        Me.txt_qtd.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_qtd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_qtd.CustomButton.TabIndex = 1
        Me.txt_qtd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_qtd.CustomButton.UseSelectable = True
        Me.txt_qtd.CustomButton.Visible = False
        Me.txt_qtd.Lines = New String(-1) {}
        Me.txt_qtd.Location = New System.Drawing.Point(24, 169)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtd.MaxLength = 32767
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_qtd.SelectedText = ""
        Me.txt_qtd.SelectionLength = 0
        Me.txt_qtd.SelectionStart = 0
        Me.txt_qtd.ShortcutsEnabled = True
        Me.txt_qtd.Size = New System.Drawing.Size(217, 32)
        Me.txt_qtd.TabIndex = 34
        Me.txt_qtd.UseSelectable = True
        Me.txt_qtd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_qtd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frm_fornecadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_fornecadastro"
        Me.Text = "Fornecedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_nomef As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Criar As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_nomep As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_dia As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txt_qtd As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_preco As MetroFramework.Controls.MetroTextBox
End Class
