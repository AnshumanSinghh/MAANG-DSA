using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class QuickSorting
    {
        /*
         * Time Complexity:
         * Recurrence Relation: 
         * T(N) = C   [when N = 1;]
         * T(N) = T(m - start) + T(end - m) + N   [when N > 1;]
         * 
         * Best Case / Average Case:
         * T(N) = T(N/2) + T(N/2) + N ~= O(N Log N)
         * 
         * Worst Case:
         * T(N) = T(N-1) + 1 + N ~= O(N^2)
         * 
         * Analysis:
         * Worst case will happen when pivot partition returns start or end index. This will happen when array is already
         * sorted or almost sorted. But suppose you are given an array where after first element every element is bigger than
         * that but not in sorted order. Then in that case also T.C will be O(N^2). So, what is wrong neither it is sorted nor
         * it is almost sorted array? So, answer is very simple if you are choosing 'smallest' or 'largest' element of an array 
         * as pivot then it will be worst case scenario as it will always search only in either LeftSubArray or RightSubArray. 
         * 
         * PROOF :-
         * If you put m = 0, 1, n-1, n [n is last index of any array] in equation of Line 15. You will notice it will transform 
         * into equation of Line 21 (worst case).
         * 
         * Best case or Average case will happen when both L SubArray and R SubArray are partionedd equally. And it will happen 
         * only when our Partition() method returns middle index. It means the pivot we chose has it's correct position at 
         * (N/2)th index.
         * 
         * Space Complexity:
         * O(1) [no extra space required]
         * 
         * Feature:
         * It is inplace and unstable sorting algorithm.
         * After every call of partion method pivot will be at it's correct position. Which means in left of 'pivot' element
         * every element is smaller than 'pivot' (if 'pivot' is not the 1st element) and in right every element is larger than 
         * that (if 'pivot' is not the last element).
         */
        public List<int> QuickSort(List<int> arr, int start, int end)
        {
            if (start < end)
            {
                var m = Partition(arr, start, end); // Call Partition() to get the 'partition' index

                QuickSort(arr, start, m - 1);  // Call for Left-SubArray
                QuickSort(arr, m + 1, end);  // Call for Right-SubArray
            }
            return arr;
        }

        private int Partition(List<int> arr, int start, int end)
        {
            var pivot = arr[start];
            var i = start;  // for returning the pivot element index (After exiting the for loop 'i' will point the
                            // correct position of our 'pivot' element).

            for (int j = i + 1; j < end + 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i], arr[start]) = (arr[start], arr[i]);  // finally put the pivot element at 'i'th index [we took pivot
                                                          // element as first element of the array]
            return i; // the right posiotion of pivot element [the first element of array]
        }
    }
}
