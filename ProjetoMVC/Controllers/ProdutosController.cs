using System.Data.Entity;
using System.Linq;
using ProjetoMVC.Context;
using System.Web.Mvc;
using ProjetoMVC.Models;
using System.Net;

namespace ProjetoMVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly EFContexts Context = new EFContexts();
        private Produto produto;

        // GET: Produtos
        public ActionResult Index()
        {
            //var produtos = Context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).OrderBy(n => n.Nome);
            var produtos = Context.Produtos.Include(c => c.Categoria).
                                                                Include(f => f.Fabricante).OrderBy(n => n.Nome);

            return View(produtos);
            //return View(Context.Produtos.OrderBy(c => c.Nome));
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaID = new SelectList(Context.Categorias.OrderBy(b => b.Nome), "CategoriaID", "Nome");
           ViewBag.FabricanteID = new SelectList(Context.Fabricantes.OrderBy(b => b.Nome), "FabricanteID", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                Context.Produtos.Add(produto);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = Context.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(Context.Categorias.OrderBy(b => b.Nome), "CategoriaId", "Nome", produto.CategoriaId);
            ViewBag.FabricanteId = new SelectList(Context.Fabricantes.OrderBy(b => b.Nome), "FabricanteId", "Nome", produto.FabricanteId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Context.Entry(produto).State = EntityState.Modified;
                    Context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View(produto);
            }

        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
