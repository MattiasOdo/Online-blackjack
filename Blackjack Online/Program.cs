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
                    Console.WriteLine("");
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
                foreach (Player p in players)
                {
                    Console.WriteLine(p.PlayerName() + " do want another card? (yes/no)");
                    string hit = Console.ReadLine();
                    while (hit == "yes")
                    {
                        p.AddCardToHand(carddeck.GetFirstCard());
                        Console.WriteLine("");
                        Console.WriteLine(p.PlayerName() + " you have " + p.GetHandSum() + " points!");
                        if (p.GetHandSum() == 21)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Yo Pierre you got " + p.GetHandSum() + " and won " + bet * 2);
                            Console.WriteLine("");
                            break;
                        }
                        else if (p.GetHandSum() >= 21)
                        {
                            
                            Console.WriteLine("Yo Pierre you got " + p.GetHandSum() + " and lost " + bet );
                            Console.WriteLine("");
                            break;
                        }
                        else if (p.GetHandSum() <= 21)
                        { 
                            Console.WriteLine("Yo Pierre you got " + p.GetHandSum() + " and it is less then 21! Do want another card?");
                            hit = Console.ReadLine();
                            Console.WriteLine("");
                        }
                    }
                    if (hit == "no")
                    {
                        Console.WriteLine("Yo Pierre you chose to stay at " + p.GetHandSum());
                        Console.WriteLine("");
                    }

                }


            }






            
         
        }
    }
}
