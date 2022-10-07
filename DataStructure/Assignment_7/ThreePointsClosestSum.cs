using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_7
{
    class ThreePointsClosestSum
    {
        public int GetThreePoints(List<int> nums, int target)
        {
            // Time Complexity = O(n log(n))
            nums.Sort();  // Sort the array in this way we can efficiently iterate through the elemnts [once we have visited a
                          // particular ith element we don't need to visit it again]

            int n = nums.Count;
            var closestSum = int.MaxValue;

            // Time Complexity = O(N^2) [for every 'i' while loop is running]
            for (int i = 0; i < n - 2; i++)
            {
                // Take 2 pointers: 1st at next of ith index and 2nd at last index
                int j = i + 1;
                int k = n - 1;

                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    {
                        if (sum == target) // if both are equal it means that no other sum can be closer. So, stop iterating
                                           // and return the sum or target;
                        {
                            return sum;
                        }
                        closestSum = sum;
                    }

                    // changing pointers value based on below conditions
                    if(sum > target) // now decrease k to decrease the sum
                    {
                        k--;
                    }
                    else // if smaller then increase j to increase the sum. [for equal condition we have already handled
                         // that in line 32]
                    {
                        j++;
                    }
                }
            }

            return closestSum;

        }
    }
}
