using System;

namespace Generics
{
    class Program
    {
        public static double MaximumIntNumber(double firstValue, double secondValue, double thirdValue)
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
            Console.WriteLine("Enter first Number");
            double first =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second  Number");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            double third= Convert.ToDouble(Console.ReadLine());

            double maximum = MaximumIntNumber(first, second, third);
            Console.WriteLine("The maximum value is: " + maximum);
        }
    }
}
