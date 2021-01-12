using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SelectionSort
    {
        private readonly int[] list;

        public SelectionSort(int[] _list)
        {
            list = _list;
        }

        public SelectionSort(int lenght, int min, int max)
        {
            var random = new Random();
            list = new int[lenght];
            for (int i = 0; i < lenght; i++)
                list[i] = random.Next(min, max);
        }

        #region Page 54 modified example to fit C#

        public int[] Execute()
        {
            var listOrdered = list;
            for (int i = 0; i < listOrdered.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < listOrdered.Length; j++)
                {
                    if (listOrdered[j] < listOrdered[min])
                        min = j;
                }

                var aux = listOrdered[min];
                listOrdered[min] = listOrdered[i];
                listOrdered[i] = aux;
            }

            return listOrdered;
        }

        #endregion
    }
}
