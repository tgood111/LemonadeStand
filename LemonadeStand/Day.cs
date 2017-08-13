using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class Day
    {
        Weather todaysWeather;
        public int numberOfCustomers;
        public List<Customer> Customers = new List<Customer> { };
        
        public Day()
        {
            todaysWeather = new Weather();
            getNumberOfCustomers();
            makeCustomer();


        }
        public void getNumberOfCustomers()
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
            private void makeCustomer()
        {
            Customer customer;
            for(int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer();
                Customers.Add(customer);
            }
        }
                
           
        }

    }
    
}
