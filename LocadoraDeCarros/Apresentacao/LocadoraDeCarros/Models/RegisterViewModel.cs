using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage="A (0) deve ter ao menos (2) e no máximo (1) caracteres.", MinimumLength=6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "A senha informada não confere com a confirmação de senha")]

        public string ConfirmPassword { get; set; }
    }
}
