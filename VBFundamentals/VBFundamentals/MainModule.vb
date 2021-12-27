Module MainModule
#Region "Main Method - With End With"
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
#End Region

#Region "Main2 Method - With End With"
    Sub Main2()
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
#End Region
End Module
