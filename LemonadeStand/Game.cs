using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        UserInterface userInterface;
        Player player;
        Day day;
        Weather weather;
        Store store;
        Inventory inventory;
        lemon lemon;
        Sugar sugar;
        Ice ice;
        Cups cup;
        Customer customer;
        
        
        private Customer buying;
        private double lemonadeCost;

        public Game()
        {
            player = new Player();

        }

        public void getUserInterface()
        {
            UserInterface userInterface = new UserInterface();
        }
        public void getWeather()
        {
            Weather weatherOptions = new Weather();
        }

        private void sellLemonade(Player player, Customer customer)
        {
            if (customer == buying)
            {
                player.money += lemonadeCost;
                player.inventory.lose lemonade;
            }
        }
        public void getNewDay()
        {
            day = new Day();
            for (int x = 0; x < day.Customers.Count; i++)
            {
                day.Customers[x].CheckIfBuy();
            } 
        }


        private void sales()
        {
            foreach (Customer customer in day.customer)
            {
                sellLemonade(player, customer);
            }
        }

    }
}






