using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Bloqueado { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }

    }
}