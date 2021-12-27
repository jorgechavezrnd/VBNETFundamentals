Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class ProductsController
        Inherits Controller

        ' GET: Products
        Function ProductList() As ActionResult
            Dim vm As New ProductViewModel

            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace