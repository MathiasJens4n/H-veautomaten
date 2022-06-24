using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Atm;

namespace Atm.tests
{
    public class ATMTests
    {
        readonly Atm atm = new Atm();
        readonly Card validCard = new Card("5454545454545454");
        readonly Card invalidCard = new Card("545455454");

        [Fact]
        public void InsertCard_ValidCardNumberShouldWork()
        {
            string actual = atm.Card.CardNumber;

            Assert.True(actual.Length >= 16);
        }
        [Fact]
        public void InsertCard_invalidCardNumberShouldFail()
        {
            Assert.Throws<ArgumentException>("card", () => atm.InsertCard(invalidCard));
        }

    }
}
