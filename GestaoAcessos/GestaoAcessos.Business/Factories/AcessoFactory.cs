using GestaoAcessos.Business.Components;
using GestaoAcessos.Infrastructure;
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

        private static IBGestaoSenha _acesso;
        public static IBGestaoSenha Acesso()
        {
            _acesso = new BGestaoSenha(FluentNHibernateHelper.GetSession);
            return _acesso;
        }
        public static IBGestaoSenha Acesso(ISession pSession)
        {

            if (pSession != null)
                _acesso = new BGestaoSenha(pSession);

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
