using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class GestaoSenhaMap : ClassMap<GestaoSenha>
    {

        public GestaoSenhaMap()
        {
            Table("gestaoSenha");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Login).Column("login");
            Map(x => x.Senha).Column("senha");
            Map(x => x.LinkAcesso).Column("linkacesso");
            Map(x => x.Utilizador).Column("utilizador");
            References(x => x.Prestador).Column("prestadorid"); 
        }
    }
}
