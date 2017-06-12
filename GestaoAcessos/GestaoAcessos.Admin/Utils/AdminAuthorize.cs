using GestaoAcessos.Business.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GestaoAcessos.Admin.Utils
{
    public class AdminAuthorize: AuthorizeAttribute
    {

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (AcessoFactory.Autenticacao.getAuth() == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Conta", action = "Login" }));
            }
        }

    }
}