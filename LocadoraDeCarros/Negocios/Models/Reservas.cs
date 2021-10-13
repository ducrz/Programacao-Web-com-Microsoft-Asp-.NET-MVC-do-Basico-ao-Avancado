using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    class Reservas{

        public int IdReserva { get; set; }
        public DateTime DataReserva { get; set; }
        public int ClienteId { get; set; }
    }
}
