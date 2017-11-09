using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public TipoPessoaFisica TipoPessoa { get; set; }
        
    }
}