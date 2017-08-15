using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public double money;

        public Player()
        {
            this.name = "Default";
            this.money = 100;
        }

        public Player(string name, double money = 100)
        {
            this.name = name;
            this.money = money;
        }
    }
}