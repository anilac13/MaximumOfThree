using System;
namespace MaximumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Maximum of 3 Inetegers \n2.Maximum of 3 Decimal numbers \n3.Maximum of 3 strings \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter 1st number");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 3rd number");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 4th number");
                        int d = Convert.ToInt32(Console.ReadLine());
                        MaximumOf3<int> maximum = new MaximumOf3<int>(a, b, c,d);
                        int val = maximum.FindMaxOfThree(a, b, c, d);
                        Console.WriteLine("Maximum number is: {0}", val);
                        break;
                    case 2:
                        Console.WriteLine("Enter 1st number");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter 3rd number");
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter 4th number");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        MaximumOf3<double> max = new MaximumOf3<double>(num1, num2, num3,num4);
                        double value = max.FindMaxOfThree(num1, num2, num3,num4);
                        Console.WriteLine("Maximum number is: {0}", value);
                        break;
                    case 3:
                        Console.WriteLine("Enter 1st string");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Enter 3rd string");
                        string str3 = Console.ReadLine();
                        Console.WriteLine("Enter 3rd string");
                        string str4 = Console.ReadLine();
                        MaximumOf3<string> maximumOf3 = new MaximumOf3<string>(str1, str2, str3,str4);
                        string result = maximumOf3.FindMaxOfThree(str1, str2, str3, str4);
                        Console.WriteLine("Maximum string is: " + result);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}