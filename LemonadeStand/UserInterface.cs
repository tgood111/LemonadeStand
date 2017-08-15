using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class UserInterface
    {
        public string writeOpeningPrompts()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("This is your business venture. You put your life savings into this, so you need to succeed!");
            Console.WriteLine("But before you get started, what's your name?");
            string name = Console.ReadLine();
            return name;
        }

        public void explainTasks(string name)
        {
            Console.WriteLine("Hey " + name + " great to meet you! You are going to need to buy things for lemonade and sell it! Good luck!");
        }

        public int displayMainMenu()
        {
            Console.WriteLine("Enter what you would like to do");
            Console.WriteLine("1. Sell Lemonade");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Forecast");
            Console.WriteLine("4. Purchase Items");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            return choice;
        }

        public void showInventory(Player player, Inventory inventory)
        {
            Console.WriteLine("Money: $" + player.money);
            Console.WriteLine("Lemons: " + inventory.lemon.amount);
            Console.WriteLine("Cups: " + inventory.cups.amount);
            Console.WriteLine("Sugar: " + inventory.sugar.amount);
            Console.WriteLine("Ice: " + inventory.ice.amount);
        }

        public void forecast(List<Day> days)
        {
            for (int i = 0; i < days.Count; ++i)
                Console.WriteLine("Day " + (i + 1) + ": " + days[i].weather.cloudType);
        }
    }
}