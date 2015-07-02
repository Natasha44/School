﻿@ModelType School.Course
@Code
    ViewData("Title") = "Course Details"
End Code

<h2>Course Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
