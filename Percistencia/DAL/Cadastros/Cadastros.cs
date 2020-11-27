using Modelo.Cadastros;
using Percistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Cadastros
{
    public class FabricanteDAL
    {
        private EFContexts context = new EFContexts();
        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return context.Fabricantes.OrderBy(b => b.Nome);
        }
    }
}