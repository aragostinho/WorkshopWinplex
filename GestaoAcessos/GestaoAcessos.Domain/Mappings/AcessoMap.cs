using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class AcessoMap : ClassMap<Acesso>
    {

        public AcessoMap()
        {
            Table("Acesso");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Login).Column("Login");
            Map(x => x.Senha).Column("Senha");
            Map(x => x.LinkAcesso).Column("LinkAcesso");
            Map(x => x.Utilizador).Column("Utilizador");
            References(x => x.Prestador).Column("PrestadorId"); 
        }
    }
}
