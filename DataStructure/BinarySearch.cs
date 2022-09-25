using System.Collections.Generic;

namespace DataStructure
{
    class BinarySearch
    {
        public int Find(List<int> nums, int left, int right, int x)
        {
            var mid = left + (right - left) / 2;

            if(left == right)
            {
                return -1;
            }
            else if(nums[mid] == x) 
            { 
                return mid; 
            }
            else if(nums[mid] < x)
            {
                left = mid + 1;
                return Find(nums, left, right, x);
            }
            else
            {
                right = mid - 1;
                return Find(nums, left, right, x);
            }
        }
    }
}
