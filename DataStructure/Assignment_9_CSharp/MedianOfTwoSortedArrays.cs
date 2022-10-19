using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_9_CSharp
{
    class MedianOfTwoSortedArrays
    {
        /*
         * Naive method:
         * Since 2 sorted array is given and we have to merge into 1 sorted array. Then onlyw we will able to
         * get the median of that array. But here space caomplexity will become O(m+n). We can optimize it
         * by using pointers. As we only need two values middle (in case of even number of elements it will 
         * have 2 middle elements) so we can use two pointers to store that value. Now, another optiomization 
         * can be why do we need to sort whole array whenn we require element at position 'mid1' and 'mid2'.
         * So, in thuis approach we will update mid1 and mid2 value until we have reached medianIndex.
         * 
         * Time complexity: O( medianIndex). 
         * Space complexity: O(1)
         */
        public double Median(List<int> num1, List<int> num2)
        {
            var n = num1.Count;
            var m = num2.Count;
            int mid1 = 0, mid2 = 0;

            var medianIndex = (n + m) / 2;

            int p = 0, q = 0, k = -1;  // here 'K' is to keep track of number of elements
                                       // that has been sorted so far.
            while(k <= medianIndex)
            {
                if (k == medianIndex) // if we rasached medianIndex it means we ahve required mid values
                                      // in mid1 and mid2. So, return the median.
                {
                    return GetMedian(n, m, mid1, mid2);
                }
                if ((p < n) && (num1[p] <= num2[q])) // num1[p] of leftArray is smaller than or equal to num2[q]. 
                {
                    mid1 = mid2;
                    mid2 = num1[p];
                    p++;
                }
                else // num1[p] of leftArray is greater than than num2[q]. 
                {
                    mid1 = mid2;
                    mid2 = num2[q];
                    q++;
                }
                k++;
            } 
            return GetMedian(n, m, mid1, mid2);
        }

        private double GetMedian(int n, int m, int mid1, int mid2)
        {
            if ((n + m) % 2 == 0)  // if length is even
            {
                return ((double)mid1 + (double)mid2) / 2;
            }
            return mid2;  // if odd
        }
    }
}
