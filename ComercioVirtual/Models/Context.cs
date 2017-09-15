using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Models
{
    public class Context : DbContext
    {
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemCompra> ItensCompra { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}