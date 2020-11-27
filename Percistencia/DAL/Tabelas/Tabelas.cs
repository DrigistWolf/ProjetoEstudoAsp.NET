
using Modelo.Tabelas;
using Percistencia.Context;
using System.Linq;
namespace Persistencia.DAL.Tabelas
{
    public class CategoriaDAL
    {
        private EFContexts context = new EFContexts();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return context.Categorias.OrderBy(b => b.Nome);
        }
    }
}