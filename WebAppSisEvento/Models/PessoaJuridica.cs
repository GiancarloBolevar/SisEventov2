using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public TipoPessoaJuridica TipoPessoaJuridica { get; set; }
    }
}