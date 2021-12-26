Module MainModule

    Sub Main()
        Dim products = LoadProducts()

        Console.WriteLine(products(1).Name)
        Console.WriteLine(products(2).Name)
        Console.WriteLine(products(3).Name)

        Console.ReadKey()
    End Sub

    Function LoadProducts() As Dictionary(Of Integer, Product)
        Dim products As New Dictionary(Of Integer, Product)
        Dim prod As Product

        prod = New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP", .ListPrice = 1431.5D}
        products.Add(key:=prod.ProductID, value:=prod)

        prod = New Product With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE", .ListPrice = 39.99D}
        products.Add(key:=prod.ProductID, value:=prod)

        prod = New Product With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU", .ListPrice = 4.99D}
        products.Add(key:=prod.ProductID, value:=prod)

        Return products
    End Function

End Module
