using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "Mi primera aplicacion en ASP.NET con MVC5";
        }
    }
}