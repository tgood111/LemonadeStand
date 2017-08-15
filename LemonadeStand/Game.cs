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
                int choice = userInterface.displayMainMenu();
                choiceHandler(choice);
            }
        }

        public void choiceHandler(int choice)
        {
            switch (choice)
            {
                case 1:
                    break;

                case 2:
                    userInterface.showInventory(player, playerInventory);
                    break;

                case 3:
                    userInterface.forecast(days);
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Not a valid choice! Try again");
                    break;
            }
        }
    }
}