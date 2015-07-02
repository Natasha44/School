Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "This is your about page"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Natasha Whitehead"

        Return View()
    End Function
End Class
