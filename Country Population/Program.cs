namespace Country_Population
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Country 1
            Country country1 = new Country("Azerbaijan", 143421639);
            country1.City.Add(new City("Baku", 722300));
            country1.City.Add(new City("Ganja", 55500));
            country1.City.Add(new City("Tovuz", 100000));
            Console.WriteLine($"Country: {country1.Name}, Total Population: {country1.TotalPopulation}");
            Console.WriteLine("----------------------------------------------");

            foreach (City city in country1.City)
            {
                Console.WriteLine($"City: {city.Name}, Population: {city.Population}");
            }
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("City by population:");
            foreach (City city in country1.FindAllByPopulation(90000, 900000))
            {
                Console.WriteLine($"{city.Name}");
            } 
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Country 2
            Country country2 = new Country("America", 41502024345);
            country2.City.Add(new City("New-York", 900000));
            country2.City.Add(new City("San Francisco", 820000));
            country2.City.Add(new City("Los Angeles", 500000));
            Console.WriteLine($"Country: {country2.Name}, Total Population: {country2.TotalPopulation}");
            Console.WriteLine("----------------------------------------------");

            foreach (City city in country2.City)
            {
                Console.WriteLine($"City: {city.Name}, Population: {city.Population}");
            }
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("City by population:");
            foreach (City city in country2.FindAllByPopulation(300000, 900000))
            {
                Console.WriteLine($"{city.Name}");
            } 
            #endregion
        }
    }
}