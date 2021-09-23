using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    class ContaCorrente : IConta
    {
        private string Owner;
        private decimal Saldo;
        public ContaCorrente(string NovoOwner, decimal NovoSaldo) { SetOwner(NovoOwner); SetSaldo(NovoSaldo); }
        public string GetOwner() { return Owner; }
        public void SetOwner(String owner) { Owner = owner; }
        public decimal GetSaldo() { return Saldo; }
        public void SetSaldo(decimal saldo) { Saldo = saldo; }
        private List<Transacoes> ListaTransacoes = new();
        public List<Transacoes> MostrarTransacoes => ListaTransacoes;
        public void NovaTransacao(Transacoes t)
        {
            ListaTransacoes.Add(t);
        }
    }
}
