using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePatrimonio.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public String TipoCategoria { get; set; }
        public double TaxaPorcentagemDepreciacao { get; set; }
        public int PrazoVidaUtilGeral { get; set; }
    }
}