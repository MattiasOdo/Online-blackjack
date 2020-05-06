using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Player 
    {
        List<Card> cards = new List<Card>();

        public int sum = 0;
        public int bet = 0;

        public Player()
        {
            
        }

        public void AddCardToHand(Card card)
        {

            cards.Add(card);
            sum += card.GetValue();
            
        }

        public int GetHandSum()
        {
            return sum;
        }

    }
}
