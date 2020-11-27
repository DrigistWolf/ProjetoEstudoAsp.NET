using System.Linq;
using System.Data.Entity;
using Modelo.Cadastros;
using Percistencia.Context;

namespace Persistencia.DAL.Cadastros
{
    public class ProdutoDAL
    {
        private EFContexts context = new EFContexts();

        public IQueryable ObterProdutosClassificadosPorNome()
        {
            return context.Produtos.Include(c => c.Categoria).
            Include(f => f.Fabricante).OrderBy(n => n.Nome);
        }
        public Produto ObterProdutoPorId(long id)
        {
            return context.Produtos.Where(p => p.ProdutoId == id).
            Include(c => c.Categoria).Include(f =>
            f.Fabricante).First();
        }
        public void GravarProduto(Produto produto)
        {
            if (produto.ProdutoId == null)
            {
                context.Produtos.Add(produto);
            }
            else
            {
                context.Entry(produto).State =
                EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Produto EliminarProdutoPorId(long id)
        {
            Produto produto = ObterProdutoPorId(id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            return produto;
        }
    }
}