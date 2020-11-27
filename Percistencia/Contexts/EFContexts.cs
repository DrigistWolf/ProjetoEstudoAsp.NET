using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Modelo.Cadastros;
using Modelo.Tabelas;

namespace Percistencia.Context
{
    public class EFContexts : DbContext
    {
       //public EFContext() : base("Asp_Net_MVC_CS") { }
        public EFContexts() : base("Asp_Net_MVC_CS")
        {
            //Database.SetInitializer<EFContext>( new DropCreateDatabaseIfModelChanges<EFContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFContexts>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.
            Remove<PluralizingTableNameConvention>();
        }

        //Força a aplicação a funcionar mas mata as tabelas as recriando

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
    }
}