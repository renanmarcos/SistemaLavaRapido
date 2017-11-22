<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastroadm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastroadm))
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_repetir = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New MetroFramework.Controls.MetroTextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.txt_email = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_resposta = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_tipo = New MetroFramework.Controls.MetroComboBox()
        Me.cb_visualizar = New MetroFramework.Controls.MetroCheckBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_perguntas = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nome do usuário"
        '
        'txt_repetir
        '
        Me.txt_repetir.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_repetir.Location = New System.Drawing.Point(375, 348)
        Me.txt_repetir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_repetir.Name = "txt_repetir"
        Me.txt_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir.Size = New System.Drawing.Size(324, 45)
        Me.txt_repetir.TabIndex = 63
        '
        'txt_usuario
        '
        '
        '
        '
        Me.txt_usuario.CustomButton.Image = Nothing
        Me.txt_usuario.CustomButton.Location = New System.Drawing.Point(1536, 2)
        Me.txt_usuario.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_usuario.CustomButton.Name = ""
        Me.txt_usuario.CustomButton.Size = New System.Drawing.Size(70, 72)
        Me.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_usuario.CustomButton.TabIndex = 1
        Me.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_usuario.CustomButton.UseSelectable = True
        Me.txt_usuario.CustomButton.Visible = False
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(32, 148)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(1072, 49)
        Me.txt_usuario.TabIndex = 49
        Me.txt_usuario.UseSelectable = True
        Me.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_usuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_senha.Location = New System.Drawing.Point(32, 348)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(324, 45)
        Me.txt_senha.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "E-mail"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(904, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 77)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Criar conta"
        Me.Button1.UseSelectable = True
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.CustomButton.Image = Nothing
        Me.txt_email.CustomButton.Location = New System.Drawing.Point(1536, 2)
        Me.txt_email.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.CustomButton.Name = ""
        Me.txt_email.CustomButton.Size = New System.Drawing.Size(70, 72)
        Me.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_email.CustomButton.TabIndex = 1
        Me.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_email.CustomButton.UseSelectable = True
        Me.txt_email.CustomButton.Visible = False
        Me.txt_email.Lines = New String(-1) {}
        Me.txt_email.Location = New System.Drawing.Point(32, 248)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.ShortcutsEnabled = True
        Me.txt_email.Size = New System.Drawing.Size(1072, 49)
        Me.txt_email.TabIndex = 51
        Me.txt_email.UseSelectable = True
        Me.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Resposta secreta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Senha"
        '
        'txt_resposta
        '
        '
        '
        '
        Me.txt_resposta.CustomButton.Image = Nothing
        Me.txt_resposta.CustomButton.Location = New System.Drawing.Point(1170, 2)
        Me.txt_resposta.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_resposta.CustomButton.Name = ""
        Me.txt_resposta.CustomButton.Size = New System.Drawing.Size(70, 72)
        Me.txt_resposta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_resposta.CustomButton.TabIndex = 1
        Me.txt_resposta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_resposta.CustomButton.UseSelectable = True
        Me.txt_resposta.CustomButton.Visible = False
        Me.txt_resposta.Lines = New String(-1) {}
        Me.txt_resposta.Location = New System.Drawing.Point(32, 560)
        Me.txt_resposta.MaxLength = 32767
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_resposta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_resposta.SelectedText = ""
        Me.txt_resposta.SelectionLength = 0
        Me.txt_resposta.SelectionStart = 0
        Me.txt_resposta.ShortcutsEnabled = True
        Me.txt_resposta.Size = New System.Drawing.Size(828, 49)
        Me.txt_resposta.TabIndex = 59
        Me.txt_resposta.UseSelectable = True
        Me.txt_resposta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_resposta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Repetir senha"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.ItemHeight = 23
        Me.cmb_tipo.Location = New System.Drawing.Point(716, 348)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(386, 29)
        Me.cmb_tipo.TabIndex = 58
        Me.cmb_tipo.UseSelectable = True
        '
        'cb_visualizar
        '
        Me.cb_visualizar.AutoSize = True
        Me.cb_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_visualizar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb_visualizar.Location = New System.Drawing.Point(938, 431)
        Me.cb_visualizar.Name = "cb_visualizar"
        Me.cb_visualizar.Size = New System.Drawing.Size(72, 30)
        Me.cb_visualizar.TabIndex = 54
        Me.cb_visualizar.Text = "Visualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "senha"
        Me.cb_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_visualizar.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(706, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Tipo de conta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Pergunta secreta"
        '
        'cmb_perguntas
        '
        Me.cmb_perguntas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_perguntas.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_perguntas.FormattingEnabled = True
        Me.cmb_perguntas.ItemHeight = 23
        Me.cmb_perguntas.Location = New System.Drawing.Point(32, 458)
        Me.cmb_perguntas.Name = "cmb_perguntas"
        Me.cmb_perguntas.Size = New System.Drawing.Size(826, 29)
        Me.cmb_perguntas.TabIndex = 56
        Me.cmb_perguntas.UseSelectable = True
        '
        'frm_cadastroadm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 772)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_repetir)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_resposta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.cb_visualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_perguntas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastroadm"
        Me.Padding = New System.Windows.Forms.Padding(20, 92, 20, 20)
        Me.Text = "Cadastro de funcionários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_repetir As MaskedTextBox
    Friend WithEvents txt_usuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_resposta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_tipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cb_visualizar As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_perguntas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
End Class
