using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        private Customer buying;
        private double lemonadeCost;

        public Game()
        {
            

        }

        private void sellLemonade(Player player, Customer customer)
        {
            if (customer == buying)
            {
                player.money += lemonadeCost;
                Player.inventory.lose lemonade;
            }
        }

        public void getPlayer()
        {
            Player player = new Player();

        }


        private void sales()
        {
            foreach (Customer customer in day.customers)
            {
                sellLemonade(player, customer);
            }
        }

    }
}
public void getWeather()
{
    Weather weatherOptions = new Weather();
}



Day day = new Day();

