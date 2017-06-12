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
    public class BAcesso: AbstractGenericDao<Acesso>, IBAcesso
    {

        public BAcesso(ISession pSession)
            : base(pSession)
        {


        }
        public BAcesso()
            : base()
        {


        }
    }
}
