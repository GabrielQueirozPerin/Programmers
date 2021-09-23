using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    interface IFechaMes
    {
        decimal CalculaImposto(decimal Valor);
        ContaCorrente AtualizaConta(ContaCorrente cc);
    }
}
