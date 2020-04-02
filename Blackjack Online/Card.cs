using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Card
    {
        public string card;
        public int value;
        int sum = 0;
        public Card(int color, int value)
        {

            //Hearts
            if ((color == 0) && (value < 11) && (value > 1))
            {
                card = value + " of Hearts";
                this.value = value;
            }
            else if ((color == 0) && (value == 11))
            {
                card = "Jack of Hearts";
                this.value = 10;
            }
            else if ((color == 0) && (value == 12))
            {
                card = "Queen of Hearts";
                this.value = 10;
            }
            else if ((color == 0) && (value == 13))
            {
                card = "King of Hearts";
                this.value = 10;
            }
            else if ((color == 0) && (value == 0))
            {
                card = "Ace of Hearts";
                if (sum + 11 > 21)
                {
                    sum = sum + 1;
                }
                else if (sum + 11 <= 21)
                {
                    sum = sum + 11;
                }
            }

            //Clubs
            if ((color == 0) && (value < 11) && (value > 1))
            {
                card = value + " of Clubs";
                this.value = value;
            }
            else if ((color == 0) && (value == 11))
            {
                card = "Jack of Clubs";
                this.value = 10;
            }
            else if ((color == 0) && (value == 12))
            {
                card = "Queen of Clubs";
                this.value = 10;
            }
            else if ((color == 0) && (value == 13))
            {
                card = "King of Clubs";
                this.value = 10;
            }
            else if ((color == 0) && (value == 0))
            {
                card = "Ace of Clubs";
                if (sum + 11 > 21)
                {
                    sum = sum + 1;
                }
                else if (sum + 11 <= 21)
                {
                    sum = sum + 11;
                }
            }

            //Spades
            if ((color == 0) && (value < 11) && (value > 1))
            {
                card = value + " of Spades";
                this.value = value;
            }
            else if ((color == 0) && (value == 11))
            {
                card = "Jack of Spades";
                this.value = 10;
            }
            else if ((color == 0) && (value == 12))
            {
                card = "Queen of Spades";
                this.value = 10;
            }
            else if ((color == 0) && (value == 13))
            {
                card = "King of Spades";
                this.value = 10;
            }
            else if ((color == 0) && (value == 0))
            {
                card = "Ace of Spades";
                if (sum + 11 > 21)
                {
                    sum = sum + 1;
                }
                else if (sum + 11 <= 21)
                {
                    sum = sum + 11;
                }
            }

            //Diamonds
            if ((color == 0) && (value < 11) && (value > 1))
            {
                card = value + " of Diamonds";
                this.value = value;
            }
            else if ((color == 0) && (value == 11))
            {
                card = "Jack of Diamonds";
                this.value = 10;

            }
            else if ((color == 0) && (value == 12))
            {
                card = "Queen of Diamonds";
                this.value = 10;
            }
            else if ((color == 0) && (value == 13))
            {
                card = "King of Diamonds";
                this.value = 10;
            }
            else if ((color == 0) && (value == 0))
            {
                card = "Ace of Diamonds";
                if (sum + 11 > 21)
                {
                    sum = sum + 1;
                }
                else if (sum + 11 <= 21)
                {
                    sum = sum + 11;
                }
            }
        }

        public void Printcard()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(card);
            }
        }
    }
}
