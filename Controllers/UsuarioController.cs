using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCProyect.Controllers    
{
    public class UsuarioController : Controller  
    {

        public IActionResult Index()
        {
           // var url = Url.Action("Metodo","Usuario");

            return View();
            //return Content(url);
           // return Redirect(url);
        }

        public ActionResult Metodo()
        {

            return View();

        }
        public ActionResult Registrar()
        {
            return View();
        }
    }
} 