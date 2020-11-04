using ProjetoEstudoAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEstudoAspNet.Controllers
{
    public class CategoriasController : Controller
    {
        private static List<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() {
                CategoriaId = 1,
                Nome = "Notebooks"
            },
            new Categoria() {
                CategoriaId = 2,
                Nome = "Monitores"
            },
            new Categoria() {
                CategoriaId = 3,
                Nome = "Impressoras"
            },
            new Categoria() {
                CategoriaId = 4,
                Nome = "Mouses"
            },
            new Categoria() {
                CategoriaId = 5,
                Nome = "Desktops"
            }
        };

        // GET: Categorias
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(categorias);
        }
    }
}