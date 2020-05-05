using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Online
{
    class Dealer
    {
        int sum = 0;
        public int dealerpoint()
        {
            Random random = new Random();
            int tal = random.Next(17, 25);


            sum = tal;
            Console.WriteLine(sum);
            return sum;

        }
        
    }
}
