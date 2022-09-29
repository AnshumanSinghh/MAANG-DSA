using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class SelectionSort
    {
        /// <summary>
        /// It will sort the elements based on comparision and after each pass top 'k' smallest
        /// element will be at the starting 'k' indexes (if we are sorting it in ascending order).
        /// Where 'k' is no. of pass.
        /// </summary>
        /// <remarks>Time complexity = Comparision (n^2) + Swaps (n) = n^2 + n = O(n^2)</remarks>
        /// <param name="arr">A List that conatins integers. Which needs to be sorted.</param>
        /// <returns>Sorted List</returns>
        public void Sort(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                var min_idx = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[min_idx] > arr[j])
                    {
                        min_idx = j;
                    }
                }
                (arr[i], arr[min_idx]) = (arr[min_idx], arr[i]);  // Swap the elements
                
                Console.Write($"Pass {i + 1}: ");
                Console.Write($"First element: {arr[i]}\n");
            }
        }
    }
}
