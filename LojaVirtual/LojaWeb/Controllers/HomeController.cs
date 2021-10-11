using LojaWeb.Controllers.Base;
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
    public class HomeController : BaseController
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
           Mensagem("Info: Politica de Privacidade","Informação");

           return View();
        }
        //Post
        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem("Erro: Insira um Nome","Error");
                return View();
            }

            return View("Index");
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
