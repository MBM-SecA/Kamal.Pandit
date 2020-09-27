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

            //Projectionz
            var results = numbers.Select(x => x*x);
            foreach(var square in results)
            {
                Console.WriteLine(square);
            }

            // Ordering
            var result2 = from num in numbers
                          orderby num 
                          select num; 
                    
            foreach(var square in result2)
            {
                Console.WriteLine(square);
            }  

            // Partitioning
            var result3 = numbers.Skip(5).Take(5);

            // Quantifier
            var result4 = numbers.Any(x => x % 2 == 0);
            var result5 = numbers.All(x => x % 2 == 0);
            var result6 = numbers.Contains(20);

            var result7 = Enumerable.Range(1,1000);
            var result8 = Enumerable.Repeat("Hello World!",10);


            foreach(var num in result8)
            {
                Console.WriteLine(num);
            }   

        }
    }
}
