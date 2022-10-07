using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_6
{
    class KMostFrequentWords
    {
        public void GetKMostFrequnetWords(List<string> names, int n, int k)
        {
            var counter = Counter(names);
            var keyValuePairsList = counter.AsEnumerable().ToList();  // Where Key = Word and Value = Frequency
            
            var kMostFrequentWordsInSortedOrder = new List<string>();
            for (int i = 0; i < k; i++)
            {
                MaxHeap(ref keyValuePairsList, keyValuePairsList.Count);
                kMostFrequentWordsInSortedOrder.Add(keyValuePairsList[0].Key);
                keyValuePairsList.RemoveAt(0);
            }

            // Now Print the 'K' most frequent words
            Console.Write($"'{k}' most frequent words: ");
            for (var idx = 0; idx < k; idx++)
            {
                Console.Write(kMostFrequentWordsInSortedOrder[idx] + " ");
            }
            Console.WriteLine();
        }

        // Make a counter
        private Dictionary<string, int> Counter(List<string> names) 
        {
            var Counter = new Dictionary<string, int>();
            foreach (var name in names)
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

        private void MaxHeap(ref List<KeyValuePair<string, int>> keyValuePairsList, int n)
        {
            var start_index = (n / 2) - 1;  // last non-leaf node index
            for (int i = start_index; i > -1; i--)
            {
                Heapify(ref keyValuePairsList, i, n);
            }
        }

        private void Heapify(ref List<KeyValuePair<string, int>> keyValuePairsList, int largest_idx, int n)
        {
            var parent_idx = largest_idx;
            var left_child_idx = 2 * largest_idx + 1;
            var right_child_idx = 2 * largest_idx + 2;

            if (left_child_idx < n) 
            {
                if (keyValuePairsList[left_child_idx].Value > keyValuePairsList[parent_idx].Value)
                {
                    parent_idx = left_child_idx;
                }
                else if (keyValuePairsList[left_child_idx].Value == keyValuePairsList[parent_idx].Value)
                {
                    SortLexicographically(ref keyValuePairsList, left_child_idx, parent_idx);
                }
            }

            if (right_child_idx < n) 
            {
                if (keyValuePairsList[right_child_idx].Value > keyValuePairsList[parent_idx].Value)
                {
                    parent_idx = right_child_idx;
                }
                else if (keyValuePairsList[right_child_idx].Value == keyValuePairsList[parent_idx].Value)
                {
                    SortLexicographically(ref keyValuePairsList, right_child_idx, parent_idx);
                }
            }

            if (parent_idx != largest_idx) // Means left_child or right child is greater than parent.
            {
                (keyValuePairsList[parent_idx], keyValuePairsList[largest_idx]) = (keyValuePairsList[largest_idx], keyValuePairsList[parent_idx]);  // Swap keyValuePairsList elements
                Heapify(ref keyValuePairsList, parent_idx, n);
            }
        }

        private void SortLexicographically(ref List<KeyValuePair<string, int>> keyValuePairsList, int child_idx, int parent_idx)
        {
            if (keyValuePairsList[child_idx].Key.CompareTo(keyValuePairsList[parent_idx].Key) < 0)
            {
                (keyValuePairsList[parent_idx], keyValuePairsList[child_idx]) = (keyValuePairsList[child_idx], keyValuePairsList[parent_idx]);  // only Swap keyValuePairsList elements
            }
        }
    }
}
