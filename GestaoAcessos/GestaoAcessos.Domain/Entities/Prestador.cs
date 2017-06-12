﻿using GestaoAcessos.Domain.Enum;
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
        public virtual string ListaServicos { get; set; }
        public virtual IList<GestaoSenha> GestaoSenha { get; set; }
    }
}
