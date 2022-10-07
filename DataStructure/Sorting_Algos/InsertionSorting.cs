using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class InsertionSorting
    {

        // Time complexity  =  O(n^2)
        public List<int> Sort(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                int j = i - 1;
                var key = arr[i];
                while ((j >= 0) && (arr[j] > key))
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key; // Putting key after the element just smaller than it.
            }
            return arr;
        }
    }
}
