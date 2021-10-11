using LojaWeb.Controllers.Base;
using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class ClienteController : BaseController
    {
        public IActionResult Index()
        {
            List<ClienteViewModel> listCliente = new List<ClienteViewModel>() { new ClienteViewModel() { Nome = "Eduardo", Endereco="", Telefone ="123456" } };
            return View(listCliente);
        }

        public IActionResult Create()
        {
            Mensagem("");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClienteViewModel cliente)
        {

            return View("Details");
        }
    }
}
