using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class MensagemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MensagemBemVindo()
        {
            return View();
        }
    }
}
