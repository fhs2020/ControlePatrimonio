namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamponotafiscalnaclassePatrimonio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patrimonios", "NotaFiscal", c => c.String(unicode: false));
            DropColumn("dbo.Produtoes", "NotaFiscal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "NotaFiscal", c => c.String(unicode: false));
            DropColumn("dbo.Patrimonios", "NotaFiscal");
        }
    }
}
