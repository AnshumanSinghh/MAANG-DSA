using DataStructure.LinkedLists.SinglyLinkedList;
using System;

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
    }
}
