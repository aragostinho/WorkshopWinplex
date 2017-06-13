using GestaoAcessos.Business.Components;
using GestaoAcessos.Business.Factories;
using GestaoAcessos.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoAcessos.Admin.Controllers
{
    [RoutePrefix("Conta")]
    public class ContaController : Controller
    {


        private IBColaborador _IBColaborador;
        public ContaController()
        {
            _IBColaborador = ColaboradorFactory.Colaborador();



        }

        [HttpGet]
        [Route("Login")]
        public ActionResult Login()
        {
            Models.Autenticacao autenticacao = new Models.Autenticacao();

            return View(autenticacao);
        }


        [HttpPost]
        [Route("Login")]
        public ActionResult Login(Models.Autenticacao autenticacao)
        {
            if (ModelState.IsValid)
            {

                Colaborador _colaborador = _IBColaborador.Get(x => x.Login == autenticacao.Login && x.Senha == autenticacao.Senha).FirstOrDefault();

                if (_colaborador != null)
                {
                    string login = _colaborador.Login;
                    string nome = _colaborador.Nome;
                    bool admin = _colaborador.Admin;

                    Domain.Entities.Autenticacao autenticacaoDomain = new Domain.Entities.Autenticacao();
                    autenticacaoDomain.Login = login;
                    autenticacaoDomain.Nome = nome;
                    autenticacaoDomain.Admin = admin;
                    AcessoFactory.Autenticacao.setAuth(autenticacaoDomain);
                    Response.Redirect("~/");

                }
                else
                    autenticacao.Erro = new Exception("Login ou senha inválidos!");
            }

            return View(autenticacao);
        }
    }
}