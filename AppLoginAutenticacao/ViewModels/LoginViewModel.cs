using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppLoginAutenticacao.ViewModels
{
    public class LoginViewModel
    {
        public string UrlRetorno { get; set; }

        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(50, ErrorMessage = "O Login deve ter até 50 caracteres!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(6, ErrorMessage = "a senha deve ter até 6 caracteres!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}