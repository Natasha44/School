@ModelType School.Course
@Code
    ViewData("Title") = "Delete Course"
End Code

<h2>Delete Course</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Course</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CourseCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CourseName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CourseDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CourseCost)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseCost)
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
