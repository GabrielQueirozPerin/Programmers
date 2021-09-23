using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    class Transacoes : ITransacoes
    {
        private Menu.Opcoes OpcaoSelecionada;
        private DateTime DataHoraTransacao;
        private string DataEHoraTransacao;
        private decimal SaldoConta;
        private decimal Valor;
        public Menu.Opcoes GetOpcao() { return OpcaoSelecionada; }
        public string GetDataTime() { DataEHoraTransacao = DateTime.Now.ToString(); return DataEHoraTransacao; }
        public decimal GetSaldoConta() { return SaldoConta; }
        public decimal GetValor() { return Valor; }
        public ContaCorrente Creditar(ContaCorrente conta, decimal valor)
        {
            conta.SetSaldo(conta.GetSaldo() + valor);
            return conta;
        }
        public ContaCorrente Debitar(ContaCorrente conta, decimal valor)
        {
            decimal NovoSaldo = conta.GetSaldo();
            if (valor < conta.GetSaldo())
            {
                NovoSaldo -= valor;
                conta.SetSaldo(NovoSaldo);
            }
            else
                Console.WriteLine("Saldo Insuficiente");
            return conta;
        }
        public decimal VerSaldo(ContaCorrente conta)
        {
            return conta.GetSaldo();
        }
        public ContaCorrente IncluirTransacao(Menu.Opcoes Opcao, ContaCorrente cc, decimal valor)
        {
            this.OpcaoSelecionada = Opcao;
            this.SaldoConta = cc.GetSaldo();
            this.Valor = valor;
            DataEHoraTransacao = GetDataTime();
            if (OpcaoSelecionada == Menu.Opcoes.Credito) { cc = Creditar(cc, valor); }
            else if (OpcaoSelecionada == Menu.Opcoes.Debito) { cc = Debitar(cc, valor); }
            else if (OpcaoSelecionada == Menu.Opcoes.Saldo) {  }
            else if (OpcaoSelecionada == Menu.Opcoes.FecharMes)
            {
                FechaMes mes = new(); this.Valor = mes.CalculaImposto(cc.GetSaldo()); cc = mes.AtualizaConta(cc);
            }
            return cc;
        }
    }
}
