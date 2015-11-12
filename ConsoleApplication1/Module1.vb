Module Module1

    Sub Main()
        Dim num(10, 9) As Integer
        Dim i As Integer
        Dim j As Integer
        For i = 0 To 9
            For j = 0 To 9
                num(j, i) = (i) * (j)
            Next
        Next
        For i = 1 To 9
            For j = 1 To 9
                Console.Write(num(i, j))
                If num(i, j) < 10 Then
                    Console.Write(" ")
                End If
                Console.Write(" ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
