using DataStructure.LinkedLists.SinglyLinkedList;
using System;
using System.Collections.Generic;

namespace DataStructure.Assignment_10_CSharp
{
    class ReverseTheLinkedList
    {
        public void Reverse(List<int> arr)
        {
            SinglyLinkedList sList = new SinglyLinkedList();

            // appending data
            foreach (var item in arr)
            {
                sList.Append(item);
            }
            Console.WriteLine("Printing Linked list after appending all elements: ");
            sList.Peek();
            Console.Write("\n"); // Empty line for prettifying

            // Reversing logic starts
            Node prev = null;
            Node next = null;
            var curr = sList.First;

            // Ex:- [10, 100] --> [20, 200] --> [30, 300] --> [40, null]
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            sList.head = prev;

            Console.WriteLine("Printing Linked list after Reversing: ");
            sList.Peek();
        }
    }
}
