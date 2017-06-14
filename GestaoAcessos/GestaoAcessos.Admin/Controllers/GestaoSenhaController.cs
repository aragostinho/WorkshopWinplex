using GestaoAcessos.Admin.Models;
using GestaoAcessos.Admin.Utils;
using GestaoAcessos.Business.Components;
using GestaoAcessos.Business.Factories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoAcessos.Admin.Controllers
{
    [AdminAuthorize]
    [RoutePrefix("GestaoSenha")]
    public class GestaoSenhaController : Controller
    {

        private IBGestaoSenha _IBGestaoSenha;
        public GestaoSenhaController()
        {

            ISession _session = SessionFactory.Open();
            _IBGestaoSenha = AcessoFactory.GestaoSenha(_session);
        }
        protected override void Dispose(bool disposing)
        {
            SessionFactory.Close();
        }


        [HttpGet]
        [Route("Cadastrar")]
        public ActionResult Cadastrar()
        {
            GestaoSenha _gestaoSenha = new GestaoSenha();
            return View("~/Views/GestaoSenha/Cadastro.cshtml", _gestaoSenha);
        }

        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult Cadastrar(GestaoSenha gestaoSenha)
        {
            if (ModelState.IsValid)
            {


            }
            return View("~/Views/GestaoSenha/Cadastro.cshtml", gestaoSenha);
        }

      

        [HttpGet]
        [Route("Visualizar")]
        public ActionResult Visualizar(int id)
        {
            GestaoSenha _gestaoSenha = new GestaoSenha();
            return View("~/Views/GestaoSenha/Editar.cshtml", _gestaoSenha);
        }

        [HttpPost]
        [Route("Alterar")]
        public ActionResult Alterar(GestaoSenha gestaoSenha)
        {
            if (ModelState.IsValid)
            {


            }
            return View("~/Views/GestaoSenha/Editar.cshtml", gestaoSenha);
        }

        [HttpPost]
        [Route("Listar")]
        public ActionResult Listar(GestaoSenha gestaoSenha)
        {
 
            return View("~/Views/GestaoSenha/Listar.cshtml", gestaoSenha);
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult Listar()
        {
            GestaoSenha _gestaoSenha = new Models.GestaoSenha();
            _gestaoSenha.ListaSenhas = _IBGestaoSenha.List();             
            return View("~/Views/GestaoSenha/Listar.cshtml", _gestaoSenha);
        }
    }
}