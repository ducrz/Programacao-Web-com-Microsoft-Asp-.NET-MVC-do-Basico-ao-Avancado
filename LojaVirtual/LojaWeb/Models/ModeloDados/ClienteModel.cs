using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Models.ModeloDados
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }
    }
}
