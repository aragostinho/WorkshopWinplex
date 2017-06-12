using GestaoAcessos.Business.Factories;
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

        public ContaController()
        {


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
                string login = ConfigurationManager.AppSettings["login"];
                string nome = ConfigurationManager.AppSettings["nome"];
                string senha = ConfigurationManager.AppSettings["senha"];

                if (autenticacao.Login.Equals(login) && autenticacao.Senha.Equals(senha))
                {
                    Domain.Entities.Autenticacao autenticacaoDomain = new Domain.Entities.Autenticacao();
                    autenticacaoDomain.Login = login;
                    autenticacaoDomain.Nome = nome;
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