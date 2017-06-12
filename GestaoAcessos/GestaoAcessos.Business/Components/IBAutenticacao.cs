using GestaoAcessos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Business.Components
{
    public interface IBAutenticacao
    {
        void setAuth(Autenticacao autenticacao);
        void removeAuth();
        Autenticacao getAuth();
    }
}
