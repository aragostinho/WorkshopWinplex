﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Entities
{
    public class Autenticacao
    {
        public Autenticacao()
        {

        }

        public Autenticacao(string Nome, string Login, bool Admin)
        {
            this.Nome = Nome;
            this.Login = Login;
            this.Admin = Admin;
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public bool Admin { get; set; }
        public string CookiePath { get; set; }
        public DateTime Expiration { get; set; }
    }
}
