using System;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        public IActionResult Teste()
        {
            return Content("Aprendendo ASP.NET Core");
        }
    }
}