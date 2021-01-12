using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = LinkedListTest.Gen(99999999);
            linkedList.Reverse();
            linkedList.Reverse2();

            Console.ReadKey();
        }
    }
}
