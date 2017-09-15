using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public string CaminhoImagem { get; set; }
        public string Descricao { get; set; }
    }
}