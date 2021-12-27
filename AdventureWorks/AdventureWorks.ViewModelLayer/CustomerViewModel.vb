Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomers()
    End Sub

    Public Property Customers As ObservableCollection(Of Customer)
    Public Property Entity As Customer

    Function LoadCustomers() As ObservableCollection(Of Customer)
        Return LoadCustomers(Nothing)
    End Function

    Function LoadCustomers(ByVal startingFilePath As String) As ObservableCollection(Of Customer)
        ' Create a new instance of the customer manager class
        Dim mgr = New CustomerManager

        Customers = mgr.LoadCustomers(startingFilePath)

        Return Customers
    End Function

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        Return LoadCustomer(customerId, Nothing)
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal startingFilePath As String) As Customer
        ' Create a new instance of the customer manager class
        Dim mgr = New CustomerManager

        Entity = mgr.LoadCustomer(customerId, startingFilePath)

        ' Inform UI that the Entity property changed
        RaisePropertyChanged("Entity")

        Return Entity
    End Function

End Class
