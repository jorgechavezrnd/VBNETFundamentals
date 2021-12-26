Module MainModule

    Sub Main()
        Dim products = LoadProducts()

        ' Display the sum of all list prices
        Console.WriteLine(
            products.Sum(Function(p) p.ListPrice).ToString("c"))

        ' Display the average of all list prices
        Console.WriteLine(
            products.Average(Function(p) p.ListPrice).ToString("c"))

        ' Display the minimum of all list prices
        Console.WriteLine(
            products.Min(Function(p) p.ListPrice).ToString("c"))

        ' Display the maximum of all list prices
        Console.WriteLine(
            products.Max(Function(p) p.ListPrice).ToString("c"))

        Console.ReadKey()
    End Sub

    Function LoadProducts() As List(Of Product)
        Dim products As New List(Of Product) From {
            New Product() With {.ProductID = 680, .Name = "HL Road Frame - Black, 58", .ProductNumber = "FR-R92B-58", .Color = "Black", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 1431.5D, .SellStartDate = #6/1/1998 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 706, .Name = "HL Road Frame - Red, 58", .ProductNumber = "FR-R92R-58", .Color = "Red", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 1431.5D, .SellStartDate = #6/1/1998 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 707, .Name = "Sport-100 Helmet, Red", .ProductNumber = "HL-U509-R", .Color = "Red", .Size = "L", .Weight = 15.1D, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 708, .Name = "Sport-100 Helmet, Black", .ProductNumber = "HL-U509", .Color = "Black", .Size = "L", .Weight = 15.1D, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 709, .Name = "Mountain Bike Socks, M", .ProductNumber = "SO-B909-M", .Color = "White", .Size = "M", .Weight = 10, .StandardCost = 3.3963D, .ListPrice = 9.5D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #6/30/2002 12:00:00 AM#},
            New Product() With {.ProductID = 710, .Name = "Mountain Bike Socks, L", .ProductNumber = "SO-B909-L", .Color = "White", .Size = "L", .Weight = 10, .StandardCost = 3.3963D, .ListPrice = 9.5D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #6/30/2002 12:00:00 AM#},
            New Product() With {.ProductID = 711, .Name = "Sport-100 Helmet, Blue", .ProductNumber = "HL-U509-B", .Color = "Blue", .Size = "M", .Weight = 10, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 712, .Name = "AWC Logo Cap", .ProductNumber = "CA-1098", .Color = "Multi", .Size = "L", .Weight = 5.5D, .StandardCost = 6.9223D, .ListPrice = 8.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 713, .Name = "Long-Sleeve Logo Jersey, S", .ProductNumber = "LJ-0192-S", .Color = "Multi", .Size = "S", .Weight = 3.5D, .StandardCost = 38.4923D, .ListPrice = 49.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
            New Product() With {.ProductID = 714, .Name = "Long-Sleeve Logo Jersey, M", .ProductNumber = "LJ-0192-M", .Color = "Multi", .Size = "M", .Weight = 3.5D, .StandardCost = 38.4923D, .ListPrice = 49.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#}
        }

        Return products
    End Function

End Module
