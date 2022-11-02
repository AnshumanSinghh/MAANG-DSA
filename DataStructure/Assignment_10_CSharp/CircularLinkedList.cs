using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_10_CSharp
{
    class CNode
    {
        public int data;
        public CNode next;
        public CNode(int newData)
        {
            data = newData;
            next = null;
        }
    }
    class CircularLinkedList
    {
        public CNode head = null;

        public CNode Last = null;

        private int Count;
        
        public void Append(int newData)
        {
            var newNode = new CNode(newData);
            if (head == null)
            {
                head = newNode;
                Last = head;
                Last.next = head;
                Count++;
            }
            else
            {
                newNode.next = Last.next;
                Last.next = newNode;
                Last = newNode;
                Count++;
            }
        }

        public void Peek()
        {
            var curr = Last.next;
            while (curr != null)
            {
                Console.Write($"{curr.data}, ");
                curr = curr.next;
                if (curr == Last.next)
                {
                    return;
                }
            }
        }

        public void Peek_2()
        {
            var curr = Last.next;
            var tempCount = 0;
            while (tempCount < Count)
            {
                Console.Write($"{curr.data}, ");
                curr = curr.next;
                tempCount++;
            }
        }
    }
}
