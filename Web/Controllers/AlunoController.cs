using BDPojetoCrud.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            var appFuncionario = new FuncionarioAplicacao();
            var listaFuncionario = appFuncionario.Lista();
            return View(listaFuncionario);
        }
    }
}