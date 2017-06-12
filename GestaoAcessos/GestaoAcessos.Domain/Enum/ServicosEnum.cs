using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Domain.Enum
{
    public enum ServicosEnum:byte
    {
        [Description("Hospedagem de website")]
        HospedagemSite = 0,
        [Description("Implementação SEO")]
        ImplementacaoSEO = 2,
        [Description("Marketing digital")]
        MarketingDigital = 3,
        [Description("Manutenção de software")]
        ManutencaoSoftware = 4
    }
}
