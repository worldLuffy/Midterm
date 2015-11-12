Public Class Form1
    Dim a As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        a = Int(Rnd() * 3) + 1
        If a = 1 Then Label3.Text = "剪刀" Else If a = 2 Then Label3.Text = "石頭" Else If a = 3 Then Label3.Text = "布"
        If a = 1 Then
            MsgBox("Peer")
        ElseIf a = 2 Then
            MsgBox("Lost")
        Else : a = 3
            MsgBox("Win")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        a = Int(Rnd() * 3) + 1
        If a = 1 Then Label3.Text = "剪刀" Else If a = 2 Then Label3.Text = "石頭" Else If a = 3 Then Label3.Text = "布"
        If a = 1 Then
            MsgBox("Win")
        ElseIf a = 2 Then
            MsgBox("Peer")
        Else : a = 3
            MsgBox("Lost")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Randomize()
        a = Int(Rnd() * 3) + 1
        If a = 1 Then Label3.Text = "剪刀" Else If a = 2 Then Label3.Text = "石頭" Else If a = 3 Then Label3.Text = "布"
        If a = 1 Then
            MsgBox("Lost")
        ElseIf a = 2 Then
            MsgBox("Win")
        Else : a = 3
            MsgBox("Peer")
        End If
    End Sub
End Class
