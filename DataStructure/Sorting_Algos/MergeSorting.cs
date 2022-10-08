using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos
{
    class MergeSorting
    {
        /*
         * Merge Sort is a sorting algorithm based on Divide and Conquer Algorithm. Which is Stable and 
         * Outplace kind of sorting.
         * 
         * Time Complexity: O(N log N)
         * Recurrence Relation = T(N) = T(N/2) + T(N/2) + T(N) ~= O(N log N)
         * 
         * Space Complexity: O(N) + O(log N) ~= O(N)
         * Since we are using extra space for making two arrays LeftSubArray and RightSubarray. Also we are
         * using recursion. So, S.C will be O(N) [where N = n1 + 2] for arrays and (log N) for stack algorith 
         * of Recursion.
         */
        /// <summary>
        /// Merge Sort is a sorting algorithm based on Divide and Conquer Algorithm.Which is Stable and
        /// Outplace kind of sorting.
        ///  
        /// <para>
        /// Time Complexity: O(N log N)
        ///     <para>
        ///         Recurrence Relation = T(N) = T(N / 2) + T(N / 2) + T(N) ~= O(N log N)
        ///     </para>
        /// </para>
        /// 
        /// <para>
        /// Space Complexity: O(N) + O(log N) ~= O(N)
        ///     <para>
        ///         Since we are using extra space for making two arrays LeftSubArray and RightSubarray.Also we are
        ///         using recursion. So, S.C will be O(N) [where N = n1 + n2] for arrays and (log N) for stack algorithm
        ///         of Recursion.
        ///     </para>
        /// </para>
        /// </summary>
        /// <param name="arr">List of integers.</param>
        /// <param name="start">First Element Index.</param>
        /// <param name="end">Last Element Index.</param>
        /// <returns>Sorted Array</returns>
        public List<int> MergeSort(List<int> arr, int start, int end)
        {
            if (start < end)
            {
                // Divide
                var mid = start + (end - start) / 2;

                // Conquer
                MergeSort(arr, start, mid); // calling for left Sub-Array [Recuurence Relation = T(N/2)]
                MergeSort(arr, mid + 1, end); // calling for right Sub-Array [Recuurence Relation = T(N/2)]

                // Merge / Combine
                MergeProcedure(arr, start, mid, end);  // [Recuurence Relation = T(N)]

            }
            return arr;
        }

        private void MergeProcedure(List<int> arr, int start, int mid, int end)
        {
            var n1 = mid - start + 1;  // no. of elements in left array 
            var n2 = end - (mid+1) + 1;  // no. of elements in right array 

            var leftSubArray = new int[n1];
            var rightSubArray = new int[n2];

            // Copying elements in leftSubArray
            for (int i = 0; i < n1; i++)
            {
                leftSubArray[i] = arr[i + start];
            }

            // Copying elements in rightSubArray
            for (int j = 0; j < n2; j++)
            {
                rightSubArray[j] = arr[j + mid + 1];  // start from (mid + 1)th element
            }

            int p = 0, q = 0, k = start;
            // Sorting the elements of LSA and RSA
            while ((p < n1) && (q < n2))
            {
                if (leftSubArray[p] <= rightSubArray[q])
                {
                    arr[k] = leftSubArray[p];
                    p++;
                }
                else
                {
                    arr[k] = rightSubArray[q];
                    q++;
                }
                k++;
            }

            // copying the rest elements of leftSubArray as it is
            while (p < n1)
            {
                arr[k] = leftSubArray[p];
                p++;
                k++;
            }

            // copying the rest elements of rightSubArray as it it
            while (q < n2)
            {
                arr[k] = rightSubArray[q];
                q++;
                k++;
            }
        }
    }
}
