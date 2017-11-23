<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastrocli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastrocli))
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_nomecompleto = New MetroFramework.Controls.MetroTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_repetir = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New MetroFramework.Controls.MetroTextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_criar = New MetroFramework.Controls.MetroButton()
        Me.txt_email = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_resposta = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cb_visualizar = New MetroFramework.Controls.MetroCheckBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_perguntas = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_cel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_foneres = New System.Windows.Forms.MaskedTextBox()
        Me.txt_dtnasc = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 71)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel3.TabIndex = 57
        Me.MetroLabel3.Text = "Nome completo"
        '
        'txt_nomecompleto
        '
        '
        '
        '
        Me.txt_nomecompleto.CustomButton.Image = Nothing
        Me.txt_nomecompleto.CustomButton.Location = New System.Drawing.Point(233, 2)
        Me.txt_nomecompleto.CustomButton.Name = ""
        Me.txt_nomecompleto.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nomecompleto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nomecompleto.CustomButton.TabIndex = 1
        Me.txt_nomecompleto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nomecompleto.CustomButton.UseSelectable = True
        Me.txt_nomecompleto.CustomButton.Visible = False
        Me.txt_nomecompleto.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_nomecompleto.Lines = New String(-1) {}
        Me.txt_nomecompleto.Location = New System.Drawing.Point(27, 92)
        Me.txt_nomecompleto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomecompleto.MaxLength = 32767
        Me.txt_nomecompleto.Name = "txt_nomecompleto"
        Me.txt_nomecompleto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomecompleto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nomecompleto.SelectedText = ""
        Me.txt_nomecompleto.SelectionLength = 0
        Me.txt_nomecompleto.SelectionStart = 0
        Me.txt_nomecompleto.ShortcutsEnabled = True
        Me.txt_nomecompleto.Size = New System.Drawing.Size(263, 32)
        Me.txt_nomecompleto.TabIndex = 58
        Me.txt_nomecompleto.UseSelectable = True
        Me.txt_nomecompleto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nomecompleto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(470, 92)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(178, 32)
        Me.txt_cpf.TabIndex = 56
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(470, 71)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel2.TabIndex = 55
        Me.MetroLabel2.Text = "CPF"
        '
        'txt_rg
        '
        Me.txt_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_rg.Location = New System.Drawing.Point(304, 92)
        Me.txt_rg.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rg.Mask = "00,000,000-0"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(152, 32)
        Me.txt_rg.TabIndex = 54
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(306, 71)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(26, 19)
        Me.MetroLabel1.TabIndex = 53
        Me.MetroLabel1.Text = "RG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nome do usuário"
        '
        'txt_repetir
        '
        Me.txt_repetir.Font = New System.Drawing.Font("Bernard MT Condensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_repetir.Location = New System.Drawing.Point(261, 217)
        Me.txt_repetir.Name = "txt_repetir"
        Me.txt_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir.Size = New System.Drawing.Size(217, 26)
        Me.txt_repetir.TabIndex = 52
        '
        'txt_usuario
        '
        '
        '
        '
        Me.txt_usuario.CustomButton.Image = Nothing
        Me.txt_usuario.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txt_usuario.CustomButton.Name = ""
        Me.txt_usuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_usuario.CustomButton.TabIndex = 1
        Me.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_usuario.CustomButton.UseSelectable = True
        Me.txt_usuario.CustomButton.Visible = False
        Me.txt_usuario.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(414, 153)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(166, 32)
        Me.txt_usuario.TabIndex = 40
        Me.txt_usuario.UseSelectable = True
        Me.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_usuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bernard MT Condensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_senha.Location = New System.Drawing.Point(27, 217)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(217, 26)
        Me.txt_senha.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "E-mail"
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_criar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_criar.Location = New System.Drawing.Point(659, 297)
        Me.btn_criar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(133, 63)
        Me.btn_criar.TabIndex = 50
        Me.btn_criar.Text = "Criar conta"
        Me.btn_criar.UseSelectable = True
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.CustomButton.Image = Nothing
        Me.txt_email.CustomButton.Location = New System.Drawing.Point(165, 2)
        Me.txt_email.CustomButton.Name = ""
        Me.txt_email.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_email.CustomButton.TabIndex = 1
        Me.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_email.CustomButton.UseSelectable = True
        Me.txt_email.CustomButton.Visible = False
        Me.txt_email.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_email.Lines = New String(-1) {}
        Me.txt_email.Location = New System.Drawing.Point(600, 153)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.ShortcutsEnabled = True
        Me.txt_email.Size = New System.Drawing.Size(195, 32)
        Me.txt_email.TabIndex = 42
        Me.txt_email.UseSelectable = True
        Me.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Resposta secreta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Senha"
        '
        'txt_resposta
        '
        '
        '
        '
        Me.txt_resposta.CustomButton.Image = Nothing
        Me.txt_resposta.CustomButton.Location = New System.Drawing.Point(522, 2)
        Me.txt_resposta.CustomButton.Name = ""
        Me.txt_resposta.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_resposta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_resposta.CustomButton.TabIndex = 1
        Me.txt_resposta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_resposta.CustomButton.UseSelectable = True
        Me.txt_resposta.CustomButton.Visible = False
        Me.txt_resposta.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txt_resposta.Lines = New String(-1) {}
        Me.txt_resposta.Location = New System.Drawing.Point(27, 341)
        Me.txt_resposta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_resposta.MaxLength = 32767
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_resposta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_resposta.SelectedText = ""
        Me.txt_resposta.SelectionLength = 0
        Me.txt_resposta.SelectionStart = 0
        Me.txt_resposta.ShortcutsEnabled = True
        Me.txt_resposta.Size = New System.Drawing.Size(552, 32)
        Me.txt_resposta.TabIndex = 48
        Me.txt_resposta.UseSelectable = True
        Me.txt_resposta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_resposta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Repetir senha"
        '
        'cb_visualizar
        '
        Me.cb_visualizar.AutoSize = True
        Me.cb_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_visualizar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb_visualizar.Location = New System.Drawing.Point(498, 217)
        Me.cb_visualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_visualizar.Name = "cb_visualizar"
        Me.cb_visualizar.Size = New System.Drawing.Size(72, 30)
        Me.cb_visualizar.TabIndex = 45
        Me.cb_visualizar.Text = "Visualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "senha"
        Me.cb_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_visualizar.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Pergunta secreta"
        '
        'cmb_perguntas
        '
        Me.cmb_perguntas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_perguntas.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_perguntas.FormattingEnabled = True
        Me.cmb_perguntas.ItemHeight = 23
        Me.cmb_perguntas.Location = New System.Drawing.Point(27, 281)
        Me.cmb_perguntas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_perguntas.Name = "cmb_perguntas"
        Me.cmb_perguntas.Size = New System.Drawing.Size(553, 29)
        Me.cmb_perguntas.TabIndex = 47
        Me.cmb_perguntas.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(667, 71)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel4.TabIndex = 59
        Me.MetroLabel4.Text = "Data de nascimento"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 132)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel5.TabIndex = 61
        Me.MetroLabel5.Text = "Telefone"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(214, 132)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel6.TabIndex = 63
        Me.MetroLabel6.Text = "Celular"
        '
        'txt_cel
        '
        Me.txt_cel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_cel.Location = New System.Drawing.Point(214, 153)
        Me.txt_cel.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cel.Mask = "(99) 00000-0000"
        Me.txt_cel.Name = "txt_cel"
        Me.txt_cel.Size = New System.Drawing.Size(189, 32)
        Me.txt_cel.TabIndex = 64
        '
        'txt_foneres
        '
        Me.txt_foneres.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_foneres.Location = New System.Drawing.Point(27, 153)
        Me.txt_foneres.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_foneres.Mask = "(99) 0000-0000"
        Me.txt_foneres.Name = "txt_foneres"
        Me.txt_foneres.Size = New System.Drawing.Size(173, 32)
        Me.txt_foneres.TabIndex = 65
        '
        'txt_dtnasc
        '
        Me.txt_dtnasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_dtnasc.Location = New System.Drawing.Point(667, 92)
        Me.txt_dtnasc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dtnasc.Mask = "00/00/0000"
        Me.txt_dtnasc.Name = "txt_dtnasc"
        Me.txt_dtnasc.Size = New System.Drawing.Size(128, 32)
        Me.txt_dtnasc.TabIndex = 66
        Me.txt_dtnasc.ValidatingType = GetType(Date)
        '
        'frm_cadastrocli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(859, 399)
        Me.Controls.Add(Me.txt_dtnasc)
        Me.Controls.Add(Me.txt_foneres)
        Me.Controls.Add(Me.txt_cel)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_nomecompleto)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_rg)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_repetir)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_resposta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_visualizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_perguntas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_cadastrocli"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cadastro de clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_nomecompleto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_rg As MaskedTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_repetir As MaskedTextBox
    Friend WithEvents txt_usuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_criar As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_resposta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_visualizar As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_perguntas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_cel As MaskedTextBox
    Friend WithEvents txt_foneres As MaskedTextBox
    Friend WithEvents txt_dtnasc As MaskedTextBox
End Class
