using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        public double money;
        private Random random = new Random();

        private int customerChoice;

        public Customer()
        {
            double max = 5;
            this.money = random.NextDouble() * max;
        }

        public bool CheckIfBuy(double price)
        {
            //logic to check if a customer will buy
            if (money > price)
            {
                return true;
            }
            return false;
        }
    }
}