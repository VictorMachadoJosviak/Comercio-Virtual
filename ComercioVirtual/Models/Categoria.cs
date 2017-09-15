using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public string Nome { get; set; }

        [MaxLength(100, ErrorMessage="No máximo 100 caracteres")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}