using System.ComponentModel.DataAnnotations;

namespace LojaWeb.Models
{
    public class ClienteViewModel
    {
      
        [Required]
        [Display(Name="Nome e Sobrenome")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

    }
}
