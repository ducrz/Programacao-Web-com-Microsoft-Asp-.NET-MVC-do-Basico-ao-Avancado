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
            List<ClienteViewModel> listCliente = new List<ClienteViewModel>() { new ClienteViewModel() { Nome = "Eduardo", Endereco="", Telefone ="123456" },
                                                    new ClienteViewModel() { Nome="Pablo", Endereco="", Telefone="45678" } };
            return View(listCliente);
        }

        public IActionResult Create()
        {
            //Mensagem("");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid){
                List<ClienteViewModel> listCliente = new List<ClienteViewModel>();
                listCliente.Add(cliente);
                Mensagem("Cliente Salvo com Sucesso", "Success");
                return View("Index", listCliente);
            }
            return View(cliente);
        }
        public IActionResult Details(string nome)
        {
            return View();
        }
    }
}
