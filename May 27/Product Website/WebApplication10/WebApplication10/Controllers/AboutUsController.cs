﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
