using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public Inventory stock { get; private set; }

        public Store()
        {
            stock = new Inventory();
            restock();
        }

        public Store(double l, double s, double i, double c)
        {
            stock = new Inventory(l, s, i, c);
            restock();
        }

        public void restock()
        {
            stock.cups.amount = 300;
            stock.ice.amount = 300;
            stock.lemon.amount = 300;
            stock.sugar.amount = 300;
        }

        public void setPrices(double l, double s, double i, double c)
        {
            stock.setPrices(l, s, i, c);
        }
    }
}