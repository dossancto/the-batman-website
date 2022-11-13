using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspneto.Models
{
    public class Usuario
    {
        [Display(Name = "Nome do Usuário")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? NomeUsuario { get; set; }

        [Display(Name = "Observação")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres")]
        public string? Observacao { get; set; }

        [Display(Name = "Idade do usuário")]
        [Range(18, 70, ErrorMessage = "Idade permitida 18 e 70")]
        
        public string? Idade { get; set; }

        [Display(Name = "Email profissional")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email invalido")]

        public string? Email { get; set; }

        [Display(Name = "Crie seu login")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login Obrigatório")]
        
        public string? Login { get; set; }

        [Display(Name = "Crie sua senha")]
        [Required(ErrorMessage = "Senha obrigatória")]
        
        public string? Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde.")]

        public string? Confsenha { get; set; }
    }
}
