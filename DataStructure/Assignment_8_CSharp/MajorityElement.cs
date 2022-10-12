using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_8_CSharp
{
    class MajorityElement
    {
        public int GetTheMajorityElement(List<int> nums)
        {
            // [2, 2, 1, 1, 1, 2, 2]
            int count = 0, element = int.MaxValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == element)
                {
                    count++;
                }
                else if (count == 0)
                {
                    element = nums[i];
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return element;
        }
    }
}
