using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlePatrimonio.Models;

namespace ControlePatrimonio.Controllers
{
    public class CategoriaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categoria
        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TipoCategoria")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                categoria.TipoCategoria.ToUpper();

                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Categoria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TipoCategoria")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                categoria.TipoCategoria.ToUpper();

                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = db.Categorias.Find(id);

            var produtos = db.Produtos.ToList();

            var produtoPatrimonio = produtos.Where(x => x.CategoriaID == id).LastOrDefault();

            if (produtoPatrimonio != null)
            {
                //throw new ApplicationException("Não é possivel excluir, existe um patrimonio cadastrado com este produto.");

                var result = new { Success = "False", Message = "Não é possivel excluir, existe um produto cadastrado com esta categoria." };
                return Json(result, JsonRequestBehavior.AllowGet);
            }



            db.Categorias.Remove(categoria);
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
