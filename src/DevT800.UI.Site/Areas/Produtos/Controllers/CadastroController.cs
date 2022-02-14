using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevT800.UI.Site.Areas.Produtos.Controllers
{
    public class CadastroController : Controller
    {
        [Area("Produtos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
