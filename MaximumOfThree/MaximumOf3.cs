using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree
{
    public class MaximumOf3
    {
        public int FindMaxOfIntegers(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
        public double FindMaxOfDouble(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 ||
                firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 ||
                secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) > 0 ||
                thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
        public string FindMaxOfString(string first, string second, string third)
        {
            if (first.Length.CompareTo(second.Length) > 0 && first.Length.CompareTo(third.Length) > 0 ||
                first.Length.CompareTo(second.Length) >= 0 && first.Length.CompareTo(third.Length) > 0 ||
                first.Length.CompareTo(second.Length) > 0 && first.Length.CompareTo(third.Length) >= 0)
            {
                return first;
            }
            if (second.Length.CompareTo(first.Length) > 0 && first.Length.CompareTo(third.Length) > 0 ||
                second.Length.CompareTo(first.Length) >= 0 && first.Length.CompareTo(third.Length) > 0 ||
                second.Length.CompareTo(first.Length) > 0 && first.Length.CompareTo(third.Length) >= 0)
            {
                return second;
            }
            if (third.Length.CompareTo(first.Length) > 0 && third.Length.CompareTo(second.Length) > 0 ||
                third.Length.CompareTo(first.Length) >= 0 && third.Length.CompareTo(second.Length) > 0 ||
                third.Length.CompareTo(first.Length) > 0 && third.Length.CompareTo(second.Length) >= 0)
            {
                return third;
            }
            return first;
        }
    }
}
