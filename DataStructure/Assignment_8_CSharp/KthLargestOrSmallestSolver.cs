using System;
using System.Collections.Generic;

namespace DataStructure.Assignment_8_CSharp
{
    class KthLargestOrSmallestSolver
    {
        public KthLargestOrSmallestSolver()
        {
            heap = new List<int>(); // can be min heap or max heap
            size = 0;
        }

        List<int> heap; // can be min heap or max heap
        int size;

        public string TypeOfQuestion { get; set; }

        /// <summary>
        /// Idea is simple. Build a heap of 'k' size and perform push and pop on that. Since we are maintaining 
        /// heap of size 'k' only so heapyfying it will take only logk. So after performing 'n' insertion and
        /// 'n-k' deletion Time Complexity =  (n Log k) + ((n - k) Log k) ~= O(n Log k)
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <param name="k">which larhest or smallest element you want to search</param>
        /// <param name="type">Type of question, default is set to "KthSmallest"</param>
        /*
         * These type of question can be solved using.
         * 1) Bubble sort for kth largest as after every pass largest element is at end.
         * 2) Selection sort for kth smallest as after every pass smallest element is at end.
         * Both above 2 approaches will take O(n*k). ABcz after Kth pass we will get the answer.
         * 
         * 3) Using QuickSort partition method (I will solve using this also). If partition returns
         * k-1 index then that element is kth largest or smallest. Time Complexity:
         * Best case = O(n)
         * Worst case = O(n^2)  [demonstrate this in that solution itself]
         */
        public void Solve(List<int> nums, int k, string type = "KthSmallest")
        {
            TypeOfQuestion = type; // set the value of TypeOfQuestion

            // We need most sold product. So we will make MinHeap. If we notice we are indirecty said to find k most frequent
            // product where k = 1. So, we will maintain productWithSoldQuantity length as 1.
            for (int i = 0; i < k; i++)
            {
                HeapPush(nums[i]);  // Add the 1st k numbers
            }

            // If we have to find Kth Largest it means we have build a Min Heap.
            if (type.ToLower() == "kthlargest")
            {
                // Now iterate the rest products and add if Top() element is smaller. In this way
                // we will have largest numbers in our heap
                for (int i = k; i < nums.Count; i++)
                {
                    if (nums[i] > heap[0])  // if curr is larger then remove the top element & add the current element to heap
                    {
                        HeapPop(); // removing the top

                        HeapPush(nums[i]);
                    }
                }
            }
            else  // it means we have to find Kth smallest element. So we will build a Max Heap.
            {
                // Now iterate the rest products and add if Top() element is larger. In this way
                // we will have smallest numbers in our heap
                for (int i = k; i < nums.Count; i++)
                {
                    if (nums[i] < heap[0])  // if curr is smaller then remove the top element & add the current element to heap
                    {
                        HeapPop(); // removing the top

                        HeapPush(nums[i]);
                    }
                }
            }
            
            // Print the top element of heap it is our answer
            Console.WriteLine($"{TypeOfQuestion} number is: {heap[0]}");
        }

        // Adding data to Heap
        private void HeapPush(int num)
        {
            heap.Add(num);  // Add the product and quatity key value pair
            size++;  // keep track of size

            // Heapify the existing non-leaf elements
            for (int i = heap.Count / 2 - 1; i > -1; i--)
            {
                if (TypeOfQuestion.ToLower() == "kthlargest")
                {
                    MinHeapify(i, heap.Count);
                }
                else
                {
                    MaxHeapify(i, heap.Count);
                }
            }
        }

        // Building min Heap
        private void MinHeapify(int smallest, int n)
        {
            var parent_idx = smallest;
            var leftChild_idx = 2 * smallest + 1;
            var rightChild_idx = 2 * smallest + 2;

            if ((leftChild_idx < n) && (heap[leftChild_idx] < heap[parent_idx]))
            {
                parent_idx = leftChild_idx;
            }

            if ((rightChild_idx < n) && (heap[rightChild_idx] < heap[parent_idx]))
            {
                parent_idx = rightChild_idx;
            }
            if (parent_idx != smallest)
            {
                (heap[parent_idx], heap[smallest]) = (heap[smallest], heap[parent_idx]);  // Swap
                MinHeapify(parent_idx, n);
            }
        }

        // Building max Heap
        private void MaxHeapify(int largest, int n)
        {
            var parent_idx = largest;
            var leftChild_idx = 2 * largest + 1;
            var rightChild_idx = 2 * largest + 2;

            if ((leftChild_idx < n) && (heap[leftChild_idx] > heap[parent_idx]))
            {
                parent_idx = leftChild_idx;
            }

            if ((rightChild_idx < n) && (heap[rightChild_idx] > heap[parent_idx]))
            {
                parent_idx = rightChild_idx;
            }
            if (parent_idx != largest)
            {
                (heap[parent_idx], heap[largest]) = (heap[largest], heap[parent_idx]);  // Swap
                MaxHeapify(parent_idx, n);
            }
        }

        private void HeapPop()
        {
            if (heap.Count == 0)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            (heap[0], heap[size - 1]) = (heap[size - 1], heap[0]); // Swap 1st element with last element
            heap.RemoveAt(size - 1); // Remove the last element
            size--;

            // Heapify the existing non-leaf elements
            for (int i = heap.Count / 2 - 1; i > 0; i--)
            {
                if (TypeOfQuestion.ToLower() == "kthlargest")
                {
                    MinHeapify(i, heap.Count);
                }
                else
                {
                    MaxHeapify(i, heap.Count);
                }
            }
        }        
    }
}
