using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos
{
    public class BinarySearch
    {
        #region Page 27 example
        private readonly List<int> list;
        public BinarySearch(List<int> _list)
        {
            list = _list;
        }

        public BinarySearch(int lenght)
        {
            list = new List<int>();
            for (int i = 0; i < lenght; i++)
                list.Add(i*5);
        }

        public int? Execute(int item)
        {
            int low = 0;
            int high = list.Count - 1;
            int middle = 0;

            while (low <= high)
            {
                middle = (low + high) / 2;
                int guess = list[middle];

                if (guess == item)
                    return middle;

                if (guess > item)
                    high = middle - 1;

                if (guess < item)
                    low = middle + 1;
            }

            return null;
        }
        #endregion

        #region Page 28 exercises

        public double Section1Exercise1()
        {
            //log.2. 128 = 7
            return Math.Log2(128);
        }

        public double Section1Exercise2()
        {
            //log.2. 256 = 8
            return Math.Log2(256);
        }

        #endregion
    }
}
