@ModelType WebApplication2.Users
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Users</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Correo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Correo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Clave)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Clave)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Perfil)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Perfil)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Idastate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Idastate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
