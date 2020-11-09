﻿using System.Data.Entity;
using ProjetoEstudoAspNet.Models;

namespace ProjetoEstudoAspNet.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}