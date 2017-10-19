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
    public class PatrimonioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Patrimonio
        public ActionResult Index(String search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                search.ToLower();

                var listaPatrimonio = db.Patrimonios.ToList();

                var patrimoniosSearched = listaPatrimonio.Where(s => s.EmpresaNome.ToLower().Contains(search) || s.FilialNome.ToLower().Contains(search) ||
                           s.ProdutoNome.ToLower().Contains(search) || s.NumeroSerie.ToLower().Contains(search) || s.NumeroPatrimonio.ToLower().Contains(search) ||
                           s.NotaFiscal.ToLower().Contains(search));

                if (patrimoniosSearched != null)
                {
                    return View(patrimoniosSearched.ToList());
                }
                else
                {
                    return View();
                }
            }
            else
            {
              return View(db.Patrimonios.ToList());
            }
        }

        // GET: Patrimonio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);

            if (patrimonio.Observacao == null)
            {
                patrimonio.Observacao = "";
            }

            ViewBag.Image = patrimonio.URLImage;

            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // GET: Patrimonio/Create
        public ActionResult Create()
        {
            var empresaLista = db.Empresas.ToList();

            ViewBag.Empresa = new SelectList(empresaLista, "id", "nome");

            var filialLista = db.Filials.ToList();

            ViewBag.FilialLista = new SelectList(filialLista, "id", "NomeFilial");

            var fornecedoresLista = db.Fornecedors.ToList();

            ViewBag.FornecedoresLista = new SelectList(fornecedoresLista, "id", "Nome");

            var produtosLista = db.Produtoes.ToList();

            ViewBag.ProdutosLista = new SelectList(produtosLista, "id", "Modelo");

            return View();
        }

        // POST: Patrimonio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Patrimonio patrimonio, HttpPostedFileBase fileImage)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    if (fileImage != null)
                    {
                        patrimonio.DataCadastro = DateTime.Now;

                        string path = System.IO.Path.Combine(Server.MapPath("~/Images"),
                                          Path.GetFileName(fileImage.FileName));

                        fileImage.SaveAs(path);

                        patrimonio.URLImage = path;

                        ViewBag.Message = "File uploaded successfully";
                    }
 

                    if (patrimonio.FilialId != 0)
                    {
                        var filial = db.Filials.Find(patrimonio.FilialId);
                        patrimonio.FilialNome = filial.NomeFilial;

                        var empresa = db.Empresas.Find(filial.EmpresaId);
                        patrimonio.EmpresaNome = empresa.Nome;
                        patrimonio.EmpresaId = empresa.Id;
                    }
                    else
                    {
                        throw new ApplicationException("Selecione uma filial");
                    }
        
                    if (patrimonio.ProdutoId != 0)
                    {
                        var produto = db.Produtoes.Find(patrimonio.ProdutoId);
                        patrimonio.ProdutoNome = produto.Modelo;
                    }
                    else
                    {
                        throw new ApplicationException("Selecione um produto!");
                    }

                    if (patrimonio.FornecedorId != 0)
                    {
                        var fornecedor = db.Fornecedors.Find(patrimonio.FornecedorId);
                        patrimonio.FornecedorNome = fornecedor.Nome;
                    }
                    else
                    {
                        throw new ApplicationException("Selecione um fornecedor ou adicione um novo fornecedor");
                    }

                    db.Patrimonios.Add(patrimonio);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new ApplicationException(ex.Message);
                }
            
                return RedirectToAction("Index");
            }

            return View(patrimonio);
        }

        // GET: Patrimonio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);

            var empresaLista = db.Empresas.ToList();

            ViewBag.Empresa = new SelectList(empresaLista, "id", "nome");

            var filialLista = db.Filials.ToList();

            ViewBag.FilialLista = new SelectList(filialLista, "id", "NomeFilial", patrimonio.FilialNome);

            var fornecedoresLista = db.Fornecedors.ToList();

            ViewBag.FornecedoresLista = new SelectList(fornecedoresLista, "id", "Nome");

            var produtosLista = db.Produtoes.ToList();

            ViewBag.ProdutosLista = new SelectList(produtosLista, "id", "Modelo");

            ViewBag.Image = patrimonio.URLImage;

            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // POST: Patrimonio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Patrimonio patrimonio, HttpPostedFileBase fileImage)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    if (fileImage != null)
                    {
                        string path = System.IO.Path.Combine(Server.MapPath("~/Content/Images"),
                             Path.GetFileName(fileImage.FileName));

                        fileImage.SaveAs(path);

                        patrimonio.URLImage = path;

                        ViewBag.Message = "File uploaded successfully";
                    }


                    var filial = db.Filials.Find(patrimonio.FilialId);
                    patrimonio.FilialNome = filial.NomeFilial;

                    var empresa = db.Empresas.Find(filial.EmpresaId);
                    patrimonio.EmpresaNome = empresa.Nome;

                    var fornecedor = db.Fornecedors.Find(patrimonio.FornecedorId);
                    patrimonio.FornecedorNome = fornecedor.Nome;

                    var protudo = db.Produtoes.Find(patrimonio.ProdutoId);
                    patrimonio.ProdutoNome = protudo.Modelo;



                    db.Entry(patrimonio).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(patrimonio);
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }

        }

        // GET: Patrimonio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);

            ViewBag.Image = patrimonio.URLImage;


            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // POST: Patrimonio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patrimonio patrimonio = db.Patrimonios.Find(id);
            db.Patrimonios.Remove(patrimonio);
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
