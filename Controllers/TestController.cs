using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BlazorMvcViewTest.Controllers;

public class TestController : Controller
{
    // 
    // GET: /Test/
    public ViewResult Index()
    {
        return View();
    }
}