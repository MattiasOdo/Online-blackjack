﻿using System;
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
            
            Console.WriteLine("Välkommen till scam city. Vill du spela? (ja/nej)");
            string choice = Console.ReadLine();
            if (choice == "ja")
            {

                Card c = carddeck.gettopcard();
                c.printvalue();
                //carddeck.PrintCard();
                //carddeck.PrintCard();

                

            }
        }
    }
}
