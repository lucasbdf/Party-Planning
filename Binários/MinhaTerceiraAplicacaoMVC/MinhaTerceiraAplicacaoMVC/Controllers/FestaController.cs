using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinhaTerceiraAplicacaoMVC.Models;
using MinhaTerceiraAplicacaoMVC.Repositorio;

namespace MinhaTerceiraAplicacaoMVC.Controllers
{
    public class FestaController : Controller
    {
        //
        // GET: /Festa/

        public ActionResult Festa()
        {

            //var listaSexo = new List<dynamic>(){
            //new { opcao = 1, descricao = "Masculino"},
            //new { opcao = 2, descricao = "Feminino"},
            //new { opcao = 3, descricao = "Indefinido"}


            //};

            //ViewBag.ListaOpcoesSexo = listaSexo;

            var listaFesta = new List<FestaModel>{
                new FestaModel{Id = 1, Nome ="Chalau"},
                new FestaModel{Id = 2, Nome ="Chalau 2"}
            };

            var listaFestaDoBanco = RepositorioUniversal<FestaModel>.RecupereLista();

            

            return View(listaFestaDoBanco);
        }


        public ActionResult Edit()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Edit(FestaModel festa)
        {
            RepositorioUniversal<FestaModel>.GraveObjeto(festa);

            if (!ModelState.IsValid)
            {

                return View();

            }
            else
            {

                return RedirectToAction("Festa");
            }
        }

    }
}
