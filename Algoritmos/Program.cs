using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var binarySearch = new BinarySearch(99999999);
            var result1 = binarySearch.Execute(5);
            Console.WriteLine(result1);

            var result2 = binarySearch.ExecuteRecursive(99999999);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
