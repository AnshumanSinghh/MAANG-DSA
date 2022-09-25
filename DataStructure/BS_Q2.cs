using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BS_Q2
    {
        /*
         Given: An array having unsorted numbers and after a certain number (to the right) it only contains
                infinite. So, find the first infinite in the given List. Also the legth of list is infinite
         Ex:- [-23, 40, 55, 1, 2, 27, -89, 999999, 999999, 999999, 999999, 999999] (Let's suppose 999999 = infinity)
        */
        public int right = 2;
        public int SearchFirstInfinityInInfiniteList(List<int> nums, int left)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == 999999)
            {
                if (nums[mid - 1] == 999999)
                {
                    right = mid - 1;
                    BS_Q1 bS_Q1 = new BS_Q1();
                    return bS_Q1.SearchFirstInfinity(nums, left, right);
                }
                else { return mid; }
            }
            else if (nums[mid] != 999999)
            {
                left = mid + 1;  // left = right (we can write this also if we were checking nums[right] == 999999)
                                 // instead of checking nums[mid] == 999999
                right *= 2;
                return SearchFirstInfinityInInfiniteList(nums, left);
            }
            return -1;
        }
    }
}
