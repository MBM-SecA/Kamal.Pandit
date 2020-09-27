using System;
using System.Collections.Generic;

public class ComplexType
{
    static void LearnRestriction()
    {
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
                             where country.Continent == "Asia" && country.IndependenceDay == default
                             select country.Name;
        Console.WriteLine("Asian Countries never invaded are:");
            
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

   