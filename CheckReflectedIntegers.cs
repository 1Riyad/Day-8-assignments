// Day-8-assignments
using System;

namespace week2_day1_exercise2
{
    class CheckReflectedIntegers
    {
        static bool checkOrder(string integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers.Length % 2 != 0)
                    return false;

                if (i < (integers.Length - 1) && integers[i] == integers[i + 1])
                {
                    integers = integers.Remove(i, 2);
                    return checkOrder(integers);
                }
            }
            if (integers.Length == 0)
                return true;
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("89339998")); // true
            Console.WriteLine(checkOrder("122234321")); // false
            Console.WriteLine(checkOrder("1222344321")); // true
            Console.WriteLine(checkOrder("1234784321")); // false
            Console.WriteLine(checkOrder("1122334455")); // true


        }



    }

}