using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BS_Q1
    {
        /*
         Given: An array having unsorted numbers and after a certain number (to the right) it only contains
                infinite. So, find the first infinite in the given List.
        Ex:- [-23, 40, 55, 1, 2, 27, -89, 999999, 999999, 999999, 999999, 999999] (Let's suppose 999999 = infinity)
        */

        public int SearchFirstInfinity(List<int> nums, int left, int right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == 999999)
            {
                if (nums[mid-1] == 999999)
                {
                    right = mid - 1;
                    return SearchFirstInfinity(nums, left, right);
                }
                else { return mid; }
            }
            else if (nums[mid] != 999999) {
                left = mid + 1;
                return SearchFirstInfinity(nums, left, right);
            }
            return -1;
        }
    }
}
