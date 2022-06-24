using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class PinValidator
    {
        readonly Atm atm = new Atm();
        public int Attempts { get; set; }
        public void ValidatePin(string enteredpin)
        {
            if (Attempts <= 3)
            {
                if(enteredpin == atm.Card.PinCode)
                {

                }
            }
        }
    }   
}
