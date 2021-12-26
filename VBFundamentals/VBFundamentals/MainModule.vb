Module MainModule
    Sub Main()
        Dim products As New ArrayList From
        {
            New Product With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP"},
            New Product With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE"},
            New Product With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU"}
        }

        Console.WriteLine(DirectCast(products(0), Product).Name)
        Console.WriteLine(DirectCast(products(1), Product).Name)
        Console.WriteLine(DirectCast(products(2), Product).Name)

        Console.WriteLine(products.Count)

        Console.ReadKey()
    End Sub
End Module
