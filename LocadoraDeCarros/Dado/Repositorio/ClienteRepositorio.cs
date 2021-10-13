using AutoMapper;
using Dados.Models;
using Negocio.Models;
using Negocio.RepositorioDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IMapper _mapper;

        public ClienteRepositorio(IMapper mapper){
            _mapper = mapper;
        }

        public Cliente ObterCliente(int id)
        {

            ClienteDataModel clienteDM = new ClienteDataModel();

            //Implementar a lógica de acesso a dados

            return _mapper.Map<Cliente>(clienteDM);

        }
    }
}
