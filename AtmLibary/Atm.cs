using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class Atm
    {
        public Card Card { get; private set; }

        public void InsertCard(Card card)
        {
            if(card.CardNumber.Length < 16)
            {
                throw new ArgumentException("The cardnumber was too short", "card");
            }
            else
            {
                Card = card;
            }
        }
        public void EnterPin()
        {

        }
    }
}
