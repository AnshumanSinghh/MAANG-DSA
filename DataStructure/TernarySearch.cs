using System.Collections.Generic;

namespace DataStructure
{
    class TernarySearch
    {
        public int SearchElement(List<int> nums, int start, int end, int key)
        {
            var mid1 = start + (end - start) / 3;
            var mid2 = end - (end - start) / 3;

            if(nums[mid1] == key)
            {
                return mid1;
            }
            else if(nums[mid2] == key)
            {
                return mid2;
            }
            else if (key < nums[mid1])  // Seacrh in first part
            {
                end = mid1 + 1;
            }
            else if(key > nums[mid2])  // Seacrh in third part
            {
                start = mid2 + 1;
            }
            else  // Seacrh in second part
            {
                start = mid1 + 1;
                end = mid2 - 1;
            }
            return SearchElement(nums, start, end, key);
        }
    }
}
