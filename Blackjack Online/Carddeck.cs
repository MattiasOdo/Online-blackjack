using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Carddeck
    {
        List<Card> Cards;

        public Carddeck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                int color = i % 13;
                int value = i / 13;
                Card card = new Card(color, value);
                Cards.Add(card);
            }
        }
        public void PrintCarddeck()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                Cards[i].Printcard();
            }
        }

        public void ShuffleCards()
        {
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int a = random.Next(0, 52);
                int b = random.Next(0, 52);

                Card temp = Cards[a];
                Cards[a] = Cards[b];
                Cards[b] = temp;
            }
        }
    }
}
