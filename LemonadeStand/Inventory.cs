using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Item lemon;
        public Item sugar;
        public Item ice;
        public Item cups;

        public Inventory()
        {
            lemon = new LemonadeStand.Item("Lemon", 0.25);
            sugar = new LemonadeStand.Item("Sugar", 0.3);
            ice = new LemonadeStand.Item("Ice", 0.1);
            cups = new LemonadeStand.Item("Cups", 0.1);
        }

        public Inventory(double l, double s, double i, double c)
        {
            lemon = new LemonadeStand.Item("Lemon", l);
            sugar = new LemonadeStand.Item("Sugar", s);
            ice = new LemonadeStand.Item("Ice", i);
            cups = new LemonadeStand.Item("Cups", c);
        }

        public void setPrices(double l, double s, double i, double c)
        {
            lemon.cost = l;
            sugar.cost = s;
            ice.cost = i;
            cups.cost = c;
        }
    }
}