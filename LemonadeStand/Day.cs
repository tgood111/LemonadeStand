using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public Weather todaysWeather { get; private set; }

        public int numberOfCustomers { get; private set; }
        public List<Customer> Customers { get; private set; }

        public Day()
        {
            init();
        }

        public void determineNumberOfCustomers()
        {
            switch (todaysWeather.cloudType)
            {
                case "sunny":
                    numberOfCustomers = 120;
                    break;

                case "rainy":
                    numberOfCustomers = 60;
                    break;

                case "cloudy":
                    numberOfCustomers = 80;
                    break;

                default:
                    break;
            }
        }

        private void init()
        {
            todaysWeather = new Weather();
            Customers = new List<Customer>();
            makeCustomer();
        }

        private void makeCustomer()
        {
            determineNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
                Customers.Add(new Customer());
        }
    }
}