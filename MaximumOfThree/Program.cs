using System;
namespace MaximumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string a = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string b = Console.ReadLine();
            Console.WriteLine("Enter 3rd string");
            string c = Console.ReadLine();
            MaximumOf3 maximum = new MaximumOf3();
            string val = maximum.FindMaxOfString(a, b, c);
            Console.WriteLine("Maximum string is: {0}", val);
        }
    }
}