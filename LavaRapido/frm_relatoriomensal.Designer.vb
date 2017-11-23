<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_relatoriomensal
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_caixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.maindbDataSet = New LavaRapido.maindbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_caixaTableAdapter = New LavaRapido.maindbDataSetTableAdapters.tb_caixaTableAdapter()
        Me.MesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MesToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MesToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MesToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.tb_caixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maindbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MesToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_caixaBindingSource
        '
        Me.tb_caixaBindingSource.DataMember = "tb_caixa"
        Me.tb_caixaBindingSource.DataSource = Me.maindbDataSet
        '
        'maindbDataSet
        '
        Me.maindbDataSet.DataSetName = "maindbDataSet"
        Me.maindbDataSet.EnforceConstraints = False
        Me.maindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_caixaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LavaRapido.Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 100)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(650, 391)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_caixaTableAdapter
        '
        Me.tb_caixaTableAdapter.ClearBeforeFill = True
        '
        'MesToolStrip
        '
        Me.MesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MesToolStripLabel, Me.MesToolStripTextBox, Me.MesToolStripButton})
        Me.MesToolStrip.Location = New System.Drawing.Point(20, 60)
        Me.MesToolStrip.Name = "MesToolStrip"
        Me.MesToolStrip.Size = New System.Drawing.Size(637, 25)
        Me.MesToolStrip.TabIndex = 1
        Me.MesToolStrip.Text = "MesToolStrip"
        '
        'MesToolStripLabel
        '
        Me.MesToolStripLabel.Name = "MesToolStripLabel"
        Me.MesToolStripLabel.Size = New System.Drawing.Size(80, 22)
        Me.MesToolStripLabel.Text = "Digitar o mes:"
        '
        'MesToolStripTextBox
        '
        Me.MesToolStripTextBox.Name = "MesToolStripTextBox"
        Me.MesToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'MesToolStripButton
        '
        Me.MesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MesToolStripButton.Name = "MesToolStripButton"
        Me.MesToolStripButton.Size = New System.Drawing.Size(56, 22)
        Me.MesToolStripButton.Text = "procurar"
        '
        'frm_relatoriomensal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 511)
        Me.Controls.Add(Me.MesToolStrip)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "frm_relatoriomensal"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Relatório Mensal"
        CType(Me.tb_caixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maindbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MesToolStrip.ResumeLayout(False)
        Me.MesToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_caixaBindingSource As BindingSource
    Friend WithEvents maindbDataSet As maindbDataSet
    Friend WithEvents tb_caixaTableAdapter As maindbDataSetTableAdapters.tb_caixaTableAdapter
    Friend WithEvents MesToolStrip As ToolStrip
    Friend WithEvents MesToolStripLabel As ToolStripLabel
    Friend WithEvents MesToolStripTextBox As ToolStripTextBox
    Friend WithEvents MesToolStripButton As ToolStripButton
End Class
