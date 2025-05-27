﻿using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Message = "Thank you for conatcting us!";
                ModelState.Clear();
                return View();
            }
            return View(contact);
        }
    }
}