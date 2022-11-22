using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_12_CSharp
{
    class InOrder
    {
        public Node root;
        public void InOrderIterative()
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();

            // Traversing
            var curr = root;
            while (curr != null || stack.Count != 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                // at this point curr will be null as we are at the leftmost node
                curr = stack.Pop();
                Console.WriteLine(curr.data + " ");
                curr = curr.right;
            }
        }
    }
}
