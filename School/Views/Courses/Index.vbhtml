@ModelType IEnumerable(Of School.Course)
@Code
    ViewData("Title") = "Courses"
End Code

<h2>Courses</h2>

<p>
    @Html.ActionLink("Create New Course", "Create")
</p>
<table class="table table-striped">
    <tr>
        <th>
            <strong>Course Code</strong>
        </th>
        <th>
            <strong>Course Name</strong>
        </th>
        <th>
            <strong>Course Description</strong>
        </th>
        <th> 
            <strong>Course Cost</strong>
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
                $@Html.DisplayFor(Function(modelItem) item.CourseCost)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>
