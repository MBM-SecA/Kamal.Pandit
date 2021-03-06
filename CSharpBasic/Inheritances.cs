using System;

public interface IShapeWithSides
{
    public double GetDiagonal();
}

public abstract class Shape
{
    // Define abstract members when you want to force derived classes to implement
    // their own logic
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void Display()
    {
        Console.WriteLine("Displaying results for some shape");
    }
}

public class Rectangle : Shape, IShapeWithSides
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length + Breadth);

    
        public override void Display()
    {
        if(Length == Breadth)
        {
            Console.WriteLine($"Displaying results for Square with side {Length}:");
        }
        else
        {
            Console.WriteLine($"Displaying results for Rectangle with length {Length} and breadth {Breadth}:");
        }
        
        Console.WriteLine($"Area: {this.GetArea()} square units");
        Console.WriteLine($"Circumference: {this.GetCircumference()} units ");
        Console.WriteLine($"Diagonal: {this.GetDiagonal()} units.");
    }
    public double GetDiagonal() => Math.Sqrt(Length * Length + Breadth * Breadth);
}

    public class Square: Rectangle
    {
        public Square(double side) : base(side, side)
        {

        }

    }

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;
    public override void Display()
    {
        Console.WriteLine($"Displaying results for Circle with radius {Radius}:");
        Console.WriteLine($"Area: {this.GetArea()} square units");
        Console.WriteLine($"Circumference: {this.GetCircumference()} units ");
    }
}

// Types of Inheritance
// Inheritance is used in is-a relationship
class A
{ }
class B : A
{ }
class C : B
{ }
class D : A, IA, IB
{ }

// Interface is used when activities of class are common or somewhat overlap 
// Interface is used in has-a relationship
interface IA
{ }
interface IB
{ }