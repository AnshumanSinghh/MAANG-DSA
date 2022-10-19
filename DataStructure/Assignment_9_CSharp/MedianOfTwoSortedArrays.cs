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
         * Since 2 sorted array is given and we have to find median. So, merging into 1 sorted array is the way to
         * get the median of that array. But here space complexity will become O(m+n). We can optimize it
         * by using pointers. As we only need two values middle (in case of even number of elements it will 
         * have 2 middle elements) so we can use two pointers to store that value. Now, another optimization 
         * can be why do we need to sort whole array when we only need elements at position 'mid1' and 'mid2'.
         * So, in this approach we will update mid1 and mid2 values until we have reached medianIndex.
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

        /*
         * What is median?
         * Median is the middle value of sorted values / array (in case of even length it will Average of 2 
         * middle elements). Now, we can also say that median is the point which divides an array into 2 equal
         * halves. If this is the case we can use this property to find median.
         * 
         * Now, supoose if we somehow divide both array in such a way that in left we have lesser elements and
         * right side we have larger elements. Since 2 sorthed arrays are given we can achieve this by applying little maths.
         * Let's  leftArray = { -5, 3, 6, 12, 15}; x = 5;
         * and rightArray = { -12, -10, -6, -3, 4, 10}; y = 6;
         * Now, divide booth array ion 2 parts such that leftArray_leftPart + rightArray_leftPart = leftArray_rightPart + rightArray_righttPart
         * partitionX = 5/2 = 2;
         * PartitionY = (5+6+1)/2 - partitionX = 6 - 2 = 4;
         * 
         *          ===== Overall Left =====          |       ====== Overall Right ======
         * leftArray_leftPart = -5, 3                 | leftArray_rightPart = 6, 12, 15
         * rightArray_leftPart = -12, -10, -6, -3     | rightArray_righttPart = 4, 10
         * Now observe:
         * All elements of 'leftArray_leftPart' < All elements of 'leftArray_rightPart'. [as leftArray was sorted]
         * All elements of 'rightArray_leftPart' < All elements of 'rightArray_ightPart'. [as leftArray was sorted]
         * 
         * Deciding whether our partition is the required partition or not:
         * If last element of 'leftArray_leftPart' <= first element of 'rightArray_rightPart'
         * and last element of 'rightArray_leftPart' <= first element of 'leftArray_rightPart' then we can say
         * that in Left we have all smaller elements and in right we have all larger elements.
         * If above case it TRUE then we can return median using following expression.
         * 
         * if x + y = ODD_number, it means Median will be at x+y/2 or in Left. In Left we have following elements
         * leftArray_leftPart = -5, 3  
         * rightArray_leftPart = -12, -10, -6, -3 
         * How to decide which one is Median?
         * => If we see both are sorted array. So, suppose we have to merge leftArray_leftPart and rightArray_leftPart
         * and the last element will be our median. But can we predict the last element without merging?
         * Yes, since both are sorted so maximum of last element of leftArray_leftPart and rightArray_leftPart will be
         * the over all last element. And this would be our median Max(leftArray_leftPart[partiotnX-1], rightArray_leftPart[partiotnY-1]).
         * 
         * If x+y = EVEN_number. In this case we will have 2 mid values.
         * How to get the mid1 and mid2?
         * Getting mid1 will be same as getting median in case of ODD_number. In order to get mid2 suppose we have to merge
         * 'leftArray_rightPart' and 'rightArray_righttPart'. Then the first element of this merged array will be mid2. But why?
         * Bcz mid1 and mid2 will be always adjacent elements and since mid1 is the last elemnt of overall Left Part. So, it's 
         * adjacent will be the first element of overall Right part. ow to decide the first elemnt of overall Right Part?
         * Since both 'leftArray_rightPart' and 'rightArray_righttPart' are sorted so the Minimum of first element of both
         * arrays would be the first element of overall Right part.
         * Righ Part:
         * leftArray_rightPart = 6, 12, 15
         * rightArray_righttPart = 4, 10
         * Overall Right = Min(6, 4)
         *              (------- mid1 ---------  + --------- mid2 -------------) / 2   [Average of mid1 and mid2]
         * So, Median = Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY) / 2.
         * 
         * Deciding for left or right traversal:
         * If last element of 'leftArray_leftPart' > first element of 'rightArray_rightPart' it means too right of
         * median. So, move left as we to find some smaller element in 'leftArray'. 
         * 
         * If last element of 'rightArray_leftPart' > first element of 'leftArray_rightPart' it means too left of
         * median. So, move right as we to find some smaller element in 'rightArray'. 
         * 
         * There are few edge case as well here, any  of this leftArray_leftPart, rightArray_leftPart, leftArray_rightPart, 
         * rightArray_rightPart can have zero elements. Ex:- Elements of leftArray are greater than elments of rightArray 
         * elements. We will handle this situation by giving -infinity or +infinity based on need. See line 149, 152, 155 & 156.
         */
        public double Median_2(List<int> num1, List<int> num2)
        {
            // If num1 length is greater than num2 array. 
            if (num1.Count > num2.Count)
            {
                return Median_2(num2, num1);
            }

            var x = num1.Count;
            var y = num2.Count;

            int low = 0;
            int high = x;

            while (low <= high)
            {
                var partitionX = low + (high - low) / 2;
                var partitionY = ((x + y + 1)/2) - partitionX;

                // partitonX is 0 means nothing is there in left side, Use -Infinity. In this way we will neglect
                // the maxLeftX as will take Max(maxLeftX, maxLeftY) for median. so, -Infinity will be neglected.
                var maxLeftX = (partitionX == 0) ? int.MinValue : num1[partitionX - 1];
                // partitonX is 0 means nothing is there in left side, Use +Infinity. In this way we will neglect
                // the minRightX as will take Min(minRightX, minRightY) for 'mid2'. So, +Infinity will be neglected.
                var minRightX = (partitionX == x) ? int.MaxValue : num1[partitionX];

                // Do same for PartitonY
                var maxLeftY = (partitionX == 0) ? int.MinValue : num2[partitionY - 1];
                var minRightY = (partitionX == y) ? int.MaxValue : num2[partitionY];

                if (maxLeftX <= minRightX && maxLeftY <= minRightY)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return ((double)(Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY))) / 2;
                    }
                    return (double)Math.Max(maxLeftX, maxLeftY);
                }
                else if (maxLeftX > minRightY)  // we are to right, search in left
                {
                    high = partitionX - 1;
                }
                else  // we are to left, search in right
                {
                    low = partitionX + 1;
                }
            }
            return 0.0;  // If input arrays are not sorted 
        }
    }
}
