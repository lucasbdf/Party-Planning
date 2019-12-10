using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinhaTerceiraAplicacaoMVC.Models;
using MinhaTerceiraAplicacaoMVC.Repositorio;

 

namespace MinhaTerceiraAplicacaoMVC.Controllers
{
    public class ConvidadoController : Controller
    {
        //
        // GET: /Convidado/

        public ActionResult Convidado()
        {
            var listaConvidadoDoBanco = RepositorioUniversal<ConvidadoModel>.RecupereLista();
            return View(listaConvidadoDoBanco);
        }

        public ActionResult Edit()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Edit(ConvidadoModel convidado)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            RepositorioUniversal<ConvidadoModel>.GraveObjeto(convidado);

            return RedirectToAction("Convidado");
        }

    }
}
