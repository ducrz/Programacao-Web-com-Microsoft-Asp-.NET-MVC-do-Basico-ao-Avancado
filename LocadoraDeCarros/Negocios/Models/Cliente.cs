using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Cliente{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CNH { get; set; }
        public string CartaoDeCredito { get; set; }
    }
}
