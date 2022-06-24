using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public Card(string cardNumber)
        {
            CardNumber = cardNumber;
        }
    }
}
