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
    }
}
