using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaTerceiraAplicacaoMVC.Controllers
{
    public class HomeController : ControladorBaseController
    {
        //
        // GET: /Home/

        public ActionResult Home()
        {
            return View();
        }

    }
}
