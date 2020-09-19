using System;
public class MethodTeacher
{
    static void Main5()
    {
        MethodTeacher methodTeacher =new MethodTeacher();
        double sum = methodTeacher.Sum(246.123, 4525.215);
    }
   public double Sum(double FirstNum, double SecondNum)
    {
        return FirstNum + SecondNum;
        
    }

public int SumofEven(params int[] nums)
{
    int sum = 0;
    foreach(int num in nums)
    {
        if(num%2 == 0)
            sum= sum + num;
    }
    return sum;
}
//return multiple value using tuple
// Examples of finding min and max from set of numbers
internal (int,int) FindMinMax(int[] numbers)
{
    int min = numbers[0];
    int max = numbers[0];
    foreach(int num in numbers)
    {
        if(num<min)
            min = num;
        if(num>max)
            max = num;
    }
    return(min,max);
    
}
}
public class MethodTester
{
static void Main4()
{
    MethodTeacher methodTeacher = new MethodTeacher();
    int[] numbers = {24,30,15,2,1,50,75,45,12,35};
    (int Min,int Max) result = methodTeacher.FindMinMax(numbers);
    Console.WriteLine($"Minimum:{result.Min}, Maximum:{result.Max}");
}
}

