using System;

namespace Generics
{
    public class GenericMaximun<T> where T : IComparable
    {
        public T[] value;

        public GenericMaximun(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_Values = Sort(values);
            return sorted_Values[^1];
        }

        public T MaxMethod(params T[] values)
        {
            var max = MaxValue(this.value);
            return max;
        }

         public void PrintMaxValue()
         {
         var max = MaxValue(this.value);
        Console.WriteLine("maximum value is " + max);
        }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                int[] arr = { 23, 56, 456, 444, 88, 89 };
                GenericMaximun<int> generic = new GenericMaximun<int>(arr);
                generic.PrintMaxValue();

              

        }
        }
    }
