using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_7
{
    class SortTheAlmostSortedArray
    {
        int OuterLoopCounter = 0;
        int InnerLoopCounter = 0;

        /*
         * More the array is sorted lesser the inner while loop run. To demonstrate it I have added 2 Counters 1 for
         * Outer Loop & Other for Inner Loop. It will give us a broad idea about why InsertionSort is best for
         * Sorted or almost sorted array.
         * 
         * Time Complexity = ~O(N) [almost order of N]
         * Bcz inner loop will execute for negligible times.
         */
        public void InsertionSort(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                // increase OuterLoopCounter
                OuterLoopCounter++;

                int j = i - 1;
                var key = arr[i];

                // This will not run at all if there is no smaller element to the left of 'i'. Better say if the
                // element is already sorted. 
                while ((j >= 0) && (arr[j] > key))
                {
                    // increase InnerLoopCounter
                    InnerLoopCounter++;

                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;  // putting 'key' after the element just smaller than it.
            }

            // Printing the sorted array:
            Console.Write("Sorted array: ");
            foreach (var num in arr)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine($"\nOuter Loop runs = {OuterLoopCounter}\nInner Loop runs = {InnerLoopCounter}");
        }
    }
}
