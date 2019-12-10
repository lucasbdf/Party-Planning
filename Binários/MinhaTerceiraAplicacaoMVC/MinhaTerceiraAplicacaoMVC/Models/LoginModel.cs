using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MinhaTerceiraAplicacaoMVC.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings=false, ErrorMessage= "Login é obrigatório!  ( ˶˘ ³˘(ᵕ꒳ᵕ)*₊˚♡")]
        [MinLength(5, ErrorMessage= "Login muito pequeno!")]
        public string email { get; set; }
        
        [Required(AllowEmptyStrings=false, ErrorMessage= "Senha é obrigatória!  ( ˶˘ ³˘(ᵕ꒳ᵕ)*₊˚♡")]
        [MinLength(5, ErrorMessage= "Senha muito pequena!")]
        public string senha { get; set; }
    }
}