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

                    Console.WriteLine("Do you want another card? " + p.PlayerName());
                    string hit = Console.ReadLine();
                    while (hit == "yes")
                    {
                        Card c = carddeck.GetFirstCard();
                        p.AddCardToHand(carddeck.GetFirstCard());
                        sum = sum + p.GetHandSum();
                        Console.WriteLine("You have " + sum + " points!");

                        if (sum == 21)
                        {
                            Console.WriteLine("");

                            bet = bet * 3;
                            Console.WriteLine("Congratulations you won " + bet + "!");
                            break;
                        }
                        if (sum < 21)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You have less then 21 points. Do you want another card?");
                            hit = Console.ReadLine();

                            bet = bet * 2;
                        }
                        if (sum > 21)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You got more then 21 points. You just lost!");
                            hit = "nej";
                            Console.WriteLine("You lost " + bet);
                        }

                    }
                    if (hit == "no")
                    {
                        Console.WriteLine("You chose to stay at " + sum);

                    }
                }
            }






            
         
        }
    }
}
