using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Models
{
    [Table("ItemsCompra")]
    public class ItemCompra
    {
        [Key]
        public int ItemCompraId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public string CarrinhoId { get; set; }
    }
}