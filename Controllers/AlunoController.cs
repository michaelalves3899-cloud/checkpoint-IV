using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Seu Nome Completo";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            ViewBag.Nome = id == 1 ? "Seu Nome Completo" : "Aluno Exemplo";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }
    }
}