using GestaoAcessos.Business.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoAcessos.Admin.Utils
{
    public static class Utilitario
    {


        public static Domain.Entities.Autenticacao autenticacao
        {
            get
            {

                return AcessoFactory.Autenticacao.getAuth();
            }

        }
    }
}