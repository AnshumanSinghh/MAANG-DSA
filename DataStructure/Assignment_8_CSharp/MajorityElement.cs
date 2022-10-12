using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_8_CSharp
{
    class MajorityElement
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         * 
         * In question it is mentioned that majaority elemen will be present |_ n/2 _| (lower bound). Which means more than
         * half of the element will be same. Now, if we count the numbers and decrease if that number is not matching
         * and if count becomes zero that means the element needs updated as some other element has more duplictae.
         * We can also think like that suppose we have an array of size n. Now, mojority element will repeated more that
         * |_ n/2 _| times. Let's suppose k = |_ n/2 _| + 1, and rest elements = n - k. If we increase counter for repeated 
         * elements and decrease counter for non repeated until count = 0. Then we will visit majority element at least k times.
         * So, at last we will have count > 0. The only thing we need to take care is that update the majority element whenever
         * count is 0 bcz in this case the current majority element is not repeated most so far.
         */
        public int GetTheMajorityElement(List<int> nums)
        {
            // [2, 2, 1, 1, 1, 2, 2]
            int count = 0, majorityElement = int.MaxValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == majorityElement) // if majority element is equal to curr element then increase the count value
                {
                    count++;
                }
                else if (count == 0)  // if count is 0 then update the majority element and increase the count
                {
                    majorityElement = nums[i];
                    count++;
                }
                else // if majority element != curr element, then decrease the count value (some other element is
                     // being repeated or we have visited random numbers so far which is not equal to majority element)
                {
                    count--;
                }
            }
            return majorityElement;
        }
    }
}
