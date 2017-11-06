namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_field_to_Decimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Single());
            AlterColumn("dbo.Produtoes", "Valor", c => c.Single(nullable: false));
        }
    }
}
