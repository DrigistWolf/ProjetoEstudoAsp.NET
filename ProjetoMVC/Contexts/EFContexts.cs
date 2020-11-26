using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class EFContexts : DbContext
    {
       //public EFContext() : base("Asp_Net_MVC_CS") { }
        public EFContexts() : base("Asp_Net_MVC_CS")
        {
            //Database.SetInitializer<EFContext>( new DropCreateDatabaseIfModelChanges<EFContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFContexts>());
        }
        //Força a aplicação a funcionar mas mata as tabelas as recriando

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
    }
}