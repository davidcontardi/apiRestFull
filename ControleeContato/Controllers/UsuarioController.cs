﻿using Microsoft.AspNetCore.Mvc;

namespace ControleeContato.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
