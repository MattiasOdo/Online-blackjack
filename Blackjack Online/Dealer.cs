using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Dealer : Program
    {
        List<Card> cards = new List<Card>();

        public int sum = 0;
        public string name;

        public Dealer(string name)
        {
            this.name = "Dealer";
        }

        public void AddCardToDealer(Card card)
        {
            cards.Add(card);
            card.Printcard();
            sum += card.GetValue();
        }



        public int GetDealerSum()
        {
            return sum;
        }


    }
}
