using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Item
    {
        public string name { get; set; }
        public double cost { get; set; }
        public int amount { get; set; }

        private Item()
        {
            // Left Intentionally Blank
        }

        public Item(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
            this.amount = 0;
        }
    }
}