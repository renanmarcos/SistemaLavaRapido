<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_tentativas = New System.Windows.Forms.Label()
        Me.link_esqueceu = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_nivel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_tentativas)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(580, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(156, 113)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tentativas Restantes"
        '
        'lbl_tentativas
        '
        Me.lbl_tentativas.AutoSize = True
        Me.lbl_tentativas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tentativas.Font = New System.Drawing.Font("Cooper Black", 51.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tentativas.Location = New System.Drawing.Point(39, 22)
        Me.lbl_tentativas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tentativas.Name = "lbl_tentativas"
        Me.lbl_tentativas.Size = New System.Drawing.Size(75, 79)
        Me.lbl_tentativas.TabIndex = 1
        Me.lbl_tentativas.Text = "3"
        '
        'link_esqueceu
        '
        Me.link_esqueceu.AutoSize = True
        Me.link_esqueceu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_esqueceu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_esqueceu.LinkColor = System.Drawing.SystemColors.InfoText
        Me.link_esqueceu.Location = New System.Drawing.Point(577, 312)
        Me.link_esqueceu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_esqueceu.Name = "link_esqueceu"
        Me.link_esqueceu.Size = New System.Drawing.Size(154, 18)
        Me.link_esqueceu.TabIndex = 16
        Me.link_esqueceu.TabStop = True
        Me.link_esqueceu.Text = "Esqueceu sua senha?"
        Me.link_esqueceu.VisitedLinkColor = System.Drawing.SystemColors.Menu
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nível de acesso"
        '
        'cmb_nivel
        '
        Me.cmb_nivel.BackColor = System.Drawing.Color.Silver
        Me.cmb_nivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nivel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_nivel.FormattingEnabled = True
        Me.cmb_nivel.Location = New System.Drawing.Point(189, 297)
        Me.cmb_nivel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_nivel.Name = "cmb_nivel"
        Me.cmb_nivel.Size = New System.Drawing.Size(319, 33)
        Me.cmb_nivel.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 29)
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
        Me.txt_usuario.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_usuario.Location = New System.Drawing.Point(190, 145)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(319, 32)
        Me.txt_usuario.TabIndex = 17
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.FlatAppearance.BorderSize = 0
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_entrar.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Location = New System.Drawing.Point(580, 252)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(156, 51)
        Me.btn_entrar.TabIndex = 18
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(896, 468)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.link_esqueceu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.cmb_nivel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_tentativas As Label
    Friend WithEvents link_esqueceu As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_nivel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_entrar As Button
End Class
