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
            int sum = 0;
            Carddeck carddeck = new Carddeck();
            carddeck.ShuffleCards();
            Console.WriteLine("Välkommen till scam city. Vill du spela? (ja/nej)");
            string choice = Console.ReadLine();
            if (choice == "ja")
            {
                Card c1 = carddeck.GetFirstCard();
                Card c2 = carddeck.GetFirstCard();


                c1.Printcard();
                c1.PrintValue();
                c1.Printcard();
                c1.PrintValue();
                Console.WriteLine("--------");
                c2.Printcard();
                c2.PrintValue();
                c2.Printcard();
                c2.PrintValue();


            }
        }
    }
}
