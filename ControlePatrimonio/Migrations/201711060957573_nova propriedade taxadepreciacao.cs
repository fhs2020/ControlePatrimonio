namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novapropriedadetaxadepreciacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorias", "TaxDepreciacao", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categorias", "TaxDepreciacao");
        }
    }
}
