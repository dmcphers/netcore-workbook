﻿using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers
{
    [Route("Chat")]
    public class ChatController : Controller
    {
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}