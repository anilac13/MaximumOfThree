using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree
{
    public class MaximumOf3<T> where T:IComparable
    {
        public T first, second, third, four;
        public MaximumOf3(T first, T second, T third, T four)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.four = four;
        }
        public T FindMaxOfThree(T first, T second, T third, T four)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(four) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 && first.CompareTo(four) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(four) >= 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(four) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 && second.CompareTo(four) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(four) >= 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(four) > 0 ||
                third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 && third.CompareTo(four) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(four) >= 0)
            {
                return third;
            }
            if (four.CompareTo(first) > 0 && four.CompareTo(second) > 0 && four.CompareTo(third) > 0 ||
                four.CompareTo(first) >= 0 && four.CompareTo(second) > 0 && four.CompareTo(third) > 0 ||
                four.CompareTo(first) > 0 && four.CompareTo(second) > 0 && four.CompareTo(third) >= 0)
            {
                return four;
            }
            return first;
        }
    }
}
