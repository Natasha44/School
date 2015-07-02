@ModelType IEnumerable(Of School.Course)
@Code
    ViewData("Title") = "Courses"
End Code

<h2>Courses</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseCost)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseCost)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
