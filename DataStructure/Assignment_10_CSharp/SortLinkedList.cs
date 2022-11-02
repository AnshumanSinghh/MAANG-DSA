using DataStructure.LinkedLists.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_10_CSharp
{
    /// <summary>
    /// Sorts the Linked (which only contains 0, 1, & 2) in ascending order.
    /// </summary>
    class SortLinkedList
    {
        SinglyLinkedList linkedList;
        int Count;
        public SortLinkedList()
        {
            linkedList = new SinglyLinkedList();
            Count = 0;
        }

        public void Append(int data)
        {
            linkedList.Append(data);
            Count++;
        }

        public void Sort()
        {
            var curr = linkedList.head;
            Node previous = null;
            int i = 0;

            while (i < Count)
            {
                if (curr.data == 0)
                {
                    var temp = curr;
                    if (curr == linkedList.head)
                    {
                        linkedList.head = linkedList.head.next; // Deleting the head node
                        previous = curr;
                        curr = null;
                    }
                    else
                    {
                        previous.next = curr.next; // Deleting the current node
                        curr = null;
                        linkedList.Prepend(temp.data);
                    }
                    curr = temp.next;
                }
                else if (curr.data == 2)
                {
                    var temp = curr;
                    if (previous == null) // Deleting the head node
                    {
                        linkedList.head = linkedList.head.next;
                        previous = curr;
                        curr = null;
                    }
                    else // Deleting the current node
                    {
                        previous.next = curr.next;
                        curr = null;
                    }
                    linkedList.Append(temp.data);
                    
                    curr = temp.next;
                }
                else // in case of 1 don't do anything
                {
                    previous = curr;
                    curr = curr.next;
                }
                i++;
            }
        }

        public void Print()
        {
            linkedList.Peek();
        }
    }
}
