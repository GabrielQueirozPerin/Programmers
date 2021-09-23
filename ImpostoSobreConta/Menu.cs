using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    class Menu
    {
        public enum Opcoes { Inicial = 99, Saldo = 1, Debito = 2, Credito = 3, FecharMes = 4, Historico = 5, Fechar = 0 }
        public Mensagem mens = new();
        public void ExibirMenu(int numero)
        {
            Console.WriteLine(mens.getMensagem(numero));
        }
        public Opcoes QualOpcao(int valor)
        {
            switch (valor)
            {
                case 1: return Opcoes.Saldo; 
                case 2: return Opcoes.Debito; 
                case 3: return Opcoes.Credito; 
                case 4: return Opcoes.FecharMes; 
                case 5: return Opcoes.Historico; 
                case 0: return Opcoes.Fechar; 
                case 99: return Opcoes.Inicial; 
                default: break;
            }
            return Opcoes.Inicial;
        }
        public static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
        public Opcoes ReceberOpcao()
        {
            return QualOpcao(int.Parse(Console.ReadLine()));
        }
    }
}
