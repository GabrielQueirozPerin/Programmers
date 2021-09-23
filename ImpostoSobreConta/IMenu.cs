using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    interface IMenu
    {
        enum Opcoes { }
        void ExibirMenu(int i);
        int ReceberOpcao();
    }
}
