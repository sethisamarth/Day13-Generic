using System;

namespace GenericProblems
{
    class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            Program.toPrint<int>(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }
    }
}

