Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim score As Integer

        If Not Integer.TryParse(txtScore.Text, score) Then
            MessageBox.Show("Please enter a valid numeric score.", "Input Error")
            Exit Sub
        End If

        If score < 0 Then
            MessageBox.Show("Error: Score can not be Negative!", "Invalid Score")
            Exit Sub
        End If

        If score > 100 Then
            MessageBox.Show("Error: Score cannot be greater than 100!", "Invalid Score")
            Exit Sub
        End If

        If score >= 80 And score <= 100 Then
            lblResult.Text = "Grade: A"
        ElseIf score >= 70 Then
            lblResult.Text = "Grade: B"
        ElseIf score >= 60 Then
            lblResult.Text = "Grade: C"
        ElseIf score >= 50 Then
            lblResult.Text = "Grade: D"
        ElseIf score >= 40 Then
            lblResult.Text = "Grade: E"
        Else
            lblResult.Text = "Grade: F"
        End If

    End Sub
End Class
