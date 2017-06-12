using GestaoAcessos.Business.Components;
using GestaoAcessos.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Factories
{
    public static class AcessoFactory
    {

        private static IBAcesso _acesso;
        public static IBAcesso Acesso()
        {
            _acesso = new BAcesso(FluentNHibernateHelper.GetSession);
            return _acesso;
        }
        public static IBAcesso Acesso(ISession pSession)
        {

            if (pSession != null)
                _acesso = new BAcesso(pSession);

            return _acesso;

        }

        private static IBAutenticacao _autenticacao;
        public static IBAutenticacao Autenticacao
        {
            get
            { 
                _autenticacao = new BAutenticacao();
                return _autenticacao;
            }
        }

    }
}
