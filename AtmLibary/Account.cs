using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class Account
    {
        public Card Card { get; private set; }
        public decimal Balance { get; set; }

    }
}
