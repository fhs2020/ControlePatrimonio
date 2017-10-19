using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePatrimonio.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Observacao { get; set; }
        public String Endereco { get; set; }
        public String Email { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
    }
}