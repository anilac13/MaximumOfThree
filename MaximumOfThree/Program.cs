using System;
namespace MaximumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            MaximumOf3 maximum = new MaximumOf3();
            int val = maximum.FindMaxOfIntegers(num1, num2, num3);
            Console.WriteLine("Maximum number is: {0}", val);
        }
    }
}