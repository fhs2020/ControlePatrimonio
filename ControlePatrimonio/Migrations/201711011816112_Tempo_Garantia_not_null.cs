namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tempo_Garantia_not_null : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "TempoGarantia", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "TempoGarantia", c => c.Int(nullable: false));
        }
    }
}
