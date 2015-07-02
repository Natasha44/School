@ModelType School.Course
@Code
    ViewData("Title") = "Edit Course"
End Code

<h2>Edit Course</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.Id)

        <div class="form-group">
            <strong class="control-label col-md-2">Course Code</strong>
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CourseCode, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.CourseCode, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <strong class="control-label col-md-2">Course Name</strong>
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CourseName, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.CourseName, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <strong class="control-label col-md-2">Course Description</strong>
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CourseDescription, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.CourseDescription, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <strong class="control-label col-md-2">Course Cost</strong>
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CourseCost, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.CourseCost, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
