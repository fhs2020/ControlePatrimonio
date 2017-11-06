namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mudança_na_DataDeAquisição : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patrimonios", "DataAquisicao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Produtoes", "DataAquisicao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "DataAquisicao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Patrimonios", "DataAquisicao");
        }
    }
}
