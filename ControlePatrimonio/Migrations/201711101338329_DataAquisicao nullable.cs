namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAquisicaonullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patrimonios", "DataAquisicao", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patrimonios", "DataAquisicao", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
