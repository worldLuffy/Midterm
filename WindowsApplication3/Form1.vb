Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(txtUserName.Text)) Then
            txtUserName.BackColor = Color.MistyRose
        End If
        If (String.IsNullOrEmpty(txtPassword.Text)) Then
            txtPassword.BackColor = Color.MistyRose
        End If

        If txtUserName.Text = "login" Then
            If txtPassword.Text = "abc123" Then
                MsgBox("帳戶密碼正確")
                Application.Exit()
            Else
                txtPassword.BackColor = Color.MistyRose
            End If
        Else
            txtUserName.BackColor = Color.MistyRose
        End If
        If txtUserName.Text = "login" Then
            txtUserName.BackColor = Color.White
        End If
        If txtPassword.Text = "abc123" Then
            txtPassword.BackColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
