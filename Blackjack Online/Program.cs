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
            Console.WriteLine("Welcome to scam city! Do you want to play? (yes/no)");
            //string choice = Console.ReadLine();
            string choice = "yes";
            if (choice == "yes")
            {
                carddeck.ShuffleCards();
                Card c1 = carddeck.GetFirstCard();
                Card c2 = carddeck.GetFirstCard();
                Card c3 = carddeck.GetFirstCard();



                c1.Printcard();
                c1.PrintValue();
                c2.Printcard();
                c2.PrintValue();
                sum = c1.PrintValue() + c2.PrintValue();
                Console.WriteLine("You have "+ sum +" points!");

                Console.WriteLine("Do you want to hit a child?");
                string hit = "yes";
                while(hit == "yes")
                {
                    c3.Printcard();
                    c3.PrintValue();
                    sum = c1.PrintValue() + c2.PrintValue() + c3.PrintValue();
                    Console.WriteLine("You have " + sum + " points!");

                    if (sum == 21)
                    {
                        Console.WriteLine("Grattis Sagge du vann");
                    }
                    if (sum < 21)
                    {
                        Console.WriteLine("You have less then 21 points. Do you want another card?");
                        hit = Console.ReadLine();


                    }
                    if (sum > 21)
                    {

                    }
                }





            }
        }
    }
}
