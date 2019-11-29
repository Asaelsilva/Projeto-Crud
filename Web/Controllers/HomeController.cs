using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDPojetoCrud.Aplicacao;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var appFuncionario = new FuncionarioAplicacao();
            var listaFuncionario = appFuncionario.Lista();

            return View(listaFuncionario);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}