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
            Console.WriteLine("Hey " + name + " great to meet you! You are going to need to buy product for lemonade and sell it for a profit! Good luck!");
        }

        public int displayMainMenu()
        {
            Console.WriteLine("Enter what you would like to do");
            Console.WriteLine("1. Sell Lemonade");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Weather Forecast");
            Console.WriteLine("4. Purchase Items");
            Console.WriteLine("5. Quit the Software");
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
            {
                Console.WriteLine("Day " + (i + 1) + ": " + days[i].weather.cloudType);
            }

            //I have shown the forecast above.
            //now showing today's weather

            //we have already decided that the lowest temperature is going to be 45.
            //hence, the following is assigned 45
            int lowestTemperature = 45;
            int highestTemperature = 95;
            //that means, the temperature that we create using random number must be
            //between 45 and 95.
            //that means, 95 - 45 = 50. So, we pick a number between 0 and 50

            Random randomNumber = new Random();
            int randomWeatherNumber = randomNumber.Next(0, 50);
            int todayTemperature = lowestTemperature + randomWeatherNumber;
            Console.WriteLine("Today's Weather is {0} degrees Fahrenheit", todayTemperature);
            //Console.WriteLine("Today's Weather is " + todayTemperature + " degrees Fahrenheit");

        }

        public Inventory purchaseItems(Inventory playerInventory)
        {
            Console.WriteLine("purchase items");

            //here we write all the inventory code.
            //update the inventory object with things

            //list prices of items.

            //note : prices are dependent on weather. higher weather means higher prices.

            //Step 1 : Calculate weather first.
            //weather goes from 45 to 95
            int lowestTemperature = 45;
            Random randomNumber = new Random();
            int randomWeatherNumber = randomNumber.Next(0, 50);
            int todayTemperature = lowestTemperature + randomWeatherNumber;

            //set initial prices of the items
            /*        public Item lemon;
        public Item sugar;
        public Item ice;
        public Item cups;
             */
            int priceLemon = 10;
            int priceSugar = 10;
            int priceIce = 10;
            int priceCups = 10;

            //now, based on weather, set the prices
            if(todayTemperature >= 45 && todayTemperature <=54)
            {
                priceLemon = priceLemon + 5;
                priceSugar = priceSugar + 5;
                priceIce = priceIce + 5;
                priceCups = priceCups + 5;
            }
            else if(todayTemperature >= 55 && todayTemperature <= 64)
            {
                priceLemon = priceLemon + 15;
                priceSugar = priceSugar + 15;
                priceIce = priceIce + 15;
                priceCups = priceCups + 15;
            }
            else if (todayTemperature >= 65 && todayTemperature <= 74)
            {
                priceLemon = priceLemon + 25;
                priceSugar = priceSugar + 25;
                priceIce = priceIce + 25;
                priceCups = priceCups + 25;
            }
            else if (todayTemperature >= 75 && todayTemperature <= 84)
            {
                priceLemon = priceLemon + 35;
                priceSugar = priceSugar + 35;
                priceIce = priceIce + 35;
                priceCups = priceCups + 35;
            }
            else  //that means, the highest weather.
            {
                priceLemon = priceLemon + 45;
                priceSugar = priceSugar + 45;
                priceIce = priceIce + 45;
                priceCups = priceCups + 45;
            }

            Console.WriteLine("Here are current prices");
            Console.WriteLine("1. Lemon {0} \n 2. Sugar {1} \n 3. Ice {2} \n 4.Cups {3}", priceLemon, priceSugar, priceIce, priceCups);

            Console.WriteLine("Ener the quantity you wish to purchase");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);

            //calculate total cost of purchase
            //prices are in cents. So, multiplying by 0.1
            double totalCostPurchase = (priceLemon + priceSugar + priceIce + priceCups) * 0.1;

            //check if money is there to make purchase

            if(totalCostPurchase<playerInventory.MoneyBalance)
            {
                //this means, purchasing can be done.

                //add items to the current inventory
                playerInventory.lemon.amount = playerInventory.lemon.amount + choice;
                playerInventory.sugar.amount = playerInventory.sugar.amount + choice;
                playerInventory.ice.amount = playerInventory.ice.amount + choice;
                playerInventory.cups.amount = playerInventory.cups.amount + choice;

                //reduce money from player balance.
                playerInventory.MoneyBalance = playerInventory.MoneyBalance - totalCostPurchase;
            }
            else
            {
                //no purchasing can happen.
                //do nothing.
            }







            //return the updated inventory object
            return playerInventory;
           
        }

        public void purchaseItems()
        {
            Console.WriteLine("purchase items");
        }
    }
}