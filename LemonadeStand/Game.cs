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
        private Player player1;
        private Player player2;  //second player 2
        private Store store;
        private Inventory playerInventory1;
        private Inventory playerInventory2;  //second player Inventory
        private List<Day> days;

        Player player;
        Inventory playerInventory;

        private Customer buying;
        private double lemonadeCost;

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            store = new LemonadeStand.Store();
            userInterface = new UserInterface();
            playerInventory1 = new Inventory();
            playerInventory2 = new Inventory();

            //set the first player and inventory as default

            //this will be used to switch
            player = player1;
            playerInventory = playerInventory1;

            //set the cost of lemonade here
            //this is in the cents.
            lemonadeCost = 150;
        }

        public void run()
        {

            player1.name = userInterface.writeOpeningPrompts();
            userInterface.explainTasks(player1.name);

            player2.name = userInterface.writeOpeningPrompts();
            userInterface.explainTasks(player2.name);

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
                    Customer customer = new Customer();
                    //sell the lemonade
                    //get the money and calculate how many lemonades they can buy.
                    double customerMoney = customer.money;
                    //convert customer money into cents by multiplying by 100
                    customerMoney = customerMoney * 100;

                    int lemonadesSold = (int)customerMoney / (int) lemonadeCost;

                    //check inventory to see if you can sell that much.
                    if(playerInventory.cups.amount > lemonadesSold)
                    {
                        //this means, you have enough lemonades to sell

                        //alright, reuduce inventory by the amount sold.
                        playerInventory.cups.amount = playerInventory.cups.amount - lemonadesSold;
                        playerInventory.ice.amount = playerInventory.ice.amount - lemonadesSold;
                        playerInventory.lemon.amount = playerInventory.lemon.amount - lemonadesSold;
                        playerInventory.sugar.amount = playerInventory.sugar.amount - lemonadesSold;

                        //increaes player money
                        int earnings = lemonadesSold * (int)lemonadeCost;
                        //divide by 100 and get the dollar amount.
                        player.money = player.money + (double)earnings / 100;

                        Console.WriteLine("You just sold {0} lemonades and made {1} $", lemonadesSold, (double)earnings / 100);
                    }
                    else
                    {
                        //you dont have enough lemonades to sell
                        //ask player to buy stuff
                        Console.WriteLine("You dont have enough lemonades because your inventory is too low. Buy supplies");
                    }
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
                    double openingMoney = 100; ;
                    double revenue = player.money - openingMoney;
                    Console.WriteLine("You have earned {0} so far",revenue);
                    if(revenue>0)
                    {
                        Console.WriteLine("Profits! Looks like you are doing good. Congragulations!");
                    }
                    else
                    {
                        Console.WriteLine("Loss! Looks like you are losing money. Keep trying!");
                    }
                    break;

                case 6:playerInventory.showRecipe();

                    break;

                case 7: //switch the player and inventory
                    //doing a simple swap of players and inventory objects
                    if(player.name == player1.name)
                    {
                        player = player2;
                        playerInventory = playerInventory2;
                    }
                    else
                    {
                        player = player1;
                        playerInventory = playerInventory1;
                    }

                    break;

                case 9:
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