using FluentNHibernate.Mapping;
using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class ModuloMap : ClassMap<Modulo>
    {

        public ModuloMap()
        {
            Table("modulo");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Nome).Column("nome"); 
        }
    }
}
