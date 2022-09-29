using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class BubbleSort
    {
        /// <summary>
        /// It will sort the elements based on comparision and after each pass top 'k' largest
        /// element will be at the last k indexes (if we are sorting it in ascending order). Where 
        /// 'k' is no. of pass.
        /// </summary>
        /// <remarks>Time complexity = Comparision (n^2) + Swaps (n^2) = n^2 + n^2 = O(n^2)</remarks>
        /// <param name="arr">A List that conatins integers. Which needs to be sorted.</param>
        /// <returns>Sorted List</returns>
        public void Sort(List<int> arr)
        {
            /* 
             * In worst case n-1 pass will be required to sort the array.
             * Time complexity = Comparision (n^2) + Swaps (n^2) = n^2 + n^2 = O(n^2)
             */
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);  // Swap the elements
                    }
                }
                Console.Write($"Pass {i+1}: ");
                Console.Write($"Last element: {arr[arr.Count - i - 1]}\n");
            }
            //Console.Write("Sorted Array: ");
            //foreach (var ele in arr)
            //{
            //    Console.Write(ele + " ");
            //}
        }
    }
}
