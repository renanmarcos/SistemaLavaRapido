﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recuperar
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_resposta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_perguntas = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(32, 61)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(619, 20)
        Me.txt_usuario.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.08392!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Digite o usuário ou E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.08392!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Pergunta secreta"
        '
        'txt_resposta
        '
        Me.txt_resposta.Location = New System.Drawing.Point(32, 194)
        Me.txt_resposta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.Size = New System.Drawing.Size(619, 20)
        Me.txt_resposta.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.08392!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Resposta secreta"
        '
        'cmb_perguntas
        '
        Me.cmb_perguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perguntas.FormattingEnabled = True
        Me.cmb_perguntas.Location = New System.Drawing.Point(32, 128)
        Me.cmb_perguntas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_perguntas.Name = "cmb_perguntas"
        Me.cmb_perguntas.Size = New System.Drawing.Size(619, 21)
        Me.cmb_perguntas.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0979!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(300, 260)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(29, 231)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(306, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Clique aqui se você for Administrador tentando recuperar senha"
        '
        'frm_recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 321)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_perguntas)
        Me.Controls.Add(Me.txt_resposta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(717, 360)
        Me.Name = "frm_recuperar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_resposta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_perguntas As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
