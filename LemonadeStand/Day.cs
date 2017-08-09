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
        public Day()
        {
            todaysWeather = new Weather();
            getNumberOfCustomers();

        }
        public void getNumberOfCustomers()
        {
            switch (todaysWeather.cloudType) {
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

    }
    
}
