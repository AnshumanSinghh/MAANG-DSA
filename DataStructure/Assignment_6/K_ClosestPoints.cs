using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_6
{
    class K_ClosestPoints
    {   /*
         * Time Complexity:
         * 1) Counter = O(n) where n is length of nums
         * 
         * 2) Insertion of k elements = O( k log k) [addint takes O(1) and heapifying that takes log k. Since we have
         * k elements only in heap]
         * 
         * 3) Deletion of n-k elements = O((n-k)*log k) [As in worst case we are deleting n-k elements and deletion of 1 node
         * takes O(1) but heapyifying it takes log k and we doing it for n-k nodes. So, T.C = O((n-k)*log k) for deletion.]
         * 
         * 4) Again we are doing insertion for n-k elements. So, it will take O((n-k)*Log k).
         * 
         * Now over all time complexity will be = n + (k log k) + (n-k)*log k + (n-k)*Log k ~= O(n log k)  [Add steps: 1 + 2 + 3 + 4]
         * If you observe we are inserting all elements but mainting the heap of size k only. So, ultimately it will 
         * take O(n * log k).
         */
        List<KeyValuePair<double, List<int>>> distancesWithCord = new List<KeyValuePair<double, List<int>>>();
        int size = 0;
        public void GetKClosestPoints(List<List<int>> nums, int k)
        {
            int x; int y; double dist;
            int counter = 0;
            // Building max heap for k elements
            foreach (var coordinates in nums)
            {
                if (counter < k)
                {
                    x = coordinates[0];
                    y = coordinates[1];
                    dist = GetSquareOfDistanceFromOrigin(x, y);
                    HeapPush(new KeyValuePair<double, List<int>>(dist, coordinates));  // will act as PriorityQueue
                                                                                       // or BinaryHeap
                    counter++;
                }
                else
                {
                    break;
                }
            }

            // if 1st element (top / zeroth index element) has larger distance than ith index of nums
            // (where i starts from k) then, remove the 1st element from distancesWithCord and push
            // the ith element of nums to distancesWithCord
            for (int i = k; i < nums.Count; i++)
            {
                x = nums[i][0];
                y = nums[i][1];
                dist = GetSquareOfDistanceFromOrigin(x, y);
                if ( dist < distancesWithCord[0].Key)
                {
                    HeapPop();
                    HeapPush(new KeyValuePair<double, List<int>>(dist, new List<int> { x, y}));
                }
            }

            var result = distancesWithCord.OrderBy(z=>z.Key);
            // Print the result
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value[0]}, {item.Value[1]}");
            }
        }

        private void HeapPush(KeyValuePair<double, List<int>> kv)
        {
            distancesWithCord.Add(kv);
            size++;
            // Heapify
            for (int i = distancesWithCord.Count / 2 - 1; i > -1 ; i--)
            {
                MaxHeapify(i, distancesWithCord.Count); 
            }
        }

        private void MaxHeapify(int i, int n)
        {
            int parent_idx = i;  // largest
            var left_child = 2 * i + 1;
            var right_child = 2 * i + 2;

            if ((left_child < n) && (distancesWithCord[left_child].Key > distancesWithCord[parent_idx].Key))
            {
                parent_idx = left_child;
            }
            if ((right_child < n) && (distancesWithCord[right_child].Key > distancesWithCord[parent_idx].Key))
            {
                parent_idx = right_child;
            }

            // If largest is not the root
            if (parent_idx != i) // It means either left or right child is greater than parent.
            {
                (distancesWithCord[parent_idx], distancesWithCord[i]) = (distancesWithCord[i], distancesWithCord[parent_idx]);  // Swap
                MaxHeapify(parent_idx, n);
            }
        }

        private void HeapPop()
        {
            if (distancesWithCord.Count == 0)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }
            (distancesWithCord[0], distancesWithCord[size - 1]) = (distancesWithCord[size - 1], distancesWithCord[0]);
            distancesWithCord.RemoveAt(size - 1);
            size--;
            for (int i = distancesWithCord.Count / 2 - 1; i > 0; i--)
            {
                MaxHeapify(i, distancesWithCord.Count);
            }
        }

        private double GetSquareOfDistanceFromOrigin(int x, int y)
        {
            return (x * x) + (y * y); // we are skipping the evaluation of Sqrt (as it will incerease time complexity). Bcz
                                      // if Sqrt(x^2 + y^2) is greater or smaller then (x^2 + y^2) will be also greater or
                                      // smaller. We don't need to caculate Sqrt.
        }
    }
}
