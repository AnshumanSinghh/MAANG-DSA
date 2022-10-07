using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos.BinaryHeap
{
    class Heapq
    {
        public int[] arr = new int[100];
        public int size;
        public Heapq()
        {
            arr[0] = -1;
            size = 0;
        }
        /*
         * Time Complexity for Heap Creation:
         * Since adding 1 node and heapifying it takes O(log n). So, adding n elements Time complexity will be
         * O(n Log n)
         */
        public void HeapPush(int val)
        {
            size += 1;
            int index = size;
            arr[index] = val;

            // Heapify
            //MaxHeapifyForHeapPush(index);
            MinHeapifyForHeapPush(index);
        }

        /* 
         * Time Complexity of Insertion in Heap:
         * T.C = O(1) [swapping parent and leaf node] + O(H) [swapping the nodes for Heapify, where H = O(Log n) for CBT]
         */
        public void HeapPop()
        {
            if (size == 0)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Swap(1, size);  // Swap first element with last
            size--;

            //RearrangeForValidMaxHeap_ForPop();
            RearrangeForValidMinHeap_ForPop();
        }

        /// <summary>
        /// Creates MinHeap or MaxHeap for given array.
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <param name="n">Size of the Heap</param>
        /// <param name="isMinHeap">Boolean value to create either MinHeap or MaxHeap. Default
        /// value is true.</param>
        /// <remarks>Time Complexity = O(n). 
        /// Space Complexity = O(n).</remarks>
        public void BuildHeap(List<int> nums, int n, bool isMinHeap = true)
        {
            //last non-leaf node idx = (n / 2) - 1;  [since leaf nodes = n/2. So, non-leaf nodes = n/2 - 1]

            for (int start_idx = (n / 2) - 1; start_idx > 0; start_idx--)
            {
                // Call Heapify Method
                if (isMinHeap)
                {
                    MinHeapify(ref nums, n, start_idx);  // For Min-Heap
                }
                else
                {
                    MaxHeapify(ref nums, n, start_idx);  // For Max-Heap
                }
            }

            // Printing the Heap
            Console.Write(isMinHeap ? "Min Heap: " : "Max Heap: ");
            for (var idx = 1; idx < nums.Count; idx++)
            {
                Console.Write(nums[idx] + " ");
            }
            Console.WriteLine(); 
        }

        private void MinHeapify(ref List<int> nums, int n, int i)
        {
            int parent_idx = i;  // smallest
            var left_child = 2 * i;
            var right_child = 2 * i + 1;
            /*
            For Zero Based Indexing:
            int parent_idx = i;  // smallest
            var left_child = 2 * i + 1;
            var right_child = 2 * i + 2;
             */
            if ((left_child < n)&&(nums[left_child] < nums[parent_idx]))
            {
                parent_idx = left_child;
            }
            if ((right_child < n) && (nums[right_child] < nums[parent_idx]))
            {
                parent_idx = right_child;
            }

            // If smallest is not the root
            if (parent_idx != i) // It means either left or right child is smaller than parent.
            {
                (nums[parent_idx], nums[i]) = (nums[i], nums[parent_idx]);  // Swap
                MinHeapify(ref nums, n, parent_idx);
            }
            
        }

        private void MaxHeapify(ref List<int> nums, int n, int i)
        {
            int parent_idx = i;  // largest
            var left_child = 2 * i;
            var right_child = 2 * i + 1;
            /*
            For Zero Based Indexing:
            int parent_idx = i;  // largest
            var left_child = 2 * i + 1;
            var right_child = 2 * i + 2;
             */
            if ((left_child < n) && (nums[left_child] > nums[parent_idx]))
            {
                parent_idx = left_child;
            }
            if ((right_child < n) && (nums[right_child] > nums[parent_idx]))
            {
                parent_idx = right_child;
            }

            // If largest is not the root
            if (parent_idx != i) // It means either left or right child is greater than parent.
            {
                (nums[parent_idx], nums[i]) = (nums[i], nums[parent_idx]);  // Swap
                MaxHeapify(ref nums, n, parent_idx);
            }

        }

        public void Peek()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private void Swap(int parentIndex, int childIndex)
        {
            var temp = arr[parentIndex];
            arr[parentIndex] = arr[childIndex];
            arr[childIndex] = temp;
        }

        /* 
         * Time Complexity of Heap Insertion:
         * T.C = O(1) [adding a node] + O(H) [swapping the nodes, where H = O(Log n) for CBT]
         */
        private void MaxHeapifyForHeapPush(int index)
        {
            while (index > 1)
            {
                int parent = index / 2;
                if (arr[parent] < arr[index])  // for max heapification.
                {
                    Swap(parent, index);
                    index = parent;
                }
                else
                {
                    return;
                }
            }
        }

        private void MinHeapifyForHeapPush(int index)
        {
            while (index > 1)
            {
                int parent = index / 2;
                if (arr[parent] > arr[index])  // for min heapification
                {
                    Swap(parent, index);
                    index = parent;
                }
                else
                {
                    return;
                }
            }
        }

        private void RearrangeForValidMaxHeap_ForPop()
        {
            int i = 1;
            while (size > i)
            {
                var leftChildIndex = 2 * i;
                var rightChildIndex = (2 * i) + 1;

                if (leftChildIndex < size && arr[i] < arr[leftChildIndex])
                {
                    Swap(i, leftChildIndex);
                    i = leftChildIndex;
                }
                else if (rightChildIndex < size && arr[i] < arr[rightChildIndex])
                {
                    Swap(i, leftChildIndex);
                    i = rightChildIndex;
                }
                else
                {
                    return;
                } 
            }
        }

        private void RearrangeForValidMinHeap_ForPop()
        {
            int i = 1;
            while (size > i)
            {
                var leftChildIndex = 2 * i;
                var rightChildIndex = (2 * i) + 1;

                if (leftChildIndex < size && arr[i] > arr[leftChildIndex])
                {
                    Swap(i, leftChildIndex);
                    i = leftChildIndex;
                }
                else if (rightChildIndex < size && arr[i] > arr[rightChildIndex])
                {
                    Swap(i, leftChildIndex);
                    i = rightChildIndex;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
