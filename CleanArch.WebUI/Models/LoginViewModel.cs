using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email é Obrigatório.")]
        [EmailAddress(ErrorMessage = "formatoo do Email é invalido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password é obrigatório")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max " + "{1} characters long.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}
