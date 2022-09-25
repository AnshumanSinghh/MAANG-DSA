using System.Collections.Generic;

namespace DataStructure
{
    class BS_Q3
    {
        /*
         Given: An array having sorted numbers. 
         Find: a, b from the given list such that a + b = given_number
         Ex:- [20, 40, 60, 70, 80, 90, 120, 210, 240] 

         Time complexity:- O(nlogn)
         */

        public string FindPairForTheGivenSum(List<int> nums, int sum)
        {
            BinarySearch binarySearch = new BinarySearch();
            foreach (var num in nums)
            {
                var isPairAvailable = binarySearch.Find(nums, 0, nums.Count, sum - num) != -1;
                if (isPairAvailable)
                {
                    return $"({num}, {sum - num})";
                }
            }
            return "No such pairs!";
        }


        // GREEDY Approach:- More Optimize than above one.
        // Time complexity:- O(n)
        public string FindPairForTheGivenSum_2(List<int> nums, int sum)
        {
            var left = 0;
            var right = nums.Count - 1;

            while (left < right)
            {
                var leftValue = nums[left];
                var rightValue = nums[right];
                if (leftValue + rightValue == sum)
                {
                    return $"({leftValue}, {rightValue})";
                }
                else if(leftValue + rightValue > sum)
                {
                    right -= 1;
                }
                else
                {
                    left += 1;
                }
            }
            return "No such pairs!";
        }
    }
}
