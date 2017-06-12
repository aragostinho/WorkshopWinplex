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
    public class BGestaoSenha: AbstractGenericDao<GestaoSenha>, IBGestaoSenha
    {

        public BGestaoSenha(ISession pSession)
            : base(pSession)
        {


        }
        public BGestaoSenha()
            : base()
        {


        }
    }
}
