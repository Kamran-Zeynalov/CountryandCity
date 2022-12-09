using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Population
{
    internal class Country
    {
        public List<City> City = new List<City>();
        public string Name { get; set; }
        public long TotalPopulation { get; set; }

        public Country(string countryName, long totalPopulation)
        {
            Name = countryName;
            TotalPopulation = totalPopulation;
        }

        public List<City> FindAllByPopulation(long min, long max)
        {
            List<City> pop = City.FindAll(x => x.Population > min && x.Population < max);
        return pop;
        }

    }
}
