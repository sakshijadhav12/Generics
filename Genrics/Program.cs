using System;

namespace Generics
{
    class Program
    {
        public static int MaximumIntNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return Math.Max(Math.Max(firstValue, secondValue), thirdValue);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer Number");
            int first =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer Number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Integer Number");
            int third= Convert.ToInt32(Console.ReadLine());

            int maximum = MaximumIntNumber(first, second, third);
            Console.WriteLine("The maximum value is: " + maximum);
        }
    }
}
