using System;

class SelectionStatement
{
    static void Main6()
{
    SelectionStatement ss = new SelectionStatement();
    ss.LearnIfElse();
    ss.LearnSwitch();

}
    void LearnIfElse()
    {
        Console.WriteLine("enter the number:");
        string input= Console.ReadLine();
        byte a = byte.Parse(input);
        if(a>15)
        {
            Console.WriteLine("a is greater than 15");       
        }
        else if(a<15)
        {
            Console.WriteLine("a is less than 15");
        }
        else
        {
            Console.WriteLine("a is equal to 15");
        }
    }
    void LearnSwitch()
    {
        char option = 'y';

        switch(option)
        {
            case 'n':
            Console.WriteLine("You opted for NO.");
            break;

            case 'y':
            Console.WriteLine("You opted for YES.");
            break;

            case 'x':
            Console.WriteLine("You opted for No.");
            break;

            case 'z':
            Console.WriteLine("You opted for YES.");
            break;

            default:
            Console.WriteLine("No cases matched.");
            break;
        }
    }
}