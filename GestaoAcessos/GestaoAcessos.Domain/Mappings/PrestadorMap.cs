using FluentNHibernate.Mapping;
using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Mappings
{
    public class PrestadorMap : ClassMap<Prestador>
    {

        public PrestadorMap()
        {
            Table("Prestador");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Nome).Column("Nome");
            Map(x => x.Servico).Column("Servico").CustomType<ServicosEnum>();
            HasMany(x => x.Acessos).KeyColumn("PrestadorId").Inverse().Cascade.All();
        }
    }
}
