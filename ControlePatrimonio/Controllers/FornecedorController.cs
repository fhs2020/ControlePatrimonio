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
    [Authorize]
    public class FornecedorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fornecedor
        public ActionResult Index()
        {
            return View(db.Fornecedors.ToList());
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public ActionResult Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                var telefone = fornecedor.Telefone.Replace("_", "");

                fornecedor.Telefone = null;

                fornecedor.Telefone = telefone;

                db.Fornecedors.Add(fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public ActionResult Edit(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                var telefone = fornecedor.Telefone.Replace("_", "");

                fornecedor.Telefone = null;

                fornecedor.Telefone = telefone;

                db.Entry(fornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fornecedor fornecedor = db.Fornecedors.Find(id);

            var patrimonioLista = db.Patrimonios.ToList();

            var fornecedorPatrimonio = patrimonioLista.Where(x => x.FornecedorId == id).SingleOrDefault();

            if (fornecedorPatrimonio != null)
            {
                //throw new ApplicationException("Não é possivel excluir, existe um patrimonio cadastrado para este fornecedor.");

                var result = new { Success = "False", Message = "Não é possivel excluir, existe um patrimonio cadastrado para este fornecedor." };
                return Json(result, JsonRequestBehavior.AllowGet);
            }

            db.Fornecedors.Remove(fornecedor);
            db.SaveChanges();
            //return RedirectToAction("Index");

            var resultSucesso = new { Success = "true", Message = "Fornecedor excluido com sucesso!" };
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
