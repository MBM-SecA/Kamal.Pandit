using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Async
{
    class Program
    {
        static void Main1()
        {
            int [] numbers = {10, 6, 3, 11, 8, 7};

            Stopwatch stopwatch = new Stopwatch();

            // Sequential 
            stopwatch.Start();
            Console.WriteLine("Sequential Execution");
            foreach(var num in numbers)
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            }
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");


            // Parallel
            stopwatch.Restart();
            Console.WriteLine("Parallel Execution");
            Parallel.ForEach(numbers, num =>{
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
            
            // Async Programming

        }
        static long Factorial(long number)
        {
            Thread.Sleep(100);
            if(number == 0 || number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main2()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            TurnOnBurner();
            PutOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            Add("Milk");
            Boil("Milk");
            TurnOnBurner();
            PutOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
    

        }
        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Parallel Version: Expected completion time = 56 sec
            await TurnOnBurner();
            await PutOnBurner("Kettle");
            await Add("Water");
            await Boil("Water");
            await GrindTeaMasala();
            await PutSugarAndMasalas();
            await Add("Milk");
            await Boil("Milk");
            await TurnOnBurner();
            await PutOnBurner("Pan");
            await AddOil();
            await WhiskEggs();
            await Fry();
            await Serve();
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static Task Serve()
        {
            Console.WriteLine($"Serving Breakfast.... :)");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Fry()
        {
            Console.WriteLine($"Frying ");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task WhiskEggs()
        {
            Console.WriteLine($"Cracking and Whisking Eggs");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task AddOil()
        {
            Console.WriteLine($"Adding oil");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task Add(string item)
        {
            Console.WriteLine($"Adding {item}");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task PutSugarAndMasalas()
        {
            Console.WriteLine("Adding Sugar and Tea Masala");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task GrindTeaMasala()
        {
            Console.WriteLine("Grinding Tea Masalas");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task PourWater()
        {
            Console.WriteLine("Adding Water");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Boil(string item)
        {
            Console.WriteLine($"Boiling {item}..");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task PutOnBurner(string pot)
        {
            Console.WriteLine($"Placing {pot} on burner..");
            Task.Delay(3000);
            return Task.CompletedTask;
        }

        private static Task TurnOnBurner()
        {
            Console.WriteLine("Turning on the burner..");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
    }
}
