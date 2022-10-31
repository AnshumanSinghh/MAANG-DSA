using DataStructure.LinkedLists.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_10_CSharp
{
    class DetectCycleInLinkedList
    {
        SinglyLinkedList singlyLinkedList;
        public DetectCycleInLinkedList()
        {
            singlyLinkedList = new SinglyLinkedList();
        }

        public Node head { get { return singlyLinkedList.First; }}
        public void InsertAtEnd(int newData)
        {
            singlyLinkedList.Append(newData);
        }

        public bool CheckIfCycleExists()
        {
            var curr = singlyLinkedList.First;
            var tortoise = curr;
            var hare = curr;

            while ((tortoise != null) && (hare != null) && (hare.next != null))
            {
                tortoise = tortoise.next;
                hare = hare.next.next;
                if (hare == tortoise)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckIfCycleExists_2()
        {
            var curr = singlyLinkedList.First;
            while (curr != null)
            {
                if (curr.next == null)
                {
                    return false;
                }
                else if (curr.data == int.MinValue)
                {
                    return true;
                }
                else
                {
                    curr.data = int.MinValue;
                }
                curr = curr.next;
            }
            return false;
        }
    }
}
