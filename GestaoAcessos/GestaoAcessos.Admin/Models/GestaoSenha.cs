using GestaoAcessos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoAcessos.Admin.Models
{
    public class GestaoSenha : BaseModel
    {
        public  int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo login!")]
        public  string Login { get; set; }
        [Required(ErrorMessage = "Preencha o campo senha!")]
        public  string Senha { get; set; }
        public  string LinkAcesso { get; set; }
        public  UtilizadorEnum Utilizador { get; set; }
        [Required(ErrorMessage = "Preencha o campo prestador!")]
        public  string Prestador { get; set; }
        [Required(ErrorMessage = "Preencha o campo lista de serviços!")]
        public  string ListaServicos { get; set; }

        public IList<GestaoAcessos.Domain.GestaoSenha> ListaSenhas { get; set; }
    }
}