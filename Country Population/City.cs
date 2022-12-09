using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Population
{
    internal class City
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public City(string cityName, long population)
        {
            Name = cityName;
            Population = population;
        }
    }
}
