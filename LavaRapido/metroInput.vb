Public Class metroInput
    Protected m_BlankValid As Boolean = True
    Protected m_ReturnText As String = ""

    Public Overloads Function ShowDialog(
      ByRef EnteredText As String,
      ByVal BlankValid As Boolean) As DialogResult
        m_BlankValid = BlankValid
        ShowDialog()
        EnteredText = m_ReturnText
        Return DialogResult
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_input.TextChanged
        If txt_input.Text = "" Then
            btn_ok.Enabled = m_BlankValid
        Else
            btn_ok.Enabled = True
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        DialogResult = DialogResult.OK
        m_ReturnText = txt_input.Text
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        DialogResult = DialogResult.Cancel
        m_ReturnText = ""
        Close()
    End Sub
End Class