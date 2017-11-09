using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Musica> Musicas { get; set; }
    }
}