﻿using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class HomeController : Controller
    {
        //Get
        public IActionResult Index()
        {
            return View();
        }
        //Get
        public IActionResult Privacy()
        {
            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            return View();
        }


    }
}
