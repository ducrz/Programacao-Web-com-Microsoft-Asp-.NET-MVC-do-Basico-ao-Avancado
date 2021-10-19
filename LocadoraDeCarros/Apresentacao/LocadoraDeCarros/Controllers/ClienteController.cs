using AutoMapper;
using LocadoraDeCarros.Models;
using LocadoraDeCarros.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LocadoraDeCarros.Controllers
{
    [Authorize(Roles = "Admin, Balconista")]

    public class ClienteController : BaseController
    {
        private readonly IClienteServico _clienteServico;
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper,IClienteServico clienteServico)
        {
            _mapper = mapper;
            _clienteServico = clienteServico;
        }


        // GET: ClienteController
        public ActionResult Index()
        {
            var listaClientes = _clienteServico.ObterListaClientes();
            return View(_mapper.Map<List<ClienteViewModel>>(listaClientes));
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            ClienteViewModel clienteVM = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorId(id));
            return View(clienteVM);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View(new ClienteViewModel());
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteVM)
        {
            try
            {
                var novoCliente = _mapper.Map<Cliente>(clienteVM);

                //Validar Regras de Negocio

                if (novoCliente.EmailEstaDuplicado(_clienteServico))
                    ModelState.AddModelError("Email","O email já existe no banco de dados");
                if (ModelState.IsValid)
                {
                    if (_clienteServico.Inserir(novoCliente))
                    {
                        Mensagem("O Cliente foi inserido com sucesso","Info");
                        return RedirectToAction(nameof(Index));
                    }
                }
                Mensagem("Ocorreu algum erro ao inserir o novo cliente.", "Error");
                return View(clienteVM);               
                
            }
            catch
            {
                Mensagem("Ocorreu alguma exceção ao inserir o novo cliente.", "Error");
                return View(clienteVM);
            }
        }
        [Authorize]
        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var clienteEditar = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorId(id));
            return View(clienteEditar);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteVM)
        {
            try
            {
                var clienteEditado = _mapper.Map<Cliente>(clienteVM);

                if (clienteEditado.EmailEstaDuplicado(_clienteServico))
                    ModelState.AddModelError("Email", "O email ja existe no banco de dados");

                if (ModelState.IsValid)
                {

                    if (_clienteServico.Editar(clienteEditado))
                    {
                        Mensagem("O cliente foi editado com sucesso.", "Info");
                        return RedirectToAction(nameof(Index));
                    }
                }

                Mensagem("Ocorreu algum erro ao editar o cliente.", "Error");
                return View(clienteVM);
            }
            catch
            {
                Mensagem("Ocorreu alguma exceção ao editar o cliente.", "Error");
                return View(clienteVM);
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            var clienteExcluir = _mapper.Map<ClienteViewModel>(_clienteServico.ObterClientePorId(id));
            return View(clienteExcluir);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteViewModel clienteExcluir)
        {
            try{
                if (_clienteServico.Excluir(clienteExcluir.Id)){
                    Mensagem("O cliente foi excluido com sucesso.", "Info");
                    return RedirectToAction(nameof(Index));
                }
                else{
                    Mensagem("Ocorreu alguma erro ao excluir o cliente.", "Error");
                    return View(clienteExcluir);
                }
                    
            }
            catch{
                Mensagem("Ocorreu alguma exceção ao excluir o cliente.", "Error");
                return View(clienteExcluir);
            }
        }
    }
}
