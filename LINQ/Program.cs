using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class program
    {
        static void Main(string[] args)
        {
            // LINQ  Language Integrated Query
            // LINQ to objects

            int [] numbers = { 23, 55, 12, 45, 65, 78, 20, 45, 30, 77};

            // Fetch numbers which is greater than 50

            // Using method syntax -   lambda expression
            var numbersGreaterThan50 = numbers.Where(x => x > 50);

            // Using query syntax  - Query expression
            var numbersGreaterThanFifty =   from num in numbers
                                            where num > 50
                                            select num;

            string[] names = {"Kamal", "Ranjit", "Roshan", "Ashish", "Rb", "Cosmic", "Paras", "Rajesh"};

            var namesStartingWithR = names.Where(x => x.ToLower().StartsWith("R") && x.Length > 3);

            var namesStartsWithR =  from name in names
                                    where name.ToLower().StartsWith("R") && name.Length > 3
                                    select name;

            foreach(var name in namesStartingWithR)
            {
                Console.WriteLine(name);
            }


            List<Country> countries = new List<Country>();
            /*Country c1 = new Country();
            c1.Name = "Nepal";
            c1.Continent = "Asia";
            c1.Area = 147181;
            c1.Polulation = 26494504;

            countries.Add(c1);
            Country c2 = new Country() {Name = "India", Continent = "Asia", Area = 5045155.245, Polulation = 5453552.2355};
            */
            var countries1 = Country.GetCountries();

            var asianCountries = from country in countries1
                                 where country.Continent == "Asia"
                                 select country.Name;
            Console.WriteLine("Asian Countries are:");
            
            foreach(var country in asianCountries)
            {
                Console.WriteLine(country);
            }

            
            var countriesWithMoreThan100kPopulation = from population in countries1
                                      where population.Population < 100000
                                      select population.Name;
                                      
            Console.WriteLine("Country With more than 100k population are:");                       

            foreach(var country in countriesWithMoreThan100kPopulation )
            {
                Console.WriteLine(country);
            }





                                   
        }
    }
}
