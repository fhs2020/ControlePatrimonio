using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlePatrimonio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String NomeProduto { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Obsrvacao { get; set; }
        public String URLFoto { get; set; }
        public String Descricao { get; set; }

        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        //[DataType(DataType.Currency)]
        //public decimal? ValorDepreciadoMensal { get; set; }

        //public int? PrazoVidaUtilProduto { get; set; }

        //public DateTime? ProdutoDataVidaUtilExpiracao { get; set; }

        public String NotaFiscal { get; set; }
        public int? TempoGarantia { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime DataAquisicao { get; set; }
    }
}