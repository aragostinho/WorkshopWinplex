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
    public static class ColaboradorFactory
    {

        private static IBColaborador _colaborador;
        public static IBColaborador Colaborador()
        {
            _colaborador = new BColaborador(FluentNHibernateHelper.GetSession);
            return _colaborador;
        } 
    }
}
