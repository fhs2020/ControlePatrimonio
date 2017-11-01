namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TempoGarantia_Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patrimonios", "TempoGarantia", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patrimonios", "TempoGarantia", c => c.Int(nullable: false));
        }
    }
}
