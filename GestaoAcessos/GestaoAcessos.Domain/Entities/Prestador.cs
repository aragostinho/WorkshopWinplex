using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain
{
    public class Prestador
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<ServicosEnum> Servico { get; set; }
        public virtual IList<Acesso> Acessos { get; set; }
    }
}
