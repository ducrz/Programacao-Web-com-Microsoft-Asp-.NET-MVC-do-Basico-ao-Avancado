﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dados.Models
{
    public class TelefoneDataModel
    {
        public int Id { get; set; }

        //Data Annotations
        [Required]
        [MaxLength(12)]
        public string Numero { get; set; }

        public string Tipo { get; set; }
        [Required]
        public int ClienteId { get; set; }

        public virtual ClienteDataModel Cliente { get; set; }
    }
}
