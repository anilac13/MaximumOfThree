using System;
namespace MaximumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            MaximumOf3 maximum = new MaximumOf3();
            double val = maximum.FindMaxOfDouble(num1, num2, num3);
            Console.WriteLine("Maximum number is: {0}", val);
        }
    }
}