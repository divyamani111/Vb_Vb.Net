Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btn_Verify_Click(sender As Object, e As EventArgs) Handles btn_Verify.Click
        execReg("^([\w]+)@([\w]+)\.([\w]+)$", txt_Email, lbl_state1)
        execReg("^(0011)(([ ][0-9]{3}){3})$", txt_Phone, lbl_state2)
        execReg("^((http|https)://www\.)([\w]+)\.([\w]+)$", txt_Website, lbl_state3)
    End Sub

    Sub execReg(ByVal pattern As String, ByVal tbx As TextBox, ByVal lbl As Label)
        Dim rgx As New Regex(pattern)
        If rgx.IsMatch(tbx.Text) Then
            lbl.Text = "valid"
            lbl.ForeColor = Color.Green
        Else
            lbl.Text = "Invalid"
            lbl.ForeColor = Color.Red
        End If
    End Sub
End Class
