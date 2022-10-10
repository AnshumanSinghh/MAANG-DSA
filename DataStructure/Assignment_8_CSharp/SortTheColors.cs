using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_8_CSharp
{
    class SortTheColors
    {
        /// <summary>
        /// The idea is to put the 0 towards starting and 2 towards ending for the given array. Then
        /// 1 will be automatically sorted and also the the give Array.
        /// <para>
        ///     Time Complexiy: O(n)
        ///     <para>
        ///         Space Complexity: O(1)
        ///     </para>
        /// </para>
        /// </summary>
        /// <param name="arr">List of integers</param>
        /// <returns></returns>
        public List<int> Sort(List<int> arr)
        {
            int zero = 0, two = arr.Count - 1; int i = 0;

            while(i <= two && zero < two)
            {
                if (arr[i] == 0)
                {
                    // Swap the current element with index 'zero'. Here we are sure that ith element is 1 (if 'i' != 'zero')
                    arr[i] = arr[zero];
                    arr[zero] = 0;

                    zero++; // now increase the zero pointer to store next 0 if we have any.
                    i++; // Now, we know the previous and current element as we have gone through that. So, we can
                         // move to next element.
                }
                else if (arr[i] == 2)
                {
                    // Swap the current element with index 'two'. Here we are not sure about the element
                    // which is being pointed by 'two'. It can 0 or 1 or 2 anything.
                    arr[i] = arr[two];
                    arr[two] = 2;

                    two--; // Now we have placed on 2 at ending position. So, decrease the 'two' for storing other 2's if
                           // we haev any

                    /*
                     * Here why we are not incrementing 'i'? Bcz we are not sure about element at index 'two'. So, suppose
                     * it is 0 or 2. In that case after swapping current index ('i') will point either 2 or 0 and if we 
                     * increment 'i' then we will skip the comparision of 0 or 2 here. So, in order to visit each element,
                     * after swapping with 2 we must start with same index again until arr[i] != 2;
                     */
                }
                else // if curr element is 1
                {
                    i++; // if it 1 just skip any comparirion as we are already sorting 1 and 2. So, if 1 and 2 are
                         // at it's correct positions then 1 will be automatically at it's correct position.
                }
            }
            return arr;
        }
    }
}
