using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain
{
    public class GestaoSenha
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual string LinkAcesso { get; set; }
        public virtual UtilizadorEnum Utilizador { get; set; }
        public virtual string Prestador { get; set; }
        public virtual string ListaServicos { get; set; }
    }
}
