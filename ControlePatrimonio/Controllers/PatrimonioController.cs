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
using Microsoft.AspNet.Identity;

namespace ControlePatrimonio.Controllers
{
    [Authorize]
    public class PatrimonioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Patrimonio
        public ActionResult Index(String search)
        {

            var usuarioId = User.Identity.GetUserId();

            var usuarioLogado = db.Users.Find(usuarioId);


            if (!String.IsNullOrEmpty(search))
            {
                search.ToLower();

                var listaPatrimonio = db.Patrimonios.ToList();

                var patrimoniosSearched = listaPatrimonio.Where(s => s.EmpresaNome.ToLower().Contains(search) || 
                           s.ProdutoNome.ToLower().Contains(search) || s.NumeroPatrimonio.ToLower().Contains(search)).ToList();

                foreach(var item in listaPatrimonio)
                {
                    if (item.NumeroSerie != null)
                    {
                       if(string.Equals(item.NumeroSerie.ToLower(), search))
                        {
                            patrimoniosSearched.Add(item);
                        }
                    }

                    if (item.FilialNome != null)
                    {
                        if (string.Equals(item.FilialNome.ToLower(), search))
                        {
                            patrimoniosSearched.Add(item);
                        }
                    }
                }


                if (patrimoniosSearched != null)
                {
                    if (usuarioLogado.UsuarioPerfil == "Emp")
                    {
                        return View(patrimoniosSearched.Where(x => x.UserId == usuarioId || x.FilialId == usuarioLogado.FilialId).ToList());
                    }
                    else
                    {
                        return View(patrimoniosSearched.ToList());
                    }

                }
                else
                {
                    return View();
                }
            }
            else
            {
                if (usuarioLogado.UsuarioPerfil == "Emp")
                {
                    return View(db.Patrimonios.Where(x => x.UserId == usuarioId || x.Regiao == usuarioLogado.Region).ToList());
                }
                else
                {
                    return View(db.Patrimonios.ToList());
                }
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

            //ViewBag.Image = patrimonio.URLImage;

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

            var listaEmpresa = db.Filials.AsEnumerable().Select(c => new
            {
                Id = c.Id,
                NomeEmpresa = string.Format("{0} - {1}", c.EmpresaNome,
                c.NomeFilial)
            }).ToList();

            var categoriaList = db.Categorias.ToList();

            ViewBag.Categoria = new SelectList(categoriaList, "ID", "TipoCategoria");

            ViewBag.Empresa = new SelectList(listaEmpresa, "id", "NomeEmpresa");

            ViewBag.EmpresaLista = new SelectList(empresaLista, "Id", "Nome");

            var usuarioId = User.Identity.GetUserId();

            var usuarioLogado = db.Users.Find(usuarioId);

            var filialLista = db.Filials.ToList();

            if (usuarioLogado.UsuarioPerfil == "Emp")
            {

                ViewBag.FilialLista = new SelectList(filialLista.Where(x => x.Id == usuarioLogado.FilialId).ToList(), "id", "NomeFilial");
            }
            else
            {
                ViewBag.FilialLista = new SelectList(filialLista, "id", "NomeFilial");
            }

            var fornecedoresLista = db.Fornecedors.ToList();

            ViewBag.FornecedoresLista = new SelectList(fornecedoresLista, "id", "Nome");

            var produtosLista = db.Produtos.ToList();


            var listaProduto = db.Produtos.AsEnumerable().Select(c => new
            {
                Id = c.Id,
                NomeProduto = string.Format("{0} - {1} - {2}", c.NomeProduto,
                c.Marca, c.Modelo)
            }).ToList();

            // ViewBag.ProdutosLista = new SelectList(listaProduto, "id", "NomeProduto");

            var listaProducts = new List<Produto>();
            var listaFilial = new List<Filial>();

            ViewBag.ProdutosLista = new SelectList(listaProducts, "id", "NomeProduto");

            ViewBag.Filial = new SelectList(listaFilial, "Id", "NomeFilial");

            return View();
        }

        // POST: Patrimonio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public ActionResult Create(Patrimonio patrimonio, HttpPostedFileBase fileImage)
        {
            var usuarioId = User.Identity.GetUserId();
            var usuarioLogado = db.Users.Find(usuarioId);
            
            var listaPatrimonio = db.Patrimonios.ToList();

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in listaPatrimonio)
                    {
                        if (patrimonio.NumeroSerie != null)
                        {
                            if (item.NumeroSerie == patrimonio.NumeroSerie)
                            {
                                throw new ApplicationException("Este número de serie já existe cadastrado com outro patrimonio");

                            }
                        }

                        if (patrimonio.NumeroPatrimonio != null)
                        {
                            if (item.NumeroPatrimonio == patrimonio.NumeroPatrimonio)
                            {
                                throw new ApplicationException("Este número de patrimonio já existe cadastrado com outro patrimonio");
                            }
                        }


                    }


                    patrimonio.UserId = usuarioId;

                    patrimonio.DataCadastro = DateTime.Now;

                    if (fileImage != null)
                    {
                       

                        string path = System.IO.Path.Combine(Server.MapPath("~/Images"),
                                          Path.GetFileName(fileImage.FileName));

                        fileImage.SaveAs(path);

                        //patrimonio.URLImage = path;

                        ViewBag.Message = "File uploaded successfully";
                    }

                    if (patrimonio.EmpresaId != 0)
                    {
                        var empresaSelecionada = db.Empresas.Find(patrimonio.EmpresaId);
                        patrimonio.EmpresaNome = empresaSelecionada.Nome;
                    }
                    else
                    {
                        throw new ApplicationException("Selecione uma empresa");
                    }


                    if (patrimonio.FilialId != null && patrimonio.FilialId > 0)
                    {
                        var filial = db.Filials.Find(patrimonio.FilialId);
                        patrimonio.FilialNome = filial.NomeFilial;
                    }


                    if (patrimonio.ProdutoId != 0)
                    {
                        var produto = db.Produtos.Find(patrimonio.ProdutoId);
                        patrimonio.ProdutoNome = produto.NomeProduto;
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


        [HttpPost]
        public ActionResult GetProdutoByCategoriaID(int? categoriaId)
        {
            if (categoriaId != null)
            {
                var categoria = db.Categorias.Find(categoriaId);

                List<Produto> objproduto = new List<Produto>();
                objproduto = db.Produtos.Where(m => m.CategoriaID == categoriaId).ToList();

                //SelectList produtoSelectList = new SelectList(objproduto, "id", "NomeProduto");

                //var listaProdutosSelect = db.Produtos.Where(x => x.CategoriaID == categoriaId).ToList();

                var listaProduto = objproduto.AsEnumerable().Select(c => new
                {
                    Id = c.Id,
                    NomeProduto = string.Format("{0} - {1} - {2}", c.NomeProduto, c.Marca, c.Modelo)
                }).ToList();


                var selectList = new SelectList(listaProduto, "id", "NomeProduto");

                return Json(selectList);
            }
            else
            {
                return Json("");
            }

        }



        //

        [HttpPost]
        public ActionResult GetFilialByEmpresaID(int? empresaId)
        {
            if (empresaId != null)
            {
                var empresa = db.Empresas.Find(empresaId);

                List<Filial> objfilial = new List<Filial>();
                objfilial = db.Filials.Where(m => m.EmpresaId == empresaId).ToList();

                //SelectList produtoSelectList = new SelectList(objproduto, "id", "NomeProduto");

                //var listaProdutosSelect = db.Produtos.Where(x => x.CategoriaID == categoriaId).ToList();

                //var listaProduto = objfilial.AsEnumerable().Select(c => new
                //{
                //    Id = c.Id,
                //    NomeProduto = string.Format("{0} - {1} - {2}", c.NomeProduto, c.Marca, c.Modelo)
                //}).ToList();

                var selectList = new SelectList(objfilial, "Id", "NomeFilial");

                return Json(selectList);
            }
            else
            {
                return Json("");
            }

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

            //var listaEmpresa = db.Filials.AsEnumerable().Select(c => new
            //{
            //    Id = c.Id,
            //    NomeEmpresa = string.Format("{0} - {1}", c.EmpresaNome,
            //                                c.NomeFilial)
            //}).ToList();

            ViewBag.Empresa = new SelectList(empresaLista, "Id", "Nome");

            var filialLista = new List<Filial>();

            if (patrimonio.FilialNome != null && patrimonio.FilialId != null)
            {
                var filialAtual = db.Filials.Find(patrimonio.FilialId);

                filialLista.Add(filialAtual);

                ViewBag.FilialLista = new SelectList(filialLista, "id", "NomeFilial", patrimonio.FilialNome);
            }
            else
            {
                var listaFilial = new List<Filial>();

                ViewBag.FilialLista = new SelectList(listaFilial, "Id", "NomeFilial");
            }


            var fornecedoresLista = db.Fornecedors.ToList();

            ViewBag.FornecedoresLista = new SelectList(fornecedoresLista, "id", "Nome");

            var produtosLista = db.Produtos.ToList();

            var listaProduto = db.Produtos.AsEnumerable().Select(c => new
            {
                Id = c.Id,
                NomeProduto = string.Format("{0} - {1} - {2}", c.NomeProduto,
                                            c.Marca, c.Modelo)
            }).ToList();

            ViewBag.ProdutosLista = new SelectList(listaProduto, "Id", "NomeProduto");

            //ViewBag.Image = patrimonio.URLImage;


            var categoriaList = db.Categorias.ToList();
        

            ViewBag.Categoria = new SelectList(categoriaList, "ID", "TipoCategoria");

      

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
        [PreventDuplicateRequest]
        public ActionResult Edit(Patrimonio patrimonio, HttpPostedFileBase fileImage)
        {
            try
            {
                var listaPatrimonio = db.Patrimonios.ToList();


                var categoriaList = db.Categorias.ToList();

                ViewBag.Categoria = new SelectList(categoriaList, "ID", "TipoCategoria");

                //foreach (var item in listaPatrimonio)
                //{
                //    if (item.NumeroSerie == patrimonio.NumeroSerie)
                //    {
                //        throw new ApplicationException("Este número de serie ja esta cadastrado com outro produto");
                //    }

                //    if (item.NumeroPatrimonio == patrimonio.NumeroPatrimonio)
                //    {
                //        throw new ApplicationException("Este número de patrimonio já esta cadastrado com outro produto");
                //    }
                //}

                if (ModelState.IsValid)
                {
                    if (fileImage != null)
                    {
                        string path = System.IO.Path.Combine(Server.MapPath("~/Content/Images"),
                             Path.GetFileName(fileImage.FileName));

                        fileImage.SaveAs(path);

                        //patrimonio.URLImage = path;

                        ViewBag.Message = "File uploaded successfully";
                    }

                    if (patrimonio.FilialId != null && patrimonio.FilialId > 0)
                    {
                        var filial = db.Filials.Find(patrimonio.FilialId);
                        patrimonio.FilialNome = filial.NomeFilial;
                    }


                    var empresa = db.Empresas.Find(patrimonio.EmpresaId);
                    patrimonio.EmpresaNome = empresa.Nome;
                    patrimonio.EmpresaId = empresa.Id;

                    var fornecedor = db.Fornecedors.Find(patrimonio.FornecedorId);
                    patrimonio.FornecedorNome = fornecedor.Nome;

                    var protudo = db.Produtos.Find(patrimonio.ProdutoId);
                    patrimonio.ProdutoNome = protudo.NomeProduto;

                    var local = db.Set<Patrimonio>()
                         .Local
                         .FirstOrDefault(f => f.Id == patrimonio.Id);
                    if (local != null)
                    {
                        db.Entry(local).State = EntityState.Detached;
                    }


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

            //ViewBag.Image = patrimonio.URLImage;


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

        //Action result for ajax call
        [HttpPost]
        public ActionResult GetMarcaByProdutoId(int produtoId)
        {
            List<Produto> produtoLista = new List<Produto>();
            produtoLista = db.Produtos.Where(m => m.Id == produtoId).ToList();

            SelectList produtoMarca = new SelectList(produtoLista, "Id", "Marca", 0);
            return Json(produtoMarca);
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
