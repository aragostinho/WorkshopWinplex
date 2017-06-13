using GestaoAcessos.Business.Core;
using GestaoAcessos.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Components
{
    public class BColaborador: AbstractGenericDao<Colaborador>, IBColaborador
    {

        public BColaborador(ISession pSession)
            : base(pSession)
        {


        }
        public BColaborador()
            : base()
        {


        }
    }
}
