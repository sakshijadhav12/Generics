namespace Genrics
{
    class PrintArray
    {
        public static void ToPrint<T>(T[] arr)
        {
           foreach(var element in arr)
            {
                Console.WriteLine(element);
            }
           

        }
 
    }
    class program
    {    public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Genrics");
            int[] intArray = { 10, 20, 30, 40 };
            PrintArray.ToPrint<int>(intArray);
            double[] doubleArray = { 1.5, 2.8, 3.0, 4.0 };
            PrintArray.ToPrint<double>(doubleArray);
            char [] charArray = { 'h', 'j', 'k','s'};
            PrintArray.ToPrint<char>(charArray);
        }
    }   
}