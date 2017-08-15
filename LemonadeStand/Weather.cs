using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        private List<string> weatherOptions = new List<string> { "sunny", "rainy", "cloudy" };
        public string cloudType { get; set; }
        private static Random random = new Random(Guid.NewGuid().GetHashCode());

        public Weather()
        {
            generateWeather();
        }

        public void generateWeather()
        {
            int select = random.Next(0, 3);
            cloudType = weatherOptions[select];
        }
    }
}