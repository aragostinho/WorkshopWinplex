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

        private static IBGestaoSenha _gestaoSenha;
        public static IBGestaoSenha GestaoSenha()
        {
            _gestaoSenha = new BGestaoSenha(FluentNHibernateHelper.GetSession);
            return _gestaoSenha;
        }
        public static IBGestaoSenha GestaoSenha(ISession pSession)
        {

            if (pSession != null)
                _gestaoSenha = new BGestaoSenha(pSession);

            return _gestaoSenha;

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
