﻿@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

        <div class="container">
            <h2>Index</h2>

            <p>
                @Html.ActionLink("Create New", "Create")
            </p>
            <table class="table">
                <tr>
                    <th>
                        @Html.DisplayNameFor(model => model.StudentName)
                    </th>
                    <th>
                        @Html.DisplayNameFor(model => model.Age)
                    </th>
                    <th></th>
                </tr>

                @foreach (var item in Model) {
                <tr>
                    <td>
                        @Html.DisplayFor(modelItem => item.StudentName)
                    </td>
                    <td>
                        @Html.DisplayFor(modelItem => item.Age)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "Edit", new { id=item.StudentId }) |
                        @Html.ActionLink("Details", "Details", new { id=item.StudentId  }) |
                        @Html.ActionLink("Delete", "Delete", new { id = item.StudentId })
                    </td>
                </tr>
                }

            </table>
    </body>
</html>
