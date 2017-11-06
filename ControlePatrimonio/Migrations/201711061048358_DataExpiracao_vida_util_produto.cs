namespace ControlePatrimonio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataExpiracao_vida_util_produto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorias", "TaxaPorcentagemDepreciacao", c => c.Double(nullable: false));
            AddColumn("dbo.Categorias", "PrazoVidaUtilGeral", c => c.Int(nullable: false));
            AddColumn("dbo.Produtoes", "PrazoVidaUtilProduto", c => c.Int());
            AddColumn("dbo.Produtoes", "ProdutoDataVidaUtilExpiracao", c => c.DateTime(precision: 0));
            AlterColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Single());
            DropColumn("dbo.Categorias", "TaxDepreciacao");
            DropColumn("dbo.Categorias", "PrazoVidaUtil");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categorias", "PrazoVidaUtil", c => c.Int(nullable: false));
            AddColumn("dbo.Categorias", "TaxDepreciacao", c => c.Double(nullable: false));
            AlterColumn("dbo.Produtoes", "ValorDepreciadoMensal", c => c.Single(nullable: false));
            DropColumn("dbo.Produtoes", "ProdutoDataVidaUtilExpiracao");
            DropColumn("dbo.Produtoes", "PrazoVidaUtilProduto");
            DropColumn("dbo.Categorias", "PrazoVidaUtilGeral");
            DropColumn("dbo.Categorias", "TaxaPorcentagemDepreciacao");
        }
    }
}
