Module MainModule

    Sub Main()
#If DEBUG Then
        Console.WriteLine("In DEBUG mode")
#Else
        Console.WriteLine("In RELEASE mode")
#End If

        Console.ReadKey()
    End Sub

End Module
