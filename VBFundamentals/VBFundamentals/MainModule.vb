Module MainModule
    Sub Main()
        Dim prod As New Product With {
            .ProductID = 700,
            .Name = "10 Speed Bike",
            .ProductNumber = "10-SP"
        }

        Console.WriteLine(prod.ToString())

        Dim cust As New Customer With {
            .CustomerID = 1,
            .CompanyName = "Beach Computer Consulting",
            .FirstName = "Bruce",
            .LastName = "Jones"
        }

        Console.WriteLine(cust.ToString())

        Console.ReadKey()
    End Sub
End Module
