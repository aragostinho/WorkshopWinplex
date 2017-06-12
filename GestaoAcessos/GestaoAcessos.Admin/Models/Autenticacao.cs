using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoAcessos.Admin.Models
{
    public class Autenticacao: BaseModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}