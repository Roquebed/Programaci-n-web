﻿using Microsoft.AspNetCore.Mvc;

namespace U1A1Perfil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
