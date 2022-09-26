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
        public void HeapPush(int val)
        {
            size += 1;
            int index = size;
            arr[index] = val;

            // Heapify
            //MaxHeapify(index);
            MinHeapify(index);
        }

        public void HeapPop()
        {
            if (size == 0)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Swap(1, size);  // Swap first element with last
            size--;

            //RearrangeForValidMaxHeap();
            RearrangeForValidMinHeap();
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

        private void MaxHeapify(int index)
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

        private void MinHeapify(int index)
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

        private void RearrangeForValidMaxHeap()
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

        private void RearrangeForValidMinHeap()
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
