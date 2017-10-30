using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlePatrimonio.Models;
using System.IO;

namespace ControlePatrimonio.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produto
        public ActionResult Index(String search)
        {
            var produtoLista = db.Produtos.ToList();

            var listaDeProdutos = new List<Produto>();

            foreach(var item in produtoLista)
            {
                var categoria = db.Categorias.Find(item.CategoriaID);

                item.Categoria = new Categoria();

                item.Categoria.TipoCategoria = categoria.TipoCategoria;

                item.Categoria.ID = categoria.ID;

                listaDeProdutos.Add(item);

            }


            if (!String.IsNullOrEmpty(search))
            {
                search.ToLower();

                var listaProdutosSearch = db.Produtos.ToList();

                var novaListaProdutos = new List<Produto>();

                foreach (var item in listaDeProdutos)
                {
                    var categoriaProdutoSearched = db.Categorias.Find(item.CategoriaID);

                    item.Categoria = new Categoria();

                    item.Categoria.TipoCategoria = categoriaProdutoSearched.TipoCategoria;
                    item.CategoriaID = categoriaProdutoSearched.ID;

                    novaListaProdutos.Add(item);
                }

                var produtosSearched = novaListaProdutos.Where(s => s.Categoria.TipoCategoria.ToLower().Contains(search) || s.Marca.ToLower().Contains(search) ||
                           s.Modelo.ToLower().Contains(search) || s.NomeProduto.ToLower().Contains(search)).ToList();

                if (produtosSearched != null)
                {
                        return View(produtosSearched);
                }
                else
                {
                    return View();
                }
             
            }
            else
            {
                return View(listaDeProdutos.ToList());
            }

            
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);

            var categoria = db.Categorias.Find(produto.CategoriaID);

            produto.Categoria = new Categoria();

            produto.Categoria.TipoCategoria = categoria.TipoCategoria;

            if (produto == null)
            {
                return HttpNotFound();
            }

            ViewBag.Image = produto.URLFoto;

            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            var categoriaLista = db.Categorias.ToList();

            ViewBag.Categoria = new SelectList(categoriaLista, "ID", "TipoCategoria");


            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto, HttpPostedFileBase fileImage)
        {

            var categoriaLista = db.Categorias.ToList();

            ViewBag.Categoria = new SelectList(categoriaLista, "ID", "TipoCategoria");

            if (fileImage != null)
            {

                string path = System.IO.Path.Combine(Server.MapPath("~/Images"),
                                  Path.GetFileName(fileImage.FileName));

                fileImage.SaveAs(path);

                produto.URLFoto = path;

                ViewBag.Message = "File uploaded successfully";
            }

            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produto);
        }


        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {

            var categoriaLista = db.Categorias.ToList();

            ViewBag.Categoria = new SelectList(categoriaLista, "ID", "TipoCategoria");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);

            ViewBag.Image = produto.URLFoto;


            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto produto, HttpPostedFileBase fileImage)
        {
            var categoriaLista = db.Categorias.ToList();

            ViewBag.Categoria = new SelectList(categoriaLista, "ID", "TipoCategoria");


            if (ModelState.IsValid)
            {
                if (fileImage != null)
                {
                    string path = System.IO.Path.Combine(Server.MapPath("~/Content/Images"),
                         Path.GetFileName(fileImage.FileName));

                    fileImage.SaveAs(path);

                    produto.URLFoto = path;

                    ViewBag.Message = "File uploaded successfully";
                }



                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);

            ViewBag.Image = produto.URLFoto;

            var categoria = db.Categorias.Find(produto.CategoriaID);

            produto.Categoria = new Categoria();

            produto.Categoria.TipoCategoria = categoria.TipoCategoria;


            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produtos.Find(id);

            var patrimonioLista = db.Patrimonios.ToList();

            var produtoPatrimonio = patrimonioLista.Where(x => x.ProdutoId == id).LastOrDefault();

            if (produtoPatrimonio != null)
            {
                //throw new ApplicationException("Não é possivel excluir, existe um patrimonio cadastrado com este produto.");

                var result = new { Success = "False", Message = "Não é possivel excluir, existe um patrimonio cadastrado com este produto." };
                return Json(result, JsonRequestBehavior.AllowGet);
            }

            db.Produtos.Remove(produto);
            db.SaveChanges();
            //return RedirectToAction("Index");

            var resultSucesso = new { Success = "true", Message = "Produto Excluido com sucesso!" };
            return Json(resultSucesso, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
