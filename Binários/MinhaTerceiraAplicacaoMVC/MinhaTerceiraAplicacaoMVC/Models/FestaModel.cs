using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MinhaTerceiraAplicacaoMVC.Models
{
    public class FestaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        
        public double ValorIngresso { get; set; }
        public int TotalDeConvidados { get; set; }
  
    }
}