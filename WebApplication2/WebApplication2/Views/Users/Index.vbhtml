@ModelType IEnumerable(Of WebApplication2.Users)
@Code
ViewData("Title") = "Index"
End Code
    <div class="container">
        <h2>Users</h2>

        <p>
            @Html.ActionLink("Create New", "Create")
        </p>
        <table class="table">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Correo)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Clave)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Perfil)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Idastate)
                </th>
                <th></th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Correo)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Clave)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Perfil)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Idastate)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) 
                        @Html.ActionLink("Details", "Details", New With {.id = item.Id}) 
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                    </td>
                </tr>
            Next

        </table>


    </div>
