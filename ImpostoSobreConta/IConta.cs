using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSobreConta
{
    public interface IConta    
    {
        decimal GetSaldo();
        string GetOwner();
    }
}
