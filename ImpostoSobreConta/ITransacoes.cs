using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    interface ITransacoes
    {
        ContaCorrente Debitar(ContaCorrente cc, decimal valor);
        ContaCorrente Creditar(ContaCorrente cc, decimal valor);
        decimal VerSaldo(ContaCorrente cc);
    }
}
