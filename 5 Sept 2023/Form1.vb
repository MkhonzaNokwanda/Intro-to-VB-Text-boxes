Public Class Form1
    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub BtnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim strName As String
        Dim strSurname As String
        Dim strGender As String

        strName = txtName.Text
        strSurname = txtSurname.Text
        strGender = txtGender.Text
        MessageBox.Show("Hi" & " " & strName & " " & strSurname)
    End Sub
End Class
