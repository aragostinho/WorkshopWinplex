using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoAcessos.Domain.Entities;
using System.Web;
using System.Web.Security;

namespace GestaoAcessos.Business.Components
{
    public class BAutenticacao : IBAutenticacao
    {
        public Autenticacao getAuth()
        {
            string cookieName = FormsAuthentication.FormsCookieName;

            if (HttpContext.Current.Request.Cookies[cookieName] == null)
                return null;

            string cookieValue = HttpContext.Current.Request.Cookies[cookieName].Value;

            if (cookieValue.IsNullOrEmpty())
                return null;

            FormsAuthenticationTicket oFormsAuthenticationTicket = FormsAuthentication.Decrypt(cookieValue);
            Autenticacao _autenticacao = new Autenticacao()
            {
                Nome = oFormsAuthenticationTicket.Name,
                Login = oFormsAuthenticationTicket.UserData,
                CookiePath = oFormsAuthenticationTicket.CookiePath,
                Expiration = oFormsAuthenticationTicket.Expiration
            };

            return _autenticacao;
        }

        public void removeAuth()
        {
            Autenticacao _autenticacao = this.getAuth();
            if (_autenticacao != null)
            {
                FormsAuthentication.SignOut();

                // clear authentication cookie
                HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                cookie1.Expires = DateTime.Now.AddYears(-1);
                HttpContext.Current.Response.Cookies.Add(cookie1);

                // clear session cookie (not necessary for your current problem but i would recommend you do it anyway)
                HttpCookie cookie2 = new HttpCookie("ASP.NET_SessionId", "");
                cookie2.Expires = DateTime.Now.AddYears(-1);
                HttpContext.Current.Response.Cookies.Add(cookie2);
            }
        }

        public void setAuth(Autenticacao autenticacao)
        {
            var authTicket = new FormsAuthenticationTicket(
                 1,
                 autenticacao.Nome,
                 DateTime.Now,
                 DateTime.Now.AddDays(7),
                 false,
                  autenticacao.Login,
                  "/"
                  );
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
            HttpContext.Current.Response.Cookies.Add(cookie);

        }
    }
}
