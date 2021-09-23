using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    public class Mensagem 
    {
        public string MenuInicial = "\nBem-Vindo ao Menu. Digite a opção desejada: \n1 - Saldo\n2 - Débito\n3 - Crédito\n4 - Fechar o Mês\n5 - Histórico\n0 - Fechar";
        public string MenuSaldo = "\nVamos verificar o seu saldo na conta: \n";
        public string MenuCredito = "\nValor a ser creditado em sua conta:\n";
        public string MenuDebito = "\nValor a ser debitado de sua conta: ";
        public string FechaMes = "\nEncerrando o Mês. Valor pago em imposto: ";
        public string MenuSaida = "\nFechando o programa e encerrando as transações. \n";
        public string SaldoAtualizado = "\nNovo Saldo atualizado: ";
        public string ReceberEntrada= "\nDigite: ";
        public string MenuHistorico = "Histórico de transacoes na conta: \n";
        public string SaldoInsuficiente = "Saldo Insuficiente para a operação desejada.";
        public string[] MensagemMenu = new string[10];
        public  string getMensagem(int numero) { string MensagemSelecionada = EscolherMensagem(numero); return MensagemSelecionada;  }
        private string EscolherMensagem(int Numero)
        {
            switch (Numero)
            {
                case (int)Menu.Opcoes.Saldo:
                    return MenuSaldo;
                case (int)Menu.Opcoes.Credito:
                    return MenuCredito;
                case (int)Menu.Opcoes.Debito:
                    return MenuDebito;
                case (int)Menu.Opcoes.Fechar:
                    return MenuSaida;
                case (int)Menu.Opcoes.Inicial:
                    return MenuInicial;
                case (int)Menu.Opcoes.Historico:
                    return MenuHistorico;
            }
            return "";
        }
    }
}
