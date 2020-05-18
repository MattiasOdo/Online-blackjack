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
        public string name;

        public Player(string name)
        {
            this.name = name;
        }

        public void AddCardToHand(Card card)
        {

            cards.Add(card);
            card.Printcard();
            sum += card.GetValue();
        }

        public string PlayerName()
        {
            return name;
        }

        public int GetHandSum()
        {
            return sum;
        }

    }
}
