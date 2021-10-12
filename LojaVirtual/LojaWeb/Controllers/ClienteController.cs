using LojaWeb.Controllers.Base;
using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaWeb.Models.ModeloDados;

namespace LojaWeb.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            List<ClienteViewModel> listCliente = new List<ClienteViewModel>() { new ClienteViewModel() { Nome = "Eduardo", Endereco="", Telefone ="123456" },
                                                    new ClienteViewModel() { Nome="Pablo", Endereco="", Telefone="45678" } };
            return View(listCliente);
        }

        public IActionResult Create()
        {
            //Mensagem("");
            var cliente = new ClienteModel() { CPF="1", Endereco="a", Id=1, Nome="Eduardo", NumeroCartaoCredito="1", Telefone="123" };

            var clienteVM = _mapper.Map<ClienteViewModel>(cliente);

            return View(clienteVM);
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
