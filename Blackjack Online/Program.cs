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
            //string choice = Console.ReadLine();
            string choice = "ja";
            if (choice == "ja")
            {
                carddeck.ShuffleCards();
                Card c1 = carddeck.GetFirstCard();
                Card c2 = carddeck.GetFirstCard();
                


                c1.Printcard();
                c1.PrintValue();
                c2.Printcard();
                c2.PrintValue();
                sum = c1.PrintValue() + c2.PrintValue();
                Console.WriteLine(sum);

                Console.WriteLine("Hora vill du ha hit?");
                string hit = "ja";
                while(hit == "ja")
                {
                    c1.Printcard();
                    c1.PrintValue();
                    sum = c1.PrintValue() + c2.PrintValue();
                    Console.WriteLine(sum);

                }





            }
        }
    }
}
