using System;
enum DayofWeek
{
    sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}
internal class Demo
{
    public DayOfWeek DayofWeek{get; set;}
    void PrintGreeting()
    {
        if(DayofWeek == DayOfWeek.Saturday)
        {
            Console.WriteLine("Its a good saturday");
        }
        else if(DayofWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("yes its another weekend day");
        }
        else
        {
            Console.WriteLine("Oh gosh, work day.");
        }
    }
}