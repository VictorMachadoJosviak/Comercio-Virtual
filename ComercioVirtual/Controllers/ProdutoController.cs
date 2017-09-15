using ComercioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComercioVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        
        private Context db = new Context();

        public ActionResult ListarProdutos()
        {
            return View(db.Produtos.ToList());
        }

        // GET: Produto
        public ActionResult Index()
        {
            ViewBag.ListaDeProdutos = db.Produtos.ToList();
            return View();
        }

        public ActionResult CadastrarProduto()
        {
            ViewBag.CategoriaId = 
                new SelectList(db.Categorias, "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarProduto(string txtNome,
            int txtQuantidade, double txtPreco, string CategoriaId, 
            HttpPostedFileBase fileImagem)
        {
            ViewBag.CategoriaId =
                new SelectList(db.Categorias, "CategoriaId", "Nome");
            Produto p = new Produto();
            p.Nome = txtNome;
            p.Quantidade = txtQuantidade;
            p.Preco = txtPreco;
            p.CategoriaId = Convert.ToInt32(CategoriaId);
            p.Categoria = db.Categorias.Find(p.CategoriaId);

            if (fileImagem != null)
            {
                string imagemNome = fileImagem.FileName;
                string caminho = System.IO.Path.Combine(Server.MapPath("~/Images/"), imagemNome);

                fileImagem.SaveAs(caminho);
                p.CaminhoImagem = imagemNome;
            }
            else
            {
                p.CaminhoImagem = "SemImagem.png";
            }

            try
            {
                db.Produtos.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult EditarProduto(int id)
        {
            ViewBag.Produto = db.Produtos.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult EditarProduto(string txtNome,
            int txtQuantidade, double txtPreco, string txtCategoria,
            int txtProdutoId)
        {
            Produto p = db.Produtos.Find(txtProdutoId);
            p.Nome = txtNome;
            p.Quantidade = txtQuantidade;
            p.Preco = txtPreco;
            //p.Categoria = txtCategoria;

            try
            {
                db.Entry(p).State =
                    System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("EditarProduto");
            }

        }

        public ActionResult RemoverProduto(int id)
        {
            ViewBag.Produto = db.Produtos.Find(id);
            return View();
        }
        [HttpPost]
        public ActionResult Confirmacao(int txtProdutoId)
        {
            try
            {
                db.Produtos.Remove(db.Produtos.Find(txtProdutoId));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("RemoverProduto");
            }
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