<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatoriototal
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_caixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.maindbDataSet = New LavaRapido.maindbDataSet()
        Me.tb_caixaTableAdapter = New LavaRapido.maindbDataSetTableAdapters.tb_caixaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.tb_caixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maindbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.maindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_caixaTableAdapter
        '
        Me.tb_caixaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_caixaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LavaRapido.Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(616, 385)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_relatoriototal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 465)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_relatoriototal"
        Me.Text = "Relatório Geral"
        CType(Me.tb_caixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maindbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_caixaBindingSource As BindingSource
    Friend WithEvents maindbDataSet As maindbDataSet
    Friend WithEvents tb_caixaTableAdapter As maindbDataSetTableAdapters.tb_caixaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
