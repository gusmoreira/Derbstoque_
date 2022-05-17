﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Derbstoque_.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o usuário")]
        [Display(Name ="Usuário")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}