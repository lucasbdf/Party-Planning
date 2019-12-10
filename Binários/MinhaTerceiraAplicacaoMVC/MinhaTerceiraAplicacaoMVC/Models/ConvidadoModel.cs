using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhaTerceiraAplicacaoMVC.Models
{
    public class ConvidadoModel
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public FestaModel ProximaFesta { get; set; }
    }
}