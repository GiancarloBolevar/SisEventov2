using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppSisEvento.Models
{
    public class WebAppSisEventoContext : DbContext
    {
    
        public WebAppSisEventoContext() 
            : base("name=WebAppSisEventoContext")
        {

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoaFisica");
            modelBuilder.Entity<PessoaJuridica>().ToTable("PessoaJuridica");
        }
    }
}
