using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Components.Endpoints;

namespace BlazorMvcViewTest.Controllers;

public class TestController : Controller
{
    // 
    // GET: /Test/
    public ViewResult Index()
    {
        return View();
    }

    public IResult Foo()
    {
        return new RazorComponentResult<BlazorMvcViewTest.Pages.MyPage>();    
    }
}