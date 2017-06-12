using GestaoAcessos.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Factories
{
    public static class SessionFactory
    {
        public static ISession Open()
        {
            return FluentNHibernateHelper.GetSession;
        }

        public static void Close()
        {
            FluentNHibernateHelper.CloseSession();
        }
    }
}
