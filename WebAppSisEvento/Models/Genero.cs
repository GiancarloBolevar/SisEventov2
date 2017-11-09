using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Musica> Musicas { get; set; }
    }
}