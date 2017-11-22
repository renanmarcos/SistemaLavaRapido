Public Class metroInput
    Protected m_BlankValid As Boolean = True
    Protected m_ReturnText As String = ""
    Private flagMask As Boolean

    Public Overloads Function ShowDialog(
      ByRef EnteredText As String,
      ByRef Title As String,
      ByVal BlankValid As Boolean,
      ByVal HasMask As Boolean,
      ByRef Mask As String) As DialogResult
        m_BlankValid = BlankValid
        lbl_titulo.Text = Title
        msk_txt.Hide()

        If HasMask Then
            msk_txt.Show()
            txt_input.Hide()
            msk_txt.Mask = Mask
            flagMask = True
        Else
            flagMask = False
        End If

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
        If flagMask Then
            If msk_txt.MaskCompleted = False Then
                m_ReturnText = "incompleto"
            Else
                m_ReturnText = msk_txt.Text
            End If
        Else
            m_ReturnText = txt_input.Text
        End If
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        DialogResult = DialogResult.Cancel
        m_ReturnText = ""
        Close()
    End Sub
End Class