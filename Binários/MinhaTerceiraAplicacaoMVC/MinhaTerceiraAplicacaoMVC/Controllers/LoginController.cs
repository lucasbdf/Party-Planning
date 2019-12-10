using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinhaTerceiraAplicacaoMVC.Models;

namespace MinhaTerceiraAplicacaoMVC.Controllers
{
    public class LoginController : Controller
    {

        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                CrieCokie();
                return RedirectToAction("Home", "Home");
            }
            else return View();
        }

        
        private void CrieCokie() {
            var guidAutenticacao = Guid.NewGuid();
            var cookie = new HttpCookie("autenticacao");
            cookie.Expires = DateTime.Today.AddDays(1);
            cookie.Value = guidAutenticacao.ToString().ToUpper();
            Session["autenticacao"] = guidAutenticacao;
            Response.Cookies.Add(cookie);

        }

    }
}
