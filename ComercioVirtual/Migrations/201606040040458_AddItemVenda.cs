namespace ComercioVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemsCompra",
                c => new
                    {
                        ItemCompraId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        CarrinhoId = c.String(),
                        Produto_ProdutoId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemCompraId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutoId)
                .Index(t => t.Produto_ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsCompra", "Produto_ProdutoId", "dbo.Produtos");
            DropIndex("dbo.ItemsCompra", new[] { "Produto_ProdutoId" });
            DropTable("dbo.ItemsCompra");
        }
    }
}
