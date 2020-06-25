@ModelType WebApplication2.Users
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
