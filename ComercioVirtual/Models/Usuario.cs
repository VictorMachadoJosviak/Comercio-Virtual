using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage="Campo obrigatório!")]
        [Display(Name="Usuário")]
        [MaxLength(20,ErrorMessage="Máximo de 20 caracteres!")]
        public string UsuarioNome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage="E-mail inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        [Display(Name = "Confirmação da senha")]
        [NotMapped]
        [ScaffoldColumn(true)]
        public string ConfirmacaoSenha { get; set; }

    }
}