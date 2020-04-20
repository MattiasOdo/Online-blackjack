using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            Carddeck carddeck = new Carddeck();
            Card card = new Card();

            Console.WriteLine("Välkommen till scam city. Vill du spela? (ja/nej)");
            string choice = Console.ReadLine();
            if (choice == "ja")
            {
                carddeck.ShuffleCards();
                carddeck.PrintCarddeck();
                Console.WriteLine("---------");
                carddeck.DrawCard();
                carddeck.PrintCarddeck();
                carddeck.DrawCard();
                card.Printcard();

            }
        }
    }
}
