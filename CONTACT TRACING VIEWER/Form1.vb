Public Class Form1
    Dim OpenFile As String
    Dim iExit As DialogResult
    Private Sub open_btn_Click(sender As Object, e As EventArgs) Handles open_btn.Click
        OpenFile = "C:\Users\acer\Desktop\JAIRA\test.txt"
        If System.IO.File.Exists(OpenFile) = True Then
            Dim objReader As New System.IO.StreamReader(OpenFile)
            RichTextBox1.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        iExit = MessageBox.Show("Do you want to exit the application? ", "CONTACT TRACING VIEWER", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub
End Class
