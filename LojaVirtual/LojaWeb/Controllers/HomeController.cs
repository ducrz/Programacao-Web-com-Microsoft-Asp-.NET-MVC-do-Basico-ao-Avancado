using LojaWeb.Models;
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
            ViewData["Title"] = "Política de Privacidade";
            ViewBag.nome = "Eduardo";
           return View();
        }
        //Post
        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            return View();
        }
        [Route("/Home/Mensagem/Saudacao/{nome}/{sobrenome}")]
        public IActionResult SaudacaoComNome(string nome, string sobrenome)
        {
            return Content($"Olá usuário {nome} {sobrenome}");
        }

        [Route("/Home/Mensagem/Saudacao/")]
        public IActionResult Saudacao(int id)
        {
            return Content($"Olá usuário { id }");
        }


    }
}
