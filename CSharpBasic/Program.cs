using System;
using LearnCollections;

public class Program
{
    static void Main()
    {
       /* //Main program for collection 
        Collections collections = new Collections();
        collections.LearnDictionary();*/

        // Inheritances 
        var square = new Square(8.0);
        square.Display();
        square.GetDiagonal();
        
        var rectangle = new Rectangle(4.0, 3.0);
        rectangle.Display();

        var circle = new Circle(7);
        circle.Display();

    }
}