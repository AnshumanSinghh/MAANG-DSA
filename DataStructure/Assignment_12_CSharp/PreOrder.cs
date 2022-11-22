using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_12_CSharp
{
    class PreOrder
    {
        Node root;

        void PreOrderIterative()
        {
            PreOrderIterative(root);
        }

        void PreOrderIterative(Node node)
        {
            if (node == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();

            Node curr = node;

            while (curr != null || stack.Count != 0)
            {
                // Iterate and push the curr right in stack. This will run untill curr left becomes null
                while (curr != null)
                {
                    Console.WriteLine(curr.data + " ");  // Print Node data

                    if (curr.right != null)
                    {
                        stack.Push(curr.right);
                    }
                    curr = curr.left; // mae current as curr left because this will be the next to print
                                      // if not present then we wll consider the right which is in stack.
                }

                if (stack.Count != 0)
                {
                    curr = stack.Pop();
                }
            }
        }
    }
}
