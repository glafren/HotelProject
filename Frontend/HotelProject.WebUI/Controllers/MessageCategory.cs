﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class MessageCategory : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
