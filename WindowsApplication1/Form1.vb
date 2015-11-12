Public Class Form1
    Dim c As Integer
    Dim f As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("請輸入數值")
        End If
        c = TextBox1.Text
        TextBox1.Text = (c - 32) / 1.8
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("請輸入數值")
        End If
        f = TextBox1.Text
        TextBox1.Text = f * 1.8 + 32
    End Sub
End Class
