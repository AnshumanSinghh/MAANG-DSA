using System.Collections.Generic;

namespace DataStructure.DivideAndConquer
{
    class FindMinAndMaxInArray
    {
        private int min = int.MaxValue;
        private int max = int.MinValue;
        public (int, int) FindMinAndMax(List<int> arr, int i, int j)
        {
            // If array has only one element
            if (i == j)
            {
                if (min > arr[j])
                {
                    min = arr[j];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
                return (min, max);
            }

            // If array has two elements
            if (i == j - 1)
            {
                SetMinMax(arr[i], arr[j]);
                return (min, max);
            }
            
            var mid = i + (j - i) / 2;
            FindMinAndMax(arr, i, mid);  // calling for left Sub-Array
            FindMinAndMax(arr, mid + 1, j);  // calling for right Sub-Array
            return (min, max);
        }

        private void SetMinMax(int a, int b)
        {
            if (a < b)
            {
                if (min > a)
                {
                    min = a;
                }
                if (max < b)
                {
                    max = b;
                }
            }
            else
            {
                if (min > b)
                {
                    min = b;
                }
                if (max < a)
                {
                    max = a;
                }
            }
        }
    }
}
