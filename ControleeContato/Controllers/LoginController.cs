using ControleeContato.Models;
using ControleeContato.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleeContato.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (loginModel.Login == "adm" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MessagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MessagemErro"] = $"Ops, não conseguimos realizar o seu login, tente novamente, detalhe erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
