namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Novos_atributos_class_Patrimonio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patrimonios", "ValorDepreciadoMensal", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Patrimonios", "PrazoVidaUtilProduto", c => c.Int());
            AddColumn("dbo.Patrimonios", "ProdutoDataVidaUtilExpiracao", c => c.DateTime(precision: 0));
            DropColumn("dbo.Produtoes", "ValorDepreciadoMensal");
            DropColumn("dbo.Produtoes", "PrazoVidaUtilProduto");
            DropColumn("dbo.Produtoes", "ProdutoDataVidaUtilExpiracao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "ProdutoDataVidaUtilExpiracao", c => c.DateTime(precision: 0));
            AddColumn("dbo.Produtoes", "PrazoVidaUtilProduto", c => c.Int());
            AddColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Patrimonios", "ProdutoDataVidaUtilExpiracao");
            DropColumn("dbo.Patrimonios", "PrazoVidaUtilProduto");
            DropColumn("dbo.Patrimonios", "ValorDepreciadoMensal");
        }
    }
}
