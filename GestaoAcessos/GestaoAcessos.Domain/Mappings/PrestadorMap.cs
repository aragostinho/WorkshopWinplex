﻿using FluentNHibernate.Mapping;
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
            Table("prestador");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Nome).Column("nome");
            Map(x => x.ListaServicos).Column("listaservicos");
            HasMany(x => x.GestaoSenha).KeyColumn("gestaosenhaid").Inverse().Cascade.All();
        }
    }
}
