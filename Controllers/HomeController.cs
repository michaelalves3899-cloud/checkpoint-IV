using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redireciona direto para a página de alunos para facilitar o seu teste
            return RedirectToAction("Index", "Aluno");
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}