using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     class Program
    {
        class SoccerPlayer
        {
            private int bonservicePrice;
            public int getBonservicePrice()
            {
                return bonservicePrice;
            }
            public void setBonservicePrice(int price)
            {
                this.bonservicePrice = price;
            }
        }
        static void Main(string[] args)
        {
            SoccerPlayer player = new SoccerPlayer();
            player.setBonservicePrice(25000000);

            Console.WriteLine(player.getBonservicePrice());
            Console.ReadLine();
        }
    }
}
