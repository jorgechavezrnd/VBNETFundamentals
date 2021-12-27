@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customers"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Customer ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Company Name</th>
        </tr>
    </thead>

    @For Each customer In Model.Customers
        @<tbody>
            <tr>
                <td>@customer.CustomerID</td>
                <td>@Html.ActionLink(customer.FirstName, "CustomerDetail", New With {.id = customer.CustomerID})</td>
                <td>@customer.LastName</td>
                <td>@customer.CompanyName</td>
            </tr>
        </tbody>
    Next
</table>