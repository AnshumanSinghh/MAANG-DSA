using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting_Algos.BinaryHeap
{
    // Always remember if we have to find "K Most Frequent" then build MinHeap. If we have to find "K Less Frequent" then
    // build MaxHeap.
    class ApproachForKFrequentQuestions
    {
        List<KeyValuePair<string, int>> productWithSoldQuantity = new List<KeyValuePair<string, int>>(); // Key : Product, Value : Quantity
        int size = 0;
        public void FeatureProduct(List<string> products)
        {
            var eachProductSold = Counter(products);
            products = eachProductSold.Keys.ToList(); // Product's unique names

            var keyValuePairsList = eachProductSold.AsEnumerable().ToList();  // Where Key = product name and Value = product count

            // We need most sold product. So we will make MinHeap. If we notice we are indirecty said to find k most frequent
            // product where k = 1. So, we will maintain productWithSoldQuantity length as 1.
            HeapPush(new KeyValuePair<string, int>(products[0], eachProductSold[products[0]]));  // Add the 1st product

            // Now iterate the rest products and add if Top() element is smaller. In this way we will have most sold product
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

        // Adding data to Heap
        private void HeapPush(KeyValuePair<string, int> kv)
        {
            productWithSoldQuantity.Add(kv);  // Add the product and quatity key value pair
            size++;  // keep track of size

            // Heapify the existing non-leaf elements
            for (int i = productWithSoldQuantity.Count / 2 - 1; i > -1; i--)
            {
                MinHeapify(i, productWithSoldQuantity.Count);
            }
        }

        // Building min Heap
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

            // Heapify the existing non-leaf elements
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
