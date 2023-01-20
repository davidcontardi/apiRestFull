using ControleeContato.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControleeContato.Controllers
{
    [PaginaParaUsuarioLogado]

    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
