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
                    break;

                case 2:
                    userInterface.showInventory(player, playerInventory);
                    break;

                case 3:
                    userInterface.forecast(days);
                    break;

                case 4:
                    // Purchasing choices
                    break;

                default:
                    Console.WriteLine("Not a valid choice! Try again");
                    break;
            }
            return next;
        }
    }
}