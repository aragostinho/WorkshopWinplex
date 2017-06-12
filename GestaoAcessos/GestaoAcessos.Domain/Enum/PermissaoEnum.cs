using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Enum
{
    public enum PermissaoEnum
    {
        [Description("Cadastrar")]
        Cadastrar,
        [Description("Listar")]
        Listar,
        [Description("Visualizar")]
        Visualizar,
        [Description("Excluir")]
        Excluir,
        [Description("Atualizar")]
        Atualizar
    }
}
