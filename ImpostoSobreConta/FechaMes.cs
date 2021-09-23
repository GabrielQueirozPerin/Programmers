using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    class FechaMes : IFechaMes
    {
        enum Imposto { ImpBaixo = 20, ImpMedBaixo = 25, ImpMedAlto = 28, ImpAlto = 30 }
        Transacoes Transacao = new();
        public ContaCorrente AtualizaConta(ContaCorrente conta)
        {
            decimal ValorImposto = CalculaImposto(conta.GetSaldo());
            conta.SetSaldo(conta.GetSaldo() - ValorImposto);
            return conta;
        }
        public decimal CalculaImposto(decimal valor)
        {
            Imposto Imp = Imposto.ImpBaixo;
            if (valor <= 900)   
                Imp = Imposto.ImpBaixo;
            if (valor > 900 && valor <= 2999) 
                Imp = Imposto.ImpMedBaixo;
            if (valor > 2999 && valor <= 6999) 
                Imp = Imposto.ImpMedAlto;
            if (valor > 6999) 
                Imp = Imposto.ImpAlto;
            switch (Imp)
            {
                case Imposto.ImpBaixo: 
                    return (valor * ((decimal)Imposto.ImpBaixo) / 1000);
                case Imposto.ImpMedBaixo: 
                    return (valor * ((decimal)Imposto.ImpMedBaixo) / 1000);
                case Imposto.ImpMedAlto:
                    return (valor * ((decimal)Imposto.ImpMedAlto) / 1000);
                case Imposto.ImpAlto:
                    return (valor * ((decimal)Imposto.ImpAlto) / 1000);
                default: break;
            }
            return ((decimal)Imp);
        }
    }
}
