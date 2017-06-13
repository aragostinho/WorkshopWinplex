using FluentNHibernate.Mapping;
using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class ColaboradorMap : ClassMap<Colaborador>
    {

        public ColaboradorMap()
        {
            Table("colaborador");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Nome).Column("nome");
            Map(x => x.Login).Column("login");
            Map(x => x.Senha).Column("senha");
            Map(x => x.Admin).Column("admin");
        }
    }
}
