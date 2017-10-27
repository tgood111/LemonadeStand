using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        private UserInterface userInterface;
        private Player player;
        private Store store;
        private Inventory playerInventory;
        private List<Day> days;

        private Customer buying;
        private double lemonadeCost;

        public Game()
        {
            player = new Player();
            store = new LemonadeStand.Store();
            userInterface = new UserInterface();
            playerInventory = new Inventory();
        }

        public void run()
        {
            player.name = userInterface.writeOpeningPrompts();
            userInterface.explainTasks(player.name);

            days = new List<Day>();
            for (int i = 0; i < 7; ++i)
                days.Add(new LemonadeStand.Day());

            for (int i = 0; i < 7; ++i)
            {
                int choice;
                do
                {
                    choice = userInterface.displayMainMenu();
                } while (choiceHandler(choice));
            }
        }

        public bool choiceHandler(int choice)
        {
            bool next = true;
            switch (choice)
            {
                case 1:
                    // Sell Lemonade
                    //create a new customer.

                    //sell the lemonade
                    break;

                case 2:
                    userInterface.showInventory(player, playerInventory);
                    break;

                case 3:
                    userInterface.forecast(days);
                    break;

                case 4:
                    // Purchasing choices
                    //update the inventory stock and get back the inventory object.
                    //get the amount of money the person has
                    playerInventory.MoneyBalance = player.money;
                    double playerMoneyBeforePurchase = player.money;

                    playerInventory =  userInterface.purchaseItems(playerInventory);

                    //get the remaining money after purchasing.
                    player.money = playerInventory.MoneyBalance;
                    double playerMoneyAfterPurchase = player.money;
                    if(playerMoneyAfterPurchase == playerMoneyBeforePurchase)
                    {
                        //this means, player does not have enough money to make the purchase
                        Console.WriteLine("You dont have enough money to make purchase");
                    }
                    else
                    {
                        //this means, purchase did happen. 
                        Console.WriteLine("Your remaining money is {0}", playerMoneyAfterPurchase);
                    }
                    break;

                case 5:
                    //exit the application
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Not a valid choice! Try again");
                    break;
            }
            return next;
        }
    }
}