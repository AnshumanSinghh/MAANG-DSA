using DataStructure.LinkedLists.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_10_CSharp
{
    class RemoveNthNodeFromLast
    {
        SinglyLinkedList linkedList;
        public RemoveNthNodeFromLast()
        {
            linkedList = new SinglyLinkedList();
        }

        public void Append(int data)
        {
            linkedList.Append(data);
        }

        public void DeleteNthNodeFromLast(int n)
        {
            var dummy = new Node(next : linkedList.head);
            var count = 0;
            var first = linkedList.head;
            var second = linkedList.head;

            while (second != null)
            {
                // to delete nth node from last we will need (n-1)th node from last. And to get that 
                // set 'second' pointer to (n+1)th node.
                if (count < n + 1)
                {
                    second = second.next;
                }
                // once 'second' pointer is at (n+1)th index. Start incrementing both the pointers
                // 'second' and 'first'. This once second pointer reaches end 'first' pointer will 
                // point the (n-1)th index from last.
                else
                {
                    first = first.next;
                    second = second.next;
                }
                count++;
            }
            // if number of elements is 1 or less than 'n'. Then delete the head.
            if (count <= n)
            {
                linkedList.head = linkedList.head.next;
            }
            else
            {
                first.next = first.next.next;
            }

            linkedList.Peek();
            //return linkedList.head;
        }
    }
}
