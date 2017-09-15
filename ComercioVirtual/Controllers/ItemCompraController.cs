using ComercioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComercioVirtual.Controllers
{
    public class ItemCompraController : Controller
    {
        private Context db = new Context();
        public string carrinhoId { get; set; }
        // GET: ItemCompra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RemoverDoCarrinho(int id)
        {
            ItemCompra ic = db.ItensCompra.Find(id);
            if (ic != null)
            {
                if (ic.Quantidade > 1)
                {
                    ic.Quantidade--;
                }
                else
                {
                    db.ItensCompra.Remove(ic);
                }
            }
            db.SaveChanges();
            return RedirectToAction("CarrinhoDeCompras");
        }

        public ActionResult AdicionarAoCarrinho(int id)
        {
            carrinhoId = Validacao.RetornarCarrinhoId();
            ItemCompra ic = db.ItensCompra.FirstOrDefault(x => x.Produto.ProdutoId == id && x.CarrinhoId.Equals(carrinhoId));
            if (ic == null)
            {
                ic = new ItemCompra();
                ic.Data = DateTime.Now;
                ic.Quantidade = 1;
                ic.CarrinhoId = carrinhoId;
                ic.Produto = db.Produtos.Find(id);
                db.ItensCompra.Add(ic);
            }
            else
            {
                ic.Quantidade++;
            }
            db.SaveChanges();
            return RedirectToAction("CarrinhoDeCompras", "ItemCompra");
        }

        public ActionResult CarrinhoDeCompras()
        {
            carrinhoId = Validacao.RetornarCarrinhoId();
            string total;
            try
            {
                total = db.ItensCompra.Where(x => x.CarrinhoId.Equals(carrinhoId)).Sum(x => x.Quantidade * x.Produto.Preco).ToString("C2");
            }
            catch
            {
                total = "0";
            }
            ViewBag.Total = total;
            return View(db.ItensCompra.Where(x => x.CarrinhoId.Equals(carrinhoId)));
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