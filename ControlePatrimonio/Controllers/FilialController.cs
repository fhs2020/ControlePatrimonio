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
    public class FilialController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Filial
        public ActionResult Index()
        {
            return View(db.Filials.ToList());
        }

        // GET: Filial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filials.Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // GET: Filial/Create
        public ActionResult Create()
        {
            var empresaLista = db.Empresas.ToList();

            ViewBag.Empresa = new SelectList(empresaLista, "id", "nome");

            return View();
        }

        // POST: Filial/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public ActionResult Create(Filial filial)
        {
            if (ModelState.IsValid)
            {
                var empresa = db.Empresas.Find(filial.EmpresaId);

                filial.EmpresaNome = null;

                filial.EmpresaNome = empresa.Nome.ToUpper();

                var telefone = filial.Telefone.Replace("_", "");

                filial.Telefone = null;

                filial.Telefone = telefone;


                db.Filials.Add(filial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filial);
        }

        // GET: Filial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filials.Find(id);

            var empresaLista = db.Empresas.ToList();

            ViewBag.Empresa = new SelectList(empresaLista, "id", "nome");

            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filial/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public ActionResult Edit(Filial filial)
        {
            if (ModelState.IsValid)
            {
                var empresa = db.Empresas.Find(filial.EmpresaId);

                filial.EmpresaNome = empresa.Nome.ToUpper();

                var telefone = filial.Telefone.Replace("_", "");

                filial.Telefone = null;

                filial.Telefone = telefone;


                db.Entry(filial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filial);
        }

        // GET: Filial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filials.Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filial/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Filial filial = db.Filials.Find(id);

            var patrimonio = db.Patrimonios.ToList();

            var patrimonioFilial = patrimonio.Where(x => x.FilialId == id).SingleOrDefault();

            if (patrimonioFilial != null)
            {
                //throw new ApplicationException("Não é possivel excluir, existe patrimonios cadastrados para esta filial");

                var result = new { Success = "False", Message = "Não é possivel excluir, existe patrimonios cadastrados para esta filial" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }

            db.Filials.Remove(filial);
            db.SaveChanges();
            //return RedirectToAction("Index");

            var resultSucesso = new { Success = "true", Message = "Filial excluida com sucesso!" };
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
