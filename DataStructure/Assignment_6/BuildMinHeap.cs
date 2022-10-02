using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_6
{
    class BuildMinHeap
    {

        // Below Code is for Zero Indexing
        public void MinHeap(List<int> nums, int n)
        {
            var start_index = (n / 2) - 1;  // last non-leaf node index
            for (int i = start_index; i > -1; i--)
            {
                Heapify(ref nums, i, n);
            }

            // Now Print the Min Heap
            Console.Write("Min Heap: ");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Min-Heapify Algorithm
        private void Heapify(ref List<int> nums, int smallest_idx, int n)
        {
            var parent_idx = smallest_idx;
            var left_child_idx = 2 * smallest_idx + 1;
            var right_child_idx = 2 * smallest_idx + 2;

            if ((left_child_idx < n) && (nums[left_child_idx] < nums[parent_idx]))
            {
                parent_idx = left_child_idx;
            }

            if ((right_child_idx < n) && (nums[right_child_idx] < nums[parent_idx]))
            {
                parent_idx = right_child_idx;
            }

            if (parent_idx != smallest_idx) // Means left_child or right child is smaller than parent.
            {
                (nums[parent_idx], nums[smallest_idx]) = (nums[smallest_idx], nums[parent_idx]);  // Swap
                Heapify(ref nums, parent_idx, n);
            }
        }
    }
}
