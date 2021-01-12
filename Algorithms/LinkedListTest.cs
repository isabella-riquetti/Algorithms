using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class LinkedListTest
	{
		public static LinkedList<int> Gen(int size = int.MaxValue)
		{
			var linkedList = new LinkedList<int>();
			for (int i = 0; i < size; i++)
				linkedList.AddLast(i);

			return linkedList;
		}

		public static LinkedList<int> Reverse(this LinkedList<int> linkedList)
		{
			var firstInitialItem = linkedList.First;
			var last = linkedList.Last;
			while (firstInitialItem != last)
			{
				linkedList.RemoveLast();
				linkedList.AddBefore(firstInitialItem, last);
				last = linkedList.Last;
			}

			return linkedList;
		}

		public static LinkedList<int> Reverse2(this LinkedList<int> linkedList)
		{
			var newList = new LinkedList<int>();
			while (linkedList.Count != 0)
			{
				var first = linkedList.First;
				linkedList.RemoveFirst();
				newList.AddLast(first);
			}

			return newList;
		}
	}
}
