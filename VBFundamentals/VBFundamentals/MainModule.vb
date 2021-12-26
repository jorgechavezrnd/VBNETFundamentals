Module MainModule

    Sub Main()
        Dim products = LoadProducts()

        ' Display the sum of all list prices
        Console.WriteLine(
            products.Sum(Function(p)
                             Return p.Value.ListPrice
                         End Function).ToString("c"))

        ' Display the average of all list prices
        Console.WriteLine(
            products.Average(Function(p) p.Value.ListPrice).ToString("c"))

        ' Display the minimum of all list prices
        Console.WriteLine(
            products.Min(Function(p) p.Value.ListPrice).ToString("c"))

        ' Display the maximum of all list prices
        Console.WriteLine(
            products.Max(Function(p) p.Value.ListPrice).ToString("c"))

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
