Module MainModule
    Sub Main()
        Dim products As String() =
            {"10 Speed Bike", "Bike Helmet", "Inner Tube"}

        Console.WriteLine(products(0))
        Console.WriteLine(products(1))
        Console.WriteLine(products(2))

        Console.WriteLine(products.Length)

        Console.ReadKey()
    End Sub
End Module
