using System;
using System.Collections.Generic;
public class Country
{
    public string Name{ get; set;}
    public string Continent{ get; set;}
    public double Area{ get; set;}
    public long Population{ get; set;}
    public DateTime IndependenceDay{ get; set;}

    public Country(string name, string continent, double area, long population, DateTime independenceDay = default )
    {
        Name = name;
        Continent = continent;
        Area = area;
        Population = population;
        IndependenceDay = independenceDay;
    }
    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 147181, 65244221);
        string date1 = "10/12/1996";
        DateTime date1a = DateTime.Parse(date1, System.Globalization.CultureInfo.InvariantCulture);
        Country c2 = new Country("India", "Asia", 5456872, 5488415, date1a);

        Country c3 = new Country("Bangladesh", "Asia", 12542.22, 12541, DateTime.Parse("1997/12/4"));
        Country c4 = new Country("Portugal", "Europe", 12042.251, 12540);
        Country c5 = new Country("China", "Asia", 98745.558, 278451, DateTime.Parse("2000/5/10"));
        Country c6 = new Country("Spain", "Europe", 25045, 62510);
        Country c7 = new Country("Romania", "Europe", 21250.241, 26250);
        Country c8 = new Country("france", "Europe", 564781, 2350420);
        Country c9 = new Country("Sweden", "Europe", 987466,789446);
        Country c10 = new Country("Argentina", "South America", 225522, 246324520);
        Country c11 = new Country("Brazil", "South America", 254006.30, 504600);
        Country c12 = new Country("USA", "North America", 802506.30, 600454);
        Country c13 = new Country("canada", "North America", 504.2205, 604550);
        Country c14 = new Country("Afghanistan", "Asia", 505210, 50420);
        Country c15 = new Country("Egypt", "Africa", 604840.50, 60450);
        Country c16 = new Country("Congo", "Africa", 789410.2,12420);
        Country c17 = new Country("Cuba", "North America", 22502.651, 89781);
        Country c18 = new Country("Mexico", "North America", 6578.875, 269715);
        Country c19 = new Country("Columbia", "South America", 7810.2, 2985150);
        Country c20 = new Country("Peru", "South America", 12540.20, 7895);
        Country c21 = new Country("Australia", "Australia", 78915.055, 89745);
        Country c22 = new Country("Fiji", "Australia", 78050.50, 25151);
        Country c23 = new Country("Solomon Islands", "Australia", 840404.202, 324520);
        Country c24 = new Country("Germany", "Europe", 815960.30, 24620);
        Country c25 = new Country("Ireland", "Europe", 22552.5012, 24630);
        var countries = new List<Country>() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15,
                                                c16, c17, c18, c19, c20, c12, c22, c23, c24, c25};

        return countries;
    }

}