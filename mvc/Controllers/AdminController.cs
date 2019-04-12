using System;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{nome}/{numero:int?}")]
        public IActionResult Index(string nome, int numero)
        {
            return Content("Vc "+nome+" é nota " + numero);
        }

        [HttpGet("rota1")]
        [HttpGet("rota2")]
        public IActionResult Teste()
        {
            return Content("Aprendendo ASP.NET Core");
        }
    }
}