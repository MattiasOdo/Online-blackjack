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
            int sum = 0;
            /*List<Player> players =  Player();*/
            List<Player> players;
            players = new List<Player>();
            Carddeck carddeck = new Carddeck();
            Dealer dealer = new Dealer();
            int bet = 0;

            players.Add(new Player());
            players.Add(new Player());

            carddeck.ShuffleCards();
            Console.WriteLine("Welcome to scam city! Do you want to play? (yes/no)");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                Console.WriteLine("How much do you want to bet? (Minimun 200$)");
                bet = int.Parse(Console.ReadLine());
                while (bet < 200)
                {
                    Console.WriteLine("Your bet was to low, try again");
                    bet = int.Parse(Console.ReadLine());

                }




                carddeck.ShuffleCards();
                players[0].AddCardToHand(carddeck.GetFirstCard());
                players[1].AddCardToHand(carddeck.GetFirstCard());
                players[0].AddCardToHand(carddeck.GetFirstCard());
                players[1].AddCardToHand(carddeck.GetFirstCard());


                Console.WriteLine("");

                //c1.Printcard();
                players[0].PrintCardValue(carddeck.GetValue());
                //c1.GetValue();
                //c2.Printcard();
                //c2.GetValue();
                sum = c1.GetValue() + c2.GetValue();
                Console.WriteLine("You have " + sum + " points!");
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
