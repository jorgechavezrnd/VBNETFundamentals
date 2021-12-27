Module MainModule

    Sub Main()
        Dim prod As New Product

        With prod
            .ProductID = 1
            .Name = "A new product"
            .ProductNumber = "A101"
            .StandardCost = 50
            .ListPrice = 100
        End With

        Console.WriteLine(prod.ToString())

        Console.ReadKey()
    End Sub

End Module
