namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Depreciacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorias", "PrazoVidaUtil", c => c.Int(nullable: false));
            AddColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "ValorDepreciadoMensal");
            DropColumn("dbo.Categorias", "PrazoVidaUtil");
        }
    }
}
