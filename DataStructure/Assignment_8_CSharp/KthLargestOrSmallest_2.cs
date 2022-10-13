using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_8_CSharp
{
    class KthLargestOrSmallest_2
    {
        public KthLargestOrSmallest_2(string qType)
        {
            QuestionType = qType;
        }
        private string QuestionType { get; set; }
        private int ResultIndex = -1;
        private int answer { get; set; }
        /// <summary>
        /// Applying Quick Sort algorithm to find Kth smallest and / or Kth largest element. 
        /// <para>
        /// Time Complexity: 
        /// Worst = O(n^2); 
        /// Avg / Best = O(Log n)
        /// </para>
        /// </summary>
        /// <param name="arr">List of integers</param>
        /// <param name="k">number of Kth Smallest or Largest element</param>
        /// <param name="start">Starting index</param>
        /// <param name="end">Ending index</param>
        /// <returns>Kth Smallest or Largest element for given array.</returns>
        public int GetKthLargestOrSmallest(List<int> arr, int k, int start, int end)
        {
            
            if (start < end) 
            {
                var p = Partition(arr, start, end);
                // Kth largest means the element will be at end (as we are applying Quick Sort for
                // sorting the elements in ascending order). So, it will be equal to n - k but
                // here 'end' is index not the length of array so we need to add 1 to it. Finally
                // it will be `end-k+1`. Similarly Kth smallest means it will be at `k-1` index 
                // after sorting (here k is not starting from 0 that's why we are substracting 1
                // from it.
                if (ResultIndex == -1)
                {
                    ResultIndex = QuestionType.ToLower() == "kthlargest" ? end - k + 1 : k - 1;
                }
                
                if (p != ResultIndex)
                {
                    GetKthLargestOrSmallest(arr, k, start, p - 1);
                    GetKthLargestOrSmallest(arr, k, p + 1, end);
                }
                else
                {
                    start = end; // terminate the recursion
                    answer = arr[p];
                }
            }
            return answer;
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
