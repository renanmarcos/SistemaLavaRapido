<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_tentativas = New MetroFramework.Controls.MetroLabel()
        Me.link_esqueceu = New MetroFramework.Controls.MetroLink()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_nivel = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New MetroFramework.Controls.MetroTextBox()
        Me.btn_entrar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'lbl_tentativas
        '
        Me.lbl_tentativas.AutoSize = True
        Me.lbl_tentativas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tentativas.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_tentativas.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_tentativas.Location = New System.Drawing.Point(746, 139)
        Me.lbl_tentativas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tentativas.Name = "lbl_tentativas"
        Me.lbl_tentativas.Size = New System.Drawing.Size(22, 25)
        Me.lbl_tentativas.TabIndex = 1
        Me.lbl_tentativas.Text = "3"
        '
        'link_esqueceu
        '
        Me.link_esqueceu.AutoSize = True
        Me.link_esqueceu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_esqueceu.Location = New System.Drawing.Point(577, 312)
        Me.link_esqueceu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_esqueceu.Name = "link_esqueceu"
        Me.link_esqueceu.Size = New System.Drawing.Size(154, 23)
        Me.link_esqueceu.TabIndex = 16
        Me.link_esqueceu.Text = "Esqueceu sua senha?"
        Me.link_esqueceu.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nível de acesso"
        '
        'cmb_nivel
        '
        Me.cmb_nivel.BackColor = System.Drawing.Color.Silver
        Me.cmb_nivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_nivel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_nivel.FormattingEnabled = True
        Me.cmb_nivel.ItemHeight = 23
        Me.cmb_nivel.Location = New System.Drawing.Point(189, 297)
        Me.cmb_nivel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_nivel.Name = "cmb_nivel"
        Me.cmb_nivel.Size = New System.Drawing.Size(319, 29)
        Me.cmb_nivel.TabIndex = 14
        Me.cmb_nivel.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usuário ou E-mail"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(189, 221)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(319, 32)
        Me.txt_senha.TabIndex = 2
        '
        'txt_usuario
        '
        '
        '
        '
        Me.txt_usuario.CustomButton.Image = Nothing
        Me.txt_usuario.CustomButton.Location = New System.Drawing.Point(289, 2)
        Me.txt_usuario.CustomButton.Name = ""
        Me.txt_usuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_usuario.CustomButton.TabIndex = 1
        Me.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_usuario.CustomButton.UseSelectable = True
        Me.txt_usuario.CustomButton.Visible = False
        Me.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(190, 145)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(319, 32)
        Me.txt_usuario.TabIndex = 17
        Me.txt_usuario.UseSelectable = True
        Me.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_usuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Location = New System.Drawing.Point(580, 252)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(156, 51)
        Me.btn_entrar.TabIndex = 18
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(580, 145)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Número de tentativas: "
        Me.MetroLabel1.WrapToLine = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(896, 468)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_tentativas)
        Me.Controls.Add(Me.link_esqueceu)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.cmb_nivel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tentativas As MetroFramework.Controls.MetroLabel
    Friend WithEvents link_esqueceu As MetroFramework.Controls.MetroLink
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_nivel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_usuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_entrar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
