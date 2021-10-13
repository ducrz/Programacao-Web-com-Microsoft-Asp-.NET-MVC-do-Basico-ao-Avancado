
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.RepositorioDados
{
    public interface IClienteRepositorio{


        Cliente ObterCliente(int id);
        Cliente ObterClientePorEmail(string email);

    }
}
