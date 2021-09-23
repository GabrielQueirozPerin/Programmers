using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    class Controle
    {
        public static void Iniciar()
        {
            Mensagem mens = new();
            Menu.Opcoes OpcaoEscolhida;
            ContaCorrente ContaTeste = new("", 2500);
            Transacoes Transacao;
            do
            {
                Menu menus = new();
                menus.ExibirMenu(99);
                Menu.ExibirMensagem(mens.ReceberEntrada);
                OpcaoEscolhida = menus.ReceberOpcao();
                Transacao = new();
                if (OpcaoEscolhida != Menu.Opcoes.Fechar)
                {
                    switch(OpcaoEscolhida)
                    {
                        case Menu.Opcoes.Saldo:
                            Console.WriteLine(mens.MenuSaldo + ContaTeste.GetSaldo());
                            Transacao.IncluirTransacao(OpcaoEscolhida, ContaTeste, ContaTeste.GetSaldo());
                            ContaTeste.NovaTransacao(Transacao);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.Opcoes.Debito:
                            Console.WriteLine(mens.MenuDebito);
                            decimal EntradaDebito = decimal.Parse(Console.ReadLine());
                            if (EntradaDebito <= ContaTeste.GetSaldo())
                            {
                                ContaTeste = Transacao.IncluirTransacao(OpcaoEscolhida, ContaTeste, EntradaDebito);
                                Console.WriteLine(mens.SaldoAtualizado + ContaTeste.GetSaldo() + "\n");
                                ContaTeste.NovaTransacao(Transacao);
                            }
                            else Console.WriteLine(mens.SaldoInsuficiente);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.Opcoes.Credito:
                            Console.WriteLine(mens.MenuCredito);
                            Console.WriteLine(mens.ReceberEntrada);
                            decimal EntradaCredito = decimal.Parse(Console.ReadLine());
                            ContaTeste = Transacao.IncluirTransacao(OpcaoEscolhida, ContaTeste, EntradaCredito);
                            Console.WriteLine(mens.SaldoAtualizado + ContaTeste.GetSaldo() + "\n");
                            ContaTeste.NovaTransacao(Transacao);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.Opcoes.FecharMes:
                            FechaMes Mes = new();
                            Console.WriteLine(mens.FechaMes + Mes.CalculaImposto(ContaTeste.GetSaldo()));
                            ContaTeste = Transacao.IncluirTransacao(OpcaoEscolhida, ContaTeste, ContaTeste.GetSaldo());
                            Console.WriteLine(mens.SaldoAtualizado + ContaTeste.GetSaldo() + "\n");
                            ContaTeste.NovaTransacao(Transacao);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.Opcoes.Historico:
                            foreach(Transacoes t in ContaTeste.MostrarTransacoes)
                            {
                                if (t.GetOpcao() == Menu.Opcoes.Saldo)
                                    Console.WriteLine("Consulta de Saldo realizada em " + t.GetDataTime() + "\nSaldo de: " + t.GetSaldoConta());
                                else Console.WriteLine("Operação de " + t.GetOpcao() + " realizado em " + t.GetDataTime() + "\nSaldo anterior na conta: " + t.GetSaldoConta() + "\nValor modificado na conta: " + t.GetValor());
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.Opcoes.Fechar:
                            break;
                    }
                }
            } while (OpcaoEscolhida != Menu.Opcoes.Fechar);
        }
    }
}
