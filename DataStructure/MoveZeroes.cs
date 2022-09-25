using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MoveZeroes
    {
        public List<int> MoveZeroesToEnd(List<int> nums)
        {
            int indexOfFirstZero = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != 0)
                {
                    int currNonZeroNumber = nums[i];
                    int indexOfCurrentZero = i - 1;
                    while (indexOfCurrentZero >= indexOfFirstZero) // this will run only if zero is available bcz
                                                                   // for every zero if statement will not run and
                                                                   // indexOfFirstZero will not increase but
                                                                   // indexOfCurrentZero will increase as value of i
                                                                   // will increase.
                    {
                        nums[indexOfCurrentZero + 1] = nums[indexOfCurrentZero]; //shift 0 towards right by +1 index
                                                                                 // until the indexOfFirstZero
                        indexOfCurrentZero -= 1;  
                    }
                    nums[indexOfFirstZero] = currNonZeroNumber;  // Now put nonzero number at place of first zero
                                                                 // number in current list. (U can also use indexOfCurrentZero + 1
                                                                 // as it will be same after coming out of while loop)
                    indexOfFirstZero++; // now zero is at +1 index right
                }
            }
            return nums;
        }
    }
}
