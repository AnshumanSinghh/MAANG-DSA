using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedLists.SinglyLinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    class SinglyLinkedList
    {
        public Node head = null;

        /// <summary>
        /// Get the First element.
        /// </summary>
        public Node First { get { return head; } }

        /// <summary>
        /// Get the Last element.
        /// </summary>
        public Node Last 
        { 
            get
            {
                Node curr = head;
                if (curr == null)
                {
                    return null;
                }

                while (curr.next != null)
                {
                    curr = curr.next;
                }
                return curr;
            } 
        }

        /// <summary>
        /// Insert Data At Begining.
        /// </summary>
        /// <param name="data">Integer data</param>
        public void Prepend(int data) 
        {
            var newNode = new Node(data);
            newNode.next = head;  // will start pointing the curr first element
            head = newNode; // now make the newNode as head.
        }

        /// <summary>
        /// Insert Data at End.
        /// </summary>
        /// <param name="data">Integer data</param>
        public void Append(int data) 
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Last.next = newNode;
            }
        }

        /// <summary>
        /// Print all the data of Linked List.
        /// </summary>
        public void Peek()
        {
            var temp = First;
            while (temp != null)
            {
                Console.Write($"{temp.data}, ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Insert data after given node.
        /// </summary>
        /// <param name="previousNode">Previous Node of Linked List</param>
        /// <param name="data">Integer Data</param>
        public void InsertAfter(Node previousNode, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("Given Node must be present in Linked List.");
                return;
            }

            // If previousNode is present
            var newData = new Node(data);
            newData.next = previousNode.next;  // start pointing the node which was previously pointing by previousNode.
            previousNode.next = newData;  // now make the previousNode to point newData.

        }

        /// <summary>
        /// Deletes Node from begining.
        /// </summary>
        public void DeleteAtBegining()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to delete.");
                return;
            }
            Console.WriteLine($"Node {head.data} deleted successfully.");
            head = head.next;
        }

        /// <summary>
        /// Deletes given Node from end.
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to delete.");
                return;
            }
            var curr = head;
            Node secondLastNode = null;

            while (curr.next != null)
            {
                secondLastNode = curr;
                curr = curr.next;
            }
            secondLastNode.next = null; // make the secondLast Element next as null.
            Console.WriteLine($"Node {curr.data} deleted successfully.");
        }

        /// <summary>
        /// Deletes a given Node.
        /// </summary>
        /// <param name="n">Node which hass to be delete.</param>
        public void Delete(Node n)
        {
            if (n == null) 
            {
                Console.WriteLine("Nothing to delete.");
                return;
            }

            var curr = head;
            while (curr.next != null)
            {
                if (curr.next == n)
                {
                    Console.WriteLine($"Node {n.data} deleted successfully.");
                    curr.next = n.next;
                    //n.next = null;
                    return;
                }
                curr = curr.next;
            }
        }
    }
}
