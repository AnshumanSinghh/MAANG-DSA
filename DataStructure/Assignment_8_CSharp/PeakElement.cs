using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_8_CSharp
{
    class PeakElement
    {
        /*
         * Let's first understand the question properly.
         * An array is given in which we have to return any peak element ('peak elemenet')
         * is the element greater than it's neighbours. Now it is also provided that
         * 1) arr[i] != arr[i + 1]  --> this means either smaller or lesser elements in their neighbour.
         * 2) arr[-1] = arr[n] = -∞ (minus infinity)  --> which means: 
         * if arr[0] > arr[1] then arr[0] is peak element as arr[-1] is -∞ (minus infinity) or
         * if arr[n - 2] < arr[n - 1] then arr[n - 1] is peak element as arr[n-1] is -∞ (minus infinity).
         * Where n = length of array.
         * 
         * Now, possible cases:
         * 1) Array contains multiple peaks [graphically it will plot several increasing and decreasing slopes].
         * Ex:- { 1, 2, 1, 4, 5}
         * 
         * 2) Array contains increasing elements (only increasing slope). In this case 'peak' will be the last element
         * bcz of this condition arr[n - 2] < arr[n - 1]. Ex:- { 1, 2, 3, 4, 5 }; peak index =  4 (last index of 
         * increasing slope);
         * 
         * 3)Array contains decreasing elements (only decreasing slope). In this case 'peak' will be the last element
         * bcz of this condition arr[0] > arr[1]. Ex:- { 5, 4, 3, 2, 1 }; peak index =  0 (first index of decreasing slope);
         * 
         * 4) Contains only 1 increasing and 1 decreasing slope peak (Mixed of 2nd and 3rd case):
         * a) Ex:- { 1, 2, 3, 4, 5, 4, 3, 2}  --> peak index will be 4 [answer is starting index of decreaing slope]
         * b) Ex:- { 5, 4, 3, 2, 1, 2, 3, 4}  --> peak  indexes are: 0, 7 [answer is first and last index]
         * 
         * Intuition behind the approach. 
         * Find the mid now mid can be either in left of peak or ight of peak to decide that check:
         * i) arr[mid] < arr[mid+1]  (mid is left side of the peak and graph is increasing. So, last index of increasing slope
         * will be our peak element. See Ex 4.b. Here, we are sure about mid that it's not the last element so left = mid + 1
         * to search in right)
         * 
         * ii) arr[mid] > arr[mid+1]  (mid is left side of the peak and graph is decreasing. So, first index of decreasing slope
         * will be our peak element. See Ex 4.a. Here first index of decreasing slope will be either in the left of mid or mid
         * can also be the first index of decreasing slope. So, right = mid not mid + 1; to search in left)
         * 
         * Time Complexit: O(logn)  [as we are applying binary search]
         * Space complexity: O(1)   [no extra space is used]
         */
        public int GetPeakElement(List<int> arr)
        {
            int left = 0, right = arr.Count - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (arr[mid] < arr[mid + 1])  // Graph is increasing, search in right
                {
                    left = mid + 1;
                }
                else // Graph is decreasing, search in left
                {
                    right = mid; // why we are not doing mid-1?
                    /*
                     * Since, the graph is decreasing here. So, peak will be first index of decreasing slope & that
                     * would be either in the left of mid or mid can also be the first index of decreasing slope. 
                     * So, right = mid not mid + 1; to search in left)
                     */
                }
            }
            return left;
        }
    }
}
