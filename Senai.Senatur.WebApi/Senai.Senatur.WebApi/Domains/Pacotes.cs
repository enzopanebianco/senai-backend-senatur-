using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int Id { get; set; }
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public decimal Valor { get; set; }
        public int Ativo { get; set; }
        public string Cidade { get; set; }
    }
}
