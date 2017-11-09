using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class Musica
    {
        public int MusicaId { get; set; }
        public string Descricao { get; set; }
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
    }
}