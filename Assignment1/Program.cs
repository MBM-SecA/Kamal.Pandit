using System;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Sum homework = new Sum();
            // For sum of numbers
            Console.WriteLine("Enter First Number: ");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2=  int.Parse(Console.ReadLine());
            bool result= homework.SumOfNum(num1,num2); //calling first method
            if (result)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is greater than 500. So, the result is {result}");
            }
            else
            {
                Console.WriteLine($"Sum of {num1} and {num2} is not greater than 500. So, the result is {result}");
            }
            // For calculating the result
            PointCalculation Points = new PointCalculation();
            Console.WriteLine("Enter the  number of wins: ");
            int wins= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  number of Draws: ");
            int draws= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  number of losses: ");
            int losses= int.Parse(Console.ReadLine());
            int points = Points.CalculatePoints(wins,draws,losses);
            Console.WriteLine($"Team played {wins+draws+losses} matches and earned total of{points} points.");

            // For generating the results 
            Question3 Shortname = new Question3();
             Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             string initials = Shortname.GetInitials(name);
             Console.WriteLine($"Your initial is {initials}");

        }
    }
}