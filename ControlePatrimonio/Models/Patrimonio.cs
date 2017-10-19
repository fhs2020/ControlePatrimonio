﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlePatrimonio.Models
{
    public class Patrimonio
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public String EmpresaNome { get; set; }
        public int FilialId { get; set; }
        public String FilialNome { get; set; }
        public int FornecedorId { get; set; }
        public String FornecedorNome { get; set; }
        public int ProdutoId { get; set; }
        public String ProdutoNome { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAquisicao { get; set; }

        public DateTime DataCadastro { get; set; }
        public String Descricao { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Valor { get; set; }
        public String NotaFiscal { get; set; }
        public String NumeroSerie { get; set; }
        public String NumeroPatrimonio { get; set; }
        public int TempoGarantia { get; set; }
        public String Licensa { get; set; }
        public String Observacao { get; set; }
        public String URLImage { get; set; }
        public int UserId { get; set; }
        public String UsuarioEmail { get; set; }
    }
}