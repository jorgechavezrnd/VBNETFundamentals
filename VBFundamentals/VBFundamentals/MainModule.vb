Module MainModule
#Const conLANGUAGE = "ENGLISH"
    ' #Const conLANGUAGE = "GERMAN"

    Sub Main()
#If conLANGUAGE = "ENGLISH" Then
        Console.WriteLine("Good Morning Mr. Jones")
#Else
        Console.WriteLine("Guten Morgen Herr Jones")
#End If

        Console.ReadKey()
    End Sub

End Module
