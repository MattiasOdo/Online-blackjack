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
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                carddeck.ShuffleCards();
                Card c1 = carddeck.GetFirstCard();
                Card c2 = carddeck.GetFirstCard();

                Console.WriteLine("");

                c1.Printcard();
                c1.GetValue();
                c2.Printcard();
                c2.GetValue();
                sum = c1.GetValue() + c2.GetValue();
                Console.WriteLine("You have "+ sum +" points!");
                Console.WriteLine("");
                Console.WriteLine("Do you want another card?");
                string hit = Console.ReadLine();
                while (hit == "yes")
                {
                    Card c = carddeck.GetFirstCard();
                    c.Printcard();
                    
                    sum = sum + c.GetValue();
                    Console.WriteLine("You have " + sum + " points!");

                    if (sum == 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Congratulations you won!");
                        break;
                    }
                    if (sum < 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You have less then 21 points. Do you want another card?");
                        hit = Console.ReadLine();


                    }
                    if (sum > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You got more then 21 points. You just lost!");
                        hit = "nej";
                    }
                }

            }
        }
    }
}
