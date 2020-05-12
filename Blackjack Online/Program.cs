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
            List<Player> players;
            players = new List<Player>();
            Carddeck carddeck = new Carddeck();
            Dealer dealer = new Dealer();
            int bet = 0;


            

            players.Add(new Player("Benne"));
            players.Add(new Player("Matte"));
            


            {
                carddeck.ShuffleCards();

                foreach ( Player p in players )
                {
                    
                    Console.WriteLine(p.PlayerName() + " how much do you want to bet? " + " (Minimun 200$)");
                    bet = int.Parse(Console.ReadLine());
                    while (bet < 200)
                    {
                        Console.WriteLine("Your bet was to low, try again");
                        bet = int.Parse(Console.ReadLine());
                    }

                }
                foreach( Player p in players)
                {
                    Console.WriteLine(p.PlayerName() + " your cards are :");
                    p.AddCardToHand(carddeck.GetFirstCard());
                    p.AddCardToHand(carddeck.GetFirstCard());
                    Console.WriteLine("");
                    Console.WriteLine(p.PlayerName() + " you have " + p.GetHandSum() + " points!");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    
                }

            }






            
         
        }
    }
}
