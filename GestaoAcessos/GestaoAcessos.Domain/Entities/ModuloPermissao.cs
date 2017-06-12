using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain
{
    public class ModuloPermissao
    {
        public virtual int Id { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual Modulo Modulo { get; set; }
        public virtual PermissaoEnum Permissao { get; set; }
    }
}
