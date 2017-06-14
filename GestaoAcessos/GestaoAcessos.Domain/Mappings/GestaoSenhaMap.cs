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
            Map(x => x.ListaServicos).Column("listaservicos");
            Map(x => x.Utilizador).Column("utilizador");
            Map(x => x.Prestador).Column("prestador");
        }
    }
}
