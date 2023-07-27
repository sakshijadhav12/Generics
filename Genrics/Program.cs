using System;

namespace Generics
{
    public class GenericMaximun<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdvalue;
        public GenericMaximun(T firstValue, T secondValue, T thirdvalue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdvalue = thirdvalue;
        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
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
            return default;
        }

        public T MaxMethod()
        {
            T max = GenericMaximun<T>.MaxValue(this.firstValue, this.secondValue, this.thirdvalue);
            return max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter first integer:");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third integer:");
            int thirdInt = Convert.ToInt32(Console.ReadLine());

            GenericMaximun<int> intMax = new GenericMaximun<int>(firstInt, secondInt, thirdInt);
            int maxIntValue = intMax.MaxMethod();
            Console.WriteLine("The maximum integer value is: " + maxIntValue);

           
            Console.WriteLine("Enter first double:");
            double firstDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second double:");
            double secondDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third double:");
            double thirdDouble = Convert.ToDouble(Console.ReadLine());

            GenericMaximun<double> doubleMax = new GenericMaximun<double>(firstDouble, secondDouble, thirdDouble);
            double maxDoubleValue = doubleMax.MaxMethod();
            Console.WriteLine("The maximum double value is: " + maxDoubleValue);

            
            Console.WriteLine("Enter first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string secondString = Console.ReadLine();

            Console.WriteLine("Enter third string:");
            string thirdString = Console.ReadLine();

            GenericMaximun<string> stringMax = new GenericMaximun<string>(firstString, secondString, thirdString);
            string maxStringValue = stringMax.MaxMethod();
            Console.WriteLine("The maximum string value is: " + maxStringValue);
        }
    }
}