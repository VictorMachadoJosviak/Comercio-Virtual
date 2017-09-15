using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComercioVirtual.Controllers
{
    public class Validacao
    {
        private static string carrinhoSessao = "CarrinhoId";

        public static string RetornarCarrinhoId()
        {
            if (HttpContext.Current.Session[carrinhoSessao] == null)
            {
                Guid newGuid = Guid.NewGuid();
                HttpContext.Current.Session[carrinhoSessao] = newGuid.ToString();
            }
            return HttpContext.Current.Session[carrinhoSessao].ToString();
        }
    }
}