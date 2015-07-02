@ModelType School.Course
@Code
    ViewData("Title") = "Delete Course"
End Code

<h2>Delete Course</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Course Code
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseCode)
        </dd>

        <dt>
            Course Name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseName)
        </dd>

        <dt>
            Course Description
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CourseDescription)
        </dd>

        <dt>
           Course Cost
        </dt>

        <dd>
            $@Html.DisplayFor(Function(model) model.CourseCost)
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
