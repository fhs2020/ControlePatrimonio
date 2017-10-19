﻿using System;
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
        public ActionResult Create([Bind(Include = "Id,EmpresaId,NomeFilial,Cidade,Estado,Telefone")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                var empresa = db.Empresas.Find(filial.EmpresaId);

                filial.EmpresaNome = empresa.Nome;

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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmpresaId,NomeFilial,Cidade,Estado,Telefone")] Filial filial)
        {
            if (ModelState.IsValid)
            {
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
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filial filial = db.Filials.Find(id);
            db.Filials.Remove(filial);
            db.SaveChanges();
            return RedirectToAction("Index");
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
