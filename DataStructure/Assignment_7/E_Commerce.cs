using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_7
{
    class E_Commerce
    {
        /// <summary>
        /// Time Complexity = O(n)[Counter (Line 23)] + 2*O(N)[KeysList (Line 27) + Iteration (Line 32)] = O(n) + 2*(O(N))
        /// Space Complexity = O(1)[productWithSoldQuantity] + O(N) [eachProductSold] = O(N)
        /// -->> Where N is the Size of input List and n = length of input Array (products).
        /// </summary>

        // Space Complexity = O(1) as it will contain only 1 element
        List<KeyValuePair<string, int>> productWithSoldQuantity = new List<KeyValuePair<string, int>>(); // Key : Product, Value : Quantity
        int size = 0;
        public void FeatureProduct(List<string> products)
        {
            // Space Complexity = O(N) where N = unique products or Set of given list
            var eachProductSold = Counter(products);  // Time Complexity = O(n) where n = length of products

            // Space & Time Complexity = O(1) as we are assiging to same List.
            // Time Complexity = O(N) where N = unique products or Set of given list
            products = eachProductSold.Keys.ToList(); // Product's unique names

            // We need most sold product. So we will make MinHeap. If we notice we are indirecty said to find k most frequent
            // product where k = 1. So, we will maintain productWithSoldQuantity length as 1.
            HeapPush(new KeyValuePair<string, int>(products[0], eachProductSold[products[0]]));  // Add the 1st product

            // Now iterate the rest products and add if Top() element is smaller. In this way we will have most sold product
            // Time complexity = O(N) where N = unique products or Set of given list
            for (int i = 1; i < products.Count; i++)
            {
                if (eachProductSold[products[i]] > productWithSoldQuantity[0].Value)  // if curr is most sold then remove the top element & add the current element to heap
                {
                    HeapPop(); // removing the top

                    HeapPush(new KeyValuePair<string, int>(products[i], eachProductSold[products[i]]));
                }

                // As per question we have to keep track of elements with same sold quantity too. But if alphabetically current
                // product is bigger than the Top() product of heap then delete the Top element and Push the current product in heap
                else if (eachProductSold[products[i]] == productWithSoldQuantity[0].Value)
                {
                    if (products[i].CompareTo(productWithSoldQuantity[0].Key) >= 0) // if curr string >= too product in heap
                    {
                        HeapPop(); // removing the top
                        HeapPush(new KeyValuePair<string, int>(products[i], eachProductSold[products[i]]));
                    }
                }
            }

            Console.WriteLine($"Featured Product: {productWithSoldQuantity[0].Key}");  // Printing the featured element
        }

        // Adding data to Heap : for this question Heap Insertion Time Complexity will be O(1)
        private void HeapPush(KeyValuePair<string, int> kv)
        {
            productWithSoldQuantity.Add(kv);  // Add the product and quatity key value pair
            size++;  // keep track of size

            // Heapify the existing non-leaf elements: [it will not execute at all as productWithSoldQuantity.Count will be always 1]
            for (int i = productWithSoldQuantity.Count / 2 - 1; i > -1; i--)
            {
                MinHeapify(i, productWithSoldQuantity.Count);
            }
        }

        // Building min Heap [this method will be not called at all as we are only storing 1 element in heap. If heapSize
        // is >= 4 only then this will be called]. For this Question it will be not called
        private void MinHeapify(int smallest, int n)
        {
            var parent_idx = smallest;
            var leftChild_idx = 2 * smallest + 1;
            var rightChild_idx = 2 * smallest + 2;

            if ((leftChild_idx < n) && (productWithSoldQuantity[leftChild_idx].Value < productWithSoldQuantity[parent_idx].Value))
            {
                parent_idx = leftChild_idx;
            }

            if ((rightChild_idx < n) && (productWithSoldQuantity[rightChild_idx].Value < productWithSoldQuantity[parent_idx].Value))
            {
                parent_idx = rightChild_idx;
            }
            if (parent_idx != smallest)
            {
                (productWithSoldQuantity[parent_idx], productWithSoldQuantity[smallest]) = (productWithSoldQuantity[smallest], productWithSoldQuantity[parent_idx]);  // Swap
                MinHeapify(parent_idx, n);
            }
        }

        // For this question Heap Deletion Time Complexity = O(1)
        private void HeapPop()
        {
            if (productWithSoldQuantity.Count == 0)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            (productWithSoldQuantity[0], productWithSoldQuantity[size - 1]) = (productWithSoldQuantity[size - 1], productWithSoldQuantity[0]); // Swap 1st element with last element
            productWithSoldQuantity.RemoveAt(size - 1); // Remove the last element
            size--;

            // Heapify the existing non-leaf elements: [it will not execute at all as productWithSoldQuantity.Count will be always 1]
            for (int i = productWithSoldQuantity.Count / 2 - 1; i > 0; i--)
            {
                MinHeapify(i, productWithSoldQuantity.Count);
            }
        }

        private Dictionary<string, int> Counter(List<string> products)
        {
            var Counter = new Dictionary<string, int>();
            foreach (var name in products)
            {
                if (Counter.ContainsKey(name))
                {
                    Counter[name] += 1;
                }
                else
                {
                    Counter[name] = 1; // Initialize with 1
                }
            }
            return Counter;
        }
    }
}
