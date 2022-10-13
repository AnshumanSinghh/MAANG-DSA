using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class RandomisedQuickSort
    {
        private int RandomizedPartition(List<int> arr, int start, int end)
        {
            var random = new Random();
            var pivot_idx = random.Next(start, end + 1);
            (arr[start], arr[pivot_idx]) = (arr[pivot_idx], arr[start]);
            return Partition(arr, start, end);
        }

        private int Partition(List<int> arr, int start, int end)
        {
            var pivot_idx = start;
            var pivot= arr[pivot_idx];

            for (int j = pivot_idx+1; j < end + 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    pivot_idx++;
                    (arr[pivot_idx], arr[j]) = (arr[j], arr[pivot_idx]);
                }
            }
            (arr[pivot_idx], arr[start]) = (arr[start], arr[pivot_idx]);
            return pivot_idx;
        }


        /*
         * The logic will be almost same as Quick Sorting but here we will select the the pivot element
         * randomly instead of hardcoding it to start index. Since we are randomly selecting the pivot index
         * and then we are swapping it with start index. and utilizzing the same old Quicx sorrt logic.
         * Why we are doing this and how it is helpful for us?
         * So, we know that in Quick Sort worst case occut when our pivot is the lartgest or smallest element
         * of array. To areduce the prtobability of getting the smallest or largest element we are randomly 
         * picking up the pivot index.
         * Time Complexity:
         * Worst:- O(n^2)
         * Best / Average case:- O(log n)
         * It is same as the old Quick Sort but in practical lifw if we use this sorting mostly it will
         * take O(log n) only.
         */
        public List<int> QuickSort(List<int> arr, int start, int end)
        {
            if (start < end)
            {
                var partition_idx = RandomizedPartition(arr, start, end);

                QuickSort(arr, start, partition_idx - 1);
                QuickSort(arr, partition_idx + 1, end); 
            }
            return arr;
        }
    }
}
