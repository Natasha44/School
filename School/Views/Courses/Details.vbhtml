@ModelType School.Course
@Code
    ViewData("Title") = "Course Details"
End Code

<h2>Course Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
