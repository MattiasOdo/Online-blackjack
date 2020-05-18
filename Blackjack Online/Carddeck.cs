﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Carddeck:Card
    {
        List<Card> Cards;

        public Card GetFirstCard()
        {
            if (Cards.Count != 0)
            {
                Card c = Cards[0];
                Cards.RemoveAt(0);
                return c;
            }
            return null;
        }



        public Carddeck()
        {
            Cards = new List<Card>();

            for (int color = 0; color <= 3; color++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Cards.Add(new Card(color, value));
                }
            }

        }
        public void PrintCarddeck()
        {
            foreach (Card c in Cards)
            {
                c.Printcard();
            }

        }

        public void ShuffleCards()
        {
            Random random = new Random();

            for (int i = 0; i < 1000000; i++)
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
