namespace ComercioVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagemProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "CaminhoImagem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "CaminhoImagem");
        }
    }
}
