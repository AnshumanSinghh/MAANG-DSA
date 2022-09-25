using System.Collections.Generic;

namespace DataStructure
{
    class SearchElementIn2DArray
    {
        /*
         Given:- A Sorted 2D Array of m x n:
        i) each row has sorted elements.
        ii) each row first elemnt is greater than the last element of previous row.

        Expected:- Check If given number is present in 2D array or not.
        Array = {{2, 5, 7, 9}, {13, 17, 23, 29}, {40, 43, 47, 52}, {80, 89, 97, 108}}  - 4x4 matrix
         */

        // 1st approach:
        // Bruteforce approach will use two for loop and iterate through each element 
        // Time complexity - O(mxn)

        // 2nd approach:
        // Time complexity - O(m+log(n)) (but if we use linear search then time complexity will be m+n)
        public bool CheckIfElementExists(List<List<int>> nums, int target)
        {
            var m_row = nums.Count;
            var n_column = nums[0].Count;
            for (int i = 0; i < m_row; i++)
            {
                var firstNumber = nums[i][0];
                var lastNumber = nums[i][n_column - 1];
                if ((firstNumber <= target) & (target  <= lastNumber))
                {
                    BinarySearch bs = new BinarySearch();  // using simple binary search
                    return bs.Find(nums[i], 0, n_column, target) != -1;
                }
            }
            return false;
        }

        public int left = 0;
        public int right = 0;
        // 3rd approach:
        // Time complexity - O(log(m*n))
        public string CheckIfElementExists_2(List<List<int>> nums, int target)
        {
            var counter = 0;
            var m_row = nums.Count;
            var n_column = nums[0].Count;
            right = (m_row * n_column) - 1;
            
            while (left <= right)
            {
                var mid = left + (right - left) / 2;  // mid of virtual 1D array 

                // Formula to get the row and column of a nummber if we now mid index
                var row_number = mid / n_column;
                var column_number = mid % n_column;
                var currElement = nums[row_number][column_number];
                
                if (currElement == target)
                {
                    return $"True [at index ({row_number},{column_number})], loop runs {counter} times.";
                }
                else if (currElement > target)  // search in left half
                {
                    right = mid - 1;
                }
                else  // search in right half
                {
                    left = mid + 1;
                }
                counter++;
            }
            return $"False, loop runs {counter} times.";
        }
    }
}
