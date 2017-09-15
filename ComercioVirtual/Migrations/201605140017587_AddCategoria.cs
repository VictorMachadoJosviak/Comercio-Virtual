namespace ComercioVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            AddColumn("dbo.Produtos", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtos", "CategoriaId");
            AddForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias", "CategoriaId", cascadeDelete: true);
            DropColumn("dbo.Produtos", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "Categoria", c => c.String());
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            DropColumn("dbo.Produtos", "CategoriaId");
            DropTable("dbo.Categorias");
        }
    }
}
