using Negocio.Models;
using Negocio.RepositorioDados;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ServicoNegocio
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente ObterClientePorEmail(string email)
        {
            return _clienteRepositorio.ObterClientePorEmail(email);
        }

        public Cliente ObterClientePorId(int id)
        {
            return _clienteRepositorio.ObterCliente(id);
        }
    }
}
