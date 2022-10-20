using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class NumberOfInversions
    {
        /*
         * Time Complexity:O(n log n)
         * As, recurrence relation will be: T(N) = T(N/2) + T(N/2) + N  ==>  2 * T(N/2) + N = O(N Log N)
         * Where, 2 * T(N/2) is fro calling LeftSubArray and RightSubArray,
         * N ias for Mergeprocedure.
         * 
         * Space Complexity = O(N)  [in MergeProcedure we are making LSA and RSA]
         */
        private int InversionCount = 0;
        public int GetNumberOfInversion(List<int> arr, int start, int end)
        {
            if (start == end)
            {
                return 0;
            }

            if (start < end)
            {
                var mid = start + (end - start) / 2;

                var cntL = GetNumberOfInversion(arr, start, mid); // LSA
                var cntR = GetNumberOfInversion(arr, mid+1, end); // RSA

                var finalCount = MergeProcedure(arr, start, mid, end);
                InversionCount = cntL + cntR + finalCount;
            }
            Console.WriteLine($"Main: {InversionCount}");
            return InversionCount;
        }

        private int MergeProcedure(List<int> arr, int start, int mid, int end)
        {
            var n = mid - start + 1;
            var m = end - mid; // end - (mid + 1) + 1;

            var leftSubArray = new int[n];
            var rightSubArray = new int[m];
            var inversionCount = 0;

            // Copying elements in LeftSubArray, ranging from start to mid
            for (int i = 0; i < n; i++)
            {
                leftSubArray[i] = arr[i + start];
            }

            // Copying elements in RighSubArray, ranging from mid+1 to end
            for (int j = 0; j < m; j++)
            {
                rightSubArray[j] = arr[j + mid + 1];
            }

            int p = 0, q = 0, k = start;
            while ((p < n) && (q < m))
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
                    inversionCount += n - p;
                }
                k++;
            }

            // Copying rest elements of LeftSubArray
            while (p < n)
            {
                arr[k] = leftSubArray[p];
                p++;
                k++;
            }

            // Copying rest elements of RightSubArray
            while (q < m)
            {
                arr[k] = rightSubArray[q];
                q++;
                k++;
            }
            Console.WriteLine($"Merge procedure: {inversionCount}");
            return inversionCount;
        }
    }
}
