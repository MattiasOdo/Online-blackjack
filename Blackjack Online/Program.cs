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
            Carddeck firstcarddeck = new Carddeck();
            firstcarddeck.PrintCarddeck();
            Console.WriteLine("-----");
            firstcarddeck.ShuffleCards();
            firstcarddeck.PrintCarddeck();

        }
    }
}
