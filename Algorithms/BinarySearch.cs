using System.Collections.Generic;

namespace Algorithms
{
    public class BinarySearch
    {
        private readonly List<int> list;

        public BinarySearch(List<int> _list)
        {
            list = _list;
        }

        public BinarySearch(int lenght = int.MaxValue)
        {
            list = new List<int>();
            for (int i = 0; i < lenght; i++)
                list.Add(i * 5);
        }

        #region Page 27 example

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

        #region Extra
        //StackOverFlow Execption with large lists (too many recursivity?)
        public int? ExecuteRecursive(int item)
        {
            var bottomIndex = 0;
            var topIndex = list.Count - 1;
            return ExecuteRecursive(item, bottomIndex, topIndex);
        }

        public int? ExecuteRecursive(int item, int bottomIndex, int topIndex)
        {
            int middle = (bottomIndex + topIndex) / 2;
            int guess = list[middle];
            if (guess == item)
                return middle;

            if (guess > item)
                return ExecuteRecursive(item, bottomIndex, middle - 1);

            if (guess < item)
                return ExecuteRecursive(item, middle + 1, topIndex);

            return null;
        }

        #endregion
    }
}
