using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePatrimonio.Models
{
    public class Filial
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public String EmpresaNome { get; set; }
        public String NomeFilial { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Telefone { get; set; }
        public String CNPJ { get; set; }

    }
}