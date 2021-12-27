Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerManager
    Inherits DataManagerBase

    Function LoadCustomers() As ObservableCollection(Of Customer)
        Return LoadCustomers(Nothing)
    End Function

    Function LoadCustomers(ByVal startingFilePath As String) As ObservableCollection(Of Customer)
        ' Create a new instance of customers
        Dim ret = New ObservableCollection(Of Customer)()

        Try
            ' Attempt to read from XML file
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("CustomersFile"),
                startingFilePath)

            Dim customers = From prod In doc.<Customer>
                            Select New Customer With {
                                .CustomerID = Convert.ToInt32(prod.Element("CustomerID").Value),
                                .FirstName = prod.Element("FirstName").Value,
                                .LastName = prod.Element("LastName").Value,
                                .CompanyName = prod.Element("CompanyName").Value
                            }

            ret = New ObservableCollection(Of Customer)(customers.ToList())
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal startingFilePath As String) As Customer
        ' Create a new instance of customer
        Dim ret = New Customer()

        Try
            Dim list = LoadCustomers(startingFilePath)

            If list IsNot Nothing Then
                If list.Count > 0 Then
                    ret = list.FirstOrDefault(Function(c) c.CustomerID = customerId)
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function

End Class
