﻿using Microsoft.AspNetCore.Mvc;

namespace BanglaRunnersWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
