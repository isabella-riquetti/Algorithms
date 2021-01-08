using System;
using System.Collections.Generic;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 3, 5, 7, 9 };
            var binarySearch = new BinarySearch(list);
            var result1 = binarySearch.Execute(3);
            Console.WriteLine("The example code test 1 result was: " + (result1?.ToString() ?? "NULL"));
            var result2 = binarySearch.Execute(-1);
            Console.WriteLine("The example code test 2 result was: " + (result2?.ToString() ?? "NULL"));

            Console.WriteLine("The exercise 1.1 answer is: " + binarySearch.Section1Exercise1());
            Console.WriteLine("The exercise 1.2 answer is: " + binarySearch.Section1Exercise2());

            Console.ReadKey();
        }
    }
}
