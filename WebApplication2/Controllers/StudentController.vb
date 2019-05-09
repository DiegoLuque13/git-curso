Imports System.Web.Mvc





Namespace Controllers

    Public Class StudentController
        Inherits Controller

        ' GET: Student
        Function Index() As ActionResult
            var studentList = New List < Student > {
                            New Student() {StudentId = 1, StudentName = "John", Age = 18},
                            New Student() {StudentId = 2, StudentName = "Steve", Age = 21},
                            New Student() {StudentId = 3, StudentName = "Bill", Age = 25},
                            New Student() {StudentId = 4, StudentName = "Ram", Age = 20},
                            New Student() {StudentId = 5, StudentName = "Ron", Age = 31},
                            New Student() {StudentId = 4, StudentName = "Chris", Age = 17},
                            New Student() {StudentId = 4, StudentName = "Rob", Age = 19}
                        };
        // Get the students from the database in the real application

        Return View(studentList);
        End Function
    End Class
End Namespace