using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_7
{
    class E_Commerce_2
    {
        /*
         * Since, we have to maintain only one most sold product. So, we can directly iterate the counter and find that. If we 
         * have to maintain more than 1 products then Heap would be the ideal approach (see E_Commerce.FeatureProduct my first 
         * approach).
         * 
         * Time Complexity = O(n) [making counter] + O(N) (Iterating all unique products) + O(s) [string comparer, Line 42]
         *  
         * Space Complaxity = O(N) [making counter]
         * 
         * where,
         * n = length of products.
         * N = Length of Set of input products Array or List.
         * s = length of smaller product name.
         */
        public void FeatureProduct(List<string> products)
        {
            var featureProduct = string.Empty;
            var mostSoldQuantity = int.MinValue;
            // Space Complexity = O(N) where N = unique products or Set of given list
            var eachProductSold = Counter(products);  // Time Complexity = O(n) where n = length of products

            foreach (var kv in eachProductSold)
            {
                if (kv.Value > mostSoldQuantity)
                {
                    mostSoldQuantity = kv.Value;
                    featureProduct = kv.Key;
                }
                // if both have same sold quantity then take the alphabetically greater or the current one.
                else if (kv.Value == mostSoldQuantity)
                {
                    if (kv.Key.CompareTo(featureProduct) >= 0) // if alphabetically greater or equal
                    {
                        featureProduct = kv.Key;
                    }
                }
            }
            Console.WriteLine($"Feature Product is: {featureProduct}");

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
