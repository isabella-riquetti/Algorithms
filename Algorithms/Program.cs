using Algorithms;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var binarySearch = new SelectionSort(10, 0, 100);
            var result1 = binarySearch.Execute();
            Console.WriteLine("Resultado 1: ");
            foreach (var r1 in result1)
                Console.Write(r1 + "\t");

            //No way
            var binarySearch2 = new SelectionSort(99999999, 0, 99999999);
            var result2 = binarySearch2.Execute();
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
