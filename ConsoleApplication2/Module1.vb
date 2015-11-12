Module Module1

    Sub Main()
        Dim BMI, w, h As Double
        Console.Write("請輸入體重(公斤):")
        w = Console.ReadLine()
        Console.Write("請輸入身高(公尺):")
        h = Console.ReadLine()
        Console.WriteLine(w / h ^ 2)
        Console.ReadLine()
    End Sub

End Module
