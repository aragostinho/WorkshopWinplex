using FluentNHibernate.Mapping;
using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class ModuloPermissaoMap : ClassMap<ModuloPermissao>
    {

        public ModuloPermissaoMap()
        {
            Table("modulopermissao");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            References(x => x.Colaborador).Column("colaboradorId");
            References(x => x.Modulo).Column("moduloId");
            Map(x => x.Permissao).Column("permissao").CustomType<PermissaoEnum>(); 
        }
    }
}
