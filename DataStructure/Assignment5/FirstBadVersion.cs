using System.Collections.Generic;

namespace DataStructure.Assignment5
{
    class FirstBadVersion
    {
        public int GetFirstBadVersion(List<int> nums, int left, int right)
        {
            var mid = left + (right - left) / 2;
            if (left == right)
            {
                return left;
            }
            else if (nums[mid] != 1)
            {
                left = mid + 1;
                return GetFirstBadVersion(nums, left, right);
            }
            else
            {
                right = mid - 1;
                return GetFirstBadVersion(nums, left, right);
            }
        }

        public int FirstBadVersion_2(List<int> nums)
        {
            var left = 0;
            var right = nums.Count;

            while (left < right)
            {
                var mid = left + (right -left) / 2;
                if (nums[mid] != 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
