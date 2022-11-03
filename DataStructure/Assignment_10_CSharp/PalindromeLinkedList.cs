using DataStructure.LinkedLists.SinglyLinkedList;
using System;
using System.Linq;

namespace DataStructure.Assignment_10_CSharp
{
    class PalindromeLinkedList
    {
        SinglyLinkedList linkedList;
        string dataString;
        public PalindromeLinkedList()
        {
            if (linkedList == null)
            {
                linkedList = new SinglyLinkedList();
                dataString = String.Empty;
            }
        }

        public void Append(int data)
        {
            linkedList.Append(data);
        }

        /// <summary>
        /// Time Complexity: O(1.5 * N)  [counting + palindrome logic]
        /// Space Complexity: O(N)   [for storing data as string]
        /// </summary>
        /// <returns></returns>
        public bool IsPalindrome()
        {
            var curr = linkedList.head;

            while (curr != null)
            {
                dataString += curr.data;
                curr = curr.next;
            }

            var i = 0;
            var j = dataString.Length - 1;

            while (i < j)
            {
                if (dataString[i] != dataString[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        /// <summary>
        /// Time Complexity: O(2 * N)  [O(n) for counting + O(n) making number]
        /// Space Complexity: O(2 * 10) [for storing 2 integer values as string]
        /// </summary>
        /// <returns></returns>
        public bool IsPalindrome_2() /* INCOMPLETE LOGIC YET */
        {
            /*
             * Since, data is given as Integer. So, we will make 2 numbers out of that. One will represent first
             * half of data and other will represnt second half of the data. Now, number can overflow as number 
             * of nodes in question is given from 0 to 10^5. So, we will not get the exact number. But we
             * use this thing as condition. We can check how many roundtrips / overflowing are happening. If 
             * for left half and right half has same number of roundtrips and their values are also same then
             * we can say that it's a palindrome Liknked list.
             */
            var curr = linkedList.head;
            var count = 0;
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }

            var left = 0;
            var right = 0;
            var leftRoundTrip = 0;
            var rightRoundTrip = 0;

            var leftMid = count / 2 - 1;
            var rightMid = count - leftMid - 1;

            curr = linkedList.head;
            while (leftMid >= 0)
            {
                if (left > int.MaxValue/10)
                {
                    leftRoundTrip++;
                }
                left = left * 10 + curr.data;

                leftMid--;
                curr = curr.next;
            }

            // skip the mid element in case of Odd number of nodes
            if (count % 2 != 0)
            {
                curr = curr.next;
            }
            var pow = 1;
            var strNumber = "";
            while (rightMid < count)
            {
                strNumber = curr.data + strNumber;
                if ((right > int.MaxValue / 10) || (pow > int.MaxValue / 10))
                {
                    rightRoundTrip++;
                }
                right = right + curr.data * pow;
                //right = right * 10 + curr.data;
                pow *= 10;
                rightMid++;
                curr = curr.next;
            }
            return Compare(left.ToString(), right.ToString()) ? leftRoundTrip == rightRoundTrip : false;
        } 

        /// <summary>
        /// Time Complexity: O(10) in case 'a' & 'b' is equal to int.MaxValue.
        /// Space Complexity: O(10) in case 'a' & 'b' is equal to int.MaxValue.
        /// </summary>
        /// <param name="a">left number</param>
        /// <param name="b">right number</param>
        /// <returns></returns>
        private bool Compare(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            var i = 0;
            var j = b.Length-1;
            while (i <= j)
            {
                if (a[i] != b[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
