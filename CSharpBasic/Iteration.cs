using System;
class IterationStatement
{
    static void Main3()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoop();
    }
    void LearnForLoop()
    {
        for(int i = 0; i<10; i++)
        {
            Console.WriteLine("Nepal");
        }
        int[] numbers = {5,8,9,10,15};
        foreach(int x in numbers)
        {
            if(x%2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                Console.WriteLine($"{x} is odd");
            }
        }
        
    }
        void LearnWhileLoop()
    {
        int confirm = 'Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("My country name is Nepal");
            Console.WriteLine("Print one more time?");
            confirm = Console.ReadKey().KeyChar;
        }

        do
        {
           Console.WriteLine("Nepal is beautiful country.");
           Console.WriteLine("Print one more time?");
           confirm = Console.ReadKey().KeyChar; 
        } while(confirm == 'Y');
    }

}

