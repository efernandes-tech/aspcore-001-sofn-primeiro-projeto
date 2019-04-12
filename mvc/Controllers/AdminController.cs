using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace mvc.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{nome}/{numero:int?}")]
        public IActionResult Index(string nome, int numero)
        {
            // https://localhost:5001/painel/admin/principal/Ederson
            // https://localhost:5001/painel/admin/principal/Ederson/10
            return Content("Vc "+nome+" é nota " + numero);
        }

        [HttpGet("rota1")]
        [HttpGet("rota2")]
        public IActionResult Teste()
        {
            // https://localhost:5001/painel/admin/rota1?nome=Ederson
            var nome = Request.Query["nome"];
            return Content("Aprendendo ASP.NET Core " + nome);
        }

        [HttpGet("view")]
        public IActionResult Visualizar()
        {
            ViewData["helloWorld"] = true;
            ViewData["nome"] = "Éderson";

            return View();
            // return View("Nada");
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("dados")]
        public IActionResult Dados()
        {
            StringValues nome;
            StringValues email;
            Request.Form.TryGetValue("nome", out nome);
            Request.Form.TryGetValue("email", out email);
            return Content("Formulário enviado " + nome + " " + email);
        }
    }
}