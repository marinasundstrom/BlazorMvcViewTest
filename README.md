# BlazorMvcViewTest

Testing rendering interactive component in MVC Razor View.


Based on the "Blazor Server" template for ASP.NET Core 8.

## Tests

http://localhost:5119/test - Renders Razor View with interactive Razor component Counter.

http://localhost:5119/test/foo - Renders MyPage SSR Razor component with interactive Razor component Counter.


## Added and updated files


* ``/Controllers/TestController.cs``
* ``/Views/Test/Index.cshtml`` - Renders interactive ``Counter``.

* ``/Pages/MyPage.razor`` - Renders interactive ``Counter`` via endpoint in controller.

* ``/Pages/Counter.razor`` - enabled Server Render mode in component.