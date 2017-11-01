namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Make_FilialID_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patrimonios", "FilialId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patrimonios", "FilialId", c => c.Int(nullable: false));
        }
    }
}
